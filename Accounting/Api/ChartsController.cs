using Accounting.DataAccess;
using Accounting.Domain;
using System;
using System.Linq;

namespace Accounting.Api
{
    public sealed class ChartsController
    {
        private readonly AccountingDbContext _context;

        public ChartsController(AccountingDbContext context)
        {
            _context = context;
        }

        public string CreateNewChart()
        {

            var chart = new Chart(Guid.NewGuid());

            _context.Add(chart);

            _context.SaveChanges();

            return chart.Id + ", " + chart.Accounts.Count();

            /*
             info: Microsoft.EntityFrameworkCore.Infrastructure[10403]
      Entity Framework Core 3.1.16 initialized 'AccountingDbContext' using provider 'Microsoft.EntityFrameworkCore.SqlServer' with options: using lazy-loading proxies SensitiveDataLoggingEnabled
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (31ms) [Parameters=[@p0='c2861948-efde-477c-f8b1-08d93773f6f0', @p1='f7bfd42b-7e0c-4043-9685-f5fe580c2a30'], CommandType='Text', CommandTimeout='30']
      SET NOCOUNT ON;
      INSERT INTO [Charts] ([Id], [TenantId])
      VALUES (@p0, @p1);
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (7ms) [Parameters=[@p2='925c27f2-758f-4307-5daa-08d93773f6f7', @p3='1' (Size = 4000), @p4='1', @p5='Assets' (Size = 4000), @p6='Assets' (Size = 4000), @p7='3', @p8='c2861948-efde-477c-f8b1-08d93773f6f0' (Nullable = true), @p9='5fe706ef-8c16-432f-5dab-08d93773f6f7', @p10='2' (Size = 4000), @p11='2', @p12='Liabilities' (Size = 4000), @p13='Liabilities' (Size = 4000), @p14='3', @p15='c2861948-efde-477c-f8b1-08d93773f6f0' (Nullable = true), @p16='767ed3ea-a640-45e3-5dac-08d93773f6f7', @p17='3' (Size = 4000), @p18='3', @p19='Equity' (Size = 4000), @p20='Equity' (Size = 4000), @p21='3', @p22='c2861948-efde-477c-f8b1-08d93773f6f0' (Nullable = true), @p23='61324928-e74a-400c-5dad-08d93773f6f7', @p24='4' (Size = 4000), @p25='4', @p26='Income' (Size = 4000), @p27='Income' (Size = 4000), @p28='3', @p29='c2861948-efde-477c-f8b1-08d93773f6f0' (Nullable = true), @p30='4b6cf243-3bac-4bd2-5dae-08d93773f6f7', @p31='5' (Size = 4000), @p32='5', @p33='Cost of Goods Sold' (Size = 4000), @p34='Cost of Goods Sold' (Size = 4000), @p35='3', @p36='c2861948-efde-477c-f8b1-08d93773f6f0' (Nullable = true), @p37='923d5648-538c-4dc6-5daf-08d93773f6f7', @p38='6' (Size = 4000), @p39='6', @p40='Expenses' (Size = 4000), @p41='Expenses' (Size = 4000), @p42='3', @p43='c2861948-efde-477c-f8b1-08d93773f6f0' (Nullable = true), @p44='f9c160f1-742d-41d7-5db0-08d93773f6f7', @p45='7' (Size = 4000), @p46='7', @p47='TBD' (Size = 4000), @p48='TBD' (Size = 4000), @p49='3', @p50='c2861948-efde-477c-f8b1-08d93773f6f0' (Nullable = true), @p51='9aa6d655-18dd-495d-5db1-08d93773f6f7', @p52='8' (Size = 4000), @p53='8', @p54='Other Income/Expenses' (Size = 4000), @p55='Other Income/Expenses' (Size = 4000), @p56='3', @p57='c2861948-efde-477c-f8b1-08d93773f6f0' (Nullable = true), @p58='38394056-62e7-466a-5db2-08d93773f6f7', @p59='9' (Size = 4000), @p60='9', @p61='Wrong Postings' (Size = 4000), @p62='Wrong Postings' (Size = 4000), @p63='3', @p64='c2861948-efde-477c-f8b1-08d93773f6f0' (Nullable = true)], CommandType='Text', CommandTimeout='30']
      SET NOCOUNT ON;
      INSERT INTO [Accounts] ([Id], [Description], [DisplayPosition], [Name], [Number], [PostingType], [ChartId])
      VALUES (@p2, @p3, @p4, @p5, @p6, @p7, @p8),
      (@p9, @p10, @p11, @p12, @p13, @p14, @p15),
      (@p16, @p17, @p18, @p19, @p20, @p21, @p22),
      (@p23, @p24, @p25, @p26, @p27, @p28, @p29),
      (@p30, @p31, @p32, @p33, @p34, @p35, @p36),
      (@p37, @p38, @p39, @p40, @p41, @p42, @p43),
      (@p44, @p45, @p46, @p47, @p48, @p49, @p50),
      (@p51, @p52, @p53, @p54, @p55, @p56, @p57),
      (@p58, @p59, @p60, @p61, @p62, @p63, @p64);
             */
        }
    }
}
