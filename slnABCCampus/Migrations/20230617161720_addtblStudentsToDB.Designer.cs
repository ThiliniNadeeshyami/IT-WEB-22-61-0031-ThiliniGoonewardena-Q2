﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using slnABCCampus.Data;

#nullable disable

namespace slnABCCampus.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20230617161720_addtblStudentsToDB")]
    partial class addtblStudentsToDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("slnABCCampus.Model.tblStudents", b =>
                {
                    b.Property<int>("dStudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("dStudentID"));

                    b.Property<int>("dCourseID")
                        .HasColumnType("int");

                    b.Property<string>("szCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("szStudentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("dStudentID");

                    b.ToTable("tblStudentsDet");
                });
#pragma warning restore 612, 618
        }
    }
}
