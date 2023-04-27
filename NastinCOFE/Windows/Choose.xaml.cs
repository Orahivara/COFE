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

namespace NastinCOFE.Windows
{
    /// <summary>
    /// Логика взаимодействия для Choose.xaml
    /// </summary>
    public partial class Choose : Window
    {
        public Choose()
        {
            InitializeComponent();
            if (Application.Current.Properties["Role"] == null)
            {
                hi.Text = "Аве , User";
                
            }
            else {
                hi.Text = "Аве ," + Application.Current.Properties["Name"].ToString();
            }
           
        }

        private void employ_Click(object sender, RoutedEventArgs e)
        {
           
            Windows.Employ employ = new Windows.Employ();
            employ.Show();
            this.Close();
        }

        private void products_Click(object sender, RoutedEventArgs e)
        {
          
            Windows.PlaceOrder order = new Windows.PlaceOrder();
            order.Show();
            this.Close();
            
        }

        private void сlient_Click(object sender, RoutedEventArgs e)
        {
            Windows.Clients clients = new Windows.Clients();
            clients.Show();
            this.Close();
        }
    }
}
