using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace L06_Northwind_DB.Entities;

[Keyless]
public partial class Products_Above_Average_Price
{
    public string? ProductName { get; set; }

    [Column(TypeName = "NUMERIC")]
    public double? UnitPrice { get; set; }
}
