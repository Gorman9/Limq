﻿// <auto-generated />
using System;
using Limq.Persistence.LimqDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Limq.Persistence.LimqDb.Migrations
{
    [DbContext(typeof(LimqDbContext))]
    partial class LimqDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Limq.Core.Domain.Chats.Models.Chat", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FirstUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SecondUser")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("Limq.Core.Domain.Messages.Models.MessageChat", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MessageTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserFromId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserToId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("MessagesChat");
                });

            modelBuilder.Entity("Limq.Core.Domain.Messages.Models.MessageSquad", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MessageTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("SquadId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("SystemMessage")
                        .HasColumnType("bit");

                    b.Property<Guid>("UserFromId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("MessagesSquad");
                });

            modelBuilder.Entity("Limq.Core.Domain.Squads.Models.Squad", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AdminId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("Avatar")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Squads");
                });

            modelBuilder.Entity("Limq.Core.Domain.Users.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("Avatar")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<bool>("Theme")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Limq.Core.Domain.Users.Models.UserChatBlocked", b =>
                {
                    b.Property<Guid>("FirstUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SecondUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("FirstUser", "SecondUser");

                    b.HasIndex("SecondUser");

                    b.ToTable("UserChatsBlocked");
                });

            modelBuilder.Entity("Limq.Core.Domain.Users.Models.UserSquad", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SquadId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "SquadId");

                    b.HasIndex("SquadId");

                    b.ToTable("UserSquads");
                });

            modelBuilder.Entity("Limq.Core.Domain.Users.Models.UserSquadBlocked", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SquadId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "SquadId");

                    b.HasIndex("SquadId");

                    b.ToTable("UserSquadsBlocked");
                });

            modelBuilder.Entity("Limq.Core.Domain.Users.Models.UserChatBlocked", b =>
                {
                    b.HasOne("Limq.Core.Domain.Users.Models.User", "User1")
                        .WithMany("UserChatsBlocked1")
                        .HasForeignKey("FirstUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Limq.Core.Domain.Users.Models.User", "User2")
                        .WithMany("UserChatsBlocked2")
                        .HasForeignKey("SecondUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User1");

                    b.Navigation("User2");
                });

            modelBuilder.Entity("Limq.Core.Domain.Users.Models.UserSquad", b =>
                {
                    b.HasOne("Limq.Core.Domain.Squads.Models.Squad", "Squad")
                        .WithMany("UserSquads")
                        .HasForeignKey("SquadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Limq.Core.Domain.Users.Models.User", "User")
                        .WithMany("UserSquads")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Squad");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Limq.Core.Domain.Users.Models.UserSquadBlocked", b =>
                {
                    b.HasOne("Limq.Core.Domain.Squads.Models.Squad", "Squad")
                        .WithMany("UserSquadsBlocked")
                        .HasForeignKey("SquadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Limq.Core.Domain.Users.Models.User", "User")
                        .WithMany("UserSquadsBlocked")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Squad");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Limq.Core.Domain.Squads.Models.Squad", b =>
                {
                    b.Navigation("UserSquads");

                    b.Navigation("UserSquadsBlocked");
                });

            modelBuilder.Entity("Limq.Core.Domain.Users.Models.User", b =>
                {
                    b.Navigation("UserChatsBlocked1");

                    b.Navigation("UserChatsBlocked2");

                    b.Navigation("UserSquads");

                    b.Navigation("UserSquadsBlocked");
                });
#pragma warning restore 612, 618
        }
    }
}
