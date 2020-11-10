using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Car car2 = new Car("xe1", "vinfast", 1234);
            List<Vehicle> listCar = new List<Vehicle>();
            listCar.Append(car1);
            listCar.Append(car2);
            Custormer custormer1 = new Custormer();
            Custormer custormer2 = new Custormer("name","134");
            Manager manager1 = new Manager();
            Manager manager2 = new Manager("vu","12345");
            RentContract rentContract1 = new RentContract();
            RentContract rentContract2 = new RentContract(custormer2,car2);
            RentContract rentContract3 = new RentContract(custormer2, car2,123,123,134);
            Fleet fleetCar = new Fleet();
            fleetCar.AddVehicle(car1);
            fleetCar.AddVehicle(2,listCar);
            car1.NumberKilometers = 1000;
            car1.NumberOilNow = 0;
            car1.NumberFuildNow = 0;

            ////////////////////
            CarRentalManagement manage = new CarRentalManagement();
            manage.addFleet(fleetCar);
            manage.serviceFleet();

        }
    }
}
