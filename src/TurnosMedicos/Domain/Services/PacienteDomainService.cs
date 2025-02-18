

using Domain.PacienteAggregate;

namespace Domain.Services
{
    public class PacienteDomainService : IPacienteDomainService
    {
        public void AgendarCita(Paciente paciente, Guid agendaId, DateTime fechaHora)
        {
            throw new NotImplementedException();
        }

        public void CancelarCita(Paciente paciente, Guid citaId)
        {
            throw new NotImplementedException();
        }

        public Paciente Registrar(string nombre, string apellido, string email, string telefono)
        {
            return Paciente.RegistrarPaciente(nombre, apellido, email, telefono);
        }
    }
}
