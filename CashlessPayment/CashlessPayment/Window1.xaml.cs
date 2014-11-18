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

namespace CashlessPayment
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void btnManageAccount_Click(object sender, RoutedEventArgs e)
        {
            var myForm = new WachtwoordWijzigen();
            myForm.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var myForm = new AddEditProduct();
            myForm.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var myForm = new AddEditProduct();
            myForm.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var myForm = new AddEditEmployee();
            myForm.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var myForm = new AddEditEmployee();
            myForm.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var myForm = new AddEditRegister();
            myForm.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            var myForm = new AddEditRegister();
            myForm.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            var myForm = new DetailRegister();
            myForm.Show();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            var myForm = new EditKlant();
            myForm.Show();
        }
    }
}
