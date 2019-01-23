namespace Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReservationTable")]
    public partial class ReservationTable
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int TableId { get; set; }

        public int ReservationId { get; set; }

        public virtual Reservation Reservation { get; set; }

        public virtual Table Table { get; set; }
    }
}
