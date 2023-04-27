using NastinCOFE.ClassHelper;
using NastinCOFE.DB;
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
using NastinCOFE.DB;
using NastinCOFE.ClassHelper;


namespace NastinCOFE
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //users = HELP.Context.User.ToList();
            // table.ItemsSource = users;
            // end.Text = users[1].ToString();
        }

        private void _in_Click(object sender, RoutedEventArgs e)
        {
            var correct = HELP.Context.User.FirstOrDefault(u => u.Login == login.Text && u.Password == password.Text);
            if (correct != null)
            {

                string fio=string.Concat(correct.FirstName,"  ", correct.LastName);
                Application.Current.Properties["Name"] = fio;
                Application.Current.Properties["Role"] = correct.IDUserType;
                Windows.Choose choose = new Windows.Choose();
                choose.Show();
                this.Close();
            }
            if( login.Text=="" && password.Text=="")
            {
                Windows.Choose choose = new Windows.Choose();
       
                choose.Show();
                this.Close();
            }
        }

        private void password_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void signin_Click(object sender, RoutedEventArgs e)
        {
            Windows.Registration registration = new Windows.Registration();

            registration.Show();
            this.Close();

        }
    }
}