using Accounting.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Accounting.DataAccess
{
    public class AccountingDbContext : DbContext
    {
        public static readonly ILoggerFactory MyLoggerFactory = LoggerFactory.Create(
            builder =>
            {
                builder.AddConsole();
            });

        // this will cause Unable to create an object of type 'AccountingDbContext'. For the different patterns supported at design time, see https://go.microsoft.com/fwlink/?linkid=851728
        //public AccountingDbContext(DbContextOptions<AccountingDbContext> options) : base(options)
        //{
        //}


        public virtual DbSet<Chart> Charts { get; set; }
        public virtual DbSet<HeadingAccount> HeadingAccounts { get; set; }
        public virtual DbSet<PostingAccount> PostingAccounts { get; set; }
        public virtual DbSet<RootAccount> RootAccounts { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();

            optionsBuilder
                .UseLoggerFactory(MyLoggerFactory)
                .EnableSensitiveDataLogging(true)
                .UseSqlServer("Server=DESKTOP-QB0EFH1;Database=Accounting;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Chart>().Property(e => e.Id);

            //builder.Entity<Account>().Property(e => e.Id).ValueGeneratedNever();
            builder.Entity<Account>().Property(e => e.Id);
            //modelBuilder.Entity<YourEntity>().Property(x => x.Id).HasDefaultValueSql("NEWID()");

            builder.Entity<Account>()
                 .ToTable("Accounts")
                 .HasDiscriminator<PostingType>("PostingType")
                 .HasValue<PostingAccount>(PostingType.Posting)
                 .HasValue<HeadingAccount>(PostingType.Heading)
                 .HasValue<RootAccount>(PostingType.Root);

            //builder.Entity<PostingAccount>()
            //  .HasOne(p => p.ParentHeadingAccount)
            //.WithMany(h => h.PostingAccounts)
            //.HasForeignKey(p => p.ParentHeadingAccountId)
            //.OnDelete(DeleteBehavior.NoAction);

            //builder.Entity<HeadingAccount>()
            //  .HasOne(p => p.ParentHeadingAccount)
            //.WithMany(h => h.HeadingAccounts)
            //.HasForeignKey(h => h.ParentHeadingAccountId)
            //.OnDelete(DeleteBehavior.NoAction);

            //builder
            //    .Entity<PostingAccount>()
            //    .Property(e => e.AccountType)
            //    .HasConversion(MakeEnumeratorConverter<AccountType>());
        }
    }
}
