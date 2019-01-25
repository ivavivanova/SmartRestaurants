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

        public string Status { get; set; }

        public static Reservation MapFromEntity(Infrastructure.Entities.Reservation entity)
        {
            return new Reservation
            {
                ReservationId = entity.Id,
                CustomerEmail = entity.CustomerEmail,
                ChairsNeeded = entity.ChairsNeeded,
                RegistrationDate = entity.RegistrationDate,
                ReservationDateTime = entity.ReservationDate.Date + entity.ReservationTime.TimeOfDay,
                Status = entity.ReservationStatus.Name
            };
        }
    }
}