

namespace Domain.Shared
{
    public abstract class Entity
    {
        public Guid Id { get; }
        protected Entity(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentException("Id cannot be empty", nameof(id));
            }
            Id = id;
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Entity other))
            {
                return false;
            }
            if (ReferenceEquals(this, other))
            {
                return true;
            }
            if (GetType() != other.GetType())
            {
                return false;
            }
            if (Id == Guid.Empty || other.Id == Guid.Empty)
            {
                return false;
            }
            return Id == other.Id;
        }
        public override int GetHashCode() { return Id.GetHashCode(); }
    }
}
