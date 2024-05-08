
namespace P0;

public class Contact{
    
    public string Name {get; set; }
    public string Email {get; set; }
    public string Address{get; set; }


    //constructors
    public Contact() {}

    public Contact(string name, string email, string address){
        Name = name;
        Email = email;
        Address = address;
    }

 
    //for json formatting
    public override string ToString()
    {
        return $"NAME: {this.Name}, EMAIL: {this.Email}, ADDRESS: {this.Address} ";
    }



}