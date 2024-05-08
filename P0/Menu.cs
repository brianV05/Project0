namespace P0;
class Menu
{

    // Display the main Menu to the user 
    public static void printMenu(){
        Console.WriteLine("\n----Address Book----");
        Console.WriteLine("1. Add Contact");
        Console.WriteLine("2. View Contact");
        Console.WriteLine("3. Edit Contact");
        Console.WriteLine("4. Delete Contact");
        Console.WriteLine("5. Exit Program");
        Console.WriteLine("---------------------");
    }

    public static int UserOption(){
        Console.WriteLine("How may I help you today? ");
        int intChoice = Convert.ToInt32(Console.ReadLine());

        return intChoice;
    }




    public static Contact getNewContactInfo(List<Contact> contacts){
        //userinput for new contact information 


        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your email: ");
        string email = Console.ReadLine(); 
          
        Console.Write("Enter your address: ");
        string address = Console.ReadLine();
            
        Contact createdContact = new Contact(name, email, address);
        return createdContact;

    }





}