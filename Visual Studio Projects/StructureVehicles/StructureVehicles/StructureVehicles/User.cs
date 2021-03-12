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
            //User Constructor
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.ZipCode = zipCode;
            this.Balance = balance;
        }
        /// <summary>
        /// FirstName Field and proberty
        /// </summary>
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

        /// <summary>
        /// LastName Field and proberty
        /// </summary>
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

        /// <summary>
        /// Address Field and proberty
        /// </summary>
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

        /// <summary>
        /// PhoneNumber Field and proberty
        /// </summary>
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

        /// <summary>
        /// Balance Field and proberty
        /// </summary>
        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        private decimal balance;

        /// <summary>
        /// ZipCode Field and proberty
        /// </summary>
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

        /// <summary>
        /// String.Format ToString
        /// </summary>
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
        //inherited C-user from user
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
            //CorporateUser Constructor
            this.CVRNumber = cvrNumber;
            this.Credit = credit;
        }
        /// <summary>
        /// CVRNumber Field and proberty
        /// </summary>
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

        /// <summary>
        /// Credit Field and proberty
        /// </summary>
        public int Credit
        {
            get { return credit; }
            set { credit = value; }
        }
        private int credit;

        /// <summary>
        /// String.Format ToString
        /// </summary>
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
        //inherited P-user from user
        public privateUser(string firstName,
            string lastName,
            string address,
            int phoneNumber,
            int zipCode,
            decimal balance,
            int cprNumber) : base(firstName, lastName, address, phoneNumber, zipCode, balance)
        {
            //privateUser Constructor
            this.CPRNumber = cprNumber;
        }
        /// <summary>
        /// PhoneNumber Field and proberty
        /// </summary>
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

        /// <summary>
        /// CPRNumber Field and proberty
        /// </summary>
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

        /// <summary>
        /// String.Format ToString
        /// </summary>
        public override string ToString()
        {
            return base.ToString() + string.Format("\n {0}: {1}\n",
                    nameof(this.CPRNumber),
                    this.CPRNumber
                    );
        }
    }
}
