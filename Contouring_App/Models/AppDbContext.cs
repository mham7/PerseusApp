using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Contouring_App.Models;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Chat> Chats { get; set; }

    public virtual DbSet<Community> Communities { get; set; }

    public virtual DbSet<Division> Divisions { get; set; }

    public virtual DbSet<Message> Messages { get; set; }

    public virtual DbSet<Post> Posts { get; set; }

    public virtual DbSet<PostComment> PostComments { get; set; }

    public virtual DbSet<PostImage> PostImages { get; set; }

    public virtual DbSet<ProfilePic> ProfilePics { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Task> Tasks { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserChat> UserChats { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=CRIBL-ALIINHAM2\\SQLEXPRESS;Database=Contour;Integrated Security=True;Persist Security Info=True;Encrypt=true;TrustServerCertificate=yes");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Chat>(entity =>
        {
            entity.HasKey(e => e.ChatId).HasName("PK__Chat__A9FBE626F8834422");

            entity.HasOne(d => d.Reciever).WithMany(p => p.ChatRecievers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Chat__RecieverID__5FB337D6");

            entity.HasOne(d => d.Sender).WithMany(p => p.ChatSenders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Chat__SenderID__5EBF139D");
        });

        modelBuilder.Entity<Community>(entity =>
        {
            entity.HasKey(e => e.CommunityId).HasName("PK__Communit__CCAA5B09C40B64E6");

            entity.HasOne(d => d.Division).WithMany(p => p.Communities)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Community__Divis__5441852A");
        });

        modelBuilder.Entity<Division>(entity =>
        {
            entity.HasKey(e => e.DivId).HasName("PK__Division__F195146E6B877557");
        });

        modelBuilder.Entity<Message>(entity =>
        {
            entity.HasKey(e => e.MessageId).HasName("PK__Message__C87C037CE257F4E4");

            entity.HasOne(d => d.Chat).WithMany(p => p.Messages)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Message__ChatID__66603565");
        });

        modelBuilder.Entity<Post>(entity =>
        {
            entity.HasKey(e => e.PostId).HasName("PK__Post__AA126038418E2A73");

            entity.HasOne(d => d.Community).WithMany(p => p.Posts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Post__CommunityI__571DF1D5");
        });

        modelBuilder.Entity<PostComment>(entity =>
        {
            entity.Property(e => e.CommentId).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Creator).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PostComme__Creat__5AEE82B9");

            entity.HasOne(d => d.Post).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PostComme__PostI__5BE2A6F2");
        });

        modelBuilder.Entity<PostImage>(entity =>
        {
            entity.Property(e => e.PostImgId).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Post).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PostImage__PostI__59063A47");
        });

        modelBuilder.Entity<ProfilePic>(entity =>
        {
            entity.HasKey(e => e.ProfilePicId).HasName("PK__ProfileP__AE63383043EA2056");

            entity.HasOne(d => d.User).WithMany(p => p.ProfilePics)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ProfilePi__UserI__4CA06362");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__Role__8AFACE3A8C990910");
        });

        modelBuilder.Entity<Task>(entity =>
        {
            entity.HasKey(e => e.TaskId).HasName("PK__Task__7C6949D12D398C6F");

            entity.HasOne(d => d.Assigned).WithMany(p => p.TaskAssigneds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Task__AssignedID__5070F446");

            entity.HasOne(d => d.Creator).WithMany(p => p.TaskCreators)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Task__CreatorID__4F7CD00D");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__User__1788CCAC0903F30D");

            entity.HasOne(d => d.Div).WithMany(p => p.Users)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__User__DivID__49C3F6B7");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__User__RoleID__48CFD27E");
        });

        modelBuilder.Entity<UserChat>(entity =>
        {
            entity.HasKey(e => e.UserChatId).HasName("PK__UserChat__B5C6D2C291255119");

            entity.HasOne(d => d.Chat).WithMany(p => p.UserChats)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UserChat__ChatID__6383C8BA");

            entity.HasOne(d => d.User).WithMany(p => p.UserChats)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UserChat__UserID__628FA481");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
