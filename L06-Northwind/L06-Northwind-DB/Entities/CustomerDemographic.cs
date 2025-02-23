﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace L06_Northwind_DB.Entities;

public partial class CustomerDemographic
{
    [Key]
    public string CustomerTypeID { get; set; } = null!;

    public string? CustomerDesc { get; set; }

    [ForeignKey("CustomerTypeID")]
    [InverseProperty("CustomerTypes")]
    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}
