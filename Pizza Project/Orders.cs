using System;
using System.Collections.Generic;


public class Orders
{
// foodlist and total price, addFood, setTotalPrice, getTotalPrice, toString
// foodlist adds an object, not a user input
// set total price = goes through food list, and each food has a price atribute in it
// iterates through food list
public List<Food> foodList = new List<Food>();//creates list of foods
public double totalPrice = 0.0;//creates total price


    public void addFood(Food item)//adds food to list
    {
        if (item.getQuantity() != 0)//if quantity doesn't = 0 add food to list
        {
            foodList.Add(item);
        }
    }
    public void removeFood(Food item)//remove food from list
    {
        foodList.Remove(item);
    }
    public void setTotalPrice()//set total price
    {
        double price = 0;//create price
        foreach(Food item in foodList)//go through all foods in list
        {
            price += item.getTotalPrice();//add food total price to price
        }
        totalPrice = price;//set price to totalprice
    }

    public double getTotalPrice()//get total price
    {
        setTotalPrice();//run setTotalPrice
        return totalPrice;//return totalPrice
    }

    public override string ToString()//prints out order
    {
        string order = "ORDER: \t\t\t\t\t";
         foreach(Food item in foodList)
         {
            order += item.getQuantity() + "\t";
            order += item.getName() + "\t\t$" + item.getTotalPrice();
            order += "\t" + item.getDetails();
            if(item.getName() == "Drink")//helps with spacing (doesn't accept \n
            {
                order += "\t\t\t\t\t";
            }
         }
         order += "\t\t\t\tCOST: $" + getTotalPrice();
        return order;//returns order
    }

    
}