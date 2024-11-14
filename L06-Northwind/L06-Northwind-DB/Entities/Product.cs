using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace L06_Northwind_DB.Entities;

public partial class Product
{
    [Key]
    public int ProductID { get; set; }

    public string ProductName { get; set; } = null!;

    public int? SupplierID { get; set; }

    public int? CategoryID { get; set; }

    public string? QuantityPerUnit { get; set; }

    [Column(TypeName = "NUMERIC")]
    public double? UnitPrice { get; set; }

    public int? UnitsInStock { get; set; }

    public int? UnitsOnOrder { get; set; }

    public int? ReorderLevel { get; set; }

    public string Discontinued { get; set; } = null!;

    [ForeignKey("CategoryID")]
    [InverseProperty("Products")]
    public virtual Category? Category { get; set; }

    [InverseProperty("Product")]
    public virtual ICollection<Order_Detail> Order_Details { get; set; } = new List<Order_Detail>();

    [ForeignKey("SupplierID")]
    [InverseProperty("Products")]
    public virtual Supplier? Supplier { get; set; }
}
