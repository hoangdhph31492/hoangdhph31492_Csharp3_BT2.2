using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace hoangdhph31492_Csharp3_BT2._2.MODEL.DomainClass;

[Table("NXB")]
public partial class Nxb
{
    [Key]
    public Guid Id { get; set; }

    [Column("NXB")]
    [StringLength(50)]
    public string? Nxb1 { get; set; }

    [InverseProperty("IdNxbNavigation")]
    public virtual ICollection<Sach> Saches { get; set; } = new List<Sach>();
}
