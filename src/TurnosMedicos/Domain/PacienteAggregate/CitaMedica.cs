using Domain.Shared;

namespace Domain.PacienteAggregate
{

    public class CitaMedica : Entity
    {
        private DateTime _fechaHora;
        private Guid _pacienteId;
        private Guid _agendaId;
        private EstadoCita _estado;
        private CitaMedica(Guid pacienteId, Guid agendaId, DateTime fechaHora) : base(Guid.NewGuid())
        {
            _pacienteId = pacienteId;
            _agendaId = agendaId;
            _fechaHora = fechaHora;
            _estado = EstadoCita.Agendada;
        }
        internal static CitaMedica New(Guid pacienteId, Guid agendaId, DateTime fechaHora)
        {
            return new CitaMedica(pacienteId, agendaId, fechaHora);
        }
        internal CitaMedica Cancelar()
        {
            _estado = EstadoCita.Cancelada;
            return this;
        }
        internal Guid PacienteId() => _pacienteId;
  
    }
    public enum EstadoCita
    {
        Agendada,
        Cancelada
    }
}
