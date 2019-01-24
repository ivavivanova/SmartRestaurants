namespace Infrastructure.Entities
{
    using Infrastructure.Enums;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Table")]
    public partial class Table
    {
        public Table()
        {
            Orders = new HashSet<Order>();
            ReservationTables = new HashSet<ReservationTable>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string TableNumber { get; set; }

        [Required]
        [StringLength(100)]
        public string Location { get; set; }

        public int MaxChairs { get; set; }

        public int StatusId { get; set; }

        [StringLength(100)]
        public string RFIDControler { get; set; }

        public int TypeId { get; set; }

        [StringLength(1000)]
        public string AdditionalInfo { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public virtual ICollection<ReservationTable> ReservationTables { get; set; }

        public virtual TableStatus TableStatus { get; set; }

        public virtual TableType TableType { get; set; }
    }
}
