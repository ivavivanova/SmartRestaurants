namespace Infrastructure.Entities
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("MealProduct")]
    public partial class MealProduct
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int MealId { get; set; }

        public int ProductId { get; set; }

        public virtual Meal Meal { get; set; }

        public virtual Product Product { get; set; }
    }
}
