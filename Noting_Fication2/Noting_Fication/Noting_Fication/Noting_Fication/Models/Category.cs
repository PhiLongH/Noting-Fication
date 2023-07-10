using System;
using System.Collections.Generic;

namespace Noting_Fication.Models;

public partial class Category
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public virtual ICollection<Note> Notes { get; set; } = new List<Note>();
}
