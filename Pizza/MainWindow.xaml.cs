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
using Pizza.ViewModel;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Pizza.View;
using DAL;

namespace Pizza
{

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        Model1 db = new Model1();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainWindowViewModel(db);
        }

        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;
            MoveCursorMenu(index);

            switch (index)
            {
                case 0:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new HomeView());
                    break;
                case 1:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new MenuView());
                    break;
                case 2:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new OrderView(db));
                    break;
                case 3:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new DeliverymanView(db));
                    break;
                case 4:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new AboutView());
                    break;
                case 5:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new LoginView());
                    break;
            }
        }

        private void MoveCursorMenu(int index)
        {
            //TrainsitionigContentSlide.OnApplyTemplate();
            GridCursor.Margin = new Thickness(0, (100 + (60 * index)), 0, 0);
        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {

        }

    }
}
