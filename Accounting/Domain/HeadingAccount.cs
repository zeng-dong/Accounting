using System.Collections.Generic;
using System.Linq;

namespace Accounting.Domain
{
    public class HeadingAccount : Account
    {

        private ICollection<HeadingAccount> _headingAccounts;
        public virtual IEnumerable<HeadingAccount> HeadingAccounts => _headingAccounts.ToList();

        private ICollection<PostingAccount> _postingAccounts;
        public virtual IEnumerable<PostingAccount> PostingAccounts => _postingAccounts.ToList();

        //public Guid ParentHeadingAccountId { get; private set; }
        //public virtual HeadingAccount ParentHeadingAccount { get; private set; }
    }
}
