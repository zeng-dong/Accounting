using Accounting.Api;
using Accounting.DataAccess;
using System;

namespace Accounting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string result = Execute(x => x.InsertThreeDifferentGroupsOfAccounts());

            Console.WriteLine(result);
        }


        private static string Execute(Func<AccountsController, string> func)
        {
            using (var context = new AccountingDbContext())
            {
                var controller = new AccountsController(context);
                return func(controller);
            }
        }
    }
}
