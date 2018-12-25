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
    public class DeliverymanViewModel : ApplicationViewModel
    {
        private ObservableCollection<Deliveryman> deliverymanSource;
        public List<DeliverymanModel> allDeliveryman;
        IDbCrud dbOperations;
        public ObservableCollection<Deliveryman> DeliverymanSource
        {
            get { return deliverymanSource; }
            set
            {
                deliverymanSource = value;
                OnPropertyChanged("DeliverymanSource");
            }
        }

        public Deliveryman SelectedDeliveryman { get; set; }

        RelayCommand addDeliverymanCommand;
        public RelayCommand AddDeliverymanCommand
        {
            get { return addDeliverymanCommand; }
            set { addDeliverymanCommand = value; }
        }

        RelayCommand updateDeliverymanCommand;
        public RelayCommand UpdateDeliverymanCommand
        {
            get { return updateDeliverymanCommand; }
            set { updateDeliverymanCommand = value; }
        }
        RelayCommand deleteDeliverymanCommand;
        public RelayCommand DeleteDeliverymanCommand
        {
            get { return deleteDeliverymanCommand; }
            set { deleteDeliverymanCommand = value; }
        }


        private Model1 db;
        public DeliverymanViewModel(Model1 dbcontext)
        {
            db = dbcontext;
            LoadDeliveryman();
            AddDeliverymanCommand = new RelayCommand(AddDeliveryman);
            UpdateDeliverymanCommand = new RelayCommand(UpdateDeliveryman, CanExecute);
            DeleteDeliverymanCommand = new RelayCommand(DeleteDeliveryman, CanExecute);
        }

        private void LoadDeliveryman()
        {
            db.Deliveryman.Load();
            //allSupplies = dbOperations.GetAllSupply();
            //SupplyView.ListViewMain.DataSource = allSupplies;
            DeliverymanSource = new ObservableCollection<Deliveryman>(db.Deliveryman.ToList());
        }

        public void AddDeliveryman(object parameter)
        {
            Window window = new View.Edit.EditDelivermanView();
            window.DataContext = new Edit.EditDeliverymanViewModel(db, null);
            window.Title = "Добавление";
            window.ShowDialog();
            DeliverymanSource = new ObservableCollection<Deliveryman>(db.Deliveryman.ToList());
        }

        public void UpdateDeliveryman(object parameter)
        {
            Window window = new View.Edit.EditDelivermanView();
            window.DataContext = new Edit.EditDeliverymanViewModel(db, SelectedDeliveryman);
            window.Title = "Изменить";
            window.ShowDialog();
        }

        public void DeleteDeliveryman(Object parameter)
        {

            if (Helpers.ConfirmDialog.Confirm($"Удалить курьера {SelectedDeliveryman.Name} ?"))
            {
                db.Deliveryman.Local.Remove(SelectedDeliveryman);
                DeliverymanSource.Remove(SelectedDeliveryman);
                db.SaveChanges();
            }
        }

        public bool CanExecute(object parameter)
        {
            return SelectedDeliveryman != null;
        }



    }
}
