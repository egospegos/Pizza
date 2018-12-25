namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            OrderString = new HashSet<OrderString>();
        }
        [Key]
        public int Id { get; set; }

        public int Payment_ID { get; set; }

        public int Deliveryman_ID { get; set; }

        public int Status_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string ClientName { get; set; }

        [Required]
        [StringLength(20)]
        public string ClientPhone { get; set; }

        [Required]
        [StringLength(100)]
        public string Adress { get; set; }
                
        public DateTime CreateTime { get; set; }

        public DateTime? DeliveryTime { get; set; }

        public virtual Deliveryman Deliveryman { get; set; }

        public virtual Payment Payment { get; set; }

        public virtual Status Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderString> OrderString { get; set; }
    }
}
