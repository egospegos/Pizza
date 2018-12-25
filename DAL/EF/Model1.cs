namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Deliveryman> Deliveryman { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderString> OrderString { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<Pizza> Pizza { get; set; }
        public virtual DbSet<Status> Status { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Deliveryman>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Deliveryman>()
                .Property(e => e.CarNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Deliveryman>()
                .Property(e => e.CarBrand)
                .IsUnicode(false);

            modelBuilder.Entity<Deliveryman>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Deliveryman>()
                .HasMany(e => e.Order)
                .WithRequired(e => e.Deliveryman)
                .HasForeignKey(e => e.Deliveryman_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.ClientName)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.ClientPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Adress)
                .IsUnicode(false);
            
            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderString)
                .WithRequired(e => e.Order)
                .HasForeignKey(e => e.Order_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Payment>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Payment>()
                .HasMany(e => e.Order)
                .WithRequired(e => e.Payment)
                .HasForeignKey(e => e.Payment_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pizza>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Pizza>()
                .Property(e => e.Ingredients)
                .IsUnicode(false);

            modelBuilder.Entity<Pizza>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Pizza>()
                .HasMany(e => e.OrderString)
                .WithRequired(e => e.Pizza)
                .HasForeignKey(e => e.Pizza_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Status>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.Order)
                .WithRequired(e => e.Status)
                .HasForeignKey(e => e.Status_ID)
                .WillCascadeOnDelete(false);
        }
    }
}
