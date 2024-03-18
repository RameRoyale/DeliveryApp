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

namespace DeliveryApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnRegistration_Click(object sender, RoutedEventArgs e)
        {
            Registration a = new Registration();
            a.Show();
            this.Close();
        }

        private void BtnLogin_CLick(object sender, RoutedEventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var currentUser = db.User.FirstOrDefault(p => p.login == login.Text && p.password == password.Password);

                if (currentUser != null)
                {
                    if (currentUser.type_user == "Admin" || currentUser.type_user == "admin"  || currentUser.type_user == "Administrator" || currentUser.type_user == "administrator"
                         || currentUser.type_user == "Админ" || currentUser.type_user == "Администратор" || currentUser.type_user == "админ" || currentUser.type_user == "администратор")
                    {
                        DataGrid task = new DataGrid();
                        task.Show();
                        this.Close();
                    }
                    else
                    {
                        Captcha task = new Captcha();
                        task.Show();
                        this.Close();
                    }
                }
            }
        }
    }
}
