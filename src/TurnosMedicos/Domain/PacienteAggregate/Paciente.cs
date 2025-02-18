using Domain.Shared;

namespace Domain.PacienteAggregate
{
    public class Paciente :  AggregateRoot<CitaMedica>
    {
        private readonly string _nombre;
        private readonly string _apellido;
        private readonly string _email;
        private readonly string _telefono;
        private Paciente(string nombre, string apellido, string email, string telefono)
            :base(Guid.NewGuid(), [])
        {
            _nombre = nombre;
            _apellido = apellido;
            _email = email;
            _telefono = telefono;
        }

        internal static Paciente RegistrarPaciente(string nombre, string apellido, string email, string telefono)
        {
            return new Paciente(nombre, apellido, email, telefono);
        }
        internal void AgendarCitaMedica(Guid agendaId, DateTime fechaHora)
        {

            Add(CitaMedica.New(Id, agendaId, fechaHora));
        }
        internal void CancelarCitaMedica(Guid citaMedicaId)
        {
            var citaMedica = Entities.FirstOrDefault(c => c.Id == citaMedicaId);
            if (citaMedica == null)
            {
                return;
            }
            citaMedica.Cancelar();
        }
    }
}
