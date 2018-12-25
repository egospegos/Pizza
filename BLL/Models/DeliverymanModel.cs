using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BLL.Models
{
    public class DeliverymanModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CarNumber { get; set; }
        public string CarBrand { get; set; }
        public string Phone { get; set; }
    }
}
