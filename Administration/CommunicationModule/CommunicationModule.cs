using Infrastructure;
using Infrastructure.DataTypes;
using Infrastructure.Entities;
using Infrastructure.Enums;
using Infrastructure.Repositories.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Administration.CommunicationModule
{
    public class CommunicationModule
    {
        private static UnitOfWork unitOfWork = new UnitOfWork();
        private static TableRepositoryImplementation tableRepositoryImplementation
            = new TableRepositoryImplementation(unitOfWork.TableRepository);

        public static void SaveReservation(
            string userEmail,
            int chairsNeeded,
            DateTime date,
            DateTime time,
            string phoneNum)
        {
            var reservation = new Infrastructure.Entities.Reservation
            {
                ChairsNeeded = chairsNeeded,
                CustomerPhoneNumber = phoneNum,
                CustomerEmail = userEmail,
                RegistrationDate = DateTime.Now,
                ReservationDate = date.Date,
                ReservationTime = time
            };

            var table = tableRepositoryImplementation
                .GetFreeTables(unitOfWork.ReservationTableRepository.GetAll(), date.Date.Add(time.TimeOfDay))
                .FirstOrDefault(t => t.MaxChairs >= chairsNeeded && chairsNeeded + 2 >= t.MaxChairs);

            if(table != null)
            {
                reservation.StatusId = ReservationStatus.StatusNewId;
                unitOfWork.ReservationRepository.Insert(reservation);

                unitOfWork.ReservationTableRepository.Insert(new Infrastructure.Entities.ReservationTable
                {
                    ReservationId = reservation.Id,
                    TableId = table.Id
                });
            }
            else
            {
                reservation.StatusId = ReservationStatus.StatusWaitingProcessingId;
                unitOfWork.ReservationRepository.Insert(reservation);
            }

            unitOfWork.Save();
        }

        public static List<FreeTable> GetAllFreeTables()
        {
            return tableRepositoryImplementation
                .GetFreeTables(unitOfWork.ReservationTableRepository.GetAll(), DateTime.Now)
                .GroupBy(t => new { t.TypeId, t.MaxChairs })
                .Select(group => new FreeTable {
                    MaxChairs = group.Key.MaxChairs,
                    TableType = group.First().TableType.Name,
                    Count = group.Count()})
                .ToList();
        }

        public static List<string> GetFreeTableNumbers()
        {
            return tableRepositoryImplementation
                .GetFreeTables(unitOfWork.ReservationTableRepository.GetAll(), DateTime.Now)
                .Select(t => t.TableNumber)
                .ToList();
        }
    }
}