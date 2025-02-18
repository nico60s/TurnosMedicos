

namespace Domain.Shared
{
    public abstract class AggregateRoot<TEntity> where TEntity : Entity
    {
        public Guid Id { get; private set; }

        private readonly List<TEntity> _entities;

        protected AggregateRoot(Guid id, List<TEntity> entities)
        {
            if (id == Guid.Empty)
                throw new ArgumentException("El ID no puede ser vacío.", nameof(id));

            Id = id;
            _entities = entities; 
        }

        public IReadOnlyList<TEntity> Entities => _entities.AsReadOnly();

        protected void Add(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity), "La entidad no puede ser nula.");

            _entities.Add(entity);
        }

        protected void Remove(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity), "La entidad no puede ser nula.");

            _entities.Remove(entity);
        }
    }

}
