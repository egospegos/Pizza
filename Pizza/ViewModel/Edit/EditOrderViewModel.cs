using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Data.Entity;
using DAL;

namespace Pizza.ViewModel.Edit
{
    public class EditOrderViewModel : ApplicationViewModel
    {
        bool? dr;
        public bool? DialogResult { get { return dr; } set { dr = value; } }

        Model1 dbContext;
        public OrderString CurrentOrder { get; set; }
        public ObservableCollection<Payment> PaymentList { get; set; }
        public ObservableCollection<Deliveryman> DeliverymanList { get; set; }
        public ObservableCollection<Status> StatusList { get; set; }
        public RelayCommand ApplyChangesCommand { get; set; }

        public EditOrderViewModel(Model1 dbContext, OrderString order)
        {
            this.dbContext = dbContext;
            PaymentList = dbContext.Payment.Local;
            DeliverymanList = dbContext.Deliveryman.Local;
            StatusList = dbContext.Status.Local;
            if (order != null)
            {
                CurrentOrder = order;
                ApplyChangesCommand = new RelayCommand(UpdateOrder, CanExe);
            }
            else
            {
                CurrentOrder = new OrderString();
                CurrentOrder.Order.DeliveryTime = DateTime.Now;
                ApplyChangesCommand = new RelayCommand(AddOrder, CanExe);
            }
            dbContext.Payment.Load();
            dbContext.Deliveryman.Load();
            dbContext.Status.Load();
        }

        private void AddOrder(object parameter)
        {
            DialogResult = true;
            dbContext.OrderString.Add(CurrentOrder);
            dbContext.SaveChanges();
        }

        private void UpdateOrder(object parameter)
        {
            dbContext.SaveChanges();
        }

        public bool CanExe(object parameter)
        {
            return !(CurrentOrder == null) && CurrentOrder.Order.Deliveryman != null;
        }
    }
}
