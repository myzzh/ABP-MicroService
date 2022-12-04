﻿// <auto-generated />
using System;
using Business.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Volo.Abp.EntityFrameworkCore;

#nullable disable

namespace Business.Migrations
{
    [DbContext(typeof(BusinessMigrationDbContext))]
    [Migration("20221110095539_add_PrintTemplate")]
    partial class add_PrintTemplate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("_Abp_DatabaseProvider", EfCoreDatabaseProvider.SqlServer)
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Business.Models.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CreatorId");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ExtraProperties");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasColumnName("IsDeleted");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("LastModifierId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("TenantId");

                    b.HasKey("Id");

                    b.ToTable("Book", (string)null);
                });

            modelBuilder.Entity("Business.Models.PrintTemplate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CreatorId");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ExtraProperties");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasColumnName("IsDeleted");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("LastModifierId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sort")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("TempType")
                        .HasColumnType("int");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("TenantId");

                    b.HasKey("Id");

                    b.ToTable("base_print_template", (string)null);
                });

            modelBuilder.Entity("XCZ.FlowManagement.BaseFlow", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CreatorId");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ExtraProperties");

                    b.Property<Guid>("FormId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasColumnName("IsDeleted");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("LastModifierId");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Remark")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("TenantId");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UseDate")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("FormId");

                    b.ToTable("base_flow", (string)null);
                });

            modelBuilder.Entity("XCZ.FlowManagement.FlowLine", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BaseFlowId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ExtraProperties");

                    b.Property<string>("From")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasColumnName("IsDeleted");

                    b.Property<string>("Label")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Remark")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("TenantId");

                    b.Property<string>("To")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("base_flow_line", (string)null);
                });

            modelBuilder.Entity("XCZ.FlowManagement.FlowNode", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BaseFlowId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<string>("Executor")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ExtraProperties");

                    b.Property<string>("Ico")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasColumnName("IsDeleted");

                    b.Property<string>("Left")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NodeId")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Remark")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Roles")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("State")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("TenantId");

                    b.Property<string>("Top")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Users")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.ToTable("base_flow_node", (string)null);
                });

            modelBuilder.Entity("XCZ.FlowManagement.LineForm", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BaseFlowId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<string>("Condition")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Content")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ExtraProperties");

                    b.Property<Guid>("FieldId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FieldName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("FieldType")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<Guid>("FlowLineId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("IntContent")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasColumnName("IsDeleted");

                    b.Property<string>("Remark")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("TenantId");

                    b.HasKey("Id");

                    b.ToTable("base_flow_line_form", (string)null);
                });

            modelBuilder.Entity("XCZ.FormManagement.Form", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Api")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CreatorId");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("Disabled")
                        .HasColumnType("bit");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("EntityName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ExtraProperties");

                    b.Property<string>("FormName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasColumnName("IsDeleted");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("LastModifierId");

                    b.Property<string>("Namespace")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Remark")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("TableName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("TenantId");

                    b.HasKey("Id");

                    b.ToTable("base_form", (string)null);
                });

            modelBuilder.Entity("XCZ.FormManagement.FormData", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CreatorId");

                    b.Property<string>("Data")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ExtraProperties");

                    b.Property<Guid>("FormId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasColumnName("IsDeleted");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("LastModifierId");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("TenantId");

                    b.HasKey("Id");

                    b.ToTable("base_form_datas", (string)null);
                });

            modelBuilder.Entity("XCZ.FormManagement.FormField", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<string>("DataType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DefaultValue")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("Disabled")
                        .HasColumnType("bit");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ExtraProperties");

                    b.Property<string>("FieldName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("FieldOrder")
                        .HasColumnType("int");

                    b.Property<string>("FieldType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("FormId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Icon")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsIndex")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<bool>("IsReadonly")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRequired")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSort")
                        .HasColumnType("bit");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<int?>("Maxlength")
                        .HasColumnType("int");

                    b.Property<string>("Placeholder")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Regx")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Span")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(24);

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("base_form_fields", (string)null);
                });

            modelBuilder.Entity("XCZ.FormManagement.FormFieldOption", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ExtraProperties");

                    b.Property<Guid>("FormFieldId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FormId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("base_form_fields_opts", (string)null);
                });

            modelBuilder.Entity("XCZ.WorkFlow.FormWorkFlow", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BaseFlowId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CreatorId");

                    b.Property<Guid>("EntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ExtraProperties");

                    b.Property<Guid>("FormId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasColumnName("IsDeleted");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("LastModifierId");

                    b.Property<string>("NodeId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("EntityId");

                    b.HasIndex("NodeId");

                    b.ToTable("base_form_workflow", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
