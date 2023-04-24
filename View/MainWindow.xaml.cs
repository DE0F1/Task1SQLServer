using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
using Task1SQLServer.Core;
using Task1SQLServer.View;

namespace Task1SQLServer
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            /*
             try
            {
                DbModelContext.DB.Users.Add(new UserControl()
                {
                    UserLogin = TbLogin.Text,
                    UserPassword = PbPassword.Password,
                    UserPhone = TbPhone.Text,
                    UserEmail = TbEmail.Text
                });
                DbModelContext.DB.SaveChanges();
                MessageBox.Show("Данные успешно сохранены",
                    "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),
                    "Системное сообщение", 
                    MessageBoxButton.OK, MessageBoxImage.Information);
                    }
            }
                */

        }

        private void Run_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            /**/
        }
    }
}

