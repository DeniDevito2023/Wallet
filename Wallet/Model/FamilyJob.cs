using System;
using System.Collections.Generic;

namespace Wallet.Model;

public partial class FamilyJob
{
    public int Id { get; set; }

    public int? IdFns { get; set; }

    public string? Doljnost { get; set; }

    public string? Organisation { get; set; }

    public int? Oclad { get; set; }

    public DateOnly? DataDoljnost { get; set; }

    public virtual FamilyMember? IdFnsNavigation { get; set; }
}
