namespace Accounting.Domain
{
    public abstract class Account : BaseEntity
    {
        public string Name { get; private set; }
        public string Number { get; private set; }
        public string Description { get; private set; }
        public int DisplayPosition { get; private set; }

        public PostingType PostingType { get; private set; }

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

        public virtual Account ParentAccount { get; private set; }

        public override string ToString()
        {
            return $"PostingType: {PostingType} : Id = {Id}, Name = {Name}, Description = {Description}, DisplayPosition = {DisplayPosition}";
        }
    }
}
