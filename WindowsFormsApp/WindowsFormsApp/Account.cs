using System;

namespace WindowsFormsApp
{
    abstract class Account
    {
        protected string name;

        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Sex { get => sex; set => sex = value; }
        public int Age { get => age; set => age = value; }
        public DateTime birthday;
        protected string password;
        protected string email;
        protected string phoneNumber;
        protected int age;
        protected string sex;



    }
    class Customer : Account
    {
        public string Address { get; set; }

        public string Career { get; set; }

        public string Driver_license { get; set; }

        public Customer()
        {
            Console.WriteLine(" Constuctor New Customer not parameter");
            this.name = "";
            this.password = "";
            this.email = "";
            this.phoneNumber = "";
            this.age = 0;
            this.sex = "male";
            this.Address = "";
            this.Career = "";
        }
        public Customer(string name, string password)
        {
            Console.WriteLine(" Constuctor New Customer with 2 parameter");
            this.name = name;
            this.password = password;
            this.email = "";
            this.phoneNumber = "";
            this.age = 0;
            this.sex = "male";
            this.Address = "";
            this.Career = "";
        }
        public Customer(string name, string password, int age, string sex, string career)
        {
            Console.WriteLine(" Constuctor New Customer with 5 parameter");
            this.name = name;
            this.password = password;
            this.email = "";
            this.phoneNumber = "";
            this.age = age;
            this.sex = sex;
            this.Address = "";
            this.Career = career;
        }
        public Customer(string name, string password, string Email, string PhoneNumber, string Sex, int Age, string Address, string Career, string license)
        {
            Console.WriteLine(" Constuctor New Customer with 8 parameter");
            this.name = name;
            this.password = password;
            this.email = Email;
            this.phoneNumber = PhoneNumber;
            this.age = Age;
            this.sex = Sex;
            this.Address = Address;
            this.Career = Career;
            this.Driver_license = license;
        }
    }
    class Manager : Account
    {
        public Manager()
        {
            Console.WriteLine(" Constuctor New Manager not Parmater");
            this.name = "";
            this.password = "";
            this.email = "";
            this.phoneNumber = "";
            this.age = 0;
            this.sex = "male";
            this.Department = "";
            this.Salary = 0;
        }
        public Manager(string name, string password)
        {
            Console.WriteLine(" Constuctor New Manager with 2 parameter");
            this.name = name;
            this.password = password;
            this.email = "";
            this.phoneNumber = "";
            this.age = 0;
            this.sex = "male";
            this.Department = "";
            this.Salary = 0;

        }
        public Manager(string name, string password, string email, string phoneNumber, string sex, int age, string department, int salary)
        {
            Console.WriteLine(" Constuctor New Mamager with 5 parameter");
            this.name = name;
            this.password = password;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.age = age;
            this.sex = sex;
            this.Department = department;
            this.Salary = salary;

        }

        public string Department { get; set; }

        public int Salary { get; set; }
    }
    class Staff : Account
    {
        public int Salary { get; set; }

        public Staff() { }
        public Staff(string name, string password)
        {
            this.name = name;
            this.password = password;
            this.email = "";
            this.phoneNumber = "";
            this.age = 0;
            this.sex = "male";
            this.Department = "";
            this.Salary = 0;

        }
        public Staff(string name, string password, string email, string phoneNumber, string sex, int age, string department, int salary)
        {
            this.name = name;
            this.password = password;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.age = age;
            this.sex = sex;
            this.Department = department;
            this.Salary = salary;

        }

        public string Department { get; set; }
    }
}
