// ***********************************************************************
// Assembly         : FCS.Lib.Maps.AzureMap
// Filename         : MapFromPosition.cs
// Author           : Frede Hundewadt
// Created          : 2024 03 24 11:22
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

namespace FCS.Lib.Maps.AzureMap.Models;

public class MapFromPosition : Defaults
{
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public string Type { get; set; } = "reverse";
}

public class Defaults
{
    public string Action { get; set; } = "search";
    public string Format { get; set; } = "json";
    public string Scope { get; set; } = "address";
}

public class MapFromAddress : Defaults
{
    public string CountryCode { get; set; } = "";
    public string PostalCode { get; set; } = "";
    public string StreetName { get; set; } = "";
    public string StreetNumber { get; set; } = "";
    public string Type { get; set; } = "structured";
}