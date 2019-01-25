using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Implementations
{
    public class ReservationRepositoryImplementation
    {
        public ReservationRepositoryImplementation(RepositoryBase<Reservation> reservationRepository)
        {
            ReservationRepository = reservationRepository;
        }

        private RepositoryBase<Reservation> ReservationRepository { get; set; }
    }
}
