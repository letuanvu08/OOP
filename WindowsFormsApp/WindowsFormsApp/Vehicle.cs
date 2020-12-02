using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

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

        public TypeState EngineState { get; set; }

        public TypeState TransmissionState { get; set; }

        public TypeState TiresState { get; set; }
        //protected TypeState TransmissionState;
        //protected TypeState TiresState;

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
        [JsonProperty]
        protected ServiceHistory serviceHistory;
        [JsonProperty]
        public ServiceHistory GetServiceHistory { get => serviceHistory; set => serviceHistory = value; }


        // ============== METHOD SERVICE ==================== 
        abstract public void ServiceEngine();
        abstract public void ServiceTransmission();
        abstract public void ServiceTires();
        
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

        public override void ServiceEngine()
        {
            DateTime dateTime = DateTime.Now;
            string desc= "";
            if ((this.EngineState == TypeState.Bad) || (EngineState == TypeState.VeryBad))
            {
                desc += "Fix the engine from the " + EngineState.ToString();
                this.EngineState = TypeState.VeryGood;
            }

            if (numberOilNow < sizeOil)
            {
                desc += ", Filled the oil Tank to 100%";
                numberOilNow = sizeOil;
            }

            if (desc == "")
            {
                desc = $"Nothing needs maintenance for this {Name} Truck's Engine.";
            }
            else
            {
                desc += $"for this {Name} Truck's Engine";
                EngineRecord record = new EngineRecord(dateTime,desc);
                this.serviceHistory.AddRecord(record);
            }
            
        }

        public override void ServiceTransmission()
        {
            DateTime dateTime = DateTime.Now;
            string desc= "";
            if ((this.TransmissionState == TypeState.Bad) || (TransmissionState == TypeState.VeryBad))
            {
                desc += "Fix the engine from the " + TransmissionState.ToString();
                this.TransmissionState = TypeState.VeryGood;
            }

            if (NumberFluidNow < sizeFluid)
            {
                desc += ", Added fluid for better motion";
                NumberFluidNow = sizeFluid;
            }

            if (desc == "")
            {
                desc = $"Nothing needs maintenance for this {Name} Truck's Transmission.";
            }
            else
            {
                desc += $"for this {Name} Truck's Engine";
                TransmissionRecord record = new TransmissionRecord(dateTime,desc);
                this.serviceHistory.AddRecord(record);
            }
        }
        public override void ServiceTires()
        {
            DateTime dateTime = DateTime.Now;
            string desc= "";
            if ((TiresState == TypeState.Bad) || (TiresState == TypeState.VeryBad))
            {
                desc += $"The Tires is now full of Air. This {Name} Truck can move fast now";
                TiresRecord record = new TiresRecord(dateTime, desc);
                this.serviceHistory.AddRecord(record);
                TiresState = TypeState.VeryGood;
            }
        }
        public override void CheckVehicleCondition()
        {
            ServiceEngine();
            ServiceTransmission();
            ServiceTires();
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

        public override void ServiceEngine()
        {
            DateTime dateTime = DateTime.Now;
            string desc= "";
            if ((this.EngineState == TypeState.Bad) || (EngineState == TypeState.VeryBad))
            {
                desc += "Fix the engine from the " + EngineState.ToString();
                this.EngineState = TypeState.VeryGood;
            }

            if (numberOilNow < sizeOil)
            {
                desc += ", Filled the oil Tank to 100%";
                numberOilNow = sizeOil;
            }

            if (desc == "")
            {
                desc = $"Nothing needs maintenance for this {Name} car's Engine.";
            }
            else
            {
                desc += $"for this {Name} car's Engine";
                EngineRecord record = new EngineRecord(dateTime,desc);
                this.serviceHistory.AddRecord(record);
            }
            
        }

        public override void ServiceTransmission()
        {
            DateTime dateTime = DateTime.Now;
            string desc= "";
            if ((this.TransmissionState == TypeState.Bad) || (TransmissionState == TypeState.VeryBad))
            {
                desc += "Fix the engine from the " + TransmissionState.ToString();
                this.TransmissionState = TypeState.VeryGood;
            }

            if (NumberFluidNow < sizeFluid)
            {
                desc += ", Added fluid for better motion";
                NumberFluidNow = sizeFluid;
            }

            if (desc == "")
            {
                desc = $"Nothing needs maintenance for this {Name} car's Transmission.";
            }
            else
            {
                desc += $"for this {Name} car's Engine";
                TransmissionRecord record = new TransmissionRecord(dateTime,desc);
                this.serviceHistory.AddRecord(record);
            }
        }
        public override void ServiceTires()
        {
            DateTime dateTime = DateTime.Now;
            string desc= "";
            if ((TiresState == TypeState.Bad) || (TiresState == TypeState.VeryBad))
            {
                desc += $"The Tires is now full of Air. This {Name} car can move fast now";
                TiresRecord record = new TiresRecord(dateTime, desc);
                TiresState = TypeState.VeryGood;
                this.serviceHistory.AddRecord(record);
            }
        }
        public override void CheckVehicleCondition()
        {
            ServiceEngine();
            ServiceTires();
            ServiceTransmission();
        }

    }

}
