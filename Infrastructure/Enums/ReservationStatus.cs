namespace Infrastructure.Enums
{
    using Infrastructure.Entities;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class ReservationStatus
    {
        public ReservationStatus()
        {
            Reservations = new HashSet<Reservation>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }

        public static int StatusNewId => 1;

        public static int StatusConfirmedId => 2;

        public static int StatusDeniedId => 3;

        public static int StatusWaitingProcessingId => 4;

        public static int StatusExpiredId => 5;
    }
}
