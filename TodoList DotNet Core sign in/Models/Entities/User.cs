using System;
using System.Collections.Generic;

namespace TodoList.Models.Entities;

public partial class User
{
    public int Id { get; set; }

    public int Username { get; set; }

    public int Password { get; set; }
}
