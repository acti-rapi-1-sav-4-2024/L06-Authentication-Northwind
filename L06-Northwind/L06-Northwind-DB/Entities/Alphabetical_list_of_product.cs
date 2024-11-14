using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace L06_Northwind_DB.Entities;

[Keyless]
public partial class Alphabetical_list_of_product
{
    public int? ProductID { get; set; }

    public string? ProductName { get; set; }

    public int? SupplierID { get; set; }

    public int? CategoryID { get; set; }

    public string? QuantityPerUnit { get; set; }

    [Column(TypeName = "NUMERIC")]
    public double? UnitPrice { get; set; }

    public int? UnitsInStock { get; set; }

    public int? UnitsOnOrder { get; set; }

    public int? ReorderLevel { get; set; }

    public string? Discontinued { get; set; }

    public string? CategoryName { get; set; }
}
