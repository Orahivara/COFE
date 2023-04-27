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
    /// Логика взаимодействия для Clients.xaml
    /// </summary>
    public partial class Clients : Window
    {
        public Clients()
        {
            InitializeComponent();
            
            list.ItemsSource = HELP.Context.Gender.ToList();
            list.SelectedIndex = 1;

            list.DisplayMemberPath = "NameOfGender";
            
        }
    }
}
