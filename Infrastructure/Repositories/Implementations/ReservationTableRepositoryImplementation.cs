using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Implementations
{
    public class ReservationTableRepositoryImplementation
    {
        public ReservationTableRepositoryImplementation(RepositoryBase<ReservationTable> reservationTableRepository)
        {
            ReservationTableRepository = reservationTableRepository;
        }

        private RepositoryBase<ReservationTable> ReservationTableRepository { get; set; }

        public List<Table> GetTablesByReservationId(int reservationId)
        {
            return this.ReservationTableRepository
                  .GetAll()
                  .Where(r => r.ReservationId == reservationId)
                  .Select(r => r.Table)
                  .ToList();
        }

        public IEnumerable<ReservationTable> GetByReservationId(int reservationId)
        {
            return this.ReservationTableRepository
                .GetAll()
                .Where(r => r.ReservationId == reservationId);
        }
    }
}
