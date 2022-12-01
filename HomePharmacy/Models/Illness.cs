using System;
using System.Collections.Generic;

namespace HomePharmacy.Models;

public partial class Illness
{
    public int IdIllness { get; set; }

    public string IlledPerson { get; set; } = null!;

    public string Diagnoses { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public virtual ICollection<Appointment> Appointments { get; } = new List<Appointment>();

    public virtual Person IlledPersonNavigation { get; set; } = null!;

    public virtual ICollection<MedicinesUsage> MedicinesUsages { get; } = new List<MedicinesUsage>();

    public void TransferDataFrom(Illness illness)
    {
        this.IdIllness = illness.IdIllness;
        this.IlledPerson = illness.IlledPerson;
        this.Diagnoses = illness.Diagnoses;
        this.StartDate = illness.StartDate;
        this.EndDate = illness.EndDate;
    }
}
