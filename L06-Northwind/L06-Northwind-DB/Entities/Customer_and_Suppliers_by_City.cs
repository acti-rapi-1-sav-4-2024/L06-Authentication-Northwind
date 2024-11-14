using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace L06_Northwind_DB.Entities;

[Keyless]
public partial class Customer_and_Suppliers_by_City
{
    public string? City { get; set; }

    public string? CompanyName { get; set; }

    public string? ContactName { get; set; }

    public string? Relationship { get; set; }
}
