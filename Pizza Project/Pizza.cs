using System;

public class Pizza : Food
{
    private string crust;//creates crust
    private string toppings;//creates toppings
    private string size;//creates size

    public Pizza()//default constructor for pizza
    {

    }
    public Pizza(string siz, string cru, string top)//constructor for pizza with size, crust, and toppings
    {
        size = siz;//sets size
        crust = cru;//sets crust
        toppings = top;//sets toppings
    }
    public void setDetails()//set deatils
    {
        details += "Size: " + getSize();
        details += "\t\t\t\tCrust: " + getCrust();
        details += "\t\t\t\tToppings: " + getToppings();
        if (toppings.Length < 10)//helps with spacing
        {
            details += "\t\t\t\t";
        }
        else if (toppings.Length < 20)//helps with spacing
        {
            details += "\t\t\t";
        }
        else if(toppings.Length < 30)//helps with spacing
        {
            details += "\t\t";
        }
        else//helps with spacing
        {
            details += "\t";
        }

    }
    public string getToppings()//get toppings
    {
        return toppings;//returns toppings
    }
    public void setToppings(string top)//sets toppings based on input
    {
        toppings = top;
    }
    public string getCrust()//gets crust
    {
        return crust;//returns crust
    }
    public void setCrust(string cru)//sets crust based on input
    {
        crust = cru;
    }
    public void setSize(string siz)//sets size based on input
    {
        size = siz;
    }
    public string getSize() //get size
    {
        return size; //return size
    }
    public string getName()//get name
    {
        return Name;//return name
    }

    public void setName(string Name1)//set name based on input
    {
        Name = Name1;
    }

    public double getPrice()//get price
    {
        return Price;//return price
    }

    public void setPrice(double Price1)//set price based on input
    {
        Price = Price1;
    }

    public int getQuantity()//get quantity
    {
        return Quantity;//return quantity
    }

    public double getTotalPrice()//get totalprice
    {
        return Price * Quantity;//return quantity * price
    }
    public override string ToString()//prints out pizza order
    {
        string order = "";
        order += getQuantity() + "\t";
        order += getName() + "\t\t\t$" + getTotalPrice();
        order += "\t" + getDetails() + "\t\t\t\t\t";
        return order;//returns order
    }
}