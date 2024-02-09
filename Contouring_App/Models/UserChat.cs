using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Contouring_App.Models;

[Table("UserChat")]
public partial class UserChat
{
    [Key]
    [Column("UserChatID")]
    public int UserChatId { get; set; }

    [Column("ChatID")]
    public int ChatId { get; set; }

    [Column("UserID")]
    public int UserId { get; set; }

    [ForeignKey("ChatId")]
    [InverseProperty("UserChats")]
    public virtual Chat Chat { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("UserChats")]
    public virtual User User { get; set; } = null!;
}
