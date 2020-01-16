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
    /// Interaction logic for PrivateAreaHost.xaml
    /// </summary>
    public partial class PrivateAreaHost : Window
    {
        public PrivateAreaHost()
        {
            InitializeComponent();

             BL.Bl_imp b = new BL.Bl_imp();
            List<BE.BankBranch> BankBranchList = b.getAllBankBranchesInIsraelList();



            listorders.ItemsSource = BankBranchList;
        }
    }
}
