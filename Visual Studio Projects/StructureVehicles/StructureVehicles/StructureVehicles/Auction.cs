using System;
using System.Collections.Generic;
using System.Text;

namespace StructureVehicles
{
    class Auction
    {
        public Auction(Vehicle V, ISeller S, decimal price)
        {
            this.bid = price;
            this.vehicle = V;
            this.seller = (User)S;
        }

        public decimal Bid
        {
            get { }
            set { }
        }
        private decimal bid;

        public User Seller
        {
            get; 
        }
        private User seller;
        //get { return cprNumber; }
        //set { cprNumber = value; }
        public User Buyer
        {
            get { }
            set { }
        }
        private User buyer;

        public Vehicle Vehicle
        {
            get; 
        }
        public Vehicle vehicle;

        internal User User
        {
            get => default;
            set
            {
            }
        }
    }
}
