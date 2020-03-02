﻿// <auto-generated />
using System;
using CSharpWars.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CSharpWars.DataAccess.Migrations
{
    [DbContext(typeof(CSharpWarsDbContext))]
    partial class CSharpWarsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CSharpWars.Model.Bot", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CurrentHealth")
                        .HasColumnType("int");

                    b.Property<int>("CurrentStamina")
                        .HasColumnType("int");

                    b.Property<int>("FromX")
                        .HasColumnType("int");

                    b.Property<int>("FromY")
                        .HasColumnType("int");

                    b.Property<int>("LastAttackX")
                        .HasColumnType("int");

                    b.Property<int>("LastAttackY")
                        .HasColumnType("int");

                    b.Property<int>("MaximumHealth")
                        .HasColumnType("int");

                    b.Property<int>("MaximumStamina")
                        .HasColumnType("int");

                    b.Property<string>("Memory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Move")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Orientation")
                        .HasColumnType("int");

                    b.Property<Guid?>("PlayerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SysId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("TimeOfDeath")
                        .HasColumnType("datetime2");

                    b.Property<int>("X")
                        .HasColumnType("int");

                    b.Property<int>("Y")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.HasIndex("PlayerId");

                    b.HasIndex("SysId")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.ToTable("BOTS");
                });

            modelBuilder.Entity("CSharpWars.Model.BotScript", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Script")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.ToTable("BOTS");
                });

            modelBuilder.Entity("CSharpWars.Model.Player", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Hashed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastDeployment")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Salt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SysId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.HasIndex("SysId")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.ToTable("PLAYERS");
                });

            modelBuilder.Entity("CSharpWars.Model.Bot", b =>
                {
                    b.HasOne("CSharpWars.Model.Player", "Player")
                        .WithMany("Bots")
                        .HasForeignKey("PlayerId");
                });

            modelBuilder.Entity("CSharpWars.Model.BotScript", b =>
                {
                    b.HasOne("CSharpWars.Model.Bot", null)
                        .WithOne("BotScript")
                        .HasForeignKey("CSharpWars.Model.BotScript", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
