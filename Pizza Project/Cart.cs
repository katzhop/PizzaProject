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
    public partial class Cart : Form
    {
        public Orders order = new Orders(); //creates order class
        public Cart()//default constructor for cart
        {
            InitializeComponent();//creates screen with all the buttons and etc.
        }
        public Cart(Food f)//creates cart with food to keep track of order
        {
            InitializeComponent();//creates screen with all the buttons and etc.
            order.addFood(f);//add food to order
            textBoxcart.Text = order.ToString();//set the text box to show full order
        }
        public Cart(Orders c)//creates cart with order to keep track of order
        {
            InitializeComponent(); //creates screen with all the buttons and etc.
            foreach (Food f in c.foodList)
            {
                order.addFood(f);//adds all foods in c to the order
            }
            textBoxcart.Text = order.ToString(); //sets the text box to show full order
        }

        private void homebutton_Click(object sender, EventArgs e)//define what happens when the home button is clicked
        {
            this.Hide();//hide current screen
            var newForm = new HomeScreen();//create home screen
            newForm.Show();//show home screen
            this.Close();//closes current screen
        }

        private void backbutton_Click(object sender, EventArgs e)//define what happens when the back button is clicked
        {
            this.Hide();//hide current screen
            var newForm = new Menu();//creates menu screen
            newForm.Show();//shows the menu screen
            this.Close();//closes current screen
        }

        private void checkoutbutton_Click(object sender, EventArgs e)//define what happens when the checkout button is clicked
        {
            this.Hide();//hides current screen
            var newForm = new Deli_Carry(order);//creates delivery/carryout screen
            newForm.Show();//shoes delivery/caryour screen
            this.Close();//closes current screen
        }

        private void carttextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cart_Load(object sender, EventArgs e)
        {
        }

        private void textBoxcart_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
