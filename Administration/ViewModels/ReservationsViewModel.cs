using Administration.Models;
using Infrastructure.Enums;
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
            ReadyReservations = reservations
                .Where(r => r.StatusId == ReservationStatus.StatusNewId || r.StatusId == ReservationStatus.StatusConfirmedId)
                .Select(r => Reservation.MapFromEntity(r)).ToList();
            ReservationsForProcessing = reservations
                .Where(r => r.StatusId == ReservationStatus.StatusWaitingProcessingId)
                .Select(r => Reservation.MapFromEntity(r)).ToList();
        }

        public List<Reservation> ReadyReservations { get; set; }

        public List<Reservation> ReservationsForProcessing { get; set; }
    }
}