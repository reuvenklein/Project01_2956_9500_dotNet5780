using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    class Dal_imp : Idal
    {
        public void addGuestRequest(GuestRequest guestRequest)
        {
            DS.DataSource.guestRequestList.Add(guestRequest);
        }

        public void addHostingUnit(HostingUnit hostingUnit)
        {
            DS.DataSource.hostingUnitList.Add(hostingUnit);

        }

        public void addOrder(Order order)
        {
            DS.DataSource.orderList.Add(order);

        }

        public void delleteHostingUnit(HostingUnit hostingUnit)
        {
           
                    DS.DataSource.hostingUnitList.Remove(hostingUnit);

        }

        public List<BankBranch> getAllBankBranchesInIsraelList()
        {
            throw new NotImplementedException();
        }

        public List<GuestRequest> getAllGuestsRequestsList()
        {
            return DS.DataSource.guestRequestList;
        }

        public List<HostingUnit> getAllHostingUnitsList()
        {
            return DS.DataSource.hostingUnitList;
        }

        public List<Order> getAllOrdersList()
        {
            return DS.DataSource.orderList;
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
            throw new NotImplementedException();
        }
    }
}
