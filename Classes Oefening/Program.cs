using Classes_Oefening;
using System;

namespace Classes_Oefening
{

}
internal class Program
{
    static void Main(string[] args)
    {
        bool admin = false;
        Console.WriteLine("Om een account aan te maken, schrijf eerst uw naam:");
        string userInputName = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Schrijf nu uw wachtwoord:");
        string userInputPass = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("en als laatst uw leeftijd:");
        int userInputAge;
        string ageInputRaw = Console.ReadLine();
        Console.Clear();

        while (!int.TryParse(ageInputRaw, out userInputAge) || userInputAge < 0)
        {
            Console.WriteLine("Ongeldige leeftijd. Voer een positief geheel getal in:");
            ageInputRaw = Console.ReadLine();
            Console.Clear();
        }

        if (userInputName.ToLower() == "aslan")
        {
            admin = true;
        }

        User user1 = new User(userInputName, userInputPass, userInputAge, 1, admin);
        user1.Login();
    }
}
