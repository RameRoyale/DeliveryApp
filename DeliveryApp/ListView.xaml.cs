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

namespace DeliveryApp
{
    /// <summary>
    /// Логика взаимодействия для ListView.xaml
    /// </summary>
    public partial class ListView : Window
    {
        public ListView()
        {
            InitializeComponent();
            using (ApplicationContext db = new ApplicationContext())
            {
                var currentList = db.Product.ToList();
                LView.ItemsSource = currentList;
            }

        }

        private void BtnReservation_Click(object sender, RoutedEventArgs e)
        {
            //Reservation task = new Reservation();
            //task.Show();
            //this.Close();
        }
    }
}
