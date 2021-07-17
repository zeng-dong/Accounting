using Accounting.Domain;
using System.Collections.Generic;

namespace Accounting.DataAccess
{
    public class RawData
    {
        readonly static string Data = @"100000000000000,1,,,, Assets,1,1,1,1,0
110000000000000,1,1,,, Current Assets                ,2,1,1,0,0
110100000000000,10,1,10,,Cash On Hand                  ,3,1,1,0,0
110100100000000,10,1,10,10,Bank #1                       ,4,0,1,0,0
110100200000000,20,1,10,20,Bank #2                       ,4,0,1,0,0
110100300000000,30,1,10,30,Bank #3                       ,4,0,1,0,0
110100400000000,40,1,10,40,Petty Cash,4,0,1,0,0
111000000000000,100,1,100,, Accounts Receivable           ,3,0,1,0,0
111500000000000,150,1,150,,Inventory                     ,3,0,1,0,0";




        public static List<Account> Create()
        {
            var accounts = new List<Account>();
            var lines = Data.Split('\n');

            var accountLines = new List<AccountLine>();

            // first pass
            foreach (var line in lines)
            {
                var cols = line.Split(',');
                var accountLine = new AccountLine
                {
                    AccountNumber = cols[0].Trim(),
                    IndividualAccountNumber = cols[1].Trim(),
                    Description = cols[5].Trim(),
                    Level = cols[6].Trim(),
                    Heading = cols[7].Trim()
                };

                accountLines.Add(accountLine);

                //var account = new Account(cols[5], cols[1], cols[5], 1);
            }

            return accounts;
        }
    }

    public class AccountLine
    {
        public string Description { get; set; }
        public string AccountNumber { get; set; }
        public string IndividualAccountNumber { get; set; }
        public string Level { get; set; }
        public string Heading { get; set; }
    }
}
