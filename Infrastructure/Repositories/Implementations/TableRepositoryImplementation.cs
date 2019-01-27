using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repositories.Implementations
{
    public class TableRepositoryImplementation
    {
        public static List<Table> GetFreeTables(
            IEnumerable<Table> tables,
            IEnumerable<ReservationTable> reservationTables,
            DateTime reservationDateTime)
        {
            return tables
                .Where(t => t.StatusId == 1 && (
                    !reservationTables
                        .Where(r => r.TableId == t.Id).Any() ||
                    reservationTables
                        .Where(r => r.TableId == t.Id &&
                            r.Reservation.ReservationDate.Date.Add(r.Reservation.ReservationTime.TimeOfDay) >
                                reservationDateTime.AddHours(1)).Any()))
                 .ToList();
        }
    }
}
