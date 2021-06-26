namespace Accounting.Domain
{
    public class TransactionType : Enumeration
    {
        readonly RootHeadingAccountType _rootHeading;
        public RootHeadingAccountType RootHeading => _rootHeading;

        public TransactionType() { }

        public static readonly TransactionType Inventory
            = new TransactionType(1, "Inventory", RootHeadingAccountType.Assets);
        public static readonly TransactionType AccountReceivable
            = new TransactionType(2, "A/R", RootHeadingAccountType.Assets);
        public static readonly TransactionType AccountsPayable
            = new TransactionType(3, "A/P", RootHeadingAccountType.Liabilities);
        public static readonly TransactionType AccountsPayableSuspense
            = new TransactionType(4, "A/P Suspense", RootHeadingAccountType.Liabilities);
        public static readonly TransactionType Sales
            = new TransactionType(5, "Sales", RootHeadingAccountType.Income);
        public static readonly TransactionType SalesReturn
            = new TransactionType(6, "Sales Return", RootHeadingAccountType.Income);
        public static readonly TransactionType CostOfGoodsSold
            = new TransactionType(7, "COGS", RootHeadingAccountType.CostOfGoodsSold);
        public static readonly TransactionType PhysicalInventoryAdjustment
            = new TransactionType(8, "Physical Inventory (Adjustment)", RootHeadingAccountType.CostOfGoodsSold);
        public static readonly TransactionType AccountReceivableDiscount
            = new TransactionType(9, "A/R Discount", RootHeadingAccountType.Income);
        public static readonly TransactionType AccountsPayableDiscount
            = new TransactionType(10, "A/P Discount", RootHeadingAccountType.CostOfGoodsSold);
        public static readonly TransactionType RetainedEarnings
            = new TransactionType(11, "Retained Earnings", RootHeadingAccountType.Equity);
        public static readonly TransactionType SalesTax
            = new TransactionType(12, "Sales Tax", RootHeadingAccountType.Liabilities);
        public static readonly TransactionType ForeignExchangeProfitAndLoss
            = new TransactionType(13, "Foreign Exchange P&L", RootHeadingAccountType.OtherIncomeExpenses);
        public static readonly TransactionType WrongPostings
            = new TransactionType(14, "Wrong postings", RootHeadingAccountType.WrongPostings);

        public TransactionType(int value, string displayName, RootHeadingAccountType rootHeading) : base(value, displayName)
        {
            _rootHeading = rootHeading;
        }
    }
}
