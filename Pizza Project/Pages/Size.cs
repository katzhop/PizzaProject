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
    public partial class Size : Form
    {
        string size = null;//creates size
        string realSize;//creates realsize
        public Size()//default constructor for size
        {
            InitializeComponent();//creates screen with all the buttons and etc.
        }


        private void homebutton_Click(object sender, EventArgs e)//define what happens when the home button is clicked
        {
            size = null;//reset size
            realSize = size;//set realsize to size
            this.Hide();//hide current screen
            var newForm = new HomeScreen();//create homescreen
            newForm.Show();//show homescreen
            this.Close();//closes current screen
        }

        private void smallbutton_Click(object sender, EventArgs e)//define what happens when the small button is clicked
        {
            size = "small";//set size to small
        }

        private void mediumbutton_Click(object sender, EventArgs e)//define what happens when the medium button is clicked
        {
            size = "medium";//set size to medium
        }

        private void largebutton_Click(object sender, EventArgs e)//define what happens when the large button is clicked
        {
            size = "large";//set size to large
        }

        private void extralargebutton_Click(object sender, EventArgs e)//define what happens when the etralarge button button is clicked
        {
            size = "extraLarge";//set size to extraLarge
        }

        private void backbutton_Click(object sender, EventArgs e)//define what happens when the back button is clicked
        {
            size = null;//reset size
            realSize = size;//set size to realsize
            this.Hide();//hide current screen
            var newForm = new Menu();//create menu screen
            newForm.Show();//show menu
            this.Close();//closes current screen
        }


        private void continuebutton_Click(object sender, EventArgs e)//define what happens when the continue button is clicked
        {
            if (size == null)//if size = null display error message
            {
                System.Windows.Forms.MessageBox.Show("Select Pizza Size");
            }
            else
            {
                realSize = size;//set size to realsize
                size = null;//reset size
                this.Hide();//hide current screen
                var newForm = new Crusts(realSize);//create crust screen
                newForm.Show();//show crust screen
                this.Close();//closes current screen
            }
        }
    }
}
