// ***********************************************************************
// Assembly         : FCS.Lib.Maps.AzureMap
// Filename         : MapBoundingBox.cs
// Author           : Frede Hundewadt
// Created          : 2024 03 20 14:53
// 
// Last Modified By : root
// Last Modified On : 2024 03 20 15:41
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

namespace FCS.Lib.Maps.AzureMap.Models;

public class MapBoundingBox
{
    public string NorthEast { get; set; }
    public string SouthWest { get; set; }
    public string Entity { get; set; }
}