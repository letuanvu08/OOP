using System;
using System.Collections.Generic;

namespace WindowsFormsApp
{
    class Fleet
    {
        public List<Vehicle> listVehicle;
        private Manager manager;
        private List<Staff> listStaff;

        public int NumberOfVehicle { get; set; }

        public int NumberOfStaff { get; set; }

        public Fleet()
        {
            Console.WriteLine(" Constuctor New Fleet not Parameter");
            this.listVehicle = new List<Vehicle>();
            this.listStaff = new List<Staff>();
            this.manager = null;
            this.NumberOfVehicle = 0;
            this.NumberOfStaff = 0;
            ;
        }
        public Fleet(Manager manager)
        {
            Console.WriteLine(" Constuctor New Fleet with 1 Parameter: Manager");
            this.listVehicle = new List<Vehicle>();
            this.listStaff = new List<Staff>();
            this.manager = manager;
            this.NumberOfVehicle = 0;
            this.NumberOfStaff = 0;
        }
        public List<Vehicle> GetListVehicle()
        {
            return this.listVehicle;
        }
        public void AddVehicle(Vehicle vehicle)
        {
            Console.WriteLine(" this function addVehicle  with 1 parameter: vehicle");
            listVehicle.Add(vehicle);
            this.NumberOfVehicle += 1;
        }
        public void AddVehicle(int numberOfVehicle, List<Vehicle> listVehicle)
        {
            Console.WriteLine(" this function addVehicle  with 2 parameter: numberOfVehicle and listVehicle");
            foreach (Vehicle vehicle in listVehicle)
                this.listVehicle.Add(vehicle);
            this.NumberOfVehicle += numberOfVehicle;

        }
        public void AddStaff(Staff staff)
        {
            Console.WriteLine(" this function addVehicle  with 1 parameter: staff");
            this.listStaff.Add(staff);
            this.NumberOfStaff += 1;
        }
        public void AddStaff(int numberOfStaff, List<Staff> listStaff)
        {
            Console.WriteLine(" this function addVehicle  with 2 parameter: numberOfStaff and listStaff");
            foreach (Staff staff in listStaff)
                this.listStaff.Add(staff);
            this.NumberOfStaff += numberOfStaff;
        }
        public List<string> ListBranch()
        {
            List<string> list = new List<string>();
            foreach (Vehicle vehicle in listVehicle)
            {
                if (!list.Contains(vehicle.Branch))
                {
                    list.Add(vehicle.Branch);
                }
            }
            return list;
        }
        public List<string> ListType()
        {
            List<string> list = new List<string>();
            foreach (Vehicle vehicle in listVehicle)
            {
                if (vehicle.GetType() == typeof(Car))
                {
                    Car car = (vehicle as Car);
                    if (!list.Contains(car.TypeCar.ToString()))
                    {
                        list.Add(car.TypeCar.ToString());
                    }
                }
                else
                {
                    Truck car = (vehicle as Truck);
                    if (!list.Contains(car.TypeTruck.ToString()))
                    {
                        list.Add(car.TypeTruck.ToString());
                    }
                }
            }
            return list;
        }
        public Vehicle FindVehicle(string name)
        {
            foreach (var vehicle in listVehicle)
            {
                if (vehicle.Name == name)
                    return vehicle;
            }
            return null;

        }
        public Vehicle FindVehicleById(int id)
        {
            foreach (var vehicle in listVehicle)
            {
                if (vehicle.IdVehicle == id)
                    return vehicle;
            }
            return null;

        }


    }
}
