

namespace Application.Medicos.GetAppoinmentsForToday
{
    public record GetAppoinmentsForTodayCommand
    {
        public required Guid MedicoId { get; init; }

    }
}
