using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DAL;
using Pizza.ViewModel;

namespace Pizza.View
{
    /// <summary>
    /// Логика взаимодействия для DelivermanView.xaml
    /// </summary>
    public partial class DeliverymanView : UserControl
    {
            public DeliverymanViewModel DeliverymanVM { set; get; }
            public DeliverymanView(Model1 db)
            {
                InitializeComponent();
                DeliverymanVM = new DeliverymanViewModel(db);
                DataContext = DeliverymanVM;
                DataContext = this;
            
        }
    }
}
