using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Project
{
    class Database
    {
        static public List<Customer> customers = new List<Customer>();//creates list for customers
        
        public Database()//default constructor for dattabase
        {
        }
        public void addCustomer(string name, string street, string city, string state, string zip, string directions, string payment, string phoneNumber)//adds customers to the database
        {
            Customer newCustomer = new Customer(name, street, city, state, zip, directions, payment, phoneNumber);
            customers.Add(newCustomer);
        }

        public void addCustomer(Customer c)
        {
            customers.Add(c);
        }
        public Customer findPhoneNumber(string pn)//search for customer based on phone number
        {
            foreach(Customer c in customers)//goes through all customers in the database
            {
                if(c.getPhoneNumber() == pn)//if the customer's phonenumber = entered pnonumber
                {
                    Customer customer = c;//set cus to c
                    return customer;//return customer
                }
            }
            return null;
        }
    }
}
