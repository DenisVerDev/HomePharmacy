using System;
using System.Collections.Generic;

namespace HomePharmacy.Models;

public partial class Appointment
{
    public int IdIllness { get; set; }

    public string MedicineList { get; set; } = null!;

    public string Recommendator { get; set; } = null!;

    public string? AppointmentVolume { get; set; }

    public string? AdditionalInfo { get; set; }

    public virtual Illness IdIllnessNavigation { get; set; } = null!;

    public void TransferDataFrom(Appointment appointment)
    {
        this.IdIllness = appointment.IdIllness;
        this.MedicineList = appointment.MedicineList;
        this.Recommendator = appointment.Recommendator;
        this.AppointmentVolume = appointment.AppointmentVolume;
        this.AdditionalInfo = appointment.AdditionalInfo;
    }
}
