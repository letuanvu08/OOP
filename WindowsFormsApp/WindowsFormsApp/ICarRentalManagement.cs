using System.Collections.Generic;

namespace WindowsFormsApp
{
    interface ICarRentalManagement
    {

        List<Vehicle> FindCarAvailable(string type, string branch);
        void ServiceCarFleet();
        List<string> GetlistType(string type);
        List<string> GetlistBranch(string type);
        Vehicle FindVehicle(string name);
        RentContract FindContractById(int id);
    }
}
