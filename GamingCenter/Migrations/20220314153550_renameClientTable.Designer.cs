// <auto-generated />
using System;
using GamingCenter.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GamingCenter.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220314153550_renameClientTable")]
    partial class renameClientTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("GamingCenter.Data.Models.Client_Services", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("ServicesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("ServicesId");

                    b.ToTable("Client_Services");
                });

            modelBuilder.Entity("GamingCenter.Data.Models.Clients", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("GamingCenter.Data.Models.Sectors", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sectors");
                });

            modelBuilder.Entity("GamingCenter.Data.Models.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SectorsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SectorsId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("GamingCenter.Data.Models.Workers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DateStarted")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SectorsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SectorsId");

                    b.ToTable("Workers");
                });

            modelBuilder.Entity("GamingCenter.Data.Models.Client_Services", b =>
                {
                    b.HasOne("GamingCenter.Data.Models.Clients", "Clients")
                        .WithMany("Client_Services")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GamingCenter.Data.Models.Service", "Service")
                        .WithMany("Client_Services")
                        .HasForeignKey("ServicesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clients");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("GamingCenter.Data.Models.Service", b =>
                {
                    b.HasOne("GamingCenter.Data.Models.Sectors", "Sectors")
                        .WithMany("Service")
                        .HasForeignKey("SectorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sectors");
                });

            modelBuilder.Entity("GamingCenter.Data.Models.Workers", b =>
                {
                    b.HasOne("GamingCenter.Data.Models.Sectors", null)
                        .WithMany("Workers")
                        .HasForeignKey("SectorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GamingCenter.Data.Models.Clients", b =>
                {
                    b.Navigation("Client_Services");
                });

            modelBuilder.Entity("GamingCenter.Data.Models.Sectors", b =>
                {
                    b.Navigation("Service");

                    b.Navigation("Workers");
                });

            modelBuilder.Entity("GamingCenter.Data.Models.Service", b =>
                {
                    b.Navigation("Client_Services");
                });
#pragma warning restore 612, 618
        }
    }
}
