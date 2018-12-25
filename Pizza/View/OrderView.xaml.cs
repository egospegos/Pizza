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
    /// Логика взаимодействия для OrderView.xaml
    /// </summary>
    public partial class OrderView : UserControl
    {
        public OrderViewModel OrderVM { set; get; }
        public OrderView(Model1 db)
        {
            InitializeComponent();
            OrderVM = new OrderViewModel(db);
            DataContext = OrderVM;
            DataContext = this;
        }
    }
}
