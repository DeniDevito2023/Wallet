using System;
using System.Collections.Generic;

namespace Wallet.Model;

public partial class Product
{
    public int Id { get; set; }

    public string? NameProduct { get; set; }

    public string? Category { get; set; }

    public int? Price { get; set; }

    public virtual ICollection<ExpenceProduct> ExpenceProducts { get; set; } = new List<ExpenceProduct>();
}
