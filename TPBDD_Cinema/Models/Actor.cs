using System;
using System.Collections.Generic;

namespace TPBDD_Cinema.Models;

public partial class Actor
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Filmactor> Filmactors { get; set; } = new List<Filmactor>();
}
