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
    public partial class Return : Form
    {
        Orders order = new Orders();//create order
        Customer customer;//creates customer
        string type;//create type
        public Return()//default constructor for return
        {
            InitializeComponent();//creates screen with all the buttons and etc.
        }
        public Return(Orders or, string ty)//constructor for retun with order and type
        {
            InitializeComponent();//creates screen with all the buttons and etc.
            order = or;//sets order
            type = ty;//sets type
        }

        private void returningbutton_Click(object sender, EventArgs e)//define what happens when the returning button is clicked
        {
            this.Hide();//hide current screen
            var newForm = new login(order, type);//create login screen with order and type
            newForm.Show();//show login screen
            this.Close();//closes current screen
        }

        private void newbutton_Click(object sender, EventArgs e)//define what happens when the new button is clicked
        {
            this.Hide();//hide current screen
            var newForm = new CustomerInfo(customer, order, type, true);//create customerinfo screen with customer, order, type, and bool
            newForm.Show();//show customerinfo screen
            this.Close();//closes current screen
        }

        private void homebutton_Click(object sender, EventArgs e)//define what happens when the home button is clicked
        {
            this.Hide();//hide current screen
            var newForm = new HomeScreen();//create homescreen
            newForm.Show();//show homescreen
            this.Close();//closes current screen
        }

        private void backbutton_Click(object sender, EventArgs e)//define what happens when the back button is clicked
        {
            this.Hide();//hide current screen
            var newForm = new Deli_Carry(order);//create dali_carry screen
            newForm.Show();//show deli_carry screen
            this.Close();//closes current screen
        }
    }
}
