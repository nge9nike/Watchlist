﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Watchlist.Models;

public partial class Category
{
    public int IdCategory { get; set; }

    public string Name { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();

    public virtual ICollection<Series> Series { get; set; } = new List<Series>();
}