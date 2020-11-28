using System;
using System.Collections.Generic;

namespace WindowsFormsApp
{
    class CarRentalManagement : IBookAndRent
    {
        private List<Fleet> listFleet;
        private List<RentContract> listContract;
        public CarRentalManagement()
        {
            listFleet = new List<Fleet>();
            listContract = new List<RentContract>();
        }
        public void AddFleet(Fleet fleet)
        {
            this.listFleet.Add(fleet);
        }
        public void ServiceFleet()
        {
            foreach (Fleet fleet in listFleet)
            {

                foreach (Vehicle vehicle in fleet.listVehicle)
                {
                    Console.WriteLine("...........");
                    vehicle.CheckVehicleCondition();
                }

            }
        }
        public List<Vehicle> FindCarAvailable(string type, string branch)
        {
            List<Vehicle> list = new List<Vehicle>();
            if(Enum.IsDefined(typeof(TypeCar),type))
            
            {

                foreach (Vehicle vehicle in listFleet[0].listVehicle)
                {
                    Car car = vehicle as Car;
                    if (car.TypeCar == (TypeCar)Enum.Parse(typeof(TypeCar),type) && car.Branch == branch)
                        list.Add(car);
                }

            }
            else
            {
                foreach (Vehicle vehicle in listFleet[1].listVehicle)
                {
                    Truck car = vehicle as Truck;
                    if (car.TypeTruck == (TypeTruck)Enum.Parse(typeof(TypeTruck), type) && car.Branch == branch)
                        list.Add(car);
                }
            }
            return list;
        }
        
        public List<string> GetlistType(string type)
        {
            if (type == "car")
            {
                return listFleet[0].ListType();
            }
            else
            {
                return listFleet[1].ListType();
            }

        }
        public List<string> GetlistBranch(string type)
        {
            if (type == "car")
            {
                return listFleet[0].ListBranch();
            }
            else
            {
                return listFleet[1].ListBranch();
            }

        }
        public Vehicle FindVehicle(string name)
        {
            foreach (Fleet fleet in listFleet)
            {
                if (fleet.FindVehicle(name) != null)
                    return fleet.FindVehicle(name);
            }
            return null;

        }
        // -===============================Contract Supporting Function=======================
        public void AddContract(RentContract contract)
        {
            this.listContract.Add(contract);
        }
        public List<RentContract> GetContracts()
        {
            return this.listContract;
        }
        public List<RentContract> FindContractsWithDateStart(DateTime date)
        {
            List<RentContract> returnContracts = new List<RentContract>();
            foreach (RentContract contract in listContract)
            {
                if (contract.DateStartRent == date)
                {
                    returnContracts.Add(contract);
                }
            }
            return returnContracts;
        }
        public List<RentContract> FindContractsWithDateEnd(DateTime date)
        {
            List<RentContract> returnContracts = new List<RentContract>();
            foreach (RentContract contract in listContract)
            {
                if (contract.DateEndRent == date)
                {
                    returnContracts.Add(contract);
                }
            }
            return returnContracts;
        }
        public List<RentContract> GetCarRelatedConTracts()
        {
            List<RentContract> returnContracts = new List<RentContract>();
            foreach (RentContract contract in listContract)
            {
                if (contract.VehicleRented.type == TypeVehicle.Car)
                {
                    returnContracts.Add(contract);
                }
            }
            return returnContracts;
        }
        public List<RentContract> GetTruckRelatedConTracts()
        {
            List<RentContract> returnContracts = new List<RentContract>();
            foreach (RentContract contract in listContract)
            {
                if (contract.VehicleRented.type == TypeVehicle.Truck)
                {
                    returnContracts.Add(contract);
                }
            }
            return returnContracts;
        }

        public List<Vehicle> GetListVehicle(string type)
        {
            if (type == "car")
                return listFleet[0].GetListVehicle();
            else return listFleet[1].GetListVehicle();
        }
        public Vehicle FindVehiclebyId(int id)
        {
            foreach (Fleet fleet in listFleet)
            {
                if (fleet.FindVehicleById(id)!= null)
                    return fleet.FindVehicleById(id);
            }
            return null;

        }
    }
}
