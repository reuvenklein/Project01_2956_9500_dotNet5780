using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BL
{
    public class Bl_imp : IBL
    {
        public void addGuestRequest(GuestRequest guestRequest)
        {
            if (!(guestRequest.EntryDate<guestRequest.ReleaseDate))
            {
                throw new Exception("Entry date must be at least one day earlier than release date.");
            }
        }

        public void addHostingUnit(HostingUnit hostingUnit)
        {
        }

        public void addOrder(BE.GuestRequest guestRequest)
        {
           
        }

        public void delleteHostingUnit(HostingUnit hostingUnit)
        {
        }

        public List<BankBranch> getAllBankBranchesInIsraelList()
        {
            DAL.Dal_imp a = new DAL.Dal_imp();
            return a.getAllBankBranchesInIsraelList();
        }

        public List<GuestRequest> getAllGuestsRequestsList()
        {
            DAL.Dal_imp a = new DAL.Dal_imp();
            return a.getAllGuestsRequestsList();
        }

        public List<HostingUnit> getAllHostingUnitsList()
        {
            DAL.Dal_imp a = new DAL.Dal_imp();
            return a.getAllHostingUnitsList();
        }

        public List<Order> getAllOrdersList()
        {
            DAL.Dal_imp a = new DAL.Dal_imp();
            return a.getAllOrdersList();
        }

        public void updateGuestRequest(GuestRequest guestRequest)
        {
            throw new NotImplementedException();
        }

        public void updateHostingUnit(HostingUnit hostingUnit)
        {
            throw new NotImplementedException();
        }

        public void updateOrder(Order order)
        {
            if (order.Status == BE.enum_s.orderStatus.נסגר_בהיענות_של_הלקוח)
            {
                throw new Exception("After the order status has changed to 'closing a deal' it is forbidden toto change the order status anymore.");
            }
            else
            {

            }

        }
    }
}
