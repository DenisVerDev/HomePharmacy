using System;
using System.Collections.Generic;

namespace HomePharmacy.Models;

public partial class Medicine
{
    public int IdMedicine { get; set; }

    public string Name { get; set; } = null!;

    public string Type { get; set; } = null!;

    public DateTime ExpiryDate { get; set; }

    public DateTime? PurchaseDate { get; set; }

    public decimal Price { get; set; }

    public int CountOrAmount { get; set; }

    public int ExemplearsCount { get; set; }

    public int Remainings { get; set; }

    public string ForWhom { get; set; } = null!;

    public int? BelongsToFamily { get; set; }

    public virtual Family? BelongsToFamilyNavigation { get; set; }

    public virtual Person ForWhomNavigation { get; set; } = null!;

    public virtual ICollection<MedicinesUsage> MedicinesUsages { get; } = new List<MedicinesUsage>();
}
