namespace Infrastructure
{
    using System.Data.Entity;
    using Infrastructure.Enums;
    using Infrastructure.Entities;

    public partial class SmartRestaurantsContext : DbContext
    {
        public SmartRestaurantsContext()
            : base("name=SmartRestaurantsModel")
        {
        }

        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<FeedbackQuestionAnswer> FeedbackQuestionAnswers { get; set; }
        public virtual DbSet<Meal> Meals { get; set; }
        public virtual DbSet<MealProduct> MealProducts { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderMeal> OrderMeals { get; set; }
        public virtual DbSet<OrderStatus> OrderStatus { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductType> ProductTypes { get; set; }
        public virtual DbSet<QuantityType> QuantityTypes { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<ReservationStatus> ReservationStatus { get; set; }
        public virtual DbSet<ReservationTable> ReservationTables { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<TableStatus> TableStatus { get; set; }
        public virtual DbSet<TableType> TableTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Answer>()
                .Property(e => e.Description)
                .IsFixedLength();

            modelBuilder.Entity<Answer>()
                .HasMany(e => e.FeedbackQuestionAnswers)
                .WithRequired(e => e.Answer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Feedback>()
                .HasMany(e => e.FeedbackQuestionAnswers)
                .WithRequired(e => e.Feedback)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Meal>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Meal>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Meal>()
                .Property(e => e.Weight)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Meal>()
                .HasMany(e => e.MealProducts)
                .WithRequired(e => e.Meal)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Meal>()
                .HasMany(e => e.OrderMeals)
                .WithRequired(e => e.Meal)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.AdditionalCustomerRequirements)
                .IsFixedLength();

            modelBuilder.Entity<Order>()
                .Property(e => e.FinalPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.Feedbacks)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderMeals)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderStatus>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<OrderStatus>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.OrderStatus)
                .HasForeignKey(e => e.StatusId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .HasMany(e => e.MealProducts)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductType>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<ProductType>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.ProductType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<QuantityType>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<QuantityType>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.QuantityType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Question>()
                .Property(e => e.Description)
                .IsFixedLength();

            modelBuilder.Entity<Question>()
                .HasMany(e => e.FeedbackQuestionAnswers)
                .WithRequired(e => e.Question)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Reservation>()
                .Property(e => e.CustomerEmail)
                .IsFixedLength();

            modelBuilder.Entity<Reservation>()
                .Property(e => e.CustomerPhoneNumber)
                .IsFixedLength();

            modelBuilder.Entity<Reservation>()
                .HasMany(e => e.ReservationTables)
                .WithRequired(e => e.Reservation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ReservationStatus>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<ReservationStatus>()
                .HasMany(e => e.Reservations)
                .WithRequired(e => e.ReservationStatus)
                .HasForeignKey(e => e.StatusId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Table>()
                .Property(e => e.TableNumber)
                .IsFixedLength();

            modelBuilder.Entity<Table>()
                .Property(e => e.Location)
                .IsFixedLength();

            modelBuilder.Entity<Table>()
                .Property(e => e.RFIDControler)
                .IsFixedLength();

            modelBuilder.Entity<Table>()
                .Property(e => e.AdditionalInfo)
                .IsFixedLength();

            modelBuilder.Entity<Table>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Table)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Table>()
                .HasMany(e => e.ReservationTables)
                .WithRequired(e => e.Table)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TableStatus>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<TableStatus>()
                .HasMany(e => e.Tables)
                .WithRequired(e => e.TableStatus)
                .HasForeignKey(e => e.StatusId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TableType>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<TableType>()
                .HasMany(e => e.Tables)
                .WithRequired(e => e.TableType)
                .HasForeignKey(e => e.TypeId)
                .WillCascadeOnDelete(false);
        }
    }
}
