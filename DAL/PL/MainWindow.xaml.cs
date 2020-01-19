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
        public static BL.Bl_imp bbb= new BL.Bl_imp();
        List<BE.GuestRequest> guestRequestList;
        List<BE.BankBranch> BankBranchList;
        List<BE.HostingUnit> HostingUnitList;
        public static List<BE.Order> OrderList;


        public MainWindow()
        {
            InitializeComponent();
            guestRequestList = bbb.getAllGuestsRequestsList();
            BankBranchList = bbb.getAllBankBranchesInIsraelList();
            HostingUnitList = bbb.getAllHostingUnitsList();
            OrderList = bbb.getAllOrdersList();

            //lvgetAllGuestsRequestsList.ItemsSource = guestRequestList;
            //lvgetAllBankBranchesInIsraelList.ItemsSource = BankBranchList;
            //lvgetAllOrdersList.ItemsSource = OrderList;
            //lvgetAllHostingUnitsList.ItemsSource = HostingUnitList;

            this.Height = (System.Windows.SystemParameters.PrimaryScreenHeight * 0.89);
            this.Width = (System.Windows.SystemParameters.PrimaryScreenWidth * 0.89);


        }
    

        private void LoginFlyout_KeyDown(object sender, KeyEventArgs e)
        {


        }

        private void LoginFlyoutBtn_Click(object sender, RoutedEventArgs e)
        {
            if ((UserName.Text == "a") && (Password.Password == "1"))
            {
                PrivateAreaHost s = new PrivateAreaHost();
                s.Height = (System.Windows.SystemParameters.PrimaryScreenHeight * 0.89);
                s.Width = (System.Windows.SystemParameters.PrimaryScreenWidth * 0.89);
                s.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Wrong Input");
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            PrivateAreaHost p1 = new PrivateAreaHost();
            p1.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddHostingUnitHost p1 = new AddHostingUnitHost();
            p1.Show();
        }
    }
}