using System;
using System.Collections.Generic;

namespace HomePharmacy.Models;

public partial class Medicine
{
    public int IdMedicine { get; set; }

    public string Name { get; set; } = null!;

    public string? Type { get; set; }

    public DateTime? PurchaseDate { get; set; }

    public DateTime ExpiryDate { get; set; }

    public decimal Price { get; set; }

    public int CountOrAmount { get; set; }

    public int ExemplearsCount { get; set; }

    public int Remainings { get; set; }

    public string ForWhom { get; set; } = null!;

    public int? BelongsToFamily { get; set; }

    public virtual Family? BelongsToFamilyNavigation { get; set; }

    public virtual Person ForWhomNavigation { get; set; } = null!;

    public virtual ICollection<MedicinesUsage> MedicinesUsages { get; } = new List<MedicinesUsage>();

    public virtual MedicinesType? TypeNavigation { get; set; }

    public void GetSetProperties(Medicine medicine)
    {
        this.IdMedicine = medicine.IdMedicine;
        this.Name = medicine.Name;
        this.Type = medicine.Type;
        this.PurchaseDate = medicine.PurchaseDate;
        this.ExpiryDate = medicine.ExpiryDate;
        this.Price = medicine.Price;
        this.CountOrAmount = medicine.CountOrAmount;
        this.ExemplearsCount = medicine.ExemplearsCount;
        this.Remainings = medicine.Remainings;
        this.ForWhom = medicine.ForWhom;
        this.BelongsToFamily = medicine.BelongsToFamily;
    }
}
