using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using DAL;

namespace Pizza.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {

        Model1 db = new Model1();
        /// ViewModel для вкладок
        public OrderViewModel OrderVM { set; get; }
        public DeliverymanViewModel DeliverymanVM { set; get; }

        public MainWindowViewModel(Model1 db1)
        {
            this.db = db1;
            OrderVM = new OrderViewModel(db);
            DeliverymanVM = new DeliverymanViewModel(db);
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }


    }
}
