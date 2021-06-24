namespace Accounting.Domain
{
    public class RootAccount : Account
    {
        public RootAccount(string name, string number, string description, int displayPosition) : base(name, number, description, displayPosition) { }
    }
}
