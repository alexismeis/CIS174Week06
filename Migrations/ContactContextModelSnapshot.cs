﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MultiPageContactsMeis.Models;

namespace MultiPageContactsMeis.Migrations
{
    [DbContext(typeof(ContactContext))]
    partial class ContactContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MultiPageContactsMeis.Models.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactId");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            ContactId = 1,
                            Address = "6411 Northwest Dr",
                            Name = "Mom",
                            Note = "Mom (Margaret Meis) cell",
                            PhoneNum = "515-897-8596"
                        },
                        new
                        {
                            ContactId = 2,
                            Address = "1655 SE Waters Edge Dr",
                            Name = "Dad",
                            Note = "Dad (Jamie Meis) cell",
                            PhoneNum = "515-202-5665"
                        },
                        new
                        {
                            ContactId = 3,
                            Address = "6411 Northwest Dr",
                            Name = "Alexis",
                            Note = "Alexis cell",
                            PhoneNum = "515-802-0409"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}