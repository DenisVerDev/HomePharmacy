using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.EntityFrameworkCore;

namespace HomePharmacy.Models;

public partial class HomePharmacyContext : DbContext
{
    public HomePharmacyContext()
    {
    }

    public HomePharmacyContext(DbContextOptions<HomePharmacyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Appointment> Appointments { get; set; }

    public virtual DbSet<Family> Families { get; set; }

    public virtual DbSet<Illness> Illnesses { get; set; }

    public virtual DbSet<Medicine> Medicines { get; set; }

    public virtual DbSet<MedicinesType> MedicinesTypes { get; set; }

    public virtual DbSet<MedicinesUsage> MedicinesUsages { get; set; }

    public virtual DbSet<Person> Persons { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["PharmacyDB"].ConnectionString);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Appointment>(entity =>
        {
            entity.HasKey(e => new { e.IdIllness, e.MedicineList, e.Recommendator }).HasName("PK_Appointment");

            entity.Property(e => e.MedicineList).HasMaxLength(1000);
            entity.Property(e => e.Recommendator).HasMaxLength(200);
            entity.Property(e => e.AdditionalInfo).HasMaxLength(400);
            entity.Property(e => e.AppointmentVolume).HasMaxLength(1000);

            entity.HasOne(d => d.IdIllnessNavigation).WithMany(p => p.Appointments)
                .HasPrincipalKey(p => p.IdIllness)
                .HasForeignKey(d => d.IdIllness)
                .HasConstraintName("FK_Illness");
        });

        modelBuilder.Entity<Family>(entity =>
        {
            entity.HasKey(e => e.IdFamily).HasName("PK_Family");
        });

        modelBuilder.Entity<Illness>(entity =>
        {
            entity.HasKey(e => new { e.IlledPerson, e.Diagnoses, e.StartDate }).HasName("PK_Illness");

            entity.HasIndex(e => e.IdIllness, "UK_IdIllness").IsUnique();

            entity.Property(e => e.IlledPerson)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Diagnoses).HasMaxLength(1000);
            entity.Property(e => e.StartDate).HasColumnType("date");
            entity.Property(e => e.EndDate).HasColumnType("date");
            entity.Property(e => e.IdIllness).ValueGeneratedOnAdd();

            entity.HasOne(d => d.IlledPersonNavigation).WithMany(p => p.Illnesses)
                .HasForeignKey(d => d.IlledPerson)
                .HasConstraintName("FK_IlledPerson");
        });

        modelBuilder.Entity<Medicine>(entity =>
        {
            entity.HasKey(e => e.IdMedicine).HasName("PK_Medicine");

            entity.Property(e => e.ExpiryDate).HasColumnType("date");
            entity.Property(e => e.ForWhom)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.Price).HasColumnType("money");
            entity.Property(e => e.PurchaseDate).HasColumnType("date");
            entity.Property(e => e.Type)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.BelongsToFamilyNavigation).WithMany(p => p.Medicines)
                .HasForeignKey(d => d.BelongsToFamily)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_MedicineBelongsToFamily");

            entity.HasOne(d => d.ForWhomNavigation).WithMany(p => p.Medicines)
                .HasForeignKey(d => d.ForWhom)
                .HasConstraintName("FK_MedicineForWhom");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.Medicines)
                .HasForeignKey(d => d.Type)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_MedicineType");
        });

        modelBuilder.Entity<MedicinesType>(entity =>
        {
            entity.HasKey(e => e.Type).HasName("PK_MedicineType");

            entity.Property(e => e.Type)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MedicinesUsage>(entity =>
        {
            entity.HasKey(e => new { e.IdMedicine, e.IdIllness, e.UsageDate }).HasName("PK_MedicineUsage");

            entity.ToTable("MedicinesUsage");

            entity.Property(e => e.UsageDate).HasColumnType("date");
            entity.Property(e => e.Comment).HasMaxLength(200);
            entity.Property(e => e.UsageResult)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.IdIllnessNavigation).WithMany(p => p.MedicinesUsages)
                .HasPrincipalKey(p => p.IdIllness)
                .HasForeignKey(d => d.IdIllness)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MedicineForIllness");

            entity.HasOne(d => d.IdMedicineNavigation).WithMany(p => p.MedicinesUsages)
                .HasForeignKey(d => d.IdMedicine)
                .HasConstraintName("FK_UsedMedicine");
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(e => e.Email).HasName("PK_Person");

            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BirthDate).HasColumnType("date");
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.Password)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.Sex)
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.HasMany(d => d.IdFamilies).WithMany(p => p.People)
                .UsingEntity<Dictionary<string, object>>(
                    "PersonsFamily",
                    r => r.HasOne<Family>().WithMany()
                        .HasForeignKey("IdFamily")
                        .HasConstraintName("FK_Family"),
                    l => l.HasOne<Person>().WithMany()
                        .HasForeignKey("Person")
                        .HasConstraintName("FK_Person"),
                    j =>
                    {
                        j.HasKey("Person", "IdFamily").HasName("PK_FamilyRelation");
                    });
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
