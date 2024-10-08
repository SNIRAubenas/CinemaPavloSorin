using System;
using System.Collections.Generic;

namespace TPBDD_Cinema.Models;

public partial class Director
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Filmdirector> Filmdirectors { get; set; } = new List<Filmdirector>();
}
