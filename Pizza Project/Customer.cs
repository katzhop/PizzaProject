
public class Customer
{

    string name;//creates name
    string street;//creates street
    string city;//creates city
    string state;//creates state
    string zipcode;//creates zipcode
    string Directions;//creates directions
    string Payment;//creates payment type
    string PhoneNumber;//creates phonenumber

    public Customer(string name, string street, string city, string state, string zip, string directions, string payment, string phoneNumber)//constructor for customer that takes in all elements
    {
        this.name = name;//sets nam to name
        this.street = street;//sets stre to street
        this.city = city;//sets cit to city
        this.state = state;//sets stat to state
        this.zipcode = zip;//set zip to zipcode
        this.Directions = directions;//sets directions to directions
        this.Payment = payment;//sets payment to payment
        this.PhoneNumber = phoneNumber;//set phonenumber to phonenumber
    }


    public string getName(){ //gets the customer name
        return name; }//returns the name
    public string getStreet(){ //gets the customer street
        return street; }//returns the street
    public string getCity()//gets the customer city
    {
        return city;//returns the city
    }
    public string getState()//gets the customer state
    {
        return state;//returns the state
    }
    public string getZipCode()//gets the customer zipcode
    {
        return zipcode;//returns the zipcode
    }
    public string getDirections() { //gets the customer directions
        return Directions;}//returns the directions
    public string getPayment(){//gets the customer payment type
        return Payment;}//returns the payemnt
    public string getPhoneNumber()//gets the customer phone number
    { return PhoneNumber;} //returns phonenumber

    public void setName(string name) { this.name = name; }//takes in and sets name
    public void setStreet(string street) { this.street = street; }//takes in and sets street
    public void setCity(string city) { this.city = city; }//takes in and sets city
    public void setState(string state) { this.state = state; }//takes in and sets state
    public void setZipCode(string zipcode) { this.zipcode = zipcode; }//takes in and sets zipcode
    public void setDirections(string directions) { this.Directions = directions; }//takes in and sets directions
    public void setPayment(string payment) { this.Payment = payment; }//takes in and sets payment type
    public void setPhoneNumber(string PhoneNumber) { this.PhoneNumber = PhoneNumber; }//takes in and sets phone number

}