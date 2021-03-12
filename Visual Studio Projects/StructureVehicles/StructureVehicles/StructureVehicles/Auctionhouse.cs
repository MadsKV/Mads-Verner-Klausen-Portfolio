using System;
using System.Collections.Generic;
using System.Text;

namespace StructureVehicles
{
    class Auctionhouse
    {
        //For Sale method for ListOfAuctionCars
        public static Auction ForSale(Vehicle V, ISeller S, decimal price)
        {
            Auction auction = new Auction(V, S, price);
            auction.Vehicle.ToString();

            return auction;
        }
        //BitNotification method from buyers to sellers
        public static int BidNotification(ISeller buyer, Auction auctionList, decimal bid)
        {
            throw new NotImplementedException();
        }
        //BidAccepted method from Sellers to Buyers
        public static int BidAccepted(ISeller seller, Auction auctionList)
        {
            throw new NotImplementedException();
        }

        public List<Vehicle> V;
    }
}
