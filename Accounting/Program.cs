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

            //string result = Execute(x => x.InsertThreeDifferentGroupsOfAccounts());
            //Console.WriteLine(result);
            //Execute(x => x.ViewThreeDifferentGroupsOfAccounts());

            Execute(x => x.CreateNewChart());
        }


        private static string Execute(Func<AccountsController, string> func)
        {
            using (var context = new AccountingDbContext())
            {
                var controller = new AccountsController(context);
                return func(controller);
            }
        }

        private static string Execute(Func<ChartsController, string> func)
        {
            using (var context = new AccountingDbContext())
            {
                var controller = new ChartsController(context);
                return func(controller);
            }
        }
    }
}
