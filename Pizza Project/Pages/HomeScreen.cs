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
    public partial class HomeScreen : Form
    {
        public HomeScreen()//default constructor for home screen
        {
            InitializeComponent();//creates screen with all the buttons and etc.
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)//define what happens when the customer button is clicked
        {
            this.Hide();//hides current screen
            var newForm = new Menu();//creates menu screen
            newForm.Show();//shows menu screen
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void managerbutton_Click(object sender, EventArgs e)
        {

        }

        private void workerbutton_Click(object sender, EventArgs e)
        {
            
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
