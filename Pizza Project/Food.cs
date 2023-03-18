using System;

public class Food
{
    protected string details = "";//creates details
    protected string Name = "";//creats name
    protected double Price = 0.0;//creates price
    protected int Quantity = 0;//creates quantity

    public string getName()//gets the food name
    {
        return Name;//return name
    }

    public void setName(string Name1)//sets the name based on input
    {
        Name = Name1;
    }

    public double getPrice()//gets the price
    {
        return Price;//returns price
    }

    public string getDetails()//gets the details
    {
        return details;//returns details
    }
    public void setDetails(string det)//set the details based on input
    {
        details = det;
    }

    public void setPrice(double Price1)//set price based on input
    {
        Price = Price1;
    }

    public void setQuantity(int q)//sets quantity based on input
    {
        Quantity = q;
    }
    public int getQuantity()//gets the quantitiy
    {
        return Quantity;//returns quantity
    }

    public double getTotalPrice()//gets total price
    {
        return Price * Quantity;//returns price * quantity
    }
}
