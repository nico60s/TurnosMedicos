using Domain.Shared;

namespace Domain.MedicoAggregate
{
    /// <summary>
    /// Agenda diaria de un médico. 
    /// </summary>
    public class Agenda: Entity
    {
        internal Agenda(Guid medicaId, 
                      DateTime fecha, 
                      string horaInicio, 
                      string horaFin) : base(Guid.NewGuid())
        {
            MedicoId = medicaId;
            FechaInicio = fecha.AddHours(int.Parse(horaInicio.Split(":")[0]))
                               .AddMinutes(int.Parse(horaInicio.Split(":")[1]));
            FechaFin = fecha.AddHours(int.Parse(horaFin.Split(":")[0]))
                            .AddMinutes(int.Parse(horaFin.Split(":")[1]));
        }

        internal Guid MedicoId { get; init; }
        internal DateTime FechaInicio { get; init; }
        internal DateTime FechaFin { get; init; }
    }

}
