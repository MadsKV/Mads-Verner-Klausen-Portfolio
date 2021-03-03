using System;
using System.Collections.Generic;
using System.Text;

namespace StructureVehicles
{
    abstract class User : ISeller, IBuyer
    {
        private decimal Balance;
        private string firstName;
        private string lastName;
        private string address;
        private int phoneNumber;

        public User(int zipCode,
            decimal balance)
        {
            this.ZipCode = zipCode;
            this.Balance = 0.00M;
        }

        public int ZipCode
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public int Zipcode;

    }

    class corporateUser : User
    {
        public CorporateUser(int cvrNumber,
            int credit,
            int zipCode,
            decimal balance) : base(zipCode, balance)
        {
            this.CVRNumber = cvrNumber;
            this.Credit = credit;
        }

        public int CVRNumber
        {
            get { return cvrNumber; }
            set { cvrNumber = value; }
        }
        public int cvrNumber;

    }
    class privateUser : User
    {
        public PrivateUser(int cprNumber,
            int zipCode,
            decimal balance) : base(zipCode, balance)
        {
            this.CPRNumber = cprNumber;
        }
        public int CPRNumber
        {
            get { return cprNumber; }
            set { cprNumber = value; }
        }
        public int cprNumber;

    }

}
