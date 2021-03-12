using System;
using System.Collections.Generic;
using System.Text;

namespace StructureVehicles
{
    class Auction
    {
        public Auction(Vehicle V, ISeller S, decimal price)
        {
            //Auction Constructor
            this.bid = price;
            this.vehicle = V;
            this.seller = (User)S;
        }
        /// <summary>
        /// Bid Field and proberty
        /// </summary>
        public decimal Bid
        {
            get => default;
            set { }
        }
        private decimal bid;

        /// <summary>
        /// User Seller Field and proberty
        /// </summary>
        public User Seller
        {
            get; 
        }
        private User seller;

        /// <summary>
        /// User Buyer Field and proberty
        /// </summary>
        public User Buyer
        {
            get => default;
            set { }
        }
        private User buyer;

        /// <summary>
        /// "Vehicles" Field and proberty
        /// </summary>
        public Vehicle Vehicle
        {
            get; 
        }
        public Vehicle vehicle;
    }
}
