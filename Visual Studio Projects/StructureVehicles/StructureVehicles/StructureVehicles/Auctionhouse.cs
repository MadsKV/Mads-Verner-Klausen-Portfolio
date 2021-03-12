using System;
using System.Collections.Generic;
using System.Text;

namespace StructureVehicles
{
    class Auctionhouse
    {

        public static Auction ForSale(Vehicle V, ISeller S, decimal price)
        {
            Auction auction = new Auction(V, S, price);
            auction.Vehicle.ToString();

            return auction;
        }

        public static int BidNotification(ISeller buyer, Auction auctionList, decimal bid)
        {
            throw new NotImplementedException();
        }
        public static int BidAccepted(ISeller seller, Auction auctionList)
        {
            throw new NotImplementedException();
        }

        public List<Vehicle> V;
    }
}
