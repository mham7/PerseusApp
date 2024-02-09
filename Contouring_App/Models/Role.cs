using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Contouring_App.Models;

[Table("Role")]
public partial class Role
{
    [Key]
    [Column("RoleID")]
    public int RoleId { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? RoleName { get; set; }

    [InverseProperty("Role")]
    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
