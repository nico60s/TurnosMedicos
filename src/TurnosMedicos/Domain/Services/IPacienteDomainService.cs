

using Domain.PacienteAggregate;

namespace Domain.Services
{
    public interface IPacienteDomainService
    {
        Paciente Registrar(string nombre, string apellido, string email, string telefono);
        void AgendarCita(Paciente paciente, Guid agendaId, DateTime fechaHora);
        void CancelarCita(Paciente paciente, Guid citaId);
    }
}
