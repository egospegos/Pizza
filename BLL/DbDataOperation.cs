using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interfaces;
using BLL.Models;
using DAL;
using DAL.Interfaces;

namespace BLL
{
    public class DbDataOperation : IDbCrud
    {
        //паттерн репозиторий
        //Unit of work
        IDbRepos db;
        public DbDataOperation(IDbRepos repos)
        {
            db = repos;
        }
        ObservableCollection<Deliveryman> deliveryman;
        ObservableCollection<Order> order;
        ObservableCollection<OrderString> orderString;
        ObservableCollection<Pizza> pizza;
        ObservableCollection<Payment> payment;
        ObservableCollection<Status> status;

        public List<DeliverymanModel> GetAllDeliveryman()
        {
            deliveryman = db.Deliverymen.GetList();
            return deliveryman.Select(i => toDeliverymanModel(i)).ToList();
        }
        public DeliverymanModel GetDeliveryman(int id)
        {
            return toDeliverymanModel(db.Deliverymen.GetItem(id));
        }
        public void CreateDeliveryman(DeliverymanModel deliveryman)
        {
            db.Deliverymen.Create(toDeliveryman(new Deliveryman(), deliveryman));
            db.Save();
            GetAllDeliveryman();
        }
        public void UpdateDeliveryman(DeliverymanModel deliveryman)
        {
            Deliveryman del = db.Deliverymen.GetItem(deliveryman.Id);
            db.Deliverymen.Update(toDeliveryman(del, deliveryman));
            db.Save();
        }
        public void DeleteDeliveryman(int id)
        {
            Deliveryman c = db.Deliverymen.GetItem(id);
            if (c != null)
                db.Deliverymen.Delete(id);
            db.Save();
        }
        private DeliverymanModel toDeliverymanModel(Deliveryman i)
        {
            return new DeliverymanModel()
            {
                Id = i.Id,
                CarBrand = i.CarBrand,
                CarNumber = i.CarNumber,
                Name = i.Name,
                Phone = i.Phone
            };
        }
        private Deliveryman toDeliveryman(Deliveryman p, DeliverymanModel i)
        {
            p.Id = i.Id;
            p.CarBrand = i.CarBrand;
            p.CarNumber = i.CarNumber;
            p.Name = i.Name;
            p.Phone = i.Phone;
            return p;
        }

        public List<OrderModel> GetAllOrder()
        {
            order = db.Orders.GetList();
            return order.Select(i => toOrderModel(i)).ToList();
        }
        public OrderModel GetOrder(int id)
        {
            return toOrderModel(db.Orders.GetItem(id));
        }
        public void CreateOrder(OrderModel order)
        {
            db.Orders.Create(toOrder(new Order(), order));
            db.Save();
            GetAllOrder();
        }
        public void UpdateOrder(OrderModel order)
        {
            Order or = db.Orders.GetItem(order.Id);
            db.Orders.Update(toOrder(or, order));
            db.Save();
        }
        public void DeleteOrder(int id)
        {
            Order c = db.Orders.GetItem(id);
            if (c != null)
                db.Orders.Delete(id);
            db.Save();
        }
        private OrderModel toOrderModel(Order i)
        {
            return new OrderModel()
            {
                Id = i.Id,                
                Adress = i.Adress,
                ClientName = i.ClientName,
                ClientPhone = i.ClientPhone,
                CreateTime = i.CreateTime,
                Deliveryman_ID = i.Deliveryman_ID,
                DeliveryTime = i.DeliveryTime,
                Payment_ID = i.Payment_ID,
                Status_ID = i.Status_ID
            };
        }
        private Order toOrder(Order p, OrderModel i)
        {
            p.Id = i.Id;
            p.Adress = i.Adress;
            p.ClientName = i.ClientName;
            p.ClientPhone = i.ClientPhone;
            p.CreateTime = i.CreateTime;
            p.Deliveryman_ID = i.Deliveryman_ID;
            p.DeliveryTime = i.DeliveryTime;
            p.Payment_ID = i.Payment_ID;
            p.Status_ID = i.Status_ID;
            return p;
        }

        public List<OrderStringModel> GetAllOrderString()
        {
            orderString = db.OrderStrings.GetList();
            return orderString.Select(i => toOrderStringModel(i)).ToList();
        }
        public OrderStringModel GetOrderString(int id)
        {
            return toOrderStringModel(db.OrderStrings.GetItem(id));
        }
        public void CreateOrderString(OrderStringModel item)
        {
            db.OrderStrings.Create(toOrderString(new OrderString(), item));
            db.Save();
            GetAllOrderString();
        }
        public void UpdateOrderString(OrderStringModel item)
        {
            OrderString it = db.OrderStrings.GetItem(item.Id);
            db.OrderStrings.Update(toOrderString(it, item));
            db.Save();
        }
        public void DeleteOrderString(int id)
        {
            OrderString o = db.OrderStrings.GetItem(id);
            if (o != null)
                db.OrderStrings.Delete(id);
            db.Save();
        }
        private OrderStringModel toOrderStringModel(OrderString i)
        {
            return new OrderStringModel()
            {
                Id = i.Id,
                Cost = i.Cost,
                Count = i.Count,
                Order_ID = i.Order_ID,
                Pizza_ID = i.Pizza_ID
            };
        }
        private OrderString toOrderString(OrderString p, OrderStringModel i)
        {
            p.Id = i.Id;
            p.Cost = i.Cost;
            p.Count = i.Count;
            p.Order_ID = i.Order_ID;
            p.Pizza_ID = i.Pizza_ID;
            return p;
        }

        public List<PaymentModel> GetAllPayment()
        {
            payment = db.Payments.GetList();
            return payment.Select(i => toPaymentModel(i)).ToList();
        }
        public PaymentModel GetPayment(int id)
        {
            return toPaymentModel(db.Payments.GetItem(id));
        }
        public void CreatePayment(PaymentModel payment)
        {
            db.Payments.Create(toPayment(new Payment(), payment));
            db.Save();
            GetAllPayment();
        }
        public void UpdatePayment(PaymentModel payment)
        {
            Payment sel = db.Payments.GetItem(payment.Id);
            db.Payments.Update(toPayment(sel, payment));
            db.Save();
        }
        public void DeletePayment(int id)
        {
            Payment c = db.Payments.GetItem(id);
            if (c != null)
                db.Payments.Delete(id);
            db.Save();
        }
        private PaymentModel toPaymentModel(Payment i)
        {
            return new PaymentModel()
            {
                Id = i.Id,
                Type = i.Type
            };
        }
        private Payment toPayment(Payment p, PaymentModel i)
        {
                p.Id = i.Id;
                p.Type = i.Type;
            return p;
        }

        public List<PizzaModel> GetAllPizza()
        {
            pizza = db.Pizzas.GetList();
            return pizza.Select(i => toPizzaModel(i)).ToList();
        }
        public PizzaModel GetPizza(int id)
        {
            return toPizzaModel(db.Pizzas.GetItem(id));
        }
        public void CreatePizza(PizzaModel pizza)
        {
            db.Pizzas.Create(toPizza(new Pizza(), pizza));
            db.Save();
            GetAllPizza();
        }
        public void UpdatePizza(PizzaModel pizza)
        {
            Pizza sel = db.Pizzas.GetItem(pizza.Id);
            db.Pizzas.Update(toPizza(sel, pizza));
            db.Save();
        }
        public void DeletePizza(int id)
        {
            Pizza c = db.Pizzas.GetItem(id);
            if (c != null)
                db.Pizzas.Delete(id);
            db.Save();
        }
        private PizzaModel toPizzaModel(Pizza i)
        {
            return new PizzaModel()
            {
                Id = i.Id,
                Image = i.Image,
                Ingredients = i.Ingredients,
                Name = i.Name,
                Price = i.Price
            };
        }
        private Pizza toPizza(Pizza p, PizzaModel i)
        {
            p.Id = i.Id;
            p.Image = i.Image;
            p.Ingredients = i.Ingredients;
            p.Name = i.Name;
            p.Price = i.Price;
            return p;
        }

        public List<StatusModel> GetAllStatus()
        {
            status = db.Statuses.GetList();
            return status.Select(i => toStatusModel(i)).ToList();
        }
        public StatusModel GetStatus(int id)
        {
            return toStatusModel(db.Statuses.GetItem(id));
        }
        public void CreateStatus(StatusModel status)
        {
            db.Statuses.Create(toStatus(new Status(), status));
            db.Save();
            GetAllStatus();
        }
        public void UpdateStatus(StatusModel status)
        {
            Status sel = db.Statuses.GetItem(status.Id);
            db.Statuses.Update(toStatus(sel, status));
            db.Save();
        }
        public void DeleteStatus(int id)
        {
            Status c = db.Statuses.GetItem(id);
            if (c != null)
                db.Statuses.Delete(id);
            db.Save();
        }
        private StatusModel toStatusModel(Status i)
        {
            return new StatusModel()
            {
                Id = i.Id,
                Type = i.Type
            };
        }
        private Status toStatus(Status p, StatusModel i)
        {
            p.Id = i.Id;
            p.Type = i.Type;
            return p;
        }              

    }
}
