// ***********************************************************************
// Assembly         : FCS.Lib.Maps.AzureMap
// Filename         : MapAddress.cs
// Author           : Frede Hundewadt
// Created          : 2024 03 29 12:36
// 
// Last Modified By : root
// Last Modified On : 2024 04 11 13:04
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

public class MapAddress
{
    public string Country { get; set; }
    public string CountryCode { get; set; }
    public string CountryCodeISO3 { get; set; }
    public string CountrySubDivision { get; set; }
    public string CountrySubdivisionCode { get; set; }
    public string CountrySubdivisionName { get; set; }
    public string FreeformAddress { get; set; }
    public string LocalName { get; set; }
    public string Municipality { get; set; }
    public string MunicipalitySubdivision { get; set; }
    public string Neighbourhood { get; set; }
    public string PostalCode { get; set; }
    public string StreetName { get; set; }
}