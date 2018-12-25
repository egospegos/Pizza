using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Models;

namespace BLL.Interfaces
{
    public interface IDbCrud
    {
        List<DeliverymanModel> GetAllDeliveryman();
        List<OrderModel> GetAllOrder();
        List<OrderStringModel> GetAllOrderString();
        List<PaymentModel> GetAllPayment();
        List<PizzaModel> GetAllPizza();
        List<StatusModel> GetAllStatus();

        DeliverymanModel GetDeliveryman(int id);
        OrderModel GetOrder(int id);
        OrderStringModel GetOrderString(int id);
        PaymentModel GetPayment(int id);
        PizzaModel GetPizza(int id);
        StatusModel GetStatus(int id);


        void CreateDeliveryman(DeliverymanModel item);
        void UpdateDeliveryman(DeliverymanModel item);
        void DeleteDeliveryman(int id);

        void CreateOrder(OrderModel item);
        void UpdateOrder(OrderModel item);
        void DeleteOrder(int id);

        void CreateOrderString(OrderStringModel item);
        void UpdateOrderString(OrderStringModel item);
        void DeleteOrderString(int id);

        void CreatePayment(PaymentModel item);
        void UpdatePayment(PaymentModel item);
        void DeletePayment(int id);

        void CreatePizza(PizzaModel item);
        void UpdatePizza(PizzaModel item);
        void DeletePizza(int id);

        void CreateStatus(StatusModel item);
        void UpdateStatus(StatusModel item);
        void DeleteStatus(int id);
    }
}
