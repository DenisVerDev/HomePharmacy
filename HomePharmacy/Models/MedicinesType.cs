using System;
using System.Collections.Generic;

namespace HomePharmacy.Models;

public partial class MedicinesType
{
    public string Type { get; set; } = null!;

    public virtual ICollection<Medicine> Medicines { get; } = new List<Medicine>();
}
