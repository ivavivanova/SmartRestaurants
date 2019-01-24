using Administration.Models;
using System.Collections.Generic;

namespace Administration.ViewModels
{
    public class ReservationsViewModel
    {
        public ReservationsViewModel()
        {
            ReadyReservations = new List<Reservation>();
            ReservationsForProcessing = new List<Reservation>();
        }

        public List<Reservation> ReadyReservations { get; set; }

        public List<Reservation> ReservationsForProcessing { get; set; }
    }
}