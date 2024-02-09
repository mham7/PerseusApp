using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Contouring_App.Models;

[Table("Division")]
public partial class Division
{
    [Key]
    [Column("DivID")]
    public int DivId { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? DivName { get; set; }

    [InverseProperty("Division")]
    public virtual ICollection<Community> Communities { get; set; } = new List<Community>();

    [InverseProperty("Div")]
    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
