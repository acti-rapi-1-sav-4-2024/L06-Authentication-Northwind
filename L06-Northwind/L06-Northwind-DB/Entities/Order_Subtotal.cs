using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace L06_Northwind_DB.Entities;

[Keyless]
public partial class Order_Subtotal
{
    public int? OrderID { get; set; }

    public double? Subtotal { get; set; }
}
