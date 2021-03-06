﻿// <auto-generated />
using System;
using ESoftor.WebApi.Migrations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ESoftor.WebApi.Migrations
{
    [DbContext(typeof(NovelDbContext))]
    [Migration("20181113133310_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ESoftor.Core.Permission.Identity.Entity.Role", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<DateTime>("CreatedTime");

                    b.Property<bool>("IsAdmin");

                    b.Property<bool>("IsDefault");

                    b.Property<bool>("IsLocked");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Remark")
                        .HasMaxLength(128);

                    b.HasKey("ID");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("Role");

                    b.HasData(
                        new { ID = new Guid("714362d7-ccdc-4c70-ba76-a99701632df0"), ConcurrencyStamp = "96ff8c75-4d0c-4ad8-9b82-1b61987c973d", CreatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), IsAdmin = true, IsDefault = false, IsLocked = false, Name = "系统管理员", Remark = "系统最高权限管理角色" }
                    );
                });

            modelBuilder.Entity("ESoftor.Core.Permission.Identity.Entity.RoleClaim", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("Remark")
                        .HasMaxLength(128);

                    b.Property<Guid>("RoleId");

                    b.HasKey("ID");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaim");
                });

            modelBuilder.Entity("ESoftor.Core.Permission.Identity.Entity.User", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<DateTime>("CreatedTime");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("HeadImg");

                    b.Property<bool>("IsLocked");

                    b.Property<bool>("IsSystem");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NickName");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("Remark")
                        .HasMaxLength(128);

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("Email")
                        .HasName("EmailIndex");

                    b.HasIndex("UserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ESoftor.Core.Permission.Identity.Entity.UserClaim", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType")
                        .IsRequired();

                    b.Property<string>("ClaimValue");

                    b.Property<string>("Remark")
                        .HasMaxLength(128);

                    b.Property<Guid>("UserId");

                    b.HasKey("ID");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaim");
                });

            modelBuilder.Entity("ESoftor.Core.Permission.Identity.Entity.UserDetail", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("RegisterIp");

                    b.Property<string>("Remark")
                        .HasMaxLength(128);

                    b.Property<int>("UserId");

                    b.HasKey("ID");

                    b.ToTable("UserDetail");
                });

            modelBuilder.Entity("ESoftor.Core.Permission.Identity.Entity.UserLogin", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("Remark")
                        .HasMaxLength(128);

                    b.Property<Guid>("UserId");

                    b.HasKey("ID");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogin");
                });

            modelBuilder.Entity("ESoftor.Core.Permission.Identity.Entity.UserRole", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedTime");

                    b.Property<bool>("IsLocked");

                    b.Property<string>("Remark")
                        .HasMaxLength(128);

                    b.Property<Guid>("RoleId");

                    b.Property<Guid>("UserId");

                    b.HasKey("ID");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId", "RoleId")
                        .IsUnique()
                        .HasName("UserIdRoleIdIndex");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("ESoftor.Core.Permission.Identity.Entity.UserToken", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Remark")
                        .HasMaxLength(128);

                    b.Property<Guid>("UserId");

                    b.Property<string>("Value");

                    b.HasKey("ID");

                    b.HasIndex("Name", "LoginProvider", "UserId")
                        .IsUnique()
                        .HasName("UserTokenIndex")
                        .HasFilter("[Name] IS NOT NULL AND [LoginProvider] IS NOT NULL");

                    b.ToTable("UserToken");
                });

            modelBuilder.Entity("ESoftor.Core.Permission.Identity.Entity.RoleClaim", b =>
                {
                    b.HasOne("ESoftor.Core.Permission.Identity.Entity.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ESoftor.Core.Permission.Identity.Entity.UserClaim", b =>
                {
                    b.HasOne("ESoftor.Core.Permission.Identity.Entity.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ESoftor.Core.Permission.Identity.Entity.UserLogin", b =>
                {
                    b.HasOne("ESoftor.Core.Permission.Identity.Entity.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ESoftor.Core.Permission.Identity.Entity.UserRole", b =>
                {
                    b.HasOne("ESoftor.Core.Permission.Identity.Entity.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ESoftor.Core.Permission.Identity.Entity.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
