using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace L06_Northwind_DB.Entities;

[PrimaryKey("OrderID", "ProductID")]
[Table("Order Details")]
public partial class Order_Detail
{
    [Key]
    public int OrderID { get; set; }

    [Key]
    public int ProductID { get; set; }

    [Column(TypeName = "NUMERIC")]
    public double UnitPrice { get; set; }

    public int Quantity { get; set; }

    public double Discount { get; set; }

    [ForeignKey("OrderID")]
    [InverseProperty("Order_Details")]
    public virtual Order Order { get; set; } = null!;

    [ForeignKey("ProductID")]
    [InverseProperty("Order_Details")]
    public virtual Product Product { get; set; } = null!;
}
