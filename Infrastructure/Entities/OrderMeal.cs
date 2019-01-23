namespace Infrastructure.Entities
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("OrderMeal")]
    public partial class OrderMeal
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int MealId { get; set; }

        public int NumberMeals { get; set; }

        public virtual Meal Meal { get; set; }

        public virtual Order Order { get; set; }
    }
}
