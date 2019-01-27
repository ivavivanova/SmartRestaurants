using Administration.ViewModels;
using Infrastructure;
using Infrastructure.Enums;
using Infrastructure.Repositories.Implementations;
using System.Linq;
using System.Web.Mvc;

namespace Administration.Controllers
{
    public class HomeController : Controller
    {
        public static string UserRole;
        private UnitOfWork unitOfWork = new UnitOfWork();

        [HttpGet]
        public ActionResult Index()
        {
            if (UserRole == null)
            {
                return this.Redirect(Url.Action("Login", "Home"));
            }
            else
            {
                return View(new ReservationsViewModel(unitOfWork.ReservationRepository.GetAll()));
            }
        }

        [HttpGet]
        public ActionResult Tables()
        {
            return View(new TablesViewModel(
                unitOfWork.TableRepository
                    .GetAll()
                    .Where(t => t.StatusId == TableStatus.StatusOccupiedId)));
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string userRole)
        {
            UserRole = userRole;
            return this.Redirect(Url.Action("Index", "Home"));
        }

        [HttpGet]
        public ActionResult Logout()
        {
            UserRole = null;
            return this.Redirect(Url.Action("Login", "Home"));
        }

        [HttpGet]
        public ActionResult ReservationDetails(int reservationId)
        {
            var reservation = this.unitOfWork.ReservationRepository.GetByID(reservationId);
            var tables = ReservationTableRepositoryImplementation
                .GetTablesByReservationId(unitOfWork.ReservationTableRepository, reservationId);
            var freeTables = TableRepositoryImplementation.GetFreeTables(
                unitOfWork.TableRepository.GetAll(),
                unitOfWork.ReservationTableRepository.GetAll(),
                reservation.ReservationDate.Date.Add(reservation.ReservationTime.TimeOfDay));

            return View(ReservationDetailsViewModel.MapFromEntities(reservation, tables, freeTables));
        }

        [HttpPost]
        public ActionResult ReservationDetails(ReservationDetailsViewModel model)
        {
            var reservationTablesForRemove = ReservationTableRepositoryImplementation
                .GetByReservationId(unitOfWork.ReservationTableRepository, model.ReservationId);

            if (model.CheckedTablesForReservation.Any())
            {
                reservationTablesForRemove = reservationTablesForRemove
                    .Where(t => !model.CheckedTablesForReservation.Contains(t.TableId));
            }

            foreach (var reservationTable in reservationTablesForRemove)
            {
                this.unitOfWork.ReservationTableRepository.Delete(reservationTable.Id);
            }

            foreach (var tableId in model.CheckedFreeTables)
            {
                this.unitOfWork.ReservationTableRepository
                    .Insert(new Infrastructure.Entities.ReservationTable()
                    {
                        ReservationId = model.ReservationId,
                        TableId = tableId
                    });
            }

            var reservation = this.unitOfWork.ReservationRepository.GetByID(model.ReservationId);
            reservation.ChairsNeeded = model.ChairsNeeded;
            reservation.StatusId = ReservationStatus.StatusConfirmedId;

            this.unitOfWork.Save();

            return this.Redirect(Url.Action("Index", "Home"));
        }

        [HttpPost]
        public ActionResult SetFreeTable(int tableId)
        {
            var table = this.unitOfWork.TableRepository.GetByID(tableId);
            table.StatusId = TableStatus.StatusFreeId;
            this.unitOfWork.Save();

            return this.Redirect(Url.Action("Tables", "Home"));
        }

        [HttpPost]
        public ActionResult DeclineReservation(int reservationId)
        {
            var reservation = this.unitOfWork.ReservationRepository.GetByID(reservationId);
            reservation.StatusId = ReservationStatus.StatusDeniedId;
            this.unitOfWork.Save();

            return this.Redirect(Url.Action("Index", "Home"));
        }
    }
}