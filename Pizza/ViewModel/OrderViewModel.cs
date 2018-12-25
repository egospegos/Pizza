using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Windows;
using DAL;
using BLL.Interfaces;
using BLL.Models;
using Pizza.ViewModel;

namespace Pizza.ViewModel
{
    public class OrderViewModel : ApplicationViewModel
    {
        private ObservableCollection<OrderString> orderSource;
        public List<OrderStringModel> allOrders;
        IDbCrud dbOperations;
        public ObservableCollection<OrderString> OrderSource
        {
            get { return orderSource; }
            set
            {
                orderSource = value;
                OnPropertyChanged("OrderSource");
            }
        }
       
        public OrderString SelectedOrder { get; set; }

        RelayCommand addOrderCommand;
        public RelayCommand AddOrderCommand
        {
            get { return addOrderCommand; }
            set { addOrderCommand = value; }
        }        

        RelayCommand updateOrderCommand;
        public RelayCommand UpdateOrderCommand
        {
            get { return updateOrderCommand; }
            set { updateOrderCommand = value; }
        }
        RelayCommand deleteOrderCommand;
        public RelayCommand DeleteOrderCommand
        {
            get { return deleteOrderCommand; }
            set { deleteOrderCommand = value; }
        }
        

        private Model1 db;
        public OrderViewModel(Model1 dbcontext)
        {
            db = dbcontext;
            LoadOrders();
            AddOrderCommand = new RelayCommand(AddOrder);
            UpdateOrderCommand = new RelayCommand(UpdateOrder, CanExecute);
            DeleteOrderCommand = new RelayCommand(DeleteOrder, CanExecute);
        }

        private void LoadOrders()
        {
            db.OrderString.Load();
            //allSupplies = dbOperations.GetAllSupply();
            //SupplyView.ListViewMain.DataSource = allSupplies;
            OrderSource = new ObservableCollection<OrderString>(db.OrderString.ToList());
        }

        public void AddOrder(object parameter)
        {
            Window window = new View.Edit.EditOrderView();
            window.DataContext = new Edit.EditOrderViewModel(db, null);
            window.Title = "Добавление";
            window.ShowDialog();
            OrderSource = new ObservableCollection<OrderString>(db.OrderString.ToList());
        }
        
        public void UpdateOrder(object parameter)
        {
            Window window = new View.Edit.EditOrderView();
            window.DataContext = new Edit.EditOrderViewModel(db, SelectedOrder);
            window.Title = "Изменить";
            window.ShowDialog();
        }

        public void DeleteOrder(Object parameter)
        {

            if (Helpers.ConfirmDialog.Confirm($"Удалить заказ {SelectedOrder.Order.Deliveryman.Name} в размере ({SelectedOrder.Order.ClientName}) от {SelectedOrder.Order.DeliveryTime}?"))
            {
                db.OrderString.Local.Remove(SelectedOrder);
                OrderSource.Remove(SelectedOrder);
                db.SaveChanges();
            }
        }

        public bool CanExecute(object parameter)
        {
            return SelectedOrder != null;
        }



    }
}
