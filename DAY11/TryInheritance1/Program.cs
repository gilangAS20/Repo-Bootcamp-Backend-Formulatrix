// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Collections;

class TryInheritance1
{
    class InheritanceProgram
    {
        static void Main()
        {
            // make new instance "myPhone1" from class "PhoneIdentity"
            PhoneIdentity myPhone1 = new();
            myPhone1.SetPhoneID = 1;
            myPhone1.SetBrandCode = 'A';
            myPhone1.SetBrandName = "Samsung";
            myPhone1.SetPhoneName = "Galaxy S21";

            System.Console.WriteLine("Phone ID: " + myPhone1.SetPhoneID);
            System.Console.WriteLine("Brand Code: " + myPhone1.SetBrandCode);
            System.Console.WriteLine("Brand Name: " + myPhone1.SetBrandName);
            System.Console.WriteLine("Phone Name: " + myPhone1.SetPhoneName);
            System.Console.WriteLine("Phone Count: " + myPhone1.GetPhoneCount);

            //=========================================================================

            CustomerIdentity myPhone2 = new();
            myPhone2.SetPhoneID = 2;
            myPhone2.SetBrandCode = 'B';
            myPhone2.SetBrandName = "Vivo";
            myPhone2.SetPhoneName = "V20 pro";
            myPhone2.SetCustomerId = 1;
            myPhone2.SetCustomerName = "Tomy Setiawan";
            myPhone2.SetCustomerAge = 150;
            myPhone2.SetCustomerAddress = "Sidorejo Lor, Salatiga";

            System.Console.WriteLine("\nPhone ID: " + myPhone2.SetPhoneID);
            System.Console.WriteLine("Brand Code: " + myPhone2.SetBrandCode);
            System.Console.WriteLine("Brand Name: " + myPhone2.SetBrandName);
            System.Console.WriteLine("Phone Name: " + myPhone2.SetPhoneName);
            System.Console.WriteLine("Customer ID: " + myPhone2.SetCustomerId);
            System.Console.WriteLine("Customer Name: " + myPhone2.SetCustomerName);
            System.Console.WriteLine("Customer Age: " + myPhone2.SetCustomerAge);
            System.Console.WriteLine("Customer Address: " + myPhone2.SetCustomerAddress);
            System.Console.WriteLine("Phone Count: " + myPhone2.GetPhoneCount);


        }
    }

    public class PhoneIdentity
    {
        private int _phoneID = 0;
        private char _brandCode = '-';
        private string _brandName = "Unknown Brand";
        private string _phoneName = "Unknown Phone";

        public static int _phoneCount = 0;

        public PhoneIdentity()
        {
            _phoneCount += 1;
        }
        public int GetPhoneCount
        {
            get
            {
                return _phoneCount;
            }
        }

        public int SetPhoneID
        {
            get
            {
                return _phoneID;
            }
            set
            {
                _phoneID = value;
            }
        }

        public char SetBrandCode
        {
            get
            {
                return _brandCode;
            }
            set
            {
                _brandCode = value;
            }
        }

        public string SetBrandName
        {
            get
            {
                return _brandName;
            }
            set
            {
                _brandName = value;
            }
        }

        public string SetPhoneName
        {
            get
            {
                return _phoneName;
            }
            set
            {
                _phoneName = value;
            }
        }
        
    } // end of class PhoneIdentity

    public class CustomerIdentity : PhoneIdentity
    {
        private int _customerId = 0;
        private string _customerName = "No Name";
        private int _customerAge = 0;
        private string _customerAddress = "No Address";

        public int SetCustomerId
        {
            get{return _customerId;}
            set{_customerId = value;}
        }

        public string SetCustomerName
        {
            get{return _customerName;}
            set{_customerName = value;}
        }

        public int SetCustomerAge
        {
            get{return _customerAge;}
            set{_customerAge = value;}
        }

        public string SetCustomerAddress
        {
            get{return _customerAddress;}
            set{_customerAddress = value;}
        }

    }
}
