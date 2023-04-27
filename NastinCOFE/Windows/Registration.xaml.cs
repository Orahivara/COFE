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
using System.Windows.Shapes;
using NastinCOFE.ClassHelper;
using NastinCOFE.DB;

namespace NastinCOFE.Windows
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {

        List<DB.User> users = new List<DB.User>();
        List<DB.Gender> genders = new List<DB.Gender>();
        List<DB.UserType> typeuser = new List<DB.UserType>();
        public int types;
        public Registration()
        {
       
            InitializeComponent();

            type.ItemsSource=HELP.Context.UserType.ToList();
            type.SelectedIndex = 1;

            type.DisplayMemberPath = "NameTypeOfUser";
          
            sex.ItemsSource = HELP.Context.Gender.ToList();
            sex.SelectedIndex = 1;

            sex.DisplayMemberPath = "NameOfGender";


        }
        private void type_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedState = type.SelectedItem.ToString();
        }

        private void end_Click(object sender, RoutedEventArgs e)
        {
            User adduser = new User();
            if (FIO.Text != "" && login.Text != "" && password.Text != "" && email.Text != "" && phone.Text != "")

            {
                string text = loh.Text;


                string[] name = FIO.Text.Split(new char[] { ' ' });
                adduser.FirstName = name[1];
                adduser.LastName = name[0];
                adduser.Patronimic = name[2];
                adduser.Email = email.Text;
                adduser.Phone = phone.Text;
                adduser.Login = login.Text;
                adduser.Password = password.Text;
                adduser.IDUserType = (type.SelectedItem as DB.UserType).IDType;
                adduser.IDGender = (sex.SelectedItem as DB.Gender).IDGender;
                Application.Current.Properties["Role"] = (type.SelectedItem as DB.UserType).IDType;

                HELP.Context.User.Add(adduser);

                HELP.Context.SaveChanges();
                PlaceOrder placeOrder = new PlaceOrder();
                placeOrder.Show();
                this.Close();



            }
        }

      

    }
}