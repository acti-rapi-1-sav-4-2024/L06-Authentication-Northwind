using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace L06_Northwind_DB.Entities;

public partial class Order
{
    [Key]
    public int OrderID { get; set; }

    public string? CustomerID { get; set; }

    public int? EmployeeID { get; set; }

    [Column(TypeName = "DATETIME")]
    public DateTime? OrderDate { get; set; }

    [Column(TypeName = "DATETIME")]
    public DateTime? RequiredDate { get; set; }

    [Column(TypeName = "DATETIME")]
    public DateTime? ShippedDate { get; set; }

    public int? ShipVia { get; set; }

    [Column(TypeName = "NUMERIC")]
    public int? Freight { get; set; }

    public string? ShipName { get; set; }

    public string? ShipAddress { get; set; }

    public string? ShipCity { get; set; }

    public string? ShipRegion { get; set; }

    public string? ShipPostalCode { get; set; }

    public string? ShipCountry { get; set; }

    [ForeignKey("CustomerID")]
    [InverseProperty("Orders")]
    public virtual Customer? Customer { get; set; }

    [ForeignKey("EmployeeID")]
    [InverseProperty("Orders")]
    public virtual Employee? Employee { get; set; }

    [InverseProperty("Order")]
    public virtual ICollection<Order_Detail> Order_Details { get; set; } = new List<Order_Detail>();

    [ForeignKey("ShipVia")]
    [InverseProperty("Orders")]
    public virtual Shipper? ShipViaNavigation { get; set; }
}
