using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IDbRepos
    {
        //Unit of Work -- паттерн
        IRepository<Deliveryman> Deliverymen { get; }
        IRepository<Order> Orders { get; }
        IRepository<OrderString> OrderStrings { get; }
        IRepository<Pizza> Pizzas { get; }
        IRepository<Payment> Payments { get; }
        IRepository<Status> Statuses { get; }
        int Save();
    }
}
