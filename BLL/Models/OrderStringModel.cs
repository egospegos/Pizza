using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class OrderStringModel
    {
        public int Id { get; set; }
        public int Pizza_ID { get; set; }
        public int Order_ID { get; set; }
        public int Count { get; set; }
        public int Cost { get; set; }
    }
}
