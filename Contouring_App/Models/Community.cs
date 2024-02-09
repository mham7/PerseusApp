using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Contouring_App.Models;

[Table("Community")]
public partial class Community
{
    [Key]
    [Column("CommunityID")]
    public int CommunityId { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string CommunityName { get; set; } = null!;

    [Column("DivisionID")]
    public int DivisionId { get; set; }

    [ForeignKey("DivisionId")]
    [InverseProperty("Communities")]
    public virtual Division Division { get; set; } = null!;

    [InverseProperty("Community")]
    public virtual ICollection<Post> Posts { get; set; } = new List<Post>();
}
