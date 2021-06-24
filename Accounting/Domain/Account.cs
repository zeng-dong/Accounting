namespace Accounting.Domain
{
    public abstract class Account : BaseEntity
    {
        public string Name { get; private set; }
        public string Number { get; private set; }
        public string Description { get; private set; }
        public int DisplayPosition { get; private set; }

        public AccountGrouping Group { get; private set; }

        protected Account()
        {
        }

        protected Account(string name, string number, string description, int displayPosition)
            : this()
        {
            Name = name;
            Number = number;
            Description = description;
            DisplayPosition = displayPosition;
        }
    }
}
