using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Contouring_App.Models;

[Keyless]
[Table("PostImage")]
public partial class PostImage
{
    [Column("PostImgID")]
    public int PostImgId { get; set; }

    public byte[]? PostImg { get; set; }

    [Column("PostID")]
    public int PostId { get; set; }

    [ForeignKey("PostId")]
    public virtual Post Post { get; set; } = null!;
}
