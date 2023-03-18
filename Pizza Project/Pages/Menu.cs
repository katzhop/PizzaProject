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
    public partial class Menu : Form
    {
        public static Orders order = new Orders();//creates order
        Food last = new Food();//creates food
        string place;//creates place
        public Menu()//default constructor for menu
        {
            InitializeComponent();//creates screen with all the buttons and etc.
        }
        public Menu(string p)//constructor for menu with string
        {
            InitializeComponent();//creates screen with all the buttons and etc.
            place = p;//sets place 
        }
        public Menu(Food f, string p)//constructor for menu with food and string
        {
            InitializeComponent();//creates screen with all the buttons and etc.
            order.addFood(f);//add food to order
            place = p;//set place
            last = f;//set food
        }

        private void pizzabutton_Click(object sender, EventArgs e)//define what happens when the pizza button is clicked
        {
            this.Hide();//hides current screen
            var newForm = new Size();//creates size screen
            newForm.Show();//show size screen
            this.Close();//closes current screen
        }

        private void drinkbutton_Click(object sender, EventArgs e)//define what happens when the drink button is clicked
        {
            this.Hide();//hides current screen
            var newForm = new Drinks();//creates drink screen
            newForm.Show();//show drink screen
            this.Close();//closes current screen
        }

        private void backbutton_Click(object sender, EventArgs e)//define what happens when the back button is clicked
        {
            this.Hide();//hide current screen
            order.removeFood(last);//remove food from order
            if (place == "quantity")//if place = quantity return to drink or toppings
            {
                if (last.getName() == "Drink")//if food name is drink
                {
                    var newForm = new Quantity(last, "drinks");//create quantity screen with food and drinks
                    newForm.Show();//show quantity screen
                    this.Close();//closes current screen
                }
                else
                {
                    var newForm = new Quantity(last, "toppings");//creates quantity screen with food and toppings
                    newForm.Show();//show quantity screen
                    this.Close();//closes current screen
                }
            }
            else
            {
                var newForm = new HomeScreen();//create homescreen
                newForm.Show();//show homescreen
                this.Close();//closes current screen
            }
        }

        private void homebutton_Click(object sender, EventArgs e)//define what happens when the home button is clicked
        {
            this.Hide();//hides current screen
            var newForm = new HomeScreen();//create homescreen
            newForm.Show();//show homescreen
            this.Close();//closes current screen
        }

        private void checkoutbutton_Click(object sender, EventArgs e)//define what happens when the checkout button is clicked
        {
            this.Hide();//hide current screen
            var newForm = new Cart(order);//create cart screen with order
            newForm.Show();//show cart
            this.Close();//closes current screen
        }
    }
}
