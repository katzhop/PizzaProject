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
    public partial class Confimation : Form
    {
        Orders order = new Orders();//creates order
        public Confimation()//the default constructor for confirmation screen
        {
            InitializeComponent();//shows screen with all buttons and text
        }
        public Confimation(Orders or, string type)//the constructor for confirmation screen that carries the order and type of order
        {
            InitializeComponent();//shows screen with all buttons and text
            order = or;//sets the order to or
            textBoxcart.Text = order.ToString();//sets the textbox to print the full order
            label1.Text = "Order will be: \n" + type;//sets the label to print out the type of order
            label2.Text = "Total: $" + order.getTotalPrice();//sets the label to print out the total price
            label3.Text = "Sign Here: \n\n ____________";//sets the label to print a spot to sign
        }

        private void backbutton_Click(object sender, EventArgs e)//define what happens when the back button is clicked
        {
            this.Hide();//hides current screen
            var newForm = new HomeScreen();//creates homescreen
            newForm.Show();//shows the homescreen
            this.Close();//closes current screen
        }

        private void homebutton_Click(object sender, EventArgs e)//define what happens when the home button is clicked
        {
            this.Hide();//hides current screen
            var newForm = new HomeScreen();//creates homescreen
            newForm.Show();//shows homescreen
            this.Close();//closes current screen
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxcart_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
