using Accounting.DataAccess;
using Accounting.Domain;

namespace Accounting.Api
{
    public sealed class AccountsController
    {
        private readonly AccountingDbContext _context;

        public AccountsController(AccountingDbContext context)
        {
            _context = context;
        }

        public string InsertThreeDifferentGroupsOfAccounts()
        {
            var root = new RootAccount();
            var heading = new HeadingAccount();
            var posting = new PostingAccount();

            _context.Add(root);
            _context.Add(heading);
            _context.Add(posting);

            _context.SaveChanges();

            return root.Id + ", " + heading.Id + ", " + posting.Id;

            /*
                 info: Microsoft.EntityFrameworkCore.Infrastructure[10403]
      Entity Framework Core 3.1.16 initialized 'AccountingDbContext' using provider 'Microsoft.EntityFrameworkCore.SqlServer' with options: using lazy-loading proxies SensitiveDataLoggingEnabled
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (33ms) [Parameters=[@p0='8ba2b432-2fed-4704-23bb-08d93749ca44', @p1='1'], CommandType='Text', CommandTimeout='30']
      SET NOCOUNT ON;
      INSERT INTO [Accounts] ([Id], [Grouping])
      VALUES (@p0, @p1);
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (1ms) [Parameters=[@p0='961fbad9-9505-4616-23bc-08d93749ca44', @p1='2'], CommandType='Text', CommandTimeout='30']
      SET NOCOUNT ON;
      INSERT INTO [Accounts] ([Id], [Grouping])
      VALUES (@p0, @p1);
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (0ms) [Parameters=[@p0='bbecb770-4818-46b8-23bd-08d93749ca44', @p1='3'], CommandType='Text', CommandTimeout='30']
      SET NOCOUNT ON;
      INSERT INTO [Accounts] ([Id], [Grouping])
      VALUES (@p0, @p1);
8ba2b432-2fed-4704-23bb-08d93749ca44, 961fbad9-9505-4616-23bc-08d93749ca44, bbecb770-4818-46b8-23bd-08d93749ca44                


            and here is the table:
            Id  Grouping
            8BA2B432-2FED-4704-23BB-08D93749CA44    1
            961FBAD9-9505-4616-23BC-08D93749CA44    2
            BBECB770-4818-46B8-23BD-08D93749CA44    3

             */
        }
    }
}
