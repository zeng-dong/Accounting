using System.Collections.Generic;
using System.Linq;

namespace Accounting.Domain
{
    public class RootHeadingAccountType : Enumeration
    {
        public RootHeadingAccountType()
        {
        }

        public static readonly RootHeadingAccountType Assets
            = new RootHeadingAccountType(1, "Assets");
        public static readonly RootHeadingAccountType Liabilities
            = new RootHeadingAccountType(2, "Liabilities");
        public static readonly RootHeadingAccountType Equity
            = new RootHeadingAccountType(3, "Equity");
        public static readonly RootHeadingAccountType Income
            = new RootHeadingAccountType(4, "Income");
        public static readonly RootHeadingAccountType CostOfGoodsSold
            = new RootHeadingAccountType(5, "Cost of Goods Sold");
        public static readonly RootHeadingAccountType Expenses
            = new RootHeadingAccountType(6, "Expenses");
        public static readonly RootHeadingAccountType TBD
            = new RootHeadingAccountType(7, "TBD");
        public static readonly RootHeadingAccountType OtherIncomeExpenses
            = new RootHeadingAccountType(8, "Other Income/Expenses");
        public static readonly RootHeadingAccountType WrongPostings
            = new RootHeadingAccountType(9, "Wrong Postings");

        RootHeadingAccountType(int value, string displayName) : base(value, displayName) { }

        public List<TransactionType> AssociatedTransactionTypes => GetAll<TransactionType>().Where(x => x.RootHeading.Equals(this)).ToList();

    }
}
