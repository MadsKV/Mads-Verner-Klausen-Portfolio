using System;
using System.Collections.Generic;
using System.Text;

namespace StructureVehicles
{
    class Auctionhouse
    {

        public int ForSale(Vehicle V, ISeller S, decimal price)
        {
            throw new NotImplementedException();
        }

        public int BidNotification(ISeller buyer, int auctionList, decimal bid)
        {
            throw new NotImplementedException();
        }
        public int BidAccepted(ISeller seller, int auctionList)
        {
            throw new NotImplementedException();
        }

        public List<Vehicle> V;
    }
}
