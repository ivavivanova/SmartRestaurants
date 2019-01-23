namespace Infrastructure.Entities
{
    using Infrastructure.Enums;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Product")]
    public partial class Product
    {
        public Product()
        {
            MealProducts = new HashSet<MealProduct>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public int ProductTypeId { get; set; }

        public int Quantity { get; set; }

        public int QuantityTypeId { get; set; }

        public bool Аllergen { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ExpirationDate { get; set; }

        public virtual ICollection<MealProduct> MealProducts { get; set; }

        public virtual ProductType ProductType { get; set; }

        public virtual QuantityType QuantityType { get; set; }
    }
}
