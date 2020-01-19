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

namespace PL
{
    /// <summary>
    /// Interaction logic for HostingUnitFirstWindow.xaml
    /// </summary>
    public partial class HostingUnitFirstWindow : Window
    {
        public static BL.Bl_imp bbb = new BL.Bl_imp();
        public List<BE.GuestRequest> guestRequestList;
        public List<BE.BankBranch> BankBranchList;
        public List<BE.HostingUnit> HostingUnitList;
        public static List<BE.Order> OrderList;
        public HostingUnitFirstWindow()
        {
            InitializeComponent();
            guestRequestList = bbb.getAllGuestsRequestsList();
            BankBranchList = bbb.getAllBankBranchesInIsraelList();
            HostingUnitList = bbb.getAllHostingUnitsList();
            OrderList = bbb.getAllOrdersList();


            lvgetAllGuestsRequestsList.ItemsSource = guestRequestList;
            lvgetAllBankBranchesInIsraelList.ItemsSource = BankBranchList;
            lvgetAllOrdersList.ItemsSource = OrderList;
            lvgetAllHostingUnitsList.ItemsSource = HostingUnitList;
        }
    }
}
