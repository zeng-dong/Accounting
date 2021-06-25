namespace Accounting.Domain
{
    public class PostingAccount : Account
    {

        //public Guid ParentHeadingAccountId { get; private set; }
        public virtual HeadingAccount ParentHeadingAccount { get; private set; }
    }
}
