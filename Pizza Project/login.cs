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
    public partial class login : Form
    {
        Customer customer;
        Orders order = new Orders();//creates orders
        Database db = new Database();//creates database
        string pn;//creates phonenumber
        string type;//creates order type
        public login()//default constructor for login
        {
            InitializeComponent();//creates screen with all the buttons and etc.
        }
        public login(Orders or, string ty)//constructor for login with order and order type
        {
            InitializeComponent();//creates screen with all the buttons and etc.
            order = or;//sets order
            type = ty;//sets type
        }

        private void continuebutton_Click(object sender, EventArgs e)//define what happens when the continue button is clicked
        {
            this.Hide();//hide current screen
            var newForm = new Confimation(order, type);//create confirmation screen with order and type
            newForm.Show();//shows confirmation screen
            this.Close();//closes current screen
        }

        private void backbutton_Click(object sender, EventArgs e)//define what happens when the back button is clicked
        {
            this.Hide();//hides current screen
            var newForm = new Return(order, type);//creates return screen with order and type
            newForm.Show();//show return screen
            this.Close();//closes current screen
        }

        private void homebutton_Click(object sender, EventArgs e)//define what happens when the continue button is clicked
        {
            this.Hide();//hides current screen
            var newForm = new HomeScreen();//creates homescreen
            newForm.Show();//show homescreen
            this.Close();//closes current screen
        }

        private void editbutton_Click(object sender, EventArgs e)//define what happens when the edit button is clicked
        {
            this.Hide();//hides current screen
            var newForm = new CustomerInfo(customer, order, type);//creates customerinfo screen
            newForm.Show();//show customerinfo screen
            this.Close();//closes current screen
        }

        private void nametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void phonenumbertextBox_TextChanged(object sender, EventArgs e)//define what happens when the phonenumber textbox is changed
        {
            pn = phonenumbertextBox.Text;//set phonenumber to input
            customer = db.findPhoneNumber(pn);//search database to customer with phonenumber
            nametextBox.Text = customer.getName();//set text box to sutomer's name
        }
    }
}
