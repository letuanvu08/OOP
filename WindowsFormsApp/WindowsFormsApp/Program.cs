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
            CarRentalManagement manage = loaddata();



            Application.Run(new Form1(manage));
        }
        static public MySqlConnection connectDatabase()
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
        static public CarRentalManagement loaddata()
        {
            MySqlConnection conn = connectDatabase();
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
            manage.addFleet(fleetcar);
            sqlcar = "select V.Name, V.ID, V.branch, V.costperday, V.stateUsed, V.maintain, t.TYPETRUCK from vehicle V, TRUCK T where v.id = T.id; ";
            cmd = new MySqlCommand(sqlcar, conn);
            using (MySqlDataReader d = cmd.ExecuteReader())
            {
                while (d.Read())
                {

                    fleettruck.AddVehicle(new Truck(NameTruck: d.GetString(1), Branch: d.GetString(3), typeTruck: (TypeTruck)Enum.Parse(typeof(TypeCar), d.GetString(0)), stateUse: d.GetBoolean(5), idTruck: d.GetInt32(2), costperday: d.GetInt32(4), maintain: d.GetBoolean(6)));
                }
            }
            manage.addFleet(fleettruck);

            //====================== Fetch the car-related-contract information from datbase================
            string query = "select * from rentcontract RC join insurance I on RC.IDINSURANCE = I.IID, vehicle V, car C where RC.IDVEHICLE = V.ID and V.ID = C.ID;";
            // This adapter connect to the database and execute the query
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            // Fill the queried data into a table:
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            
            foreach (DataRow row in dataTable.Rows)
            {
                
                // Create a contract wit the Car
                Car car = new Car(NameCar:row["Name"].ToString(),Branch:row["branch"].ToString(),idCar:Int32.Parse(row["ID"].ToString()),typecar:(TypeCar)Enum.Parse(typeof(TypeCar),row["TYPECAR"].ToString()),maintain:Boolean.Parse(row["maintain"].ToString()),costperday: Int32.Parse(row["costperday"].ToString()), stateUse: Boolean.Parse(row["stateUsed"].ToString()));
                // Create the customer of the Contract:
                Custormer custormer = new Custormer(name: row["NAMECUSTORMER"].ToString(), Password: "", Email: row["EMAIL"].ToString(), PhoneNumber: "", Sex: "", Age: 0, Address: row["ADDRESS"].ToString(), Career: row["CAREER"].ToString());
                // Creat a Insurance with the contract: 
                Insurance insurance = new Insurance(id: (int)row["IID"], type: (TypeInsurance)Enum.Parse(typeof(TypeInsurance), row["TYPEINSURANCE"].ToString()));
                int id = int.Parse(row["IDCONTRACT"].ToString());
                //DateTime dateStartRent = DateTime.ParseExact(row["STARTDATE"].ToString(), CultureInfo.InvariantCulture);
                //DateTime dateEndRent = DateTime.ParseExact(row["ENDDATE"].ToString(), CultureInfo.InvariantCulture);
                string startDateTimeFormat = "dd/MM/yyyy";
                string startDateString = row["STARTDATE"].ToString();
                string endDateTimeFormat = "dd/MM/yyyy";
                string endDateString = row["ENDDATE"].ToString();
                CultureInfo provider = CultureInfo.InvariantCulture;
                if (startDateString.Length > 10)
                {
                    startDateTimeFormat ="MM/dd/yyyy hh:mm:ss tt";
                }
                if (startDateString.ToString().Length > 10)
                {
                    endDateTimeFormat = "MM/dd/yyyy hh:mm:ss tt";
                }
                DateTime dateStartRent = DateTime.ParseExact(startDateString, startDateTimeFormat, provider);
                
                DateTime dateEndRent = DateTime.ParseExact(startDateString, startDateTimeFormat, provider);
                int totalBill = (int)row["TOTALBILL"];
                
                RentContract rentContract = new RentContract(id,car,dateStartRent,dateEndRent,totalBill);
                manage.addContract(rentContract);
                
            }
            
            conn.Close();
            return manage;
            
         }

        public static void start(Form form)
        {
            Application.Run(form);
        }
    }
      
    
}
