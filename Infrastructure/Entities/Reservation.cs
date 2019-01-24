namespace Infrastructure.Entities
{
    using Infrastructure.Enums;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Reservation")]
    public partial class Reservation
    {
        public Reservation()
        {
            ReservationTables = new HashSet<ReservationTable>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string CustomerEmail { get; set; }

        [Required]
        [StringLength(20)]
        public string CustomerPhoneNumber { get; set; }

        public int ChairsNeeded { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ReservationDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ReservationTime { get; set; }

        public int StatusId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime RegistrationDate { get; set; }

        public virtual ReservationStatus ReservationStatus { get; set; }

        public virtual ICollection<ReservationTable> ReservationTables { get; set; }
    }
}
