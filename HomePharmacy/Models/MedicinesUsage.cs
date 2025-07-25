﻿using System;
using System.Collections.Generic;

namespace HomePharmacy.Models;

public partial class MedicinesUsage
{
    public int IdMedicine { get; set; }

    public int IdIllness { get; set; }

    public DateTime UsageDate { get; set; }

    public string UsageResult { get; set; } = null!;

    public int CountOrAmount { get; set; }

    public string? Comment { get; set; }

    public virtual Illness IdIllnessNavigation { get; set; } = null!;

    public virtual Medicine IdMedicineNavigation { get; set; } = null!;

    public void TrasnferDataFrom(MedicinesUsage usage)
    {
        this.IdMedicine = usage.IdMedicine;
        this.IdIllness = usage.IdIllness;
        this.UsageDate = usage.UsageDate;
        this.UsageResult = usage.UsageResult;
        this.CountOrAmount = usage.CountOrAmount;
        this.Comment = usage.Comment;
    }
}
