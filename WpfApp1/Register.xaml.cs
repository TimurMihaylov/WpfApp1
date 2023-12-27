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
    /// Логика взаимодействия для Register.xaml
    /// </summary>
    public partial class Register : Page
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new Auth());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (DbConnect.entObj.Users.Count(x => x.login == TxbLogin.Text) > 0)
            {
                MessageBox.Show("Такой пользователь уже есть!",
                            "Уведомление",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                return;
            }
            else
            {
                try
                {
                    Users userObj = new Users()
                    {
                        login = TxbLogin.Text,
                        pass = PsbPassword.Text,                        
                    };

                    DbConnect.entObj.Users.Add(userObj);
                    DbConnect.entObj.SaveChanges();

                    MessageBox.Show("Пользователь создан!",
                				"Уведомление",
                                MessageBoxButton.OK,
                                MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка работы приложения:" + ex.Message.ToString(), "Уведомление, Критический сбой работы", MessageBoxButton.OK, MessageBoxImage.Warning);
                }

            }




        }
    }
}
