﻿// <auto-generated />
using System;
using ComiteAccesoADatos.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ComiteAccesoADatos.Migrations
{
    [DbContext(typeof(ComiteContext))]
    partial class ComiteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ComiteLogicaNegocio.Entidades.Usuario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fecRegistro")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("usuarios");

                    b.HasDiscriminator().HasValue("Usuario");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("ComiteLogicaNegocio.Entidades.Admin", b =>
                {
                    b.HasBaseType("ComiteLogicaNegocio.Entidades.Usuario");

                    b.HasDiscriminator().HasValue("Admin");
                });

            modelBuilder.Entity("ComiteLogicaNegocio.Entidades.Digitador", b =>
                {
                    b.HasBaseType("ComiteLogicaNegocio.Entidades.Usuario");

                    b.HasDiscriminator().HasValue("Digitador");
                });
#pragma warning restore 612, 618
        }
    }
}
