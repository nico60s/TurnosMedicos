

using Domain.Shared;

namespace Domain.MedicoAggregate
{
   
    internal class Turno : Entity
    {
        private Guid _pacienteId;
        private EstadoTurno _estado;
        private DateTime _fecha;
        private Turno(Guid pacienteId, DateTime fecha) : base(Guid.NewGuid())
        {
            _pacienteId = pacienteId;
            _fecha = fecha;
            _estado = EstadoTurno.Pendiente;
        }
        internal static Turno New(Guid pacienteId, DateTime fecha)
        {
            return new Turno(pacienteId,fecha);
        }
        internal void Atender()
        {
            if(_estado != EstadoTurno.Pendiente)
            {
                throw new InvalidOperationException("El turno no está pendiente.");
            }
            _estado = EstadoTurno.Atendido;
        }
        internal void Cancelar()
        {
            if (_estado != EstadoTurno.Pendiente)
            {
                throw new InvalidOperationException("El turno no está pendiente.");
            }
            _estado = EstadoTurno.Cancelado;
        }
    }
    public enum EstadoTurno
    {
        Pendiente,
        Atendido,
        Cancelado
    }
}
