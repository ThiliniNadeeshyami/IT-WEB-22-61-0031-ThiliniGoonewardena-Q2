﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using slnABCCampus.Data;

#nullable disable

namespace slnABCCampus.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("slnABCCampus.Model.tblStudents", b =>
                {
                    b.Property<decimal>("dStudentID")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("dCourseID")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("szCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("szStudentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("dStudentID");

                    b.ToTable("tblStudentsDetail");
                });
#pragma warning restore 612, 618
        }
    }
}
