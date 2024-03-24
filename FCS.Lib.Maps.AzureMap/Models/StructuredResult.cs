﻿// ***********************************************************************
// Assembly         : FCS.Lib.Maps.AzureMap
// Filename         : StructuredResult.cs
// Author           : Frede Hundewadt
// Created          : 2024 03 20 14:53
// 
// Last Modified By : root
// Last Modified On : 2024 03 20 15:42
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

using System;
using System.Collections.Generic;

namespace FCS.Lib.Maps.AzureMap.Models;

public class StructuredResult
{
    public string Type { get; set; } = string.Empty;
    public string Id { get; set; } = string.Empty;
    public double Score { get; set; }
    public MapAddress Address { get; set; } = new();
    public MapCoords Position { get; set; } = new();
    public MapViewPort ViewPort { get; set; } = new();
    public List<MapEntryPoint> EntryPoints { get; set; } = new();
}