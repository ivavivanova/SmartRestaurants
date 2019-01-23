namespace Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Table")]
    public partial class Table
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Table()
        {
            Orders = new HashSet<Order>();
            ReservationTables = new HashSet<ReservationTable>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReservationTable> ReservationTables { get; set; }

        public virtual TableStatu TableStatu { get; set; }

        public virtual TableType TableType { get; set; }
    }
}
