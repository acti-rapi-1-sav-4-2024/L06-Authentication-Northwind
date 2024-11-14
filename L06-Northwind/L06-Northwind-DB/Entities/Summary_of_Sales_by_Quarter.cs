using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace L06_Northwind_DB.Entities;

[Keyless]
public partial class Summary_of_Sales_by_Quarter
{
    [Column(TypeName = "DATETIME")]
    public DateTime? ShippedDate { get; set; }

    public int? OrderID { get; set; }

    public double? Subtotal { get; set; }
}
