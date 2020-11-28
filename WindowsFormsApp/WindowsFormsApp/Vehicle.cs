using System;

namespace WindowsFormsApp
{
    abstract class Vehicle
    {
        public int CostPerDay { get; set; }

        public string Name { get; set; }

        public int IdVehicle { get; set; }

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
            get => sizeOil; set => sizeOil = value > ConstValue.MinValueOil ? value : ConstValue.MinValueOil;
        }

        public int NumberFluidNow
        {
            get;
            set;
            //set => numberFluidNow = numberFluidNow - value > 0 ? numberFluidNow - value : 0;
        }

        protected int sizeFluid;
        public int SizeFluid
        {
            get => sizeFluid;
            set => sizeFluid = value > ConstValue.MinValueFluid ? value : ConstValue.MinValueFluid;
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
        public string Description { get => description; set => description = value; }
        public TypeVehicle Type { get => type; set => type = value; }
        public bool Maintain { get => maintain; set => maintain = value; }
        public bool StateUsed { get => stateUsed; set => stateUsed = value; }

        protected string branch;
        protected string description;
        
        public TypeVehicle type;
        protected bool maintain;
        protected bool stateUsed;

        protected ServiceHistory serviceHistory;
        public ServiceHistory GetServiceHistory { get => serviceHistory; }


        // ============== METHOD SERVICE ==================== 
        abstract public void ServiceEngine(DateTime d, string error);
        abstract public void ServiceTransmission(DateTime d, string error);
        abstract public void ServiceTires(DateTime d, string error);
        
        abstract public void CheckVehicleCondition();



    }
    class Truck : Vehicle
    {
        public TypeTruck TypeTruck { get; set; }

        public Truck()
        {
            serviceHistory = new ServiceHistory();
            Console.WriteLine(" Constuctor New Truck not Parameter");
            this.Name = "";
            this.branch = "";
            this.IdVehicle = 0;
            this.TypeTruck = 0;
            this.description = "";
            this.stateUsed = false;
            this.maintain = false;
        }
        public Truck(string nameCar, string branch, int idCar)
        {
            serviceHistory = new ServiceHistory();
            Console.WriteLine(" Constuctor New Truck Parameter with three paramter: NameTruck, Branch, IdTruck");
            this.Name = nameCar;
            this.branch = branch;
            this.IdVehicle = idCar;
            this.TypeTruck = 0;
            this.description = "";
            this.stateUsed = false;
            this.maintain = false;

        }
        public Truck(string nameTruck, string branch, int idTruck, TypeTruck typeTruck, string description)
        {
            serviceHistory = new ServiceHistory();
            this.Name = nameTruck;
            this.branch = branch;
            this.IdVehicle = idTruck;
            this.TypeTruck = typeTruck;
            this.description = description;
            this.stateUsed = false;
            this.maintain = false;

        }
        public Truck(string nameTruck, string branch, int idTruck, TypeTruck typeTruck, bool stateUse, bool maintain, int costperday)
        {
            serviceHistory = new ServiceHistory();
            this.Name = nameTruck;
            this.Branch = branch;
            this.IdVehicle = idTruck;
            this.TypeTruck = typeTruck;
            this.description = "";
            this.stateUsed = stateUse;
            this.maintain = maintain;
            this.CostPerDay = costperday;
            this.type = TypeVehicle.Truck;
        }
        public Truck(string nameTruck, string branch, int idTruck, TypeTruck typeTruck, bool stateUse, bool maintain, int costperday, int oilSize,int fluidSize)
        {
            serviceHistory = new ServiceHistory();
            this.Name = nameTruck;
            this.Branch = branch;
            this.IdVehicle = idTruck;
            this.TypeTruck = typeTruck;
            this.description = "";
            this.stateUsed = stateUse;
            this.maintain = maintain;
            this.CostPerDay = costperday;
            this.type = TypeVehicle.Truck;
            this.sizeOil = oilSize;
            this.sizeFluid = fluidSize;
        }

        //===============================//

        override public void ServiceEngine(DateTime date, string error)
        {

            EngineRecord record = new EngineRecord(this.IdVehicle, date, this.numberKilometers, this.numberOilNow, error);
            Console.WriteLine("Service Engnie is call, error : " + error, ",km : " + this.numberKilometers);
            this.serviceHistory.AddRecord(record);
        }

        override public void ServiceTransmission(DateTime dateTime, string error)
        {
            TransmissionRecord record = new TransmissionRecord(this.IdVehicle, dateTime, this.numberKilometers, this.NumberFluidNow, error);
            Console.WriteLine("Service Tranmission is call, error : " + error, ",km : " + this.numberKilometers);
            this.serviceHistory.AddRecord(record);
        }
        override public void ServiceTires(DateTime dateTime, string error)
        {
            TiresRecord record = new TiresRecord(this.IdVehicle, dateTime, this.numberKilometers);
            Console.WriteLine("Service Tires is call, error : " + error, ",km : " + this.numberKilometers);
            this.serviceHistory.AddRecord(record);

        }
        override public void CheckVehicleCondition()
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
                this.ServiceEngine(d, errorEngine);
            }

            string errorTransmission = "";
            if (this.TransmissionState == TypeState.Bad || this.TransmissionState == TypeState.VeryBad)
            {
                errorTransmission += "Hong bo truyen dong !!!";
            }
            if (this.NumberFluidNow == 0)
            {
                errorTransmission += "Het nhot !!!";
            }
            if (errorTransmission != "")
            {
                this.ServiceTransmission(d, errorTransmission);
            }

            string errorTires = "";
            if (this.TiresState == TypeState.Bad || this.TiresState == TypeState.VeryBad)
            {
                errorTires += "Lung lop !!!";
            }
            if (errorTires != "")
            {
                this.ServiceTires(d, errorTires);
            }

        }
    }



    class Car : Vehicle
    {
        public TypeCar TypeCar { get; set; }

        public Car()
        {
            serviceHistory = new ServiceHistory();
            Console.WriteLine(" Constuctor New Car not Parameter");
            this.Name = "";
            this.branch = "";
            this.IdVehicle = 0;
            this.TypeCar = 0;
            this.description = "";
            this.stateUsed = false;
            this.maintain = false;
        }
        public Car(string NameCar, string Branch, int idCar)
        {
            serviceHistory = new ServiceHistory();
            Console.WriteLine(" Constuctor New Car Parameter with three paramter: NameCar, Branch, IdCar");
            this.Name = NameCar;
            this.branch = Branch;
            this.IdVehicle = idCar;
            this.TypeCar = 0;
            this.description = "";
            this.stateUsed = false;
            this.maintain = false;

        }
        public Car(string NameCar, string Branch, int idCar, TypeCar typeCar, string Description)
        {
            serviceHistory = new ServiceHistory();
            Console.WriteLine(" Constuctor New Car Parameter with 5 paramter: NameCar, Branch, IdCar, typeCar, Description");
            this.Name = NameCar;
            this.branch = Branch;
            this.IdVehicle = idCar;
            this.TypeCar = typeCar;
            this.description = Description;
            this.stateUsed = false;
            this.maintain = false;
        }
        public Car(string NameCar, string Branch, int idCar, TypeCar typecar, bool maintain, bool stateUse, int costperday)
        {
            serviceHistory = new ServiceHistory();
            Console.WriteLine(" Constuctor New Car Parameter with 7 paramter: NameCar, Branch, IdCar, typeCar, Description,maintain,stateUse");
            this.Name = NameCar;
            this.branch = Branch;
            this.IdVehicle = idCar;
            this.TypeCar = typecar;
            this.description = "";
            this.stateUsed = stateUse;
            this.maintain = maintain;
            this.CostPerDay = costperday;
            //===================This next line make sure the rent contract is able to know what type of Vehicle is assigned when creating the contract=======
            this.type = TypeVehicle.Car;
        }
        public Car(string NameCar, string Branch, int idCar, TypeCar typecar, bool maintain, bool stateUse, int costperday,int oilSize,int fluidSize)
        {
            serviceHistory = new ServiceHistory();
            Console.WriteLine(" Constuctor New Car Parameter with 7 paramter: NameCar, Branch, IdCar, typeCar, Description,maintain,stateUse");
            this.Name = NameCar;
            this.branch = Branch;
            this.IdVehicle = idCar;
            this.TypeCar = typecar;
            this.description = "";
            this.stateUsed = stateUse;
            this.maintain = maintain;
            this.CostPerDay = costperday;
            //===================This next line make sure the rent contract is able to know what type of Vehicle is assigned when creating the contract=======
            this.type = TypeVehicle.Car;
            this.sizeOil = oilSize;
            this.sizeFluid = fluidSize;
        }

        override public void ServiceEngine(DateTime date, string error)
        {

            EngineRecord record = new EngineRecord(this.IdVehicle, date, this.numberKilometers, this.numberOilNow, error);
            Console.WriteLine("Service Engnie is call, error : " + error, ",km : " + this.numberKilometers);
            this.serviceHistory.AddRecord(record);
        }

        override public void ServiceTransmission(DateTime dateTime, string error)
        {
            TransmissionRecord record = new TransmissionRecord(this.IdVehicle, dateTime, this.numberKilometers, this.NumberFluidNow, error);
            Console.WriteLine("Service Tranmission is call, error : " + error, ",km : " + this.numberKilometers);
            this.serviceHistory.AddRecord(record);
        }
        override public void ServiceTires(DateTime dateTime, string error)
        {
            TiresRecord record = new TiresRecord(this.IdVehicle, dateTime, this.numberKilometers);
            Console.WriteLine("Service Tires is call, error : " + error, ",km : " + this.numberKilometers);
            this.serviceHistory.AddRecord(record);

        }
        override public void CheckVehicleCondition()
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
                this.ServiceEngine(d, errorEngine);
            }

            string errorTransmission = "";
            if (this.TransmissionState == TypeState.Bad || this.TransmissionState == TypeState.VeryBad)
            {
                errorTransmission += "Hong bo truyen dong !!!";
            }
            if (this.NumberFluidNow == 0)
            {
                errorTransmission += "Het nhot !!!";
            }
            if (errorTransmission != "")
            {
                this.ServiceTransmission(d, errorTransmission);
            }

            string errorTires = "";
            if (this.TiresState == TypeState.Bad || this.TiresState == TypeState.VeryBad)
            {
                errorTires += "Lung lop !!!";
            }
            if (errorTires != "")
            {
                this.ServiceTires(d, errorTires);
            }


        }

    }

}
