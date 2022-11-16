using System;
using System.Collections.Generic;

namespace HomePharmacy.Models;

public partial class Family
{
    public int IdFamily { get; set; }

    public virtual ICollection<Medicine> Medicines { get; } = new List<Medicine>();

    public virtual ICollection<Person> People { get; } = new List<Person>();
}
