using System;

namespace Accounting.Domain
{
    public abstract class BaseEntity
    {
        public Guid Id { get; }

        protected BaseEntity()
        {
        }

        protected BaseEntity(Guid id)
            : this()
        {
            Id = id;
        }


        protected object Actual => this;

        public override bool Equals(object obj)
        {
            if (!(obj is BaseEntity other))
                return false;

            if (ReferenceEquals(this, other))
                return true;

            if (GetRealType() != other.GetRealType())
                return false;


            if (Id == Guid.Empty || other.Id == Guid.Empty)
                return false;

            return Id == other.Id;
        }

        public static bool operator ==(BaseEntity a, BaseEntity b)
        {
            if (a is null && b is null)
                return true;

            if (a is null || b is null)
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(BaseEntity a, BaseEntity b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return (GetRealType().ToString() + Id).GetHashCode();
        }

        public Object Clone()
        {
            return this.MemberwiseClone();
        }

        private Type GetRealType()
        {
            Type type = GetType();

            if (type.ToString().Contains("Castle.Proxies."))
                return type.BaseType;

            return type;
        }
    }
}
