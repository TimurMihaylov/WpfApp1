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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Page
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(TxbLogin.Text == "1")
            {
                FrameApp.frmObj.Navigate(new UserPage());
            }
            if (TxbLogin.Text == "2")
            {
                FrameApp.frmObj.Navigate(new Admin());
            }
            {

            }
        }
            private void Button_Click_1(object sender, RoutedEventArgs e)
            {
                FrameApp.frmObj.Navigate(new Register());
            }
        }
    }
