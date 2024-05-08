using System.Runtime.InteropServices.JavaScript;
using System.Text.Json;

namespace P0;

class Data{

    public static void Deserialization(ref List<Contact> contacts){
        try{

            //reading the ContactList.json file 
            string filePath = "ContactList.json";
            string Rjson = File.ReadAllText(filePath);

            contacts = JsonSerializer.Deserialize<List<Contact>>(Rjson);
            
        }
        catch(ArgumentNullException e){
            Console.WriteLine("File read...Executing ");

        }

    }


    //Serialize -publishing / writing into the file xs
    public static void Serialize(List<Contact> contacts){
        //creating the json file 
        string filePath = "ContactList.json";

        //Serialize the contact list into JSON String
        string json = JsonSerializer.Serialize(contacts);


        //Have json string be stored in the ContactList.json
        File.WriteAllText(filePath, json);
    }












}