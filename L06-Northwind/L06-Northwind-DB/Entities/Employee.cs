﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace L06_Northwind_DB.Entities;

public partial class Employee
{
    [Key]
    public int EmployeeID { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? Title { get; set; }

    public string? TitleOfCourtesy { get; set; }

    [Column(TypeName = "DATE")]
    public DateOnly? BirthDate { get; set; }

    [Column(TypeName = "DATE")]
    public DateOnly? HireDate { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? Region { get; set; }

    public string? PostalCode { get; set; }

    public string? Country { get; set; }

    public string? HomePhone { get; set; }

    public string? Extension { get; set; }

    public byte[]? Photo { get; set; }

    public string? Notes { get; set; }

    public int? ReportsTo { get; set; }

    public string? PhotoPath { get; set; }

    [InverseProperty("ReportsToNavigation")]
    public virtual ICollection<Employee> InverseReportsToNavigation { get; set; } = new List<Employee>();

    [InverseProperty("Employee")]
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    [ForeignKey("ReportsTo")]
    [InverseProperty("InverseReportsToNavigation")]
    public virtual Employee? ReportsToNavigation { get; set; }

    [ForeignKey("EmployeeID")]
    [InverseProperty("Employees")]
    public virtual ICollection<Territory> Territories { get; set; } = new List<Territory>();
}
