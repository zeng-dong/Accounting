namespace Accounting.Domain
{
    public class AccountType : Enumeration
    {
        public AccountType()
        {
        }

        public static readonly AccountType AccountsReceivable
            = new AccountType(1, "Account Receivable (A/R)");
        public static readonly AccountType OtherCurrentAssets
            = new AccountType(2, "Other Current Assets");
        public static readonly AccountType Bank
            = new AccountType(3, "Bank");
        public static readonly AccountType FixedAssets
            = new AccountType(4, "Fixed Assets");
        public static readonly AccountType OtherAssets
            = new AccountType(5, "Other Assets");
        public static readonly AccountType AccountsPayable
            = new AccountType(6, "Account Payable (A/P)");
        public static readonly AccountType CreditCard
            = new AccountType(7, "Credit Card");
        public static readonly AccountType OtherCurrentLiabilities
            = new AccountType(8, "Other Current Liabilities");
        public static readonly AccountType Equity
            = new AccountType(9, "Equity");
        public static readonly AccountType Income
            = new AccountType(10, "Income");
        public static readonly AccountType CostOfGoodsSold
            = new AccountType(11, "Cost of Goods Sold");
        public static readonly AccountType Expenses
            = new AccountType(12, "Expenses");
        public static readonly AccountType OtherExpense
            = new AccountType(13, "Other Expense");

        AccountType(int value, string displayName) : base(value, displayName) { }
    }
}
