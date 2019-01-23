namespace Infrastructure.Entities
{
    using Infrastructure.Enums;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        public Order()
        {
            Feedbacks = new HashSet<Feedback>();
            OrderMeals = new HashSet<OrderMeal>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int TableId { get; set; }

        public int StatusId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime RegistationDate { get; set; }

        [StringLength(1000)]
        public string AdditionalCustomerRequirements { get; set; }

        public decimal? FinalPrice { get; set; }

        public virtual ICollection<Feedback> Feedbacks { get; set; }

        public virtual OrderStatus OrderStatus { get; set; }

        public virtual Table Table { get; set; }

        public virtual ICollection<OrderMeal> OrderMeals { get; set; }
    }
}
