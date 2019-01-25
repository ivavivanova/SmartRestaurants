namespace Infrastructure.Enums
{
    using Infrastructure.Entities;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class TableStatus
    {
        public TableStatus()
        {
            Tables = new HashSet<Table>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public virtual ICollection<Table> Tables { get; set; }

        public static int StatusFreeId => 1;

        public static int StatusOccupiedId  => 2;

        public static int StatusWaitingAccountId => 3;

        public static int StatusWaitingWaiterId => 4;
    }
}
