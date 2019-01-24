using System;

namespace Administration.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }

        public string CustomerEmail { get; set; }

        public int ChairsNeeded { get; set; }

        public DateTime ReservationDateTime { get; set; }

        public DateTime RegistrationDate { get; set; }
    }
}