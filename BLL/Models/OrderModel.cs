using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public int Payment_ID { get; set; }
        public int Deliveryman_ID { get; set; }
        public int Status_ID { get; set; }
        public string ClientName { get; set; }
        public string ClientPhone { get; set; }
        public string Adress { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? DeliveryTime { get; set; }
    }
}
