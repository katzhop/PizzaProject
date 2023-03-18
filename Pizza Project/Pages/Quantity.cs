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
    public partial class Quantity : Form
    {
        int quantity = 1;//creates and set quantity
        Food food = new Food();//creates food
        Pizza pizza = new Pizza();//creates pizza
        string place;//creates place
        public Quantity()//default constructor for pizza
        {
            InitializeComponent();//creates screen with all the buttons and etc.
        }
        public Quantity(Food f, string p)//constructor for pizza with food and place
        {
            InitializeComponent();//creates screen with all the buttons and etc.
            food = f;//sets food
            place = p;//sets place
        }
        public Quantity(Pizza f, string p)//constructor for pizza with pizza and place
        {
            InitializeComponent();//creates screen with all the buttons and etc.
            food = f;//sets food
            pizza = f;//sets pizza
            place = p;//sets place
        }

        private void backbutton_Click(object sender, EventArgs e)//define what happens when the back button is clicked
        {
            if (place == "drinks")//if place = drinks
            {
                this.Hide();//hide current screen
                var newForm = new Drinks();//creates drinks screen
                newForm.Show();//show drinks screen
                this.Close();//closes current screen
            }
            else if(place == "toppings")//if place = toppings
            {
                this.Hide();//hide current screen
                var newForm = new Toppings(pizza);//creates toppings screen with pizza
                newForm.Show();//show toppings screeen
                this.Close();//closes current screen
            }
        }

        private void homebutton_Click(object sender, EventArgs e)//define what happens when the home button is clicked
        {
            quantity = 1;//set quantity
            this.Hide();//hide current screen
            var newForm = new HomeScreen();//create homescreen
            newForm.Show();//show homescreen
            this.Close();//closes current screen
        }

        private void minusbutton_Click(object sender, EventArgs e)//define what happens when the minus button is clicked
        {
            if (quantity == 0)//if quantity=0 do nothing
            {
            }
            else
            {
                quantity--;//decrease quantity by 1
                textBox1.Text = quantity.ToString();//set textbox to quantity
            }
        }

        private void plusbutton_Click(object sender, EventArgs e)//define what happens when the plus button is clicked
        {
            quantity++;//increase qunatity by 1
            textBox1.Text = quantity.ToString();//set textbox to quantity
        }

        private void continuebutton_Click(object sender, EventArgs e)//define what happens when the continue button is clicked
        {
            food.setQuantity(quantity);//set food's quantity
            this.Hide();//hide current screen
            var newForm = new Menu(food, "quantity");//create menu screen with food and quantity
            newForm.Show();//show menu screen
            this.Close();//closes current screen
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
