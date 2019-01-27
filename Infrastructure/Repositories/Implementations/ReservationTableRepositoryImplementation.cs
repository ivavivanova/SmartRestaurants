using Infrastructure.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repositories.Implementations
{
    public class ReservationTableRepositoryImplementation
    {
        public static List<Table> GetTablesByReservationId(
            RepositoryBase<ReservationTable> reservationTableRepository,
            int reservationId)
        {
            return reservationTableRepository
                  .GetAll()
                  .Where(r => r.ReservationId == reservationId)
                  .Select(r => r.Table)
                  .ToList();
        }

        public static IEnumerable<ReservationTable> GetByReservationId(
            RepositoryBase<ReservationTable> reservationTableRepository,
            int reservationId)
        {
            return reservationTableRepository
                .GetAll()
                .Where(r => r.ReservationId == reservationId);
        }
    }
}
