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
using System.Windows.Shapes;
using NastinCOFE.ClassHelper;
using NastinCOFE.DB;

namespace NastinCOFE.Windows
{
    /// <summary>
    /// Логика взаимодействия для PlaceOrder.xaml
    /// </summary>
    public partial class PlaceOrder : Window
    {
        List<Product> products = new List<Product>();
        public PlaceOrder()
        {
            InitializeComponent();
            //for (int i = 0; i < 10; i++)
            //{

                StackPanel stackPanel = new StackPanel();

                if (Application.Current.Properties.Contains("Role"))
                {
                    int role = Convert.ToInt32(Application.Current.Properties["Role"]);
                    if (role == 3)
                    {
                        additem.Visibility = Visibility.Visible;
                    }
                 
                }
            GetProduct();

        }


        private void GetProduct()
        {
            List<Product> OrderList = new List<Product>();

            OrderList = HELP.Context.Product.ToList();

            listview.ItemsSource = OrderList;
        }


        private void inbasket_Click(object sender, RoutedEventArgs e)
        {
           
           Check check = new Check();
            check.IDUser = (Application.Current.Properties["Role"] as DB.User).IDUser;
            

        }
        private void additem_Click(object sender, RoutedEventArgs e)
        {
            AddItem addItem = new AddItem();
            this.Close();
            addItem.Show();
        }
    }
}
