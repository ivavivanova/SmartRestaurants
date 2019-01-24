using Administration.Models;
using System.Collections.Generic;
using System.Linq;

namespace Administration.ViewModels
{
    public class ReservationsViewModel
    {
        public ReservationsViewModel()
        {
            ReadyReservations = new List<Reservation>();
            ReservationsForProcessing = new List<Reservation>();
        }

        public ReservationsViewModel(IEnumerable<Infrastructure.Entities.Reservation> reservations)
        {
            ReadyReservations = reservations.Select(r => Reservation.MapFromEntity(r)).ToList();
            ReservationsForProcessing = reservations.Select(r => Reservation.MapFromEntity(r)).ToList();
        }

        public List<Reservation> ReadyReservations { get; set; }

        public List<Reservation> ReservationsForProcessing { get; set; }
    }
}