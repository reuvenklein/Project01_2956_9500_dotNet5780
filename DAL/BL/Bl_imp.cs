using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BL
{
    class Bl_imp : IBL
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
            throw new NotImplementedException();
        }

        public void addOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public void delleteHostingUnit(HostingUnit hostingUnit)
        {
            throw new NotImplementedException();
        }

        public List<BankBranch> getAllBankBranchesInIsraelList()
        {
            throw new NotImplementedException();
        }

        public List<GuestRequest> getAllGuestsRequestsList()
        {
            throw new NotImplementedException();
        }

        public List<HostingUnit> getAllHostingUnitsList()
        {
            throw new NotImplementedException();
        }

        public List<Order> getAllOrdersList()
        {
            throw new NotImplementedException();
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
