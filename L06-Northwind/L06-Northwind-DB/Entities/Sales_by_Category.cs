using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace L06_Northwind_DB.Entities;

[Keyless]
public partial class Sales_by_Category
{
    public int? CategoryID { get; set; }

    public string? CategoryName { get; set; }

    public string? ProductName { get; set; }

    public byte[]? ProductSales { get; set; }
}
