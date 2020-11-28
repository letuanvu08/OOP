using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    static public class ConstValue
    {
        public const int MinValueOil = 10;
        public const int MinValueFluid = 10;

        public const int ErrorCarKilometers = 1000;
    }

    enum TypeVehicle
    {
        Car = 0,
        Truck = 1,

    }
    enum TypeCar
    {
        Micro,
        Sedan,
        Cuv,
        Suv,
        Hatchback,
        Supercar,
        Roadster

    }
    enum TypeTruck
    {
        Minitruck,
        Truck,
        Bigtruck
    }

    enum TypeState
    {
        VeryBad,
        Bad,
        Good,
        VeryGood,
    }

    enum TypeInsurance
    {
        Wood,
        Iron,
        Silver,
        Gold,
        Diamond
    }

    
    interface IBookAndRent
    {

        List<Vehicle> FindCarAvailable(string type, string branch);
    }
}
