using System;
using System.Collections.Generic;

namespace HomePharmacy.Models;

public partial class Person
{
    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Sex { get; set; } = null!;

    public DateTime? BirthDate { get; set; }

    public byte[]? Photo { get; set; }

    public virtual ICollection<Illness> Illnesses { get; } = new List<Illness>();

    public virtual ICollection<Medicine> Medicines { get; } = new List<Medicine>();

    public virtual ICollection<Family> IdFamilies { get; } = new List<Family>();
}
