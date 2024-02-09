using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Contouring_App.Models;

[Table("User")]
public partial class User
{
    [Key]
    [Column("UserID")]
    public int UserId { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string FirstName { get; set; } = null!;

    [StringLength(250)]
    [Unicode(false)]
    public string LastName { get; set; } = null!;

    [StringLength(250)]
    [Unicode(false)]
    public string Email { get; set; } = null!;

    [StringLength(250)]
    [Unicode(false)]
    public string Password { get; set; } = null!;

    public DateOnly DateOfJoining { get; set; }

    public int Salary { get; set; }

    [Column("RoleID")]
    public int RoleId { get; set; }

    [Column("DivID")]
    public int DivId { get; set; }

    [InverseProperty("Reciever")]
    public virtual ICollection<Chat> ChatRecievers { get; set; } = new List<Chat>();

    [InverseProperty("Sender")]
    public virtual ICollection<Chat> ChatSenders { get; set; } = new List<Chat>();

    [ForeignKey("DivId")]
    [InverseProperty("Users")]
    public virtual Division Div { get; set; } = null!;

    [InverseProperty("User")]
    public virtual ICollection<ProfilePic> ProfilePics { get; set; } = new List<ProfilePic>();

    [ForeignKey("RoleId")]
    [InverseProperty("Users")]
    public virtual Role Role { get; set; } = null!;

    [InverseProperty("Assigned")]
    public virtual ICollection<Task> TaskAssigneds { get; set; } = new List<Task>();

    [InverseProperty("Creator")]
    public virtual ICollection<Task> TaskCreators { get; set; } = new List<Task>();

    [InverseProperty("User")]
    public virtual ICollection<UserChat> UserChats { get; set; } = new List<UserChat>();
}
