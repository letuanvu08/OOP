using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Globalization;
namespace WindowsFormsApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CarRentalManagement manage = LoadData();



            Application.Run(new Form1(manage));
        }
        static public MySqlConnection ConnectDatabase()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            return conn;
        }
        static public CarRentalManagement LoadData()
        {
            MySqlConnection conn = ConnectDatabase();
            string sqlcar = "(select c.TYPECAR, V.Name, V.ID,V.branch,V.costperday,V.stateUsed,V.maintain from vehicle V, car c where v.id=c.id); ";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sqlcar;
            CarRentalManagement manage = new CarRentalManagement();
            //======================== Fetch the two fleet from mySQL: 1 for Car, 1 for Truck =========================
            Fleet fleetcar = new Fleet();
            Fleet fleettruck = new Fleet();
            using (MySqlDataReader d = cmd.ExecuteReader())
            {
                while (d.Read())
                {

                    fleetcar.AddVehicle(new Car(NameCar: d.GetString(1), Branch: d.GetString(3), typecar: (TypeCar)Enum.Parse(typeof(TypeCar), d.GetString(0)), stateUse: d.GetBoolean(5), idCar: d.GetInt32(2), costperday: d.GetInt32(4), maintain: d.GetBoolean(6)));

                }
            }
            manage.AddFleet(fleetcar);
            sqlcar = "select T.TYPETRUCK, V.Name, V.ID, V.branch, V.costperday, V.stateUsed, V.maintain, t.TYPETRUCK from vehicle V, TRUCK T where v.id = T.id; ";
            cmd = new MySqlCommand(sqlcar, conn);
            using (MySqlDataReader d = cmd.ExecuteReader())
            {
                while (d.Read())
                {

                    fleettruck.AddVehicle(new Truck(nameTruck: d.GetString(1), branch: d.GetString(3), typeTruck: (TypeTruck)Enum.Parse(typeof(TypeTruck), d.GetString(0)), stateUse: d.GetBoolean(5), idTruck: d.GetInt32(2), costperday: d.GetInt32(4), maintain: d.GetBoolean(6)));
                }
            }
            manage.AddFleet(fleettruck);
            LoadCarDataFromDatabase(manage);
            
            
            conn.Close();
            return manage;
            
        }
        public static void LoadCarDataFromDatabase(CarRentalManagement manager)
        {
            MySqlConnection conn = ConnectDatabase();
            //====================== Fetch the car-related-contract information from datbase================
            string query = "select * from rentcontract RC join insurance I on RC.IDCONTRACT = I.IDCONTRACT, vehicle V, car C where RC.IDVEHICLE = V.ID and V.ID = C.ID;";
            // This adapter connect to the database and execute the query
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            // Fill the queried data into a table:
            DataTable carDataTable = new DataTable();
            adapter.Fill(carDataTable);
            foreach (DataRow row in carDataTable.Rows)
            {

                // Create a contract wit the Car: -- Vấn đề về đêm: Nếu bị null dưới database thì khi load lên sẽ lỗi (Khúc oilSIze vói oilNow khi Parse với định dạng Int32) cho nên ở đây t cho giá trị mặc định :(
                Car car = new Car(NameCar: row["Name"].ToString(), Branch: row["branch"].ToString(), idCar: Int32.Parse(row["ID"].ToString()), typecar: (TypeCar)Enum.Parse(typeof(TypeCar), row["TYPECAR"].ToString()), maintain: Boolean.Parse(row["maintain"].ToString()), costperday: Int32.Parse(row["costperday"].ToString()), stateUse: Boolean.Parse(row["stateUsed"].ToString()),oilSize:2,fluidSize:3);
                // Create the customer of the Contract:
                Customer customer = new Customer(name: row["NAMECUSTORMER"].ToString(), password: "", Email: row["EMAIL"].ToString(), PhoneNumber: row["PHONENUMBER"].ToString(), Sex: "", Age: 0, Address: row["ADDRESS"].ToString(), Career: row["CAREER"].ToString(), license: row["DRIVERLICENSE"].ToString());
                // Creat a Insurance with the contract: 
                Insurance insurance = new Insurance(id: (int)row["IID"], type: (TypeInsurance)Enum.Parse(typeof(TypeInsurance), row["TYPEINSURANCE"].ToString()));
                int id = int.Parse(row["IDCONTRACT"].ToString());
                //DateTime dateStartRent = DateTime.ParseExact(row["STARTDATE"].ToString(), CultureInfo.InvariantCulture);
                //DateTime dateEndRent = DateTime.ParseExact(row["ENDDATE"].ToString(), CultureInfo.InvariantCulture);
                string startDateString = row["STARTDATE"].ToString();
                string startDateTimeFormat = GetDateTimeFormatString(startDateString);
                
                string endDateString = row["ENDDATE"].ToString();
                string endDateTimeFormat = GetDateTimeFormatString(endDateString);
                
                CultureInfo provider = CultureInfo.InvariantCulture;
                
                DateTime dateStartRent = DateTime.ParseExact(startDateString, startDateTimeFormat, CultureInfo.InvariantCulture);

                DateTime dateEndRent = DateTime.ParseExact(startDateString, endDateTimeFormat, provider);
                int totalBill = (int)row["TOTALBILL"];
                string description = row["DESCRIPTION"].ToString();
                bool is_approved = (bool)row["APPROVED"];

                RentContract rentContract = new RentContract(id, car, insurance, customer, dateStartRent, dateEndRent, totalBill, description, is_approved);
                manager.AddContract(rentContract);
            }
        }
        public static void LoadTruckDataFromDatabase(CarRentalManagement manager)
        {
            MySqlConnection conn = ConnectDatabase();
            //====================== Fetch the car-related-contract information from datbase================
            string query = "select * from rentcontract RC join insurance I on RC.IDINSURANCE = I.IID, vehicle V, truck T where RC.IDVEHICLE = V.ID and V.ID = T.ID;";
            // This adapter connect to the database and execute the query
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            // Fill the queried data into a table:
            DataTable carDataTable = new DataTable();
            adapter.Fill(carDataTable);
            foreach (DataRow row in carDataTable.Rows)
            {
                // Create a contract wit the Car
                Truck truck = new Truck(nameTruck: row["Name"].ToString(), branch: row["branch"].ToString(), idTruck: Int32.Parse(row["ID"].ToString()), typeTruck: (TypeTruck)Enum.Parse(typeof(TypeTruck), row["TYPETRUCK"].ToString()), maintain: Boolean.Parse(row["maintain"].ToString()), costperday: Int32.Parse(row["costperday"].ToString()), stateUse: Boolean.Parse(row["stateUsed"].ToString()));
                // Create the customer of the Contract:
                Customer customer = new Customer(name: row["NAMECUSTORMER"].ToString(), password: "", Email: row["EMAIL"].ToString(), PhoneNumber: row["PHONENUMBER"].ToString(), Sex: "", Age: 0, Address: row["ADDRESS"].ToString(), Career: row["CAREER"].ToString(), license: row["DRIVERLICENSE"].ToString());
                // Creat a Insurance with the contract: 
                Insurance insurance = new Insurance(id: (int)row["IID"], type: (TypeInsurance)Enum.Parse(typeof(TypeInsurance), row["TYPEINSURANCE"].ToString()));
                int id = int.Parse(row["IDCONTRACT"].ToString());
                //DateTime dateStartRent = DateTime.ParseExact(row["STARTDATE"].ToString(), CultureInfo.InvariantCulture);
                //DateTime dateEndRent = DateTime.ParseExact(row["ENDDATE"].ToString(), CultureInfo.InvariantCulture);
                
                string startDateString = row["STARTDATE"].ToString();
                string startDateTimeFormat = GetDateTimeFormatString(startDateString);
                string endDateString = row["ENDDATE"].ToString();
                string endDateTimeFormat = GetDateTimeFormatString(endDateString);
                CultureInfo provider = CultureInfo.InvariantCulture;
                
                DateTime dateStartRent = DateTime.ParseExact(startDateString, startDateTimeFormat, provider);

                DateTime dateEndRent = DateTime.ParseExact(startDateString, endDateTimeFormat, provider);
                int totalBill = (int)row["TOTALBILL"];
                string description = row["DESCRIPTION"].ToString();
                bool isApproved = (bool)row["APPROVED"];

                RentContract rentContract = new RentContract(id, truck, insurance, customer, dateStartRent, dateEndRent, totalBill, description, isApproved);
                manager.AddContract(rentContract);
            }
        }
        public static string GetDateTimeFormatString(string datetime)
        {
            string retFormat = "MM/dd/yyyy";
            if (datetime.Length > 10)
            {
                retFormat = "MM/dd/yyyy hh:mm:ss tt";
            }
            return retFormat;
        }

        public static void Start(Form form)
        {
            Application.Run(form);
        }
    }
      
    
}
