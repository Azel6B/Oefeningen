using System;

namespace Classes_Oefening
{
    internal class User
    {
        private string _name;
        private string _password;
        private int _age;
        private int _id;
        private bool _admin;

        public User(string name, string password, int age, int id, bool admin)
        {
            _name = name;
            _password = password;
            _age = age;
            _id = id;
            _admin = admin;

            Console.WriteLine($"User created:{_name}, met wachtwoord:{_password}, en leeftijd:{_age}, is aangemaakt");
        }

        public void Login()
        {
            if (_admin)
            {
                Console.WriteLine($"Welkom admin {_name}");
            }
            else
            {
                Console.WriteLine($"Welkom gebruiker {_name}");
            }
        }
    }
}
