namespace Infrastructure.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Meal")]
    public partial class Meal
    {
        public Meal()
        {
            MealProducts = new HashSet<MealProduct>();
            OrderMeals = new HashSet<OrderMeal>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public byte[] Image { get; set; }

        public decimal Weight { get; set; }

        public virtual ICollection<MealProduct> MealProducts { get; set; }

        public virtual ICollection<OrderMeal> OrderMeals { get; set; }
    }
}
