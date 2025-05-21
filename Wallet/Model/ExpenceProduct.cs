using System;
using System.Collections.Generic;

namespace Wallet.Model;

public partial class ExpenceProduct
{
    public int IdProduct { get; set; }

    public DateOnly? DateSales { get; set; }

    public int? SalesFns { get; set; }

    public int? SalesProduct { get; set; }

    public int? Amount { get; set; }

    public virtual FamilyMember? SalesFnsNavigation { get; set; }

    public virtual Product? SalesProductNavigation { get; set; }
}
