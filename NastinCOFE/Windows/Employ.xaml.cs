using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для Employ.xaml
    /// </summary>
    public partial class Employ : Window
    {
       // List<DB.User> users = new List<DB.User>();
        public Employ()
        {
            InitializeComponent();
            listview.ItemsSource = HELP.Context.User.ToList();
          
     
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            User deleteuser = new User();

            deleteuser.Equals(listview.SelectedItem);
            HELP.Context.User.Remove(deleteuser);
        }
    }
    }

