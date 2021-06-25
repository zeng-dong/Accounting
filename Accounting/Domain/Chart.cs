using System;
using System.Collections.Generic;
using System.Linq;

namespace Accounting.Domain
{
    public class Chart : BaseEntity
    {
        protected Chart() { }
        public Chart(Guid tenantId)
        {
            TenantId = tenantId;

            Init();
        }

        public Guid TenantId { get; private set; }

        private ICollection<RootAccount> _accounts;
        public virtual IEnumerable<RootAccount> Accounts => _accounts.ToList();

        private void Init()
        {
            _accounts = new List<RootAccount>();

            var headingTypes = Enumeration.GetAll<RootHeadingAccountType>().OrderBy(x => x.Value);
            foreach (var headingType in headingTypes)
            {
                _accounts.Add(new RootAccount(headingType.DisplayName, headingType.DisplayName, headingType.Value.ToString(), headingType.Value));
            }
        }
    }
}
