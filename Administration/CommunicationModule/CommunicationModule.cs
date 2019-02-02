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

        public static void SaveReservation(
            string userEmail,
            int chairsNeeded,
            DateTime date,
            DateTime time,
            string phoneNum,
            int tableTypeId)
        {
            unitOfWork = new UnitOfWork();

            var reservation = new Infrastructure.Entities.Reservation
            {
                ChairsNeeded = chairsNeeded,
                CustomerPhoneNumber = phoneNum,
                CustomerEmail = userEmail,
                RegistrationDate = DateTime.Now,
                ReservationDate = date.Date,
                ReservationTime = time
            };

            var table = TableRepositoryImplementation
                .GetFreeTables(unitOfWork.TableRepository.GetAll(), unitOfWork.ReservationTableRepository.GetAll(), date.Date.Add(time.TimeOfDay))
                .FirstOrDefault(t => t.MaxChairs >= chairsNeeded && chairsNeeded + 2 >= t.MaxChairs && t.TypeId == tableTypeId);

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
            unitOfWork = new UnitOfWork();

            return TableRepositoryImplementation
                .GetFreeTables(unitOfWork.TableRepository.GetAll(), unitOfWork.ReservationTableRepository.GetAll(), DateTime.Now)
                .GroupBy(t => new { t.TypeId, t.MaxChairs })
                .Select(group => new FreeTable {
                    MaxChairs = group.Key.MaxChairs,
                    TableType = group.First().TableType.Name,
                    Count = group.Count()})
                .ToList();
        }

        public static List<string> GetFreeTableNumbers()
        {
            unitOfWork = new UnitOfWork();

            return TableRepositoryImplementation
                .GetFreeTables(unitOfWork.TableRepository.GetAll(), unitOfWork.ReservationTableRepository.GetAll(), DateTime.Now)
                .Select(t => t.TableNumber)
                .ToList();
        }

        public static string OccupiedTableByEmail(string email)
        {
            unitOfWork = new UnitOfWork();

            var table = unitOfWork.ReservationTableRepository
                .GetAll()
                .FirstOrDefault(r => r.Reservation.CustomerEmail.Replace(" ", "") == email)?
                .Table;

            if (table != null)
            {
                table.StatusId = TableStatus.StatusOccupiedId;
                unitOfWork.Save();
            }

            return table?.TableNumber;
        }

        public static void OccupiedTable(string tableNum)
        {
            unitOfWork = new UnitOfWork();

            var table = unitOfWork.TableRepository.GetAll().FirstOrDefault(t => t.TableNumber.Contains(tableNum));

            if(table != null)
            {
                table.StatusId = TableStatus.StatusOccupiedId;
                unitOfWork.Save();
            }
        }
    }
}