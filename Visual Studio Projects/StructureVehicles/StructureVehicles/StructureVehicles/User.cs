using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace StructureVehicles
{
    abstract class User : ISeller, IBuyer
    {
        public User( int CPRNumber,
            int zipCode,
            string firstName,
            string lastName,
            decimal balance)
        {
            this.CPRNumber = cprNumber;
            this.ZipCode = zipCode;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Balance = 0.00M;
        }
        public int CPRNumber
        {
            get { return cprNumber; }
            set { cprNumber = value; }
        }
        private int cprNumber;
        public int ZipCode
        {
            get { return ZipCode; }
            set
            {
                var r = new Regex(@"\d{4}$");
                if (!r.IsMatch(value.ToString()))
                    throw new Exception("Zipcode not valid!");
            }
        }
        private int Zipcode;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private string firstName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        private string lastName;
        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        private decimal balance;

        public override string ToString()
        {
            return base.ToString() + string.Format("\n {0}: {1}\n {2}: {3}\n {4}: {5}\n {6}: {7}\n {8}: {9}",
                    nameof(this.Towbar),
                    this.Towbar
                    );
        }
    }

    class corporateUser : User
    {
        public CorporateUser(int cvrNumber,
            int credit,
            int zipCode,
            decimal balance
            ) : base(CPRNumber, zipCode, firstName, lastName, balance)
        {
            this.CVRNumber = cvrNumber;
            this.Credit = credit;
            this.ZipCode = zipCode;
            this.Balance = balance;
        }
        
        public int Credit
        {
            get { return credit; }
            set { credit = value; }
        }
        private int credit;

        public int CVRNumber
        {
            get { return cvrNumber; }
            set { cvrNumber = value; }
        }
        private int cvrNumber;

        public override string ToString()
        {
            return base.ToString() + string.Format("\n {0}: {1}\n {2}: {3}\n {4}: {5}\n {6}: {7}\n {8}: {9}",
                    nameof(this.Towbar),
                    this.Towbar
                    );
        }
    }

    class privateUser : User
    {
        public PrivateUser(string firstName,
            string lastName,
            string address,
            int phoneNumber,
            int zipCode,
            decimal balance,
            int cprNumber) : base(firstName, lastName, address, phoneNumber, zipCode, firstName, lastName, balance)
        {
            this.CPRNumber = cprNumber;
        }
        public int PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                var r = new Regex(@"^[a-zA-Z]{2}\d{5}$");
                if (!r.IsMatch(value.ToString()))
                {
                    throw new Exception("Phonenumber is not correct");
                }
                phoneNumber = value;
            }
        }
        private int phoneNumber;

        public int CPRNumber
        {
            get { return cprNumber; }
            set
            {
                var r = new Regex(@"^\d{10}$");
                if (!r.IsMatch(value.ToString()))
                {
                    throw new Exception("CPR is not correct");
                }
                cprNumber = value;
            }
        }
        private int cprNumber;

        public int Credit
        {
            get { return credit; }
            set { credit = value; }
        }
        private int credit;

        //public int CVRNumber
        //{
        //    get { return cvrNumber; }
        //    set { cvrNumber = value; }
        //}
        //private int cvrNumber;


        public override string ToString()
        {
            return base.ToString() + string.Format("\n {0}: {1}\n",
                    nameof(this.CPRNumber),
                    this.CPRNumber
                    );
        }
    }

}
