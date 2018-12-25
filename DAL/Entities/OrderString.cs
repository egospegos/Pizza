namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderString")]
    public partial class OrderString
    {
        [Key]
        public int Id { get; set; }

        public int Pizza_ID { get; set; }

        public int Order_ID { get; set; }

        public int Count { get; set; }

        public int Cost { get; set; }

        public virtual Order Order { get; set; }

        public virtual Pizza Pizza { get; set; }
    }
}
