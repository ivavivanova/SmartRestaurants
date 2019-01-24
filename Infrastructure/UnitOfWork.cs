using Infrastructure.Entities;
using Infrastructure.Repositories;
using System;

namespace Infrastructure
{
    public class UnitOfWork : IDisposable
    {
        private SmartRestaurantsContext context = new SmartRestaurantsContext();
        private RepositoryBase<Reservation> reservationRepository;
        private RepositoryBase<Table> tableRepository;

        public RepositoryBase<Reservation> ReservationRepository
        {
            get
            {

                if (this.reservationRepository == null)
                {
                    this.reservationRepository = new RepositoryBase<Reservation>(context);
                }
                return reservationRepository;
            }
        }

        public RepositoryBase<Table> TableRepository
        {
            get
            {

                if (this.tableRepository == null)
                {
                    this.tableRepository = new RepositoryBase<Table>(context);
                }
                return tableRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
