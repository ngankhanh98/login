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

namespace login
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string username = "admin";
        string password = "123";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string input_user = txtUsername.Text;
            string input_password = txtPassword.Password;

            if (input_user==""||input_password == "")
            {
                lblError.Content = "Empty username or password not allowed";
            }
            else if (input_user != username || input_password != password)
            {
                lblError.Content = "Incorrect username or password";
            }
            else
            {
                var dashboard = new Dashboard();
                this.Close();
                dashboard.ShowDialog();
                
            }
        }
    }
}
