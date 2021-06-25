﻿// <auto-generated />
using System;
using Accounting.DataAccess;
using Accounting.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Accounting.Migrations
{
    [DbContext(typeof(AccountingDbContext))]
    [Migration("20210625011545_PostingAccountToHaveParent")]
    partial class PostingAccountToHaveParent
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Accounting.Domain.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DisplayPosition")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostingType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Accounts");

                    b.HasDiscriminator<int>("PostingType");
                });

            modelBuilder.Entity("Accounting.Domain.Chart", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Charts");
                });

            modelBuilder.Entity("Accounting.Domain.HeadingAccount", b =>
                {
                    b.HasBaseType("Accounting.Domain.Account");

                    b.Property<Guid?>("ParentHeadingAccountId")
                        .HasColumnType("uniqueidentifier");

                    b.HasIndex("ParentHeadingAccountId");

                    b.HasDiscriminator().HasValue(2);
                });

            modelBuilder.Entity("Accounting.Domain.PostingAccount", b =>
                {
                    b.HasBaseType("Accounting.Domain.Account");

                    b.Property<Guid?>("ParentHeadingAccountId")
                        .HasColumnName("PostingAccount_ParentHeadingAccountId")
                        .HasColumnType("uniqueidentifier");

                    b.HasIndex("ParentHeadingAccountId");

                    b.HasDiscriminator().HasValue(1);
                });

            modelBuilder.Entity("Accounting.Domain.RootAccount", b =>
                {
                    b.HasBaseType("Accounting.Domain.Account");

                    b.Property<Guid?>("ChartId")
                        .HasColumnType("uniqueidentifier");

                    b.HasIndex("ChartId");

                    b.HasDiscriminator().HasValue(3);
                });

            modelBuilder.Entity("Accounting.Domain.HeadingAccount", b =>
                {
                    b.HasOne("Accounting.Domain.HeadingAccount", "ParentHeadingAccount")
                        .WithMany("HeadingAccounts")
                        .HasForeignKey("ParentHeadingAccountId");
                });

            modelBuilder.Entity("Accounting.Domain.PostingAccount", b =>
                {
                    b.HasOne("Accounting.Domain.HeadingAccount", "ParentHeadingAccount")
                        .WithMany()
                        .HasForeignKey("ParentHeadingAccountId");
                });

            modelBuilder.Entity("Accounting.Domain.RootAccount", b =>
                {
                    b.HasOne("Accounting.Domain.Chart", null)
                        .WithMany("Accounts")
                        .HasForeignKey("ChartId");
                });
#pragma warning restore 612, 618
        }
    }
}