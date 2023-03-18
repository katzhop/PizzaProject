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
    public partial class Crusts : Form
    {
        string crust = null;//creates crust
        string realSize;//creates realsize
        string realCrust;//creates realcrust
        public Crusts()//default crustructor for Crust
        {
            InitializeComponent();//creates screen with all the buttons and etc.
        }
        public Crusts(string size)//cunstructor for crust with size
        {
            InitializeComponent();//creates screen with all the buttons and etc.
            realSize = size;//sets realsize to size
        }

        private void regularbutton_Click(object sender, EventArgs e)//define what happens when the regular button is clicked
        {
            crust = "regular";//sets crust to regular
        }

        private void stuffedbutton_Click(object sender, EventArgs e)//define what happens when the stuffed button is clicked
        {
            crust = "stuffed";//sets realcrust to stuffed
        }

        private void flatbutton_Click(object sender, EventArgs e)//define what happens when the flatbread button is clicked
        {
            crust = "flatbread";//sets crust to flatbread
        }

        private void homebutton_Click(object sender, EventArgs e)//define what happens when the home button is clicked
        {
            crust = null;//resets crust
            realCrust = crust;//sets realcrust to crust
            this.Hide();//hides current screen
            var newForm = new HomeScreen();//creates home screen
            newForm.Show();//shows home screen
            this.Close();//closes current screen
        }

        private void backbutton_Click(object sender, EventArgs e)//define what happens when the home button is clicked
        {
            crust = null;//rests crust
            realCrust = crust;//sets realcrust to crust
            this.Hide();//hides current screen
            var newForm = new Size();//creates size screen
            newForm.Show();//shows size screen
            this.Close();//closes current screen
        }

        private void continuebutton_Click(object sender, EventArgs e)//defines what happens when the continue button is clicked
        {
            if (crust == null)//if crust = null display error message
            {
                System.Windows.Forms.MessageBox.Show("Select Pizza Crust Type");
            }
            else
            {
                realCrust = crust;//set realcrust to crust
                crust = null;//resets crust
                this.Hide();//hides current screen
                var newForm = new Toppings(realSize, realCrust);//creates toppings screen with realcrust and realsize
                newForm.Show();//show toppings screen
                this.Close();//closes current screen
            }
        }
    }
}
