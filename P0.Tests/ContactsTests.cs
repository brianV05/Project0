//using statement which is referencing contact 
using System.Security.Cryptography.X509Certificates;
using P0;
using System.Text.Json;

namespace P0.Tests;

public class ContactsTests
{
    [Fact]
    //testing viewContact method 
    public void Test1()
    {

       //Arrange - Create any variables or objects you'll need for your test
        List<Contact> contacts = new List<Contact>
        {
            new Contact("John", "john@example.com", "123st"),
            new Contact("Jane", "jane@example.com", "987blvd")
        };
        StringWriter sw = new StringWriter();
        Console.SetOut(sw); 

        string expectedOutput = $"NAME: John, EMAIL: john@example.com, ADDRESS: 123st \n" +
                                $"NAME: Jane, EMAIL: jane@example.com, ADDRESS: 987blvd \n";

        //Act - Call the code that you are trying to test
        Logic.viewContactInfo(contacts);

        //Assert - Condition under which the test will pass/fail
        string actualOutput = sw.ToString();
        Assert.Equal(expectedOutput, actualOutput);


    }
}