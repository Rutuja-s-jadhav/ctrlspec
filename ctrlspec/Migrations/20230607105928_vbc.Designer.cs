﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ctrlspec.Data;

#nullable disable

namespace ctrlspec.Migrations
{
    [DbContext(typeof(CtrlSpecDbContext))]
    [Migration("20230607105928_vbc")]
    partial class vbc
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ctrlspec.Models.Equipment", b =>
                {
                    b.Property<double>("EquipmentID")
                        .HasColumnType("float");

                    b.Property<string>("EquipmentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EquipmentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ProjectNumber")
                        .HasColumnType("float");

                    b.Property<string>("TypicalOf")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EquipmentID");

                    b.HasIndex("ProjectNumber");

                    b.ToTable("equipment");
                });

            modelBuilder.Entity("ctrlspec.Models.Exhaust_Fan", b =>
                {
                    b.Property<double>("EquipmentID")
                        .HasColumnType("float");

                    b.Property<string>("DamperControl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilterMonitoring")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiscMonitoring")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RunConditions")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EquipmentID");

                    b.ToTable("exhaust_Fans");
                });

            modelBuilder.Entity("ctrlspec.Models.Login", b =>
                {
                    b.Property<double>("LoginId")
                        .HasColumnType("float");

                    b.Property<string>("EmailId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LoginId");

                    b.ToTable("login");
                });

            modelBuilder.Entity("ctrlspec.Models.Project_Info", b =>
                {
                    b.Property<double>("ProjectNumber")
                        .HasColumnType("float");

                    b.Property<string>("MeasurementType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreparedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjectNumber");

                    b.ToTable("projectinfo");
                });

            modelBuilder.Entity("ctrlspec.Models.Room_Units", b =>
                {
                    b.Property<double>("EquipmentID")
                        .HasColumnType("float");

                    b.Property<string>("Cooling")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnvironmentalIndex")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FaceBypassDamper")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilterMonitoring")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Heating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HeatingHighDischargeLimit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MinimunOutsideAir")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiscMonitoring")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MixedAirDamper")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RunConditions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Safeties")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZoneControl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EquipmentID");

                    b.ToTable("room_Units");
                });

            modelBuilder.Entity("ctrlspec.Models.Spec_Option", b =>
                {
                    b.Property<double>("Id")
                        .HasColumnType("float");

                    b.Property<string>("Questions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("spec_Options");
                });

            modelBuilder.Entity("ctrlspec.Models.Unitary_Heat", b =>
                {
                    b.Property<double>("EquipmentID")
                        .HasColumnType("float");

                    b.Property<string>("EnvironmentalIndex")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilterMonitoring")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Heating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiscMonitoring")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RunConditions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZoneControl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EquipmentID");

                    b.ToTable("unitary_Heats");
                });

            modelBuilder.Entity("ctrlspec.Models.Equipment", b =>
                {
                    b.HasOne("ctrlspec.Models.Project_Info", "projectinfo")
                        .WithMany()
                        .HasForeignKey("ProjectNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("projectinfo");
                });

            modelBuilder.Entity("ctrlspec.Models.Exhaust_Fan", b =>
                {
                    b.HasOne("ctrlspec.Models.Equipment", "equipment")
                        .WithMany()
                        .HasForeignKey("EquipmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("equipment");
                });

            modelBuilder.Entity("ctrlspec.Models.Room_Units", b =>
                {
                    b.HasOne("ctrlspec.Models.Equipment", "equipment")
                        .WithMany()
                        .HasForeignKey("EquipmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("equipment");
                });

            modelBuilder.Entity("ctrlspec.Models.Unitary_Heat", b =>
                {
                    b.HasOne("ctrlspec.Models.Equipment", "equipment")
                        .WithMany()
                        .HasForeignKey("EquipmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("equipment");
                });
#pragma warning restore 612, 618
        }
    }
}
