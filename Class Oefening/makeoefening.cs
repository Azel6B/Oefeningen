using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Oefening
{
    internal class makeoefening
    {
        static void Main(string[] args)
        {
            List<Car> carList = new List<Car>();
            Car car1 = new Car("Agila", "Opel", 5);
            car1.printCarInfo();
            carList.Add(car1); ;
            Car car2 = new Car("Clio", "Renault", 4);
            carList.Add(car2);

            foreach (Car car in carList)
            {
                car.printCarInfo();
            }
        }
    }
}
