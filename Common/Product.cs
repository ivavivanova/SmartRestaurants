namespace Common
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MealProduct> MealProducts { get; set; }

        public virtual ProductType ProductType { get; set; }

        public virtual QuantityType QuantityType { get; set; }
    }
}
