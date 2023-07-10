﻿using System;
using System.Collections.Generic;

namespace Noting_Fication.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual ICollection<Note> Notes { get; set; } = new List<Note>();
}
