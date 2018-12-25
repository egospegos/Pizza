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
    public class EditDeliverymanViewModel : ApplicationViewModel
    {
        bool? dr;
        public bool? DialogResult { get { return dr; } set { dr = value; } }

        Model1 dbContext;
        public Deliveryman CurrentDeliveryman { get; set; }        
        public RelayCommand ApplyChangesCommand { get; set; }

        public EditDeliverymanViewModel(Model1 dbContext, Deliveryman deliveryman)
        {
            this.dbContext = dbContext;
            if (deliveryman != null)
            {
                CurrentDeliveryman = deliveryman;
                ApplyChangesCommand = new RelayCommand(UpdateDeliveryman, CanExe);
            }
            else
            {
                CurrentDeliveryman = new Deliveryman();
                ApplyChangesCommand = new RelayCommand(AddDeliveryman, CanExe);
            }
           
            dbContext.Deliveryman.Load();
            
        }

        private void AddDeliveryman(object parameter)
        {
            DialogResult = true;
            dbContext.Deliveryman.Add(CurrentDeliveryman);
            dbContext.SaveChanges();
        }

        private void UpdateDeliveryman(object parameter)
        {
            dbContext.SaveChanges();
        }

        public bool CanExe(object parameter)
        {
            return !(CurrentDeliveryman == null);
        }
    }
}
