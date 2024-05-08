namespace P0;

class Program
{
 
    
    static void Main(string[] args)
    {       
    //Create a new instance of the contacts
       List<Contact> contacts = new();
       //Reading the json file created
       Data.Deserialization(ref contacts);
    

        int input = 0;
        while(input != 4){

            //displaying user the Main menu
            Menu.printMenu();
            //store userOption value into 'input' 
            input = Menu.UserOption();

            

            //from input, check the follow....
            switch(input)
            {
                case 1://add

                //Pass in the list to AddContact inside the Logic class folder 
                Logic.AddContact(contacts);
                break;

                case 2://views
                Logic.viewContactInfo(contacts);    
                break;

                case 3://edit
                    Logic.EditContact(contacts);
                break;

                case 4:
                    Logic.DeleteContact(contacts);
                break;

                case 5:
                    Console.WriteLine("Program shutting off.... ");
                break;

                default:
                    Console.WriteLine("Invalid input, try again");
                break;
                

            }
        }
        //Write contact into the data file.
        Data.Serialize(contacts);


    }
}
    

