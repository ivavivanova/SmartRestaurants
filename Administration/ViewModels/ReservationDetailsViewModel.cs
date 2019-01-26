using Infrastructure.Entities;
using System;
using System.Collections.Generic;

namespace Administration.ViewModels
{
    public class ReservationDetailsViewModel
    {
        public ReservationDetailsViewModel()
        {
            this.TablesForReservation = new List<Table>();
            this.FreeTables = new List<Table>();
            this.CheckedFreeTables = new int[0];
            this.CheckedTablesForReservation = new int[0];
        }

        public int ReservationId { get; set; }

        public string CustomerEmail { get; set; }

        public int ChairsNeeded { get; set; }

        public DateTime ReservationDateTime { get; set; }

        public string RegistrationDate { get; set; }

        public List<Table> TablesForReservation { get; set; }

        public int[] CheckedTablesForReservation { get; set; }

        public List<Table> FreeTables { get; set; }

        public int[] CheckedFreeTables { get; set; }

        public string PhoneNumber { get; set; }

        public static ReservationDetailsViewModel MapFromEntities(
            Reservation entity,
            List<Table> tablesForReservation,
            List<Table> freeTables)
        {
            return new ReservationDetailsViewModel()
            {
                ReservationId = entity.Id,
                CustomerEmail = entity.CustomerEmail,
                ChairsNeeded = entity.ChairsNeeded,
                RegistrationDate = entity.RegistrationDate.ToString("dd.MM.yyyy г. HH:mm"),
                ReservationDateTime = entity.ReservationDate.Date + entity.ReservationTime.TimeOfDay,
                TablesForReservation = tablesForReservation,
                FreeTables = freeTables,
                PhoneNumber = entity.CustomerPhoneNumber
            };
        }
    }
}