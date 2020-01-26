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
using System.Windows.Media.Animation;


namespace PL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        


        public MainWindow()
        {
            InitializeComponent();
          

            this.Height = (System.Windows.SystemParameters.PrimaryScreenHeight * 0.89);
            this.Width = (System.Windows.SystemParameters.PrimaryScreenWidth * 0.89);


        }
    

        private void LoginFlyout_KeyDown(object sender, KeyEventArgs e)
        {


        }

        private void LoginFlyoutBtn_Click(object sender, RoutedEventArgs e)
        {
            if ((UserName.Text == "reuven") && (Password.Password == "1234"))
            {
                HostingUnitFirstWindow s = new HostingUnitFirstWindow();
                s.Height = (System.Windows.SystemParameters.PrimaryScreenHeight * 0.89);
                s.Width = (System.Windows.SystemParameters.PrimaryScreenWidth * 0.89);
                s.Show();

            }
            else if ((UserName.Text == "b") || (Password.Password == "b"))
            {
                GuestRequestFirstWindow s = new GuestRequestFirstWindow();
                s.Height = (System.Windows.SystemParameters.PrimaryScreenHeight * 0.89);
                s.Width = (System.Windows.SystemParameters.PrimaryScreenWidth * 0.89);
                s.Show();

            }
            else if ((UserName.Text == "c") || (Password.Password == "c"))
            {
                WebsiteManagerFirstWindow s = new WebsiteManagerFirstWindow();
                s.Height = (System.Windows.SystemParameters.PrimaryScreenHeight * 0.89);
                s.Width = (System.Windows.SystemParameters.PrimaryScreenWidth * 0.89);
                s.Show();

            }
            else
            {
                MessageBox.Show("Wrong Input");
            }
        }
      

      
    }
}