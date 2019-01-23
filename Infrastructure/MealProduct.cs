namespace Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MealProduct")]
    public partial class MealProduct
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int MealId { get; set; }

        public int ProductId { get; set; }

        public virtual Meal Meal { get; set; }

        public virtual Product Product { get; set; }
    }
}
