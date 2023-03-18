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
    public partial class Drinks : Form
    {
        string drink = null;//create drink
        string size = null;//create size
        Food Drink = new Food();//create food
        public Drinks()//default constructor for drinks
        {
            InitializeComponent();//creates screen with all the buttons and etc.
        }

        private void continuebutton_Click(object sender, EventArgs e)//define what happens when the continue button is clicked
        {
            if (drink == null)//if drink is null print error message
            {
                System.Windows.Forms.MessageBox.Show("Select a Drink");
            }
            else if(size == null)//if size is null print error message
            {
                System.Windows.Forms.MessageBox.Show("Select a Drink Size");
            }
            else
            {
                Drink.setName("Drink");//set food name
                Drink.setDetails(drink + "\t\t\t\t\tSize: " + size);//set food details
                if(size == "can")//if size is can set drink price
                {
                    Drink.setPrice(0.99);//set price to 99c
                }
                else if(size == "bottle")//if size is bottle set drink price
                {
                    Drink.setPrice(1.49);//set price to $1.49
                }
                else if(size == "2Liter")//if size is 2liter set drink price
                {
                    Drink.setPrice(3.99);//set price to $3.99
                }
                drink = null;//reset drink
                size = null;//reset size
                this.Hide();//hide current screen
                var newForm = new Quantity(Drink, "drinks");//create quantity screen with food and drinks
                newForm.Show();//show quantity screen
                this.Close();//closes current screen
            }
        }

        private void backbutton_Click(object sender, EventArgs e)//define what happens when the back button is clicked
        {
            drink = null;//reset drink
            size = null;//reset size
            this.Hide();//hide current screen
            var newForm = new Menu();//create menu screen
            newForm.Show();//show menu screen
            this.Close();//closes current screen
        }

        private void homebutton_Click(object sender, EventArgs e)//define what happens when the home button is clicked
        {
            drink = null;//reset drink
            size = null;//reset size
            this.Hide();//hide current screen
            var newForm = new HomeScreen();//create home screen
            newForm.Show();//show home screen
            this.Close();//closes current screen
        }

        private void cokebutton_Click(object sender, EventArgs e)//define what happens when the coke button is clicked
        {
            cokecheckBox.Checked = true;//set coke checkbox to true
        }

        private void pepsibutton_Click(object sender, EventArgs e)//define what happens when the pepsi button is clicked
        {
            pepsicheckBox.Checked = true;//set pepsi checkbox to true
        }

        private void drpepperbutton_Click(object sender, EventArgs e)//define what happens when the drpepper button is clicked
        {
            drpepercheckBox.Checked = true;//set drpepper checkbox to true
        }

        private void spritebutton_Click(object sender, EventArgs e)//define what happens when the sprite button is clicked
        {
            spritecheckBox.Checked = true;//set sprite checkbox to true
        }

        private void fantabutton_Click(object sender, EventArgs e)//define what happens when the fanta button is clicked
        {
            fantacheckBox.Checked = true;//set fanta checkbox to true
        }

        private void cancheckBox_CheckedChanged(object sender, EventArgs e)//define what happens when the can checkbox is changed
        {
            if (cancheckBox.Checked == true)//if true set everyother size checkbox to false
            { 
                bottlecheckBox.Checked = false; 
                liter2checkBox.Checked = false; 
            }
            size = "can";//set size to can
        }

        private void bottlecheckBox_CheckedChanged(object sender, EventArgs e)//define what happens when the bottle checkbox is changed
        {
            if (bottlecheckBox.Checked == true)//if true set everyother size checkbox to false
            {
                cancheckBox.Checked = false;
                liter2checkBox.Checked = false;
            }
            size = "bottle";//set size to bottle
        }

        private void liter2checkBox_CheckedChanged(object sender, EventArgs e)//define what happens when the 2liter checkbox is changed
        {
            if (liter2checkBox.Checked == true)//if true set everyother size checkbox to false
            {
                cancheckBox.Checked = false;
                bottlecheckBox.Checked = false;
            }
            size = "2liter";//set size to 2liter
        }

        private void cokecheckBox_CheckedChanged(object sender, EventArgs e)//define what happens when the coke checkbox is changed
        {
            if (cokecheckBox.Checked == true)//if true set everyother drink checkbox to false
            {
                spritecheckBox.Checked = false;
                fantacheckBox.Checked = false;
                drpepercheckBox.Checked = false;
                pepsicheckBox.Checked = false;
            }
            drink = "coke";//set drink to coke
        }

        private void pepsicheckBox_CheckedChanged(object sender, EventArgs e)//define what happens when the pepsi checkbox is changed
        {
            if (pepsicheckBox.Checked == true)//if true set everyother drink checkbox to false
            {
                spritecheckBox.Checked = false;
                fantacheckBox.Checked = false;
                drpepercheckBox.Checked = false;
                cokecheckBox.Checked = false;
            }
            drink = "pepsi";//set drink to pepsi
        }

        private void drpepercheckBox_CheckedChanged(object sender, EventArgs e)//define what happens when the drpepper checkbox is changed
        {
            if (drpepercheckBox.Checked == true)//if true set everyother drink checkbox to false
            {
                spritecheckBox.Checked = false;
                fantacheckBox.Checked = false;
                cokecheckBox.Checked = false;
                pepsicheckBox.Checked = false;
            }
            drink = "drpepper";//set drink to drpepper
        }

        private void spritecheckBox_CheckedChanged(object sender, EventArgs e)//define what happens when the sprite checkbox is changed
        {
            if (spritecheckBox.Checked == true)//if true set everyother drink checkbox to false
            {
                cokecheckBox.Checked = false;
                fantacheckBox.Checked = false;
                drpepercheckBox.Checked = false;
                pepsicheckBox.Checked = false;
            }
            drink = "sprite";//set drink to sprite
        }

        private void fantacheckBox_CheckedChanged(object sender, EventArgs e)//define what happens when the fanta checkbox is changed
        {
            if (fantacheckBox.Checked == true)//if true set everyother drink checkbox to false
            {
                spritecheckBox.Checked = false;
                cokecheckBox.Checked = false;
                drpepercheckBox.Checked = false;
                pepsicheckBox.Checked = false;
            }
            drink = "fanta";//set drink to fanta
        }

        private void Drinks_Load(object sender, EventArgs e)
        {

        }
    }
}
