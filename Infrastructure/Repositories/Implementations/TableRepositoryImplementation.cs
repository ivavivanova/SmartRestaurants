using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Implementations
{
    public class TableRepositoryImplementation
    {
        public TableRepositoryImplementation(RepositoryBase<Table> tableRepository)
        {
            TableRepository = tableRepository;
        }

        private RepositoryBase<Table> TableRepository { get; set; }

        public List<Table> GetFreeTables(IEnumerable<ReservationTable> reservationTables, Reservation reservation)
        {
            return this.TableRepository
                .GetAll()
                .Where(t => t.StatusId == 1 && (
                    !reservationTables
                        .Where(r => r.TableId == t.Id).Any() ||
                    reservationTables
                        .Where(r => r.TableId == t.Id &&
                            r.Reservation.ReservationDate.Date.Add(r.Reservation.ReservationTime.TimeOfDay) >
                                reservation.ReservationDate.Date.Add(reservation.ReservationTime.TimeOfDay).AddHours(1)).Any()))
                 .ToList();
        }
    }
}
