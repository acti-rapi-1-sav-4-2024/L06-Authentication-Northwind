using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace L06_Northwind_DB.Entities;

public partial class Region
{
    [Key]
    public int RegionID { get; set; }

    public string RegionDescription { get; set; } = null!;

    [InverseProperty("Region")]
    public virtual ICollection<Territory> Territories { get; set; } = new List<Territory>();
}
