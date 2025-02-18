using Domain.Shared;

namespace Domain.MedicoAggregate
{
    public class Medico : AggregateRoot<Agenda>
    {
        private string _nombre;
        private string _apellido;
        private string _especialidad;
        internal Medico(string nombre, string apellido, string especialidad) : base(Guid.NewGuid(), [])
        {
            _nombre = nombre;
            _apellido = apellido;
            _especialidad = especialidad;
        }

        
    }
}
