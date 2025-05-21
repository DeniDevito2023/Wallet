using System;
using System.Collections.Generic;

namespace Wallet.Model;

public partial class FamilyMember
{
    public int Id { get; set; }

    public string? Fns { get; set; }

    public DateOnly DateBirthday { get; set; }

    public virtual ICollection<ExpenceProduct> ExpenceProducts { get; set; } = new List<ExpenceProduct>();

    public virtual ICollection<FamilyJob> FamilyJobs { get; set; } = new List<FamilyJob>();
}
