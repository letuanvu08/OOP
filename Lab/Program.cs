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
            RentContract rentContract3 = new RentContract();
            Fleet fleetCar = new Fleet();
            fleetCar.AddVehicle(car1);
            fleetCar.AddVehicle(car2);
            //  fleetCar.AddVehicle(2,listCar);
            car1.NumberKilometers = 10;
            car1.idVehicle = 1;
            car1.NumberOilNow = 0;
            car1.NumberFuildNow = 0;
            car2.NumberKilometers = 1000;
            car2.idVehicle = 2;
            car2.NumberOilNow = 0;
            car2.NumberFuildNow = 0;
            Truck truck = new Truck();
            truck.NumberKilometers = 100.2;
            truck.NumberOilNow = 10;
            truck.NumberFuildNow = 2000;
            Fleet fleetTruck = new Fleet();
            fleetTruck.AddVehicle(truck);
            ////////////////////
            CarRentalManagement manage = new CarRentalManagement();
            manage.addFleet(fleetCar);
            manage.addFleet(fleetTruck);
            manage.serviceFleet();
            car1.NumberKilometers = 20000;
            car2.NumberKilometers = 20000;
            manage.serviceFleet();
            try
            {
                double a=(car1.getServiceHistory.getListRecord()[3]) - (car1.getServiceHistory.getListRecord()[0]);
                Console.WriteLine("Difference kilometer two service:" + a);
            }
            catch(InvalidCastException e)
            {
                Console.WriteLine("Difference vehicle can't compare.");
            }
            try
            {
                double a = (car1.getServiceHistory.getListRecord()[1]) - (car2.getServiceHistory.getListRecord()[2]);
                Console.WriteLine("Difference kilometer two service:" + a.ToString());
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine("Difference vehicle can't compare.");
            }

        }
    }
}
