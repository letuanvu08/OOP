﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    static public class ConstValue
    {
        public const int MIN_VALUE_OIL = 10;
        public const int MIN_VALUE_FLUID = 10;

        public const int ERROR_CAR_KILOMETERS = 1000;
    }

    enum TypeVehicle
    {
        Car = 0,
        Truck = 1,

    }
    enum TypeCar
    {
        MICRO,
        SEDAN,
        CUV,
        SUV,
        HATCHBACK,
        SUPERCAR,
        ROADSTER

    }
    enum TypeTruck
    {
        NINITRUCK,
        TRUCK,
        BIGTRUCK
    }

    enum TypeState
    {
        VeryBad,
        Bad,
        Good,
        VeryGood,
    }

    abstract class Vehicle
    {
        public int costperDay;
        public int CostperDay { get => costperDay; set => costperDay = value; }
        protected string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        protected int id;
        public int idVehicle
        {
            get { return id; }
            set { id = value; }
        }
        // this is oil and fluid in the vehicle ( now and size)
        protected int numberOilNow;
        public int NumberOilNow
        {
            get => numberOilNow;
            set => numberOilNow = value;
            //set => numberOilNow = numberOilNow - value > 0 ? numberOilNow - value : 0;
        }
        protected int sizeOil;
        public int SizeOil
        {
            get => sizeOil; set => sizeOil = value > ConstValue.MIN_VALUE_OIL ? value : ConstValue.MIN_VALUE_OIL;
        }

        protected int numberFluidNow;
        public int NumberFuildNow
        {
            get => numberFluidNow;
            set => numberFluidNow = value;
            //set => numberFluidNow = numberFluidNow - value > 0 ? numberFluidNow - value : 0;
        }

        protected int sizeFluid;
        public int SizeFluid
        {
            get => sizeFluid;
            set => sizeFluid = value > ConstValue.MIN_VALUE_FLUID ? value : ConstValue.MIN_VALUE_FLUID;
        }

        protected double numberKilometers;
        public double NumberKilometers
        {
            get => numberKilometers;
            set => numberKilometers = value > 0 ? value : 0;
        }

        protected TypeState EngineState;
        protected TypeState TransmissionState;
        protected TypeState TiresState;
        // ==================================================== //
        // ================ END COMMENT ======================= //
        public string Branch { get => branch; set => branch = value; }
        protected string Description { get => description; set => description = value; }
        protected TypeVehicle Type { get => type; set => type = value; }
        public bool Maintain { get => maintain; set => maintain = value; }
        public bool StateUsed { get => stateUsed; set => stateUsed = value; }

        protected string branch;
        protected string description;
        protected string roleId;
        protected TypeVehicle type;
        protected bool maintain;
        protected bool stateUsed;

        protected ServiceHistory serviceHistory = new ServiceHistory();


        // ============== METHOD SERVICE ==================== 
        abstract public void serviceEngine(DateTime d, string error);
        abstract public void serviceTransmission(DateTime d, string error);
        abstract public void serviceTires(DateTime d, string error);

        abstract public void checkVehicleCondition();



    }
    class Car : Vehicle
    {
        private TypeCar typeCar;

        public TypeCar TypeCar { get => typeCar; set => typeCar = value; }
        public Car()
        {

            Console.WriteLine(" Constuctor New Car not Parameter");
            this.name = "";
            this.branch = "";
            this.idVehicle = 0;
            this.typeCar = 0;
            this.description = "";
            this.stateUsed = false;
            this.maintain = false;
        }
        public Car(string NameCar, string Branch, int idCar)
        {
            Console.WriteLine(" Constuctor New Car Parameter with three paramter: NameCar, Branch, IdCar");
            this.name = NameCar;
            this.branch = Branch;
            this.idVehicle = idCar;
            this.typeCar = 0;
            this.description = "";
            this.stateUsed = false;
            this.maintain = false;

        }
        public Car(string NameCar, string Branch, int idCar, TypeCar typeCar, string Description)
        {
            Console.WriteLine(" Constuctor New Car Parameter with 5 paramter: NameCar, Branch, IdCar, typeCar, Description");
            this.name = NameCar;
            this.branch = Branch;
            this.idVehicle = idCar;
            this.typeCar = typeCar;
            this.description = Description;
            this.stateUsed = false;
            this.maintain = false;

        }
        public Car(string NameCar, string Branch, int idCar, TypeCar typecar, string Description, bool maintain, bool stateUse)
        {
            Console.WriteLine(" Constuctor New Car Parameter with 7 paramter: NameCar, Branch, IdCar, typeCar, Description,maintain,stateUse");
            this.name = NameCar;
            this.branch = Branch;
            this.idVehicle = idCar;
            this.typeCar = typecar;
            this.description = Description;
            this.stateUsed = stateUse;
            this.maintain = maintain;
        }

        override public void serviceEngine(DateTime date, string error)
        {

            EngineRecord record = new EngineRecord(this.id, date, this.numberKilometers, this.numberOilNow, error);
            Console.WriteLine("Service Engnie is call, error : " + error, ",km : " + this.numberKilometers);
            this.serviceHistory.listRecord.Add(record);
        }

        override public void serviceTransmission(DateTime dateTime, string error)
        {
            TransmissionRecord record = new TransmissionRecord(this.id, dateTime, this.numberKilometers, this.numberFluidNow, error);
            Console.WriteLine("Service Tranmission is call, error : " + error, ",km : " + this.numberKilometers);
            this.serviceHistory.listRecord.Add(record);
        }
        override public void serviceTires(DateTime dateTime, string error)
        {
            TiresRecord record = new TiresRecord(this.id, dateTime, this.numberKilometers);
            Console.WriteLine("Service Tires is call, error : " + error, ",km : " + this.numberKilometers);
            this.serviceHistory.listRecord.Add(record);

        }
        override public void checkVehicleCondition()
        {
            Console.WriteLine("Car is serviced : ....");
            DateTime d = new DateTime();
            string errorEngine = "";
            if (this.EngineState == TypeState.Bad || this.EngineState == TypeState.VeryBad)
            {
                errorEngine += "Hong may !!!";
            }
            if (this.NumberOilNow == 0)
            {
                errorEngine += "Het xang !!!";
            }
            if (errorEngine != "")
            {
                this.serviceEngine(d, errorEngine);
            }

            string errorTransmission = "";
            if (this.TransmissionState == TypeState.Bad || this.TransmissionState == TypeState.VeryBad)
            {
                errorTransmission += "Hong bo truyen dong !!!";
            }
            if (this.NumberFuildNow == 0)
            {
                errorTransmission += "Het nhot !!!";
            }
            if (errorTransmission != "")
            {
                this.serviceTransmission(d, errorTransmission);
            }

            string errorTires = "";
            if (this.TiresState == TypeState.Bad || this.TiresState == TypeState.VeryBad)
            {
                errorTires += "Lung lop !!!";
            }
            if (errorTires != "")
            {
                this.serviceTires(d, errorTires);
            }


        }

    }
    class Truck : Vehicle
    {
        private TypeTruck typeTruck;

        public TypeTruck TypeTruck { get => typeTruck; set => typeTruck = value; }
        public Truck()
        {
            Console.WriteLine(" Constuctor New Truck not Parameter");
            this.name = "";
            this.branch = "";
            this.idVehicle = 0;
            this.typeTruck = 0;
            this.description = "";
            this.stateUsed = false;
            this.maintain = false;
        }
        public Truck(string NameCar, string Branch, int idCar)
        {
            Console.WriteLine(" Constuctor New Truck Parameter with three paramter: NameTruck, Branch, IdTruck");
            this.name = NameCar;
            this.branch = Branch;
            this.idVehicle = idCar;
            this.typeTruck =0;
            this.description = "";
            this.stateUsed = false;
            this.maintain = false;

        }
        public Truck(string NameTruck, string Branch, int idTruck, TypeTruck typeTruck, string Description)
        {
            this.name = NameTruck;
            this.branch = Branch;
            this.idVehicle = idTruck;
            this.typeTruck = typeTruck;
            this.description = Description;
            this.stateUsed = false;
            this.maintain = false;

        }
        public Truck(string NameTruck, string Branch, int idTruck, TypeTruck typeTruck, string Description, bool stateUse, bool maintain)
        {
            this.name = NameTruck;
            this.Branch = Branch;
            this.idVehicle = idTruck;
            this.typeTruck = typeTruck;
            this.description = Description;
            this.stateUsed = stateUse;
            this.maintain = maintain;
        }

        //===============================//

        override public void serviceEngine(DateTime date, string error)
        {

            EngineRecord record = new EngineRecord(this.id, date, this.numberKilometers, this.numberOilNow, error);
            Console.WriteLine("Service Engnie is call, error : " + error, ",km : " + this.numberKilometers);
            this.serviceHistory.listRecord.Add(record);
        }

        override public void serviceTransmission(DateTime dateTime, string error)
        {
            TransmissionRecord record = new TransmissionRecord(this.id, dateTime, this.numberKilometers, this.numberFluidNow, error);
            Console.WriteLine("Service Tranmission is call, error : " + error, ",km : " + this.numberKilometers);
            this.serviceHistory.listRecord.Add(record);
        }
        override public void serviceTires(DateTime dateTime, string error)
        {
            TiresRecord record = new TiresRecord(this.id, dateTime, this.numberKilometers);
            Console.WriteLine("Service Tires is call, error : " + error, ",km : " + this.numberKilometers);
            this.serviceHistory.listRecord.Add(record);

        }
        override public void checkVehicleCondition()
        {
            Console.WriteLine("Truck is serviced ....");
            DateTime d = new DateTime();
            string errorEngine = "";
            if (this.EngineState == TypeState.Bad || this.EngineState == TypeState.VeryBad)
            {
                errorEngine += "Hong may !!!";
            }
            if (this.NumberOilNow == 0)
            {
                errorEngine += "Het xang !!!";
            }
            if (errorEngine != "")
            {
                this.serviceEngine(d, errorEngine);
            }

            string errorTransmission = "";
            if (this.TransmissionState == TypeState.Bad || this.TransmissionState == TypeState.VeryBad)
            {
                errorTransmission += "Hong bo truyen dong !!!";
            }
            if (this.NumberFuildNow == 0)
            {
                errorTransmission += "Het nhot !!!";
            }
            if (errorTransmission != "")
            {
                this.serviceTransmission(d, errorTransmission);
            }

            string errorTires = "";
            if (this.TiresState == TypeState.Bad || this.TiresState == TypeState.VeryBad)
            {
                errorTires += "Lung lop !!!";
            }
            if (errorTires != "")
            {
                this.serviceTires(d, errorTires);
            }

        }
    }
    abstract class Account
    {
        protected string name;

        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Sex { get => sex; set => sex = value; }
        public int Age { get => age; set => age = value; }

        protected string password;
        protected string email;
        protected string phoneNumber;
        protected int age;
        protected string sex;



    }
    class Custormer : Account
    {

        private string address;
        private string career;

        public string Address { get => address; set => address = value; }
        public string Career { get => career; set => career = value; }
        public Custormer()
        {
            Console.WriteLine(" Constuctor New Custormer not parameter");
            this.name = "";
            this.password = "";
            this.email = "";
            this.phoneNumber = "";
            this.age = 0;
            this.sex = "male";
            this.address = "";
            this.career = "";
        }
        public Custormer(string name, string Password)
        {
            Console.WriteLine(" Constuctor New Custormer with 2 parameter");
            this.name = name;
            this.password = Password;
            this.email = "";
            this.phoneNumber = "";
            this.age = 0;
            this.sex = "male";
            this.address = "";
            this.career = "";
        }
        public Custormer(string name, string Password, int Age, string Sex, string Career)
        {
            Console.WriteLine(" Constuctor New Custormer with 5 parameter");
            this.name = name;
            this.password = Password;
            this.email = "";
            this.phoneNumber = "";
            this.age = Age;
            this.sex = Sex;
            this.address = "";
            this.career = Career;
        }
        public Custormer(string name, string Password, string Email, string PhoneNumber, string Sex, int Age, string Address, string Career)
        {
            Console.WriteLine(" Constuctor New Custormer with 8 parameter");
            this.name = name;
            this.password = Password;
            this.email = Email;
            this.phoneNumber = PhoneNumber;
            this.age = Age;
            this.sex = Sex;
            this.address = Address;
            this.career = Career;

        }
    }
    class Manager : Account
    {
        private string department;
        private int salary;

        public Manager()
        {
            Console.WriteLine(" Constuctor New Manager not Parmater");
            this.name = "";
            this.password = "";
            this.email = "";
            this.phoneNumber = "";
            this.age = 0;
            this.sex = "male";
            this.department = "";
            this.salary = 0;
        }
        public Manager(string name, string Password)
        {
            Console.WriteLine(" Constuctor New Manager with 2 parameter");
            this.name = name;
            this.password = Password;
            this.email = "";
            this.phoneNumber = "";
            this.age = 0;
            this.sex = "male";
            this.department = "";
            this.salary = 0;

        }
        public Manager(string name, string Password, string Email, string PhoneNumber, string Sex, int Age, string Department, int Salary)
        {
            Console.WriteLine(" Constuctor New Mamager with 5 parameter");
            this.name = name;
            this.password = Password;
            this.email = Email;
            this.phoneNumber = PhoneNumber;
            this.age = Age;
            this.sex = Sex;
            this.department = Department;
            this.salary = Salary;

        }

        public string Department { get => department; set => department = value; }
        public int Salary { get => salary; set => salary = value; }
    }
    class Staff : Account
    {
        private string department;
        private int salary;
        public int Salary { get => salary; set => salary = value; }
        public Staff() { }
        public Staff(string name, string Password)
        {
            this.name = name;
            this.password = Password;
            this.email = "";
            this.phoneNumber = "";
            this.age = 0;
            this.sex = "male";
            this.department = "";
            this.salary = 0;

        }
        public Staff(string name, string Password, string Email, string PhoneNumber, string Sex, int Age, string Department, int Salary)
        {
            this.name = name;
            this.password = Password;
            this.email = Email;
            this.phoneNumber = PhoneNumber;
            this.age = Age;
            this.sex = Sex;
            this.department = Department;
            this.salary = Salary;

        }

        public string Department { get => department; set => department = value; }
    }
    class RentContract
    {
        private int id;

        public int Id { get => id; set => id = value; }
        public Custormer CustormerRentCar { get => custormerRentCar; set => custormerRentCar = value; }
        public Vehicle VehicleRented { get => vehicleRented; set => vehicleRented = value; }
        public int DateStartRent { get => dateStartRent; set => dateStartRent = value; }
        public int DateEndRent { get => dateEndRent; set => dateEndRent = value; }
        public int TotalCost { get => totalCost; set => totalCost = value; }
        public string Description { get => description; set => description = value; }

        private Custormer custormerRentCar;
        private Vehicle vehicleRented;
        private int dateStartRent;
        private int dateEndRent;
        private int totalCost;

        private string description;
        public RentContract()
        {
            Console.WriteLine(" Constuctor New RentContract not Parameter");
            this.custormerRentCar = null;
            this.vehicleRented = null;
            this.dateStartRent = 0;
            this.DateEndRent = 0;
            this.totalCost = 0;
        }
        public RentContract(Custormer custormer, Vehicle vehicle)
        {
            Console.WriteLine(" Constuctor New RentContract with 2 parameter: Custormer,Car");
            this.custormerRentCar = custormer;
            this.vehicleRented = vehicle;
            this.dateStartRent = 0;
            this.DateEndRent = 0;
            this.totalCost = 0;

            this.description = "";
        }
        public RentContract(Custormer custormer, Car car, int DateStartRent, int DateEndRent, int TotalCost)
        {
            Console.WriteLine(" Constuctor New RentContract with 5 parameter: Custormer,Car,...");
            this.custormerRentCar = custormer;
            this.vehicleRented = car;
            this.dateStartRent = DateStartRent;
            this.DateEndRent = DateEndRent;
            this.totalCost = TotalCost;
            this.description = "";
        }
        public RentContract(Custormer custormer, Car car, int DateStartRent, int DateEndRent, int TotalCost, string description)
        {
            Console.WriteLine(" Constuctor New RentContract with 6 parameter: Custormer,Car,...");
            this.custormerRentCar = custormer;
            this.vehicleRented = car;
            this.dateStartRent = DateStartRent;
            this.DateEndRent = DateEndRent;
            this.totalCost = TotalCost;
            this.description = description;
        }
    }
    class Fleet
    {
        public List<Vehicle> listVehicle;
        private int numberOfVehicle;
        private Manager manager;
        private List<Staff> listStaff;
        private int numberOfStaff;

        public int NumberOfVehicle { get => numberOfVehicle; set => numberOfVehicle = value; }
        public int NumberOfStaff { get => numberOfStaff; set => numberOfStaff = value; }

        public Fleet()
        {
            Console.WriteLine(" Constuctor New Fleet not Parameter");
            this.listVehicle = new List<Vehicle>();
            this.listStaff = new List<Staff>();
            this.manager = null;
            this.numberOfVehicle = 0;
            this.numberOfStaff = 0;
            ;
        }
        public Fleet(Manager manager)
        {
            Console.WriteLine(" Constuctor New Fleet with 1 Parameter: Manager");
            this.listVehicle = new List<Vehicle>();
            this.listStaff = new List<Staff>();
            this.manager = manager;
            this.numberOfVehicle = 0;
            this.numberOfStaff = 0;
        }
        public List<Vehicle> getListVehicle()
        {
            return this.listVehicle;
        }
        public void AddVehicle(Vehicle vehicle)
        {
           
            Console.WriteLine(" this function addVehicle  with 1 parameter: vehicle");
            listVehicle.Add(vehicle);
            foreach (Vehicle vehicle in listVehicle)
           
            this.numberOfVehicle += 1;
        }
        public void AddVehicle(int numberOfVehicle, List<Vehicle> listVehicle)
        {
            Console.WriteLine(" this function addVehicle  with 2 parameter: numberOfVehicle and listVehicle");
            foreach (Vehicle vehicle in listVehicle)
            {
                this.listVehicle.Add(vehicle);
                //if (vehicle.GetType() == typeof(Car))
                //{
                //    Console.WriteLine("I AM A FUCKING CAR");
                //}
                //else
                //{
                //    Console.WriteLine("I AM ONLY A VEHICLE :(((((((((((((");
                //}
            }
            this.numberOfVehicle += numberOfVehicle;

        }
        public void AddStaff(Staff staff)
        {
            Console.WriteLine(" this function addVehicle  with 1 parameter: staff");
            this.listStaff.Append(staff);
            this.numberOfStaff += 1;
        }
        public void AddStaff(int numberOfStaff, List<Staff> listStaff)
        {
            Console.WriteLine(" this function addVehicle  with 2 parameter: numberOfStaff and listStaff");
            foreach (Staff staff in listStaff)
                this.listStaff.Append(staff);
            this.numberOfStaff += numberOfStaff;
        }

    }
    abstract class Record
    {
        protected int ID;
        protected DateTime dateTime;
        protected double numberKilometers;
    }

    class EngineRecord : Record
    {
        int numberOilChange;
        string error;

        public EngineRecord(int ID, DateTime dateTime, double numberKM, int numberOil, string error)
        {
            this.ID = ID;
            this.dateTime = dateTime;
            this.numberKilometers = numberKM;
            this.numberOilChange = numberOil;
            this.error = error;
        }
    }

    class TransmissionRecord : Record
    {
        int numberFluidChange;
        string error;
        public TransmissionRecord(int ID, DateTime dateTime, double numberKM, int numberFluid, string error)
        {
            this.ID = ID;
            this.dateTime = dateTime;
            this.numberKilometers = numberKM;
            this.numberFluidChange = numberFluid;
            this.error = error;
        }
    }

    class TiresRecord : Record
    {
        public TiresRecord(int ID, DateTime dateTime, double numberKM)
        {
            this.ID = ID;
            this.dateTime = dateTime;
            this.numberKilometers = numberKM;
        }
    }

    class ServiceHistory
    {
        public List<Record> listRecord;

        ServiceHistory(List<Record> lst)
        {
            this.listRecord = lst;
        }
        public ServiceHistory()
        {
            listRecord = new List<Record>();
        }

    }
    interface BookAndRent
    {
        List<Vehicle> FindCarAvailable(int type, string Branch);

            
       public class CarRentalManagement
        {
            private List<Fleet> listFleet;
            public CarRentalManagement()
            {
                listFleet = new List<Fleet>();
            }
            public void addFleet(Fleet fleet)
            {
                this.listFleet.Add(fleet);
            }
            public void serviceFleet()
            {
                foreach (Fleet fleet in listFleet)
                {

                    foreach (Vehicle vehicle in fleet.listVehicle)
                    {
                        Console.WriteLine("...........");
                        vehicle.checkVehicleCondition();
                    }

                }
            }

        }
    }
}
