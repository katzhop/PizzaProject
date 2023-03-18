using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class CustomerInfo : Form
    {
        Customer customer;//creates customer
        Orders order = new Orders();//creates order
        Database db = new Database();//creates database
        bool newc = false;//create if new customer
        string type;//create order type 
        public CustomerInfo()//default constructor for customer info
        {
            InitializeComponent();//creates screen with all the buttons and etc.
        }
        public CustomerInfo(Customer cust, Orders ord, string ty)//constructor for customer info with customer, order, and order type
        {
            InitializeComponent();//creates screen with all the buttons and etc.
            customer = cust;//sets customer
            order = ord;//sets order
            type = ty;//sets type
            nametextBox.Text = customer.getName();//sets textbox to name
            phonenumbertextBox.Text = customer.getPhoneNumber();//sets textbox to phonenumber
            streettextBox.Text = customer.getStreet();//sets textbox to street address
            statetextBox.Text = customer.getState();//sets textbox to state
            citytextBox.Text = customer.getCity();//sets textbox to city
            ziptextBox.Text = customer.getZipCode();//sets textbox to zipcode
            paymenttypetextBox.Text = customer.getPayment();//sets textbox to payment type
        }
        public CustomerInfo(Customer cust, Orders ord, string ty, bool ne)//constructor for customer info with customer, order, and order type
        {
            InitializeComponent();//creates screen with all the buttons and etc.
            customer = cust;//sets customer
            order = ord;//sets order
            type = ty;//sets type
            newc = ne;//sets new customer

        }
        private void homebutton_Click(object sender, EventArgs e)//define what happens when the home button is clicked
        {
            this.Hide();//hides current screen
            var newForm = new HomeScreen();//creates homescreen
            newForm.Show();//shows homescreen
            this.Close();//closes current screen
        }

        private void backbutton_Click(object sender, EventArgs e)//define what happens when the back button is clicked
        {
            if(newc == true)//if new customer go to retrun screen
            {
                this.Hide();//hides current screen
                var newForm = new Return(order, type);//creates return screen with order and type
                newForm.Show();//shows return screen
                this.Close();//closes current screen
            }
            else
            {
                this.Hide();//hides current screen
                var newForm = new login(order, type);//creates login screen
                newForm.Show();//shows login screen
                this.Close();//closes current screen
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nametextBox_TextChanged(object sender, EventArgs e)//define what happens when the name textbox is changed
        {
            customer.setName(nametextBox.Text);//sets customer name
        }

        private void phonenumbertextBox_TextChanged(object sender, EventArgs e)//define what happens when the phonenumber textbox is changed
        {
            customer.setPhoneNumber(phonenumbertextBox.Text);//sets customer phonenumber
        }

        private void statetextBox_TextChanged(object sender, EventArgs e)//define what happens when the state textbox is changed
        {
            customer.setState(statetextBox.Text);//sets customer state
        }

        private void citytextBox_TextChanged(object sender, EventArgs e)//define what happens when the city textbox is changed
        {
            customer.setCity(citytextBox.Text);//sets customer city
        }

        private void streettextBox_TextChanged(object sender, EventArgs e)//define what happens when the street textbox is changed
        {
            customer.setStreet(streettextBox.Text);//sets customer street 
        }

        private void ziptextBox_TextChanged(object sender, EventArgs e)//define what happens when the zipcode textbox is changed
        {
            customer.setZipCode(ziptextBox.Text);//sets customer zipcode
        }

        private void paymenttypetextBox_TextChanged(object sender, EventArgs e)//define what happens when the payment type textbox is changed
        {
            customer.setPayment(paymenttypetextBox.Text);//sets customer payment type
        }

        private void line2textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void continuebutton_Click(object sender, EventArgs e)//define what happens when the continue button is clicked
        {
            db.addCustomer(customer);//add customer to the database
            this.Hide();//hide current screen
            var newForm = new Confimation(order, type);//create confirmation screen with order and type
            newForm.Show();//show confirmation screen
            this.Close();//closes current screen
        }
    }
}
