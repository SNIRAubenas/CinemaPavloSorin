using System;
using System.Collections.Generic;

namespace TPBDD_Cinema.Models;

public partial class Film
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public int Year { get; set; }

    public TimeOnly Lenght { get; set; }

    public string Summary { get; set; } = null!;

    public byte[] Poster { get; set; } = null!;

    public virtual ICollection<Filmactor> Filmactors { get; set; } = new List<Filmactor>();

    public virtual ICollection<Filmdirector> Filmdirectors { get; set; } = new List<Filmdirector>();
}
