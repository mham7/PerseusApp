using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Contouring_App.Models;

[Table("Chat")]
public partial class Chat
{
    [Key]
    [Column("ChatID")]
    public int ChatId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreatedTime { get; set; }

    [Column("SenderID")]
    public int SenderId { get; set; }

    [Column("RecieverID")]
    public int RecieverId { get; set; }

    [InverseProperty("Chat")]
    public virtual ICollection<Message> Messages { get; set; } = new List<Message>();

    [ForeignKey("RecieverId")]
    [InverseProperty("ChatRecievers")]
    public virtual User Reciever { get; set; } = null!;

    [ForeignKey("SenderId")]
    [InverseProperty("ChatSenders")]
    public virtual User Sender { get; set; } = null!;

    [InverseProperty("Chat")]
    public virtual ICollection<UserChat> UserChats { get; set; } = new List<UserChat>();
}
