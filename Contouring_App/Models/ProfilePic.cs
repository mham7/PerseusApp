using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Contouring_App.Models;

[Table("ProfilePic")]
public partial class ProfilePic
{
    [Key]
    [Column("ProfilePicID")]
    public int ProfilePicId { get; set; }

    [Column("Profilepic")]
    public byte[]? Profilepic1 { get; set; }

    [Column("UserID")]
    public int UserId { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("ProfilePics")]
    public virtual User User { get; set; } = null!;
}
