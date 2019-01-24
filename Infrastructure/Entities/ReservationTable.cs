namespace Infrastructure.Entities
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ReservationTable")]
    public partial class ReservationTable
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int TableId { get; set; }

        public int ReservationId { get; set; }

        public virtual Reservation Reservation { get; set; }

        public virtual Table Table { get; set; }
    }
}
