// ***********************************************************************
// Assembly         : FCS.Lib.Maps.AzureMap
// Filename         : AzureMapsRequestService.cs
// Author           : Frede Hundewadt
// Created          : 2024 03 28 13:16
// 
// Last Modified By : root
// Last Modified On : 2024 03 29 12:36
// ***********************************************************************
// <copyright company="FCS">
//     Copyright (C) 2024-2024 FCS Frede's Computer Service.
//     This program is free software: you can redistribute it and/or modify
//     it under the terms of the GNU Affero General Public License as
//     published by the Free Software Foundation, either version 3 of the
//     License, or (at your option) any later version.
// 
//     This program is distributed in the hope that it will be useful,
//     but WITHOUT ANY WARRANTY; without even the implied warranty of
//     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//     GNU Affero General Public License for more details.
// 
//     You should have received a copy of the GNU Affero General Public License
//     along with this program.  If not, see [https://www.gnu.org/licenses]
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using FCS.Lib.Maps.AzureMap.Models;
using Newtonsoft.Json;

namespace FCS.Lib.Maps.AzureMap;

public class AzureMapsRequestService : IAzureMapsRequestService
{
    public async Task<MapResultFromPosition> GetInfoFromPosition(MapServer server, MapFromPosition info)
    {
        // create a map request
        // template
        // server: "https://atlas.microsoft.com"
        // url: "/search"
        // scope: "/address"
        // type: "/reverse"
        // format: "/json"
        // queryString: $"?api-version=1.0&subscription-key={subscription-key}&query={query}"

        var sb = new StringBuilder();
        sb.Append($"{server.Host}");
        sb.Append($"/{info.Action}");
        sb.Append($"/{info.Scope}");
        sb.Append($"/{info.Type}");
        sb.Append($"/{info.Format}");
        sb.Append($"?api-version={server.ApiVersion}");
        sb.Append($"&subscription-key={server.ApiKey}");
        sb.Append($"query={info.Latitude},{info.Longitude}");
        var endpoint = sb.ToString();

        using var client = new HttpClient();
        using var request = new HttpRequestMessage(HttpMethod.Get, endpoint);
        request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        // send request
        var response = await client.SendAsync(request).ConfigureAwait(true);
        if (!response.IsSuccessStatusCode)
            return null;

        // read response content
        var content = await response.Content.ReadAsStringAsync().ConfigureAwait(true);

        return JsonConvert.DeserializeObject<MapResultFromPosition>(content);
    }

    public async Task<MapResultFromAddress> GetInfoFromAddress(MapServer server, MapFromAddress info)
    {
        // server: "https://atlas.microsoft.com"
        // url: "/search"
        // scope: "/address"
        // type: "/structured"
        // format: "/json"
        // querystring: ?api-version=1.0&subscription-key={key}&countryCode={country}&postalCode={code}&streetName={name}&streetNumber={number}
        var sb = new StringBuilder();
        sb.Append($"{server.Host}");
        sb.Append($"/{info.Action}");
        sb.Append($"/{info.Scope}");
        sb.Append($"/{info.Type}");
        sb.Append($"/{info.Format}");
        sb.Append($"?api-version={server.ApiVersion}");
        sb.Append($"&subscription-key={server.ApiKey}");
        sb.Append($"&countryCode={info.CountryCode}");
        sb.Append($"&postalCode={info.PostalCode}");
        sb.Append($"&streetName={info.StreetName}");
        sb.Append($"&streetNumber={info.StreetNumber}");
        var endpoint = sb.ToString();

        using var client = new HttpClient();
        using var request = new HttpRequestMessage(HttpMethod.Get, endpoint);
        request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        // send request
        var response = await client.SendAsync(request).ConfigureAwait(true);
        if (!response.IsSuccessStatusCode)
            return null;

        // read response content
        var content = await response.Content.ReadAsStringAsync().ConfigureAwait(true);

        return JsonConvert.DeserializeObject<MapResultFromAddress>(content);
    }
}