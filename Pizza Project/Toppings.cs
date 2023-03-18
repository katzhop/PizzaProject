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
    public partial class Toppings : Form
    {
        public string realSize;//create realsize
        public string realCrust;//create realcrust
        public string realToppings = "";//create real toppings
        int ntops = 0;//create and set number of toppings
        string[] toppings = new string[4];//create toppings[]
        Pizza pizza = new Pizza();//create pizza
        public Toppings()//default constructor for toppings
        {
            InitializeComponent();//creates screen with all the buttons and etc.
        }
        public Toppings(string size, string crust)//constructor for toppings with size and crust
        {
            InitializeComponent();//creates screen with all the buttons and etc.
            realSize = size;//sets realsize
            realCrust = crust;//set realcrust
        }
        public Toppings(Pizza f)//constructor for toppings with pizza
        {
            InitializeComponent();//creates screen with all the buttons and etc.
            realSize = f.getSize();//sets realsize
            realCrust = f.getCrust();//sets realcrust
        }

        private void continuebutton_Click(object sender, EventArgs e)//define what happens when the continue button is clicked
        {
            for (int i = 0; i < 4; i++)//cycles trough toppings[]
            {
                if (toppings[i] != null)//if toppings is not null add to realtoppings
                {
                    realToppings += toppings[i] + ",";
                }
            }
            Pizza pizza = new Pizza(realSize, realCrust, realToppings);//set pizza
            pizza.setDetails();//set details for pizza
            pizza.setName("Pizza");//set pizza name
            if(realSize == "small")//set price based on size
            {
                pizza.setPrice(5.99);//set price to $5.99
            }
            else if(realSize == "medium")//set price based on size
            {
                pizza.setPrice(9.99);//set price to $9.99
            }
            else if (realSize == "large")//set price based on size
            {
                pizza.setPrice(12.99);//set price to $12.99
            }
            else if (realSize == "extraLarge")//set price based on size
            {
                pizza.setPrice(14.99);//set price to $14.99
            }
            if (realCrust == "regular")//add price based on crust
            {
                pizza.setPrice(pizza.getPrice());//keep same price
            }
            else if(realCrust == "stuffed")//add price based on crust
            {
                pizza.setPrice(pizza.getPrice() + 1.50);//add $1.50
            }
            else if(realCrust == "flatbread")//add price based on crust
            {
                pizza.setPrice(pizza.getPrice() + .50);//add 50c
            }
            pizza.setPrice(pizza.getPrice() + (.50 * ntops));//add price based on number of toppings
            toppings = null;//reset toppings
            this.Hide();//hide curretn screen
            var newForm = new Quantity(pizza, "toppings");//create quantity screen
            newForm.Show();//show quantity screen
            this.Close();//closes current screen
        }

        private void backbutton_Click(object sender, EventArgs e)//define what happens when the back button is clicked
        {
            toppings = null;//reset toppings
            realToppings = null;//reset realtoppings
            this.Hide();//hide current screen
            var newForm = new Crusts(realSize);//create crust screen
            newForm.Show();//shwo crust screen
            this.Close();//closes current screen
        }

        private void homebutton_Click(object sender, EventArgs e)//define what happens when the home button is clicked
        {
            toppings = null;//reset toppings
            realToppings = null;//reset realtoppings
            this.Hide();//hide current screen
            var newForm = new HomeScreen();//create home screen
            newForm.Show();//show home screen
            this.Close();//closes current screen
        }

        private void hambutton_Click(object sender, EventArgs e)//define what happens when the ham button is clicked
        {
            if (hamcheckBox.Checked == true)//if ham checkbox is already check uncheck it
            {
                hamcheckBox.Checked = false;
            }
            else if (moreThan4() == true)//check for more than 4 toppings
            {
                System.Windows.Forms.MessageBox.Show("Can only select up to 4 toppings");//if are display error message
            }
            else
            {
                hamcheckBox.Checked = true;//check ham box
            }
        }

        private void capersbutton_Click(object sender, EventArgs e)//define what happens when the capers button is clicked
        {
            if (caperscheckBox.Checked == true)//if capers checkbox is already check uncheck it
            {
                caperscheckBox.Checked = false;
            }
            else if (moreThan4() == true)//check for more than 4 toppings
            {
                System.Windows.Forms.MessageBox.Show("Can only select up to 4 toppings");//if are display error message
            }
            else
            {
                caperscheckBox.Checked = true;//check capers box
            }
        }

        private void pepperonibutton_Click(object sender, EventArgs e)//define what happens when the pepperoni button is clicked
        {
            if (pepperonicheckBox.Checked == true)//if pepperoni checkbox is already check uncheck it
            {
                pepperonicheckBox.Checked = false;
            }
            else if (moreThan4() == true)//check for more than 4 toppings
            {
                System.Windows.Forms.MessageBox.Show("Can only select up to 4 toppings");//if are display error message
            }
            else
            {
                pepperonicheckBox.Checked = true;//check pepperoni box
            }
        }

        private void sausagebutton_Click(object sender, EventArgs e)//define what happens when the sausage button is clicked
        {
            if (susaugecheckBox.Checked == true)//if sausage checkbox is already check uncheck it
            {
                susaugecheckBox.Checked = false;
            }
            else if (moreThan4() == true)//check for more than 4 toppings
            {
                System.Windows.Forms.MessageBox.Show("Can only select up to 4 toppings");//if are display error message
            }
            else
            {
                susaugecheckBox.Checked = true;//check sausage box
            }
        }

        private void bananapepperbutton_Click(object sender, EventArgs e)//define what happens when the bananapepper button is clicked
        {
            if (bannapeppercheckBox.Checked == true)//if bananapepper checkbox is already check uncheck it
            {
                bannapeppercheckBox.Checked = false;
            }
            else if (moreThan4() == true)//check for more than 4 toppings
            {
                System.Windows.Forms.MessageBox.Show("Can only select up to 4 toppings");//if are display error message
            }
            else
            {
                bannapeppercheckBox.Checked = true;//check bananapepper box
            }
        }

        private void onionbutton_Click(object sender, EventArgs e)//define what happens when the onion button is clicked
        {
            if (onioncheckBox.Checked == true)//if onion checkbox is already check uncheck it
            {
                onioncheckBox.Checked = false;
            }
            else if (moreThan4() == true)//check for more than 4 toppings
            {
                System.Windows.Forms.MessageBox.Show("Can only select up to 4 toppings");//if are display error message
            }
            else
            {
                onioncheckBox.Checked = true;//check onion box
            }
        }

        private void olivebutton_Click(object sender, EventArgs e)//define what happens when the olive button is clicked
        {
            if (olivecheckBox.Checked == true)//if olive checkbox is already check uncheck it
            {
                olivecheckBox.Checked = false;
            }
            else if (moreThan4() == true)//check for more than 4 toppings
            {
                System.Windows.Forms.MessageBox.Show("Can only select up to 4 toppings");//if are display error message
            }
            else
            {
                olivecheckBox.Checked = true;//check olive box
            }
        }

        private void onioncheckBox_CheckedChanged(object sender, EventArgs e)//define what happens when the onion checkbox is changed
        {
            if (onioncheckBox.Checked == true)//if onion is checked search through toppings[] for open space then add onion there
            {
                bool empty = true;
                for (int i = 0; i < 4; i++)
                {
                    if (empty == false) { }
                    else if (toppings[i] == null)
                    {
                        toppings[i] = "onion";
                        empty = false;
                    }
                }
            }
            else
            {
                for (int i = 0; i < 4; i++)//if onion is unchecked search for onion in toppings[] and null it
                {
                    if (toppings[i] == "onion")
                    {
                        toppings[i] = null;
                    }
                }
            }
        }

        private void olivecheckBox_CheckedChanged(object sender, EventArgs e)//define what happens when the olive checkbox is changed
        {
            if (olivecheckBox.Checked == true)//if olive is checked search through toppings[] for open space then add olive there
            {
                bool empty = true;
                for (int i = 0; i < 4; i++)
                {
                    if (empty == false) { }
                    else if (toppings[i] == null)
                    {
                        toppings[i] = "olive";
                        empty = false;
                    }
                }
            }
            else//if olive is unchecked search for olive in toppings[] and null it
            {
                for (int i = 0; i < 4; i++)
                {
                    if (toppings[i] == "olive")
                    {
                        toppings[i] = null;
                    }
                }
            }
        }

        private void bannapeppercheckBox_CheckedChanged(object sender, EventArgs e)//define what happens when the bananapepper checkbox is changed
        {
            if (bannapeppercheckBox.Checked == true)//if bananapepper is checked search through toppings[] for open space then add bananapepper there
            {
                bool empty = true;
                for (int i = 0; i < 4; i++)
                {
                    if (empty == false) { }
                    else if (toppings[i] == null)
                    {
                        toppings[i] = "bannaPepper";
                        empty = false;
                    }
                }
            }
            else//if bananapepper is unchecked search for bananapepper in toppings[] and null it
            {
                for (int i = 0; i < 4; i++)
                {
                    if (toppings[i] == "bannaPepper")
                    {
                        toppings[i] = null;
                    }
                }
            }
        }

        private void susaugecheckBox_CheckedChanged(object sender, EventArgs e)//define what happens when the sausage checkbox is changed
        {
            if (susaugecheckBox.Checked == true)//if sausage is checked search through toppings[] for open space then add sausage there
            {
                bool empty = true;
                for (int i = 0; i < 4; i++)
                {
                    if (empty == false) { }
                    else if (toppings[i] == null)
                    {
                        toppings[i] = "sausage";
                        empty = false;
                    }
                }
            }
            else//if sausage is unchecked search for sausage in toppings[] and null it
            {
                for (int i = 0; i < 4; i++)
                {
                    if (toppings[i] == "sausage")
                    {
                        toppings[i] = null;
                    }
                }
            }
        }

        private void pineapplecheckBox_CheckedChanged(object sender, EventArgs e)//define what happens when the pineapple checkbox is changed
        {
            if (pineapplecheckBox.Checked == true)//if pineapple is checked search through toppings[] for open space then add pineapple there
            {
                bool empty = true;
                for (int i = 0; i < 4; i++)
                {
                    if (empty == false) { }
                    else if (toppings[i] == null)
                    {
                        toppings[i] = "pineapple";
                        empty = false;
                    }
                }
            }
            else//if pineapple is unchecked search for pineapple in toppings[] and null it
            {
                for (int i = 0; i < 4; i++)
                {
                    if (toppings[i] == "pineapple")
                    {
                        toppings[i] = null;
                    }
                }
            }
        }

        private void pepperonicheckBox_CheckedChanged(object sender, EventArgs e)//define what happens when the pepperoni checkbox is changed
        {
            if (pepperonicheckBox.Checked == true)//if pepperoni is checked search through toppings[] for open space then add pepperoni there
            {
                bool empty = true;
                for (int i = 0; i < 4; i++)
                {
                    if (empty == false) { }
                    else if (toppings[i] == null)
                    {
                        toppings[i] = "pepperoni";
                        empty = false;
                    }
                }
            }
            else//if pepperoni is unchecked search for pepperoni in toppings[] and null it
            {
                for (int i = 0; i < 4; i++)
                {
                    if (toppings[i] == "pepperoni")
                    {
                        toppings[i] = null;
                    }
                }
            }
        }

        private void caperscheckBox_CheckedChanged(object sender, EventArgs e)//define what happens when the capers checkbox is changed
        {
            if (caperscheckBox.Checked == true)//if capers is checked search through toppings[] for open space then add capers there
            {
                bool empty = true;
                for (int i = 0; i < 4; i++)
                {
                    if (empty == false) { }
                    else if (toppings[i] == null)
                    {
                        toppings[i] = "capers";
                        empty = false;
                    }
                }
            }
            else//if capers is unchecked search for capers in toppings[] and null it
            {
                for (int i = 0; i < 4; i++)
                {
                    if (toppings[i] == "capers")
                    {
                        toppings[i] = null;
                    }
                }
            }
        }

        private void hamcheckBox_CheckedChanged(object sender, EventArgs e)//define what happens when the ham checkbox is changed
        {
            if (hamcheckBox.Checked == true)//if ham is checked search through toppings[] for open space then add ham there
            {
                bool empty = true;
                for(int i = 0; i < 4; i++)
                {
                    if(empty == false) { }
                    else if(toppings[i] == null)
                    {
                        toppings[i] = "ham";
                        empty = false;
                    }
                }
            }
            else//if ham is unchecked search for ham in toppings[] and null it
            {
                for (int i = 0; i < 4; i++)
                {
                    if (toppings[i] == "ham")
                    {
                        toppings[i] = null;
                    }
                }
            }
        }

        private void Toppings_Load(object sender, EventArgs e)
        {

        }
        private bool moreThan4()//check for more than 4 toppings selected
        {
            bool yes = false;//creates and sets yes
            int count = 0;//creates and sets count
            if (hamcheckBox.Checked == true) { count++; }//adds 1 to count if checked
            if (pepperonicheckBox.Checked == true) { count++; }//adds 1 to count if checked
            if (pineapplecheckBox.Checked == true) { count++; }//adds 1 to count if checked
            if (caperscheckBox.Checked == true) { count++; }//adds 1 to count if checked
            if (susaugecheckBox.Checked == true) { count++; }//adds 1 to count if checked
            if (bannapeppercheckBox.Checked == true) { count++; }//adds 1 to count if checked
            if (onioncheckBox.Checked == true) { count++; }//adds 1 to count if checked
            if (olivecheckBox.Checked == true) { count++; }//adds 1 to count if checked
            if (count > 3)//if count is greateer than 3 set yes to true
            {
                yes = true;
            }
            ntops = count;//sets number of toppings to count
            return yes;//returns yes
        }

        private void pineapplebutton_Click(object sender, EventArgs e)//define what happens when the pineapple button is clicked
        {
            if (pineapplecheckBox.Checked == true)//if pineapple checkbox is already check uncheck it
            {
                pineapplecheckBox.Checked = false;
            }
            else if (moreThan4() == true)//check for more than 4 toppings
            {
                System.Windows.Forms.MessageBox.Show("Can only select up to 4 toppings");//if are display error message
            }
            else
            {
                pineapplecheckBox.Checked = true;//check pineapple box
            }
        }
    }
}
