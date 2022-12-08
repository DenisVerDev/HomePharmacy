using System;
using System.Collections.Generic;

namespace HomePharmacy.Models;

public partial class Appointment
{
    public int IdIllness { get; set; }

    public string Recommendator { get; set; } = null!;

    public DateTime AppointmentDate { get; set; }

    public string Medicines { get; set; } = null!;

    public string MedicinesUsageSchedule { get; set; } = null!;

    public virtual Illness IdIllnessNavigation { get; set; } = null!;

    public void TransferDataFrom(Appointment appointment)
    {
        this.IdIllness = appointment.IdIllness;
        this.Recommendator = appointment.Recommendator;
        this.AppointmentDate = appointment.AppointmentDate;
        this.Medicines = appointment.Medicines;
        this.MedicinesUsageSchedule = appointment.MedicinesUsageSchedule;
    }
}
