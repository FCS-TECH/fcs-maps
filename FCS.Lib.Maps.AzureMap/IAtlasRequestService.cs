// // ***********************************************************************
// // Solution         : Inno.Api.v2
// // Assembly         : FCS.Lib.Maps.AzureMap
// // Filename         : IAtlasRequestService.cs
// // Created          : 2025-01-03 14:01
// // Last Modified By : dev
// // Last Modified On : 2025-01-04 11:01
// // ***********************************************************************
// // <copyright company="Frede Hundewadt">
// //     Copyright (C) 2010-2025 Frede Hundewadt
// //     This program is free software: you can redistribute it and/or modify
// //     it under the terms of the GNU Affero General Public License as
// //     published by the Free Software Foundation, either version 3 of the
// //     License, or (at your option) any later version.
// //
// //     This program is distributed in the hope that it will be useful,
// //     but WITHOUT ANY WARRANTY; without even the implied warranty of
// //     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// //     GNU Affero General Public License for more details.
// //
// //     You should have received a copy of the GNU Affero General Public License
// //     along with this program.  If not, see [https://www.gnu.org/licenses]
// // </copyright>
// // <summary></summary>
// // ***********************************************************************

using System.Threading.Tasks;
using FCS.Lib.Maps.AzureMap.Models;

namespace FCS.Lib.Maps.AzureMap;

/// <summary>
/// </summary>
public interface IAtlasRequestService
{
    /// <summary>
    ///     Retrieves geolocation information based on a specified geographic position using the Azure Maps API.
    /// </summary>
    /// <param name="mapServer">
    ///     The <see cref="FCS.Lib.Maps.AzureMap.Models.MapServer" /> instance containing the server configuration
    ///     for interacting with the Azure Maps API.
    /// </param>
    /// <param name="info">
    ///     The <see cref="FCS.Lib.Maps.AzureMap.Models.MapFromPosition" /> instance containing the geographic position
    ///     details for which the geolocation information is to be retrieved.
    /// </param>
    /// <returns>
    ///     A <see cref="FCS.Lib.Maps.AzureMap.Models.MapResultFromPosition" /> instance containing the result of the
    ///     reverse geocoding operation, including a summary and a list of addresses corresponding to the specified position.
    /// </returns>
    /// <remarks>
    ///     This method performs a reverse geocoding operation to obtain address information based on latitude and longitude.
    /// </remarks>
    Task<MapResultFromPosition> GetInfoFromPosition(MapServer mapServer, MapFromPosition info);

    /// <summary>
    ///     Retrieves detailed information about a location based on a structured address query using the Azure Map service.
    /// </summary>
    /// <param name="mapServer">
    ///     An instance of <see cref="MapServer" /> containing the server configuration, such as the host URL and API key.
    /// </param>
    /// <param name="info">
    ///     An instance of <see cref="MapFromAddress" /> containing the structured address details for the query.
    /// </param>
    /// <returns>
    ///     A task that represents the asynchronous operation. The task result contains an instance of
    ///     <see cref="MapResultFromAddress" /> with the results of the address search, including metadata and detailed
    ///     results.
    /// </returns>
    Task<MapResultFromAddress> GetInfoFromAddress(MapServer mapServer, MapFromAddress info);
}