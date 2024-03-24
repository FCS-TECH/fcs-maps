// ***********************************************************************
// Assembly         : FCS.Lib.Maps.AzureMap
// Filename         : ReverseAddress.cs
// Author           : Frede Hundewadt
// Created          : 2024 03 20 14:53
// 
// Last Modified By : root
// Last Modified On : 2024 03 20 15:42
// ***********************************************************************
// <copyright company="FCS">
//     Copyright (C) 2024-2024 FCS Fredes Computer Services.
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

using System.Collections.Generic;

namespace FCS.Lib.Maps.AzureMap.Models;

public class ReverseAddress : MapAddress
{
    public string BuildingNumber { get; set; }
    public string CountrySubdivision { get; set; }
    public string Id { get; set; }
    public string Street { get; set; }
    public string StreetNameAndNumber { get; set; }
    public string StreetNumber { get; set; }
    public List<string> RouteNumbers { get; set; }
    public string Position { get; set; }
    public MapBoundingBox BoundingBox { get; set; }

    // inherited from MapAddress
    //public new string Country { get; set; }
    //public new string CountryCode { get; set; }
    //public new string CountryCodeISO3 { get; set; }
    //public new string CountrySubdivisionCode { get; set; }
    //public new string CountrySubdivisionName { get; set; }
    //public new string FreeformAddress { get; set; }
    //public new string LocalName { get; set; }
    //public new string Municipality { get; set; }
    //public new string MunicipalitySubdivision { get; set; }
    //public new string Neighbourhood { get; set; }
    //public new string PostalCode { get; set; }
    //public new string StreetName { get; set; }
}