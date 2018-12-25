using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;

namespace DAL.Repository
{
    public class DBReposSQL : IDbRepos
    {
        private Model1 db;
        private PizzaRepository pizzaRepository;
        private DeliverymanRepository deliverymanRepository;
        private OrderStringRepository orderstringRepository;
        private OrderRepository orderRepository;
        private PaymentRepository paymentRepository;
        private StatusRepository statusRepository;

        public DBReposSQL()
        {
            db = new Model1();
        }

        public IRepository<Pizza> Pizzas
        {
            get
            {
                if (pizzaRepository == null)
                    pizzaRepository = new PizzaRepository(db);
                return pizzaRepository;
            }
        }

        public IRepository<Deliveryman> Deliverymen
        {
            get
            {
                if (deliverymanRepository == null)
                    deliverymanRepository = new DeliverymanRepository(db);
                return deliverymanRepository;
            }
        }

        public IRepository<OrderString> OrderStrings
        {
            get
            {
                if (orderstringRepository == null)
                    orderstringRepository = new OrderStringRepository(db);
                return orderstringRepository;
            }
        }

        public IRepository<Order> Orders
        {
            get
            {
                if (orderRepository == null)
                    orderRepository = new OrderRepository(db);
                return orderRepository;
            }
        }

        public IRepository<Payment> Payments
        {
            get
            {
                if (paymentRepository == null)
                    paymentRepository = new PaymentRepository(db);
                return paymentRepository;
            }
        }

        public IRepository<Status> Statuses
        {
            get
            {
                if (statusRepository == null)
                    statusRepository = new StatusRepository(db);
                return statusRepository;
            }
        }

        public int Save()
        {
            return db.SaveChanges();
        }
    }
}
