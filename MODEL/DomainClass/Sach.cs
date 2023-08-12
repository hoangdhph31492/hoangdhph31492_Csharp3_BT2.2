using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace hoangdhph31492_Csharp3_BT2._2.MODEL.DomainClass;

[Table("Sach")]
public partial class Sach
{
    [Key]
    public Guid Id { get; set; }

    [Column("MA")]
    [StringLength(20)]
    public string? Ma { get; set; }

    [Column("ten")]
    [StringLength(50)]
    public string? Ten { get; set; }

    [Column("TT")]
    public bool? Tt { get; set; }

    [Column("idNXB")]
    public Guid? IdNxb { get; set; }

    [ForeignKey("IdNxb")]
    [InverseProperty("Saches")]
    public virtual Nxb? IdNxbNavigation { get; set; }
}
