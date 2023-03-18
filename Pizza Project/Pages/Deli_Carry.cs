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
    public partial class Deli_Carry : Form
    {
        Orders order = new Orders();//creates oder
        public Deli_Carry()//default constructor for deli_carry
        {
            InitializeComponent();//creates screen with all the buttons and etc.
        }
        public Deli_Carry(Orders or)//constructor for deli_carry with orders
        {
            InitializeComponent();//creates screen with all the buttons and etc.
            order = or;//set order
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void homebutton_Click(object sender, EventArgs e)//define what happens when the home button is clicked
        {
            this.Hide();//hide curretn screen
            var newForm = new HomeScreen();//create homescreen
            newForm.Show();//show homescreen
            this.Close();//closes current screen
        }

        private void deliverybutton_Click(object sender, EventArgs e)//define what happens when the delivery button is clicked
        {
            this.Hide();//hide curretn screen
            var newForm = new Return(order, "Delivery");//create return screen with order and delivery
            newForm.Show();//shows return screen
            this.Close();//closes current screen
        }

        private void carryoutbutton_Click(object sender, EventArgs e)//define what happens when the carryout button is clicked
        {
            this.Hide();//hide curretn screen
            var newForm = new Return(order, "Carryout");//create return screen with order and carryout
            newForm.Show();//shows return screen
            this.Close();//closes current screen
        }

        private void backbutton_Click(object sender, EventArgs e)//define what happens when the back button is clicked
        {
            this.Hide();//hide curretn screen
            var newForm = new Cart(order);//creates cart screen with order
            newForm.Show();//shows cart screen
            this.Close();//closes current screen
        }
    }
}
