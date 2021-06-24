using System;

namespace Accounting.Domain
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        protected object Actual => this;

        public override bool Equals(object obj)
        {
            var other = obj as BaseEntity;

            if (other is null)
                return false;

            if (ReferenceEquals(this, other))
                return true;

            if (Actual.GetType() != other.Actual.GetType())
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
            return Id.GetHashCode();
        }

        public Object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
