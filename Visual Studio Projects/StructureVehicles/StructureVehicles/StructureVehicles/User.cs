using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace StructureVehicles
{
    abstract class User : ISeller, IBuyer
    {
        public User(string firstName,
        string lastName,
        string address,
        int phoneNumber,
        int zipCode,
        decimal balance)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.ZipCode = zipCode;
            this.Balance = balance;
        }
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"{nameof(value)}");
                }
                firstName = value;
            }
        }
        private string firstName;

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"{nameof(value)}");
                }
                lastName = value;
            }
        }
        private string lastName;

        public string Address
        {
            get { return address; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"{nameof(value)}");
                }
                address = value;
            }
        }
        private string address;

        public int PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                var r = new Regex(@"^\d{8}$");
                if (!r.IsMatch(value.ToString()))
                    throw new Exception("Telefon nummer er ikke gyldigt!");
                else
                    phoneNumber = value;
            }
        }
        private int phoneNumber;

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        private decimal balance;

        public int ZipCode
        {
            get { return zipCode; }
            set
            {
                var r = new Regex(@"^\d{4}$");
                if (!r.IsMatch(value.ToString()))
                    throw new Exception("Zip Code er ikke gyldigt!");



                else
                    zipCode = value;
            }
        }
        private int zipCode;





        //public int CPRNumber
        //{
        //    get { return cprNumber; }
        //    set { cprNumber = value; }
        //}
        //private int cprNumber;
        //public int ZipCode
        //{
        //    get { return ZipCode; }
        //    set
        //    {
        //        var r = new Regex(@"\d{4}$");
        //        if (!r.IsMatch(value.ToString()))
        //            throw new Exception("Zipcode not valid!");
        //    }
        //}
        //private int Zipcode;
        //public string FirstName
        //{
        //    get { return firstName; }
        //    set { firstName = value; }
        //}
        //private string firstName;
        //public string LastName
        //{
        //    get { return lastName; }
        //    set { lastName = value; }
        //}
        //private string lastName;
        //public decimal Balance
        //{
        //    get { return balance; }
        //    set { balance = value; }
        //}
        //private decimal balance;

        public new virtual string ToString()
        {
            return String.Format("\n {0}: {1}\n {2}: {3}\n {4}: {5}\n {6}: {7}\n {8}: {9}\n {10}: {11}",
                nameof(this.firstName),
                this.firstName,
                nameof(this.LastName),
                this.LastName,
                nameof(this.address),
                this.Address,
                nameof(this.PhoneNumber),
                this.PhoneNumber,
                nameof(this.ZipCode),
                this.ZipCode,
                nameof(this.Balance),
                this.Balance.ToString()
                );
        }

        internal Auction Auction
        {
            get => default;
            set
            {
            }
        }
    }

    class corporateUser : User
    {
        public corporateUser(string firstName,
            string lastName,
            string address,
            int phoneNumber,
            int zipCode,
            decimal balance,
            int cvrNumber,
            int credit
            ) : base(firstName, lastName, address, phoneNumber, zipCode, balance)
        {
            this.CVRNumber = cvrNumber;
            this.Credit = credit;
        }
        public int CVRNumber
        {
            get { return cvrNumber; }
            set
            {
                var r = new Regex(@"^\d{8}$");
                if (!r.IsMatch(value.ToString()))
                {
                    throw new Exception("CVR is not correct");
                }
            }
        }
        private int cvrNumber;
        
        public int Credit
        {
            get { return credit; }
            set { credit = value; }
        }
        private int credit;


        public override string ToString()
        {
            return base.ToString() + string.Format("\n {0}: {1}\n",
                    nameof(this.CVRNumber),
                    this.cvrNumber
                    );
        }
    }

    class privateUser : User
    {
        public privateUser(string firstName,
            string lastName,
            string address,
            int phoneNumber,
            int zipCode,
            decimal balance,
            int cprNumber) : base(firstName, lastName, address, phoneNumber, zipCode, balance)
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

        //public int Credit
        //{
        //    get { return credit; }
        //    set { credit = value; }
        //}
        //private int credit;

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
