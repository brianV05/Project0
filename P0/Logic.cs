
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

namespace P0;


public class Logic{

    

     public static void AddContact(List<Contact> contacts)
    {

        Console.WriteLine("Creating a new contact.....");
        //displaying prompt to user 
        Contact addedContact = Menu.getNewContactInfo(contacts);

        //adding new contact to the list 
        //contacts.Add(addedContact);
       //Console.WriteLine($"{addedContact.Name } was added!\n");
       Verify(contacts, addedContact);

    }




    public static void viewContactInfo(List<Contact> viewcontacts){
        if(viewcontacts.Count == 0){
            Console.WriteLine("No contact available ...\t");
            return;
        }

        foreach(Contact con in viewcontacts){
            Console.WriteLine(con.ToString());
        }
    }



    public static void EditContact(List<Contact> contacts)
        {
            Console.WriteLine("Editing a contact.....");

            // Display all contacts to choose from
            Console.WriteLine("Available Contacts:");
            for (int i = 0; i < contacts.Count; i++)
            {
                Console.WriteLine($"{i+1}. {contacts[i].Name}");
            }

            // Get the index of the contact to edit
            int index = -1;
            while (index < 0 || index >= contacts.Count)
            {
                Console.WriteLine("Enter the index of the contact you want to edit:");

                //Checking user input is it's valid 
                if (!int.TryParse(Console.ReadLine(), out index) || index < 0 || index >= contacts.Count)
                {
                    Console.WriteLine("Invalid input. Please enter a valid index.");
                }
            }

            // Get the new information for the contact
            // call getNewContactInfo to retype info
            Contact editedContact = Menu.getNewContactInfo(contacts);

            // Update the contact
            contacts[index] = editedContact;
            Console.WriteLine($"{editedContact.Name} was edited!\n");
        }

        public static void DeleteContact(List<Contact> contacts){
            Console.WriteLine("Delete a contact...");
            if(contacts.Count == 0){
                Console.WriteLine("No contact available to delete");
                return;
            }
            Console.WriteLine("Enter the index of the contact you want to delete: ");
            if(!int.TryParse(Console.ReadLine(), out int indexToDelete) || indexToDelete < 0 || indexToDelete >= contacts.Count){
                Console.WriteLine("Invalid index");
                return;
            }
            Contact contactToDelete = contacts[indexToDelete];
            contacts.RemoveAt(indexToDelete);
            Console.WriteLine($"{contactToDelete.Name} has been deleted.\n");
        }
    
    
    public static void Verify(List<Contact> contacts, Contact verifyInfo){
        Console.WriteLine("\nYou have entered: " );

        //displaying what user input
        Console.WriteLine($"Name: {verifyInfo.Name}");
        Console.WriteLine($"Email: {verifyInfo.Email}");
        Console.WriteLine($"Address: {verifyInfo.Address}");

        Console.WriteLine("Is this information correct?(Y/N)");
        string userinput = Console.ReadLine();


        // user input yes or no
        if(userinput == "Y" || userinput =="y"){
            //append to the list 
            contacts.Add(verifyInfo);
            Console.WriteLine($"{verifyInfo.Name } was added!\n");
        }
        else{
            Console.WriteLine("Contact not added");
            AddContact(contacts);

        }

        



        

    }


        
    
        

}