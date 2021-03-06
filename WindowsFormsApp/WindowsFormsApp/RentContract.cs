﻿using System;

namespace WindowsFormsApp
{
    class RentContract
    {
       
        public int Id { get; set; }

        public Customer CustomerRentCar { get; set; }

        public Vehicle VehicleRented { get; set; }

        public Insurance InsuranceUsed { get; set; }

        public DateTime DateStartRent { get; set; }

        public DateTime DateEndRent { get; set; }

        public int TotalCost { get; set; }

        public string Description { get; set; }
        
        public ContractStatus Status { get; set; }
        public bool IsApproved { get; set; }

        public RentContract()
        {
            Console.WriteLine(" Constuctor New RentContract not Parameter");
            this.CustomerRentCar = null;
            this.VehicleRented = null;

            this.TotalCost = 0;
        }
        public RentContract(Customer customer, Vehicle vehicle)
        {
            Console.WriteLine(" Constuctor New RentContract with 2 parameter: Customer,Car");
            this.CustomerRentCar = customer;
            this.VehicleRented = vehicle;

            this.TotalCost = 0;

            this.Description = "";
        }
        public RentContract(Vehicle vehicle, DateTime dateStartRent, DateTime dateEndRent)
        {
            Console.WriteLine(" Constuctor New RentContract with 5 parameter: Customer,Car,...");

            this.VehicleRented = vehicle;
            this.DateStartRent = dateStartRent;
            this.DateEndRent = dateEndRent;

            this.Description = "";
        }
        public RentContract(Vehicle vehicle, DateTime dateStartRent, DateTime dateEndRent, int totalCost)
        {
            Console.WriteLine(" Constuctor New RentContract with 6 parameter: Customer,Car,...");

            this.VehicleRented = vehicle;
            this.DateStartRent = dateStartRent;
            this.DateEndRent = dateEndRent;
            this.TotalCost = totalCost;
            this.Description = "";
        }
        public RentContract(int id, Vehicle vehicle, DateTime dateStartRent, DateTime dateEndRent, int totalCost)
        {
            Console.WriteLine(" Constuctor New RentContract with 6 parameter: Customer,Car,...");
            this.Id = id;
            this.VehicleRented = vehicle;
            this.DateStartRent = dateStartRent;
            this.DateEndRent = dateEndRent;
            this.TotalCost = totalCost;
            this.Description = "";
        }
        // This is the fully initialized constructor to insert a complete record into the database
        public RentContract(int id, Vehicle vehicle,Insurance insurance,Customer customer,DateTime dateStartRent, DateTime dateEndRent, int totalCost, string description,bool approval)
        {
            Console.WriteLine(" Constuctor New RentContract with 6 parameter: Customer,Car,...");
            this.Id = id;
            this.VehicleRented = vehicle;
            this.DateStartRent = dateStartRent;
            this.DateEndRent = dateEndRent;
            this.TotalCost = totalCost;
            this.Description = description;
            this.InsuranceUsed = insurance;
            this.CustomerRentCar = customer;
            this.IsApproved = approval;           
        }

        public RentContract(int id, Vehicle vehicle, Insurance insurance, Customer customer, DateTime dateStartRent, DateTime dateEndRent, int totalCost, string description, ContractStatus status)
        {
            Console.WriteLine(" Constuctor New RentContract with 6 parameter: Customer,Car,...");
            this.Id = id;
            this.VehicleRented = vehicle;
            this.DateStartRent = dateStartRent;
            this.DateEndRent = dateEndRent;
            this.TotalCost = totalCost;
            this.Description = description;
            this.InsuranceUsed = insurance;
            this.CustomerRentCar = customer;
            this.Status = status;
        }
    }
}
