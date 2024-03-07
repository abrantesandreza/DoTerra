﻿// <auto-generated />
using System;
using DoTerra.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DoTerra.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DoTerra.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("DisplayOrder")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Óleos Essenciais"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Acessórios"
                        });
                });

            modelBuilder.Entity("DoTerra.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AromaticDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Benefits")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("COD")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HowToUse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingredients")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ListPrice")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Precautions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("Price100")
                        .HasColumnType("float");

                    b.Property<double>("Price1000")
                        .HasColumnType("float");

                    b.Property<double>("Price500")
                        .HasColumnType("float");

                    b.Property<string>("ScientificName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Uses")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AromaticDescription = "Mentolado, fresco, herbáceo",
                            Benefits = "Ajuda a reduzir sentimentos de tensão.",
                            COD = 1,
                            Description = "O doTERRA® Peppermint Touch contém óleo essencial de Hortelã-Pimenta e Óleo de Coco Fracionado para promover vários benefícios. Seu aroma mentolado e herbáceo pode ser utilizado aromática e topicamente ao longo do dia para elevar o humor e promover um senso de foco. Quando aplicado nas têmporas e na nuca, ajuda a diminuir sentimentos de tensão. O doTERRA Peppermint Touch pode ser aplicado nessas áreas e em todo o corpo para promover uma massagem refrescante.",
                            HowToUse = "Esfregue nas têmporas quando estiver estudando ou ao acordar, para um reforço de energia durante a manhã.",
                            Ingredients = "Óleo de coco, Óleo de Mentha piperita.",
                            ListPrice = 125.0,
                            Name = "dōTERRA Peppermint Touch",
                            Precautions = "Uso Externo. Pode causar irritação cutânea. Mantenha fora do alcance de crianças. Em caso de gravidez ou tratamento, consulte o médico. Evite contato com os olhos, ouvidos e áreas sensíveis. Em caso de contato com os olhos, enxágue com Óleo Carreador doTERRA em abundância. Em caso de irritação, descontinue o uso e procure um médico. Mantenha o produto ao abrigo da luz e do calor.",
                            Price = 115.0,
                            Price100 = 225.0,
                            Price1000 = 1050.0,
                            Price500 = 770.0,
                            ScientificName = "Mentha piperita",
                            Size = "10 ml",
                            Uses = "Esfregue nas têmporas quando estiver estudando ou ao acordar, para um reforço de energia durante a manhã."
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
