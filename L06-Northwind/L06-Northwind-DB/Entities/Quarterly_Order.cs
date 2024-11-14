using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace L06_Northwind_DB.Entities;

[Keyless]
public partial class Quarterly_Order
{
    public string? CustomerID { get; set; }

    public string? CompanyName { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }
}
