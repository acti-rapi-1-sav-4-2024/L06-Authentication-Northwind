using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace L06_Northwind_DB.Entities;

public partial class Territory
{
    [Key]
    public string TerritoryID { get; set; } = null!;

    public string TerritoryDescription { get; set; } = null!;

    public int RegionID { get; set; }

    [ForeignKey("RegionID")]
    [InverseProperty("Territories")]
    public virtual Region Region { get; set; } = null!;

    [ForeignKey("TerritoryID")]
    [InverseProperty("Territories")]
    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
