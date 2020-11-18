using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;


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
           
            Fleet fleetcar = new Fleet();
            Fleet fleettruck = new Fleet();
            using (MySqlDataReader d = cmd.ExecuteReader())
            {
                while (d.Read())
                {

                    fleetcar.AddVehicle(new Car(NameCar: d.GetString(1), Branch: d.GetString(3), typecar: (TypeCar)Enum.Parse(typeof(TypeCar), d.GetString(0)), stateUse: d.GetBoolean(5), idCar: d.GetInt32(2), costperday: d.GetInt32(4), maintain: d.GetBoolean(6)));

                }
            }
            sqlcar = "select V.Name, V.ID, V.branch, V.costperday, V.stateUsed, V.maintain, t.TYPETRUCK from vehicle V, TRUCK T where v.id = T.id; ";
            cmd = new MySqlCommand(sqlcar, conn);
            using (MySqlDataReader d = cmd.ExecuteReader())
            {
                while (d.Read())
                {

                    fleettruck.AddVehicle(new Truck(NameTruck: d.GetString(1), Branch: d.GetString(3), typeTruck: (TypeTruck)Enum.Parse(typeof(TypeCar), d.GetString(0)), stateUse: d.GetBoolean(5), idTruck: d.GetInt32(2), costperday: d.GetInt32(4), maintain: d.GetBoolean(6)));
                }
            }
            CarRentalManagement manage = new CarRentalManagement();
            manage.addFleet(fleetcar);
            manage.addFleet(fleettruck);
            conn.Close();
            return manage;
            
         }
        public static void start(Form form)
        {
            Application.Run(form);
        }
    }
      
    
}
