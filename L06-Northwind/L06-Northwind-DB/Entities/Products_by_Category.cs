using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace L06_Northwind_DB.Entities;

[Keyless]
public partial class Products_by_Category
{
    public string? CategoryName { get; set; }

    public string? ProductName { get; set; }

    public string? QuantityPerUnit { get; set; }

    public int? UnitsInStock { get; set; }

    public string? Discontinued { get; set; }
}
