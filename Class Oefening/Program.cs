using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Oefening
{
    internal class Car
    {
        private string _name;
        private string _brand;
        private int _amountOfDoor;

        public Car(string name, string brand, int amountOfDoors)
        {
            _name = name;
            _brand = brand;
            _amountOfDoor = amountOfDoors;
        }

        public void printCarInfo()
        {
            Console.WriteLine($"Car Name: {_name} en merk: {_brand} en {_amountOfDoor} deuren");
        }
    }
}
