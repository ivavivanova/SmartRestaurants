using Infrastructure;
using Infrastructure.Enums;
using Infrastructure.Repositories.Implementations;
using System;
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
            DateTime time)
        {
            var reservation = new Infrastructure.Entities.Reservation
            {
                ChairsNeeded = chairsNeeded,
                CustomerPhoneNumber = "0887300112",
                CustomerEmail = userEmail,
                RegistrationDate = DateTime.Now,
                ReservationDate = date.Date,
                ReservationTime = time
            };

            var table = tableRepositoryImplementation
                .GetFreeTables(unitOfWork.ReservationTableRepository.GetAll(), reservation)
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

    }
}