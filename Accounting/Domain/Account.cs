namespace Accounting.Domain
{
    public abstract class Account : BaseEntity
    {
        public string Name { get; }
        public string Number { get; }
        public string Description { get; }

        public int DisplayPosition { get; }

        public AccountGrouping AccountGroup { get; }
    }
}
