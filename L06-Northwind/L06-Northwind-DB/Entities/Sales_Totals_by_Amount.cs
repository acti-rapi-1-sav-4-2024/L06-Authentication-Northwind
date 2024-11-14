using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace L06_Northwind_DB.Entities;

[Keyless]
public partial class Sales_Totals_by_Amount
{
    public byte[]? SaleAmount { get; set; }

    public int? OrderID { get; set; }

    public string? CompanyName { get; set; }

    [Column(TypeName = "DATETIME")]
    public DateTime? ShippedDate { get; set; }
}
