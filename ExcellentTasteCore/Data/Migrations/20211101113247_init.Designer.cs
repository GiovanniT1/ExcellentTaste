// <auto-generated />
using System;
using ExcellentTasteCore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExcellentTasteCore.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211101113247_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ExcellentTasteCore.Models.Bestelling", b =>
                {
                    b.Property<int>("BestellingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("BestellingId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Aantal")
                        .HasColumnType("int")
                        .HasColumnName("Aantal");

                    b.Property<string>("ConsumptieItemCode")
                        .IsRequired()
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("varchar(4)")
                        .HasColumnName("ConsumptieItemCode");

                    b.Property<DateTime?>("DateTimeBereidingConsumptie")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("DateTimeBereidingConsumptie")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<decimal?>("Prijs")
                        .HasColumnType("decimal(19,4)")
                        .HasColumnName("Prijs");

                    b.Property<int>("ReserveringId")
                        .HasColumnType("int")
                        .HasColumnName("ReserveringId");

                    b.Property<decimal?>("Totaal")
                        .HasColumnType("decimal(19,4)")
                        .HasColumnName("Totaal");

                    b.HasKey("BestellingId");

                    b.HasIndex("ConsumptieItemCode");

                    b.HasIndex("ReserveringId");

                    b.ToTable("Bestelling");
                });

            modelBuilder.Entity("ExcellentTasteCore.Models.Consumptie", b =>
                {
                    b.Property<string>("ConsumptieCode")
                        .HasMaxLength(3)
                        .IsUnicode(false)
                        .HasColumnType("varchar(3)")
                        .HasColumnName("ConsumptieCode");

                    b.Property<string>("ConsumptieNaam")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("ConsumptieNaam");

                    b.HasKey("ConsumptieCode");

                    b.ToTable("Consumptie");
                });

            modelBuilder.Entity("ExcellentTasteCore.Models.ConsumptieGroep", b =>
                {
                    b.Property<string>("ConsumptieGroepCode")
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("varchar(4)")
                        .HasColumnName("ConsumptieGroepCode");

                    b.Property<string>("ConsumptieCode")
                        .IsRequired()
                        .HasMaxLength(3)
                        .IsUnicode(false)
                        .HasColumnType("varchar(3)")
                        .HasColumnName("ConsumptieCode");

                    b.Property<string>("ConsumptieGroepNaam")
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("ConsumptieGroepNaam");

                    b.HasKey("ConsumptieGroepCode");

                    b.HasIndex("ConsumptieCode");

                    b.ToTable("ConsumptieGroep");
                });

            modelBuilder.Entity("ExcellentTasteCore.Models.ConsumptieItem", b =>
                {
                    b.Property<string>("ConsumptieItemCode")
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("varchar(4)")
                        .HasColumnName("ConsumptieItemCode");

                    b.Property<string>("ConsumptieGroepCode")
                        .IsRequired()
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("varchar(4)")
                        .HasColumnName("ConsumptieGroepCode");

                    b.Property<string>("ConsumptieItemNaam")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("ConsumptieItemNaam");

                    b.Property<decimal>("Prijs")
                        .HasColumnType("decimal(19,4)")
                        .HasColumnName("Prijs");

                    b.HasKey("ConsumptieItemCode");

                    b.HasIndex("ConsumptieGroepCode");

                    b.ToTable("ConsumptieItem");
                });

            modelBuilder.Entity("ExcellentTasteCore.Models.Klant", b =>
                {
                    b.Property<int>("KlantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("KlantId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KlantNaam")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("KlantNaam");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("status");

                    b.Property<string>("Telefoon")
                        .IsRequired()
                        .HasMaxLength(11)
                        .IsUnicode(false)
                        .HasColumnType("varchar(11)")
                        .HasColumnName("Telefoon");

                    b.HasKey("KlantId");

                    b.ToTable("Klant");
                });

            modelBuilder.Entity("ExcellentTasteCore.Models.Reservering", b =>
                {
                    b.Property<int>("ReserveringId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ReserveringId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AantalPersonen")
                        .HasColumnType("int")
                        .HasColumnName("AantalPersonen");

                    b.Property<string>("Betalingswijze")
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .HasColumnType("varchar(2)")
                        .HasColumnName("Betalingswijze");

                    b.Property<DateTime>("BonDatum")
                        .HasColumnType("datetime")
                        .HasColumnName("BonDatum");

                    b.Property<decimal?>("BonTotaal")
                        .HasColumnType("decimal(19,4)")
                        .HasColumnName("BonTotaal");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime")
                        .HasColumnName("Datum");

                    b.Property<DateTime>("DatumToegevoegd")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("DatumToegevoegd")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int>("KlantId")
                        .HasColumnType("int")
                        .HasColumnName("klantId");

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Status")
                        .HasDefaultValueSql("((1))");

                    b.Property<int>("Tafel")
                        .HasColumnType("int")
                        .HasColumnName("Tafel");

                    b.Property<TimeSpan>("Tijd")
                        .HasColumnType("time")
                        .HasColumnName("Tijd");

                    b.HasKey("ReserveringId");

                    b.HasIndex("KlantId");

                    b.ToTable("Reservering");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ExcellentTasteCore.Models.Bestelling", b =>
                {
                    b.HasOne("ExcellentTasteCore.Models.ConsumptieItem", "ConsumptieItemCodeNavigation")
                        .WithMany("Bestellings")
                        .HasForeignKey("ConsumptieItemCode")
                        .HasConstraintName("FK_Bestelling_ConsumptieItem")
                        .IsRequired();

                    b.HasOne("ExcellentTasteCore.Models.Reservering", "Reservering")
                        .WithMany("Bestellings")
                        .HasForeignKey("ReserveringId")
                        .HasConstraintName("FK_Bestelling_Reservering")
                        .IsRequired();

                    b.Navigation("ConsumptieItemCodeNavigation");

                    b.Navigation("Reservering");
                });

            modelBuilder.Entity("ExcellentTasteCore.Models.ConsumptieGroep", b =>
                {
                    b.HasOne("ExcellentTasteCore.Models.Consumptie", "ConsumptieCodeNavigation")
                        .WithMany("ConsumptieGroeps")
                        .HasForeignKey("ConsumptieCode")
                        .HasConstraintName("FK_SubConsumptie_Consumptie")
                        .IsRequired();

                    b.Navigation("ConsumptieCodeNavigation");
                });

            modelBuilder.Entity("ExcellentTasteCore.Models.ConsumptieItem", b =>
                {
                    b.HasOne("ExcellentTasteCore.Models.ConsumptieGroep", "ConsumptieGroepCodeNavigation")
                        .WithMany("ConsumptieItems")
                        .HasForeignKey("ConsumptieGroepCode")
                        .HasConstraintName("FK_ConsumptieItem_SubConsumptie")
                        .IsRequired();

                    b.Navigation("ConsumptieGroepCodeNavigation");
                });

            modelBuilder.Entity("ExcellentTasteCore.Models.Reservering", b =>
                {
                    b.HasOne("ExcellentTasteCore.Models.Klant", "Klant")
                        .WithMany("Reserverings")
                        .HasForeignKey("KlantId")
                        .HasConstraintName("FK_Reservering_Klant")
                        .IsRequired();

                    b.Navigation("Klant");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ExcellentTasteCore.Models.Consumptie", b =>
                {
                    b.Navigation("ConsumptieGroeps");
                });

            modelBuilder.Entity("ExcellentTasteCore.Models.ConsumptieGroep", b =>
                {
                    b.Navigation("ConsumptieItems");
                });

            modelBuilder.Entity("ExcellentTasteCore.Models.ConsumptieItem", b =>
                {
                    b.Navigation("Bestellings");
                });

            modelBuilder.Entity("ExcellentTasteCore.Models.Klant", b =>
                {
                    b.Navigation("Reserverings");
                });

            modelBuilder.Entity("ExcellentTasteCore.Models.Reservering", b =>
                {
                    b.Navigation("Bestellings");
                });
#pragma warning restore 612, 618
        }
    }
}
