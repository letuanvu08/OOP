using System.Collections.Generic;

namespace WindowsFormsApp
{
    interface IVehicleRentalManagement
    {

        List<Vehicle> FindCarAvailable(string type, string branch);
        void ServiceCarFleet();
        List<string> GetlistType(string type);
        List<string> GetlistBranch(string type);
        Vehicle FindVehicle(string name);
        RentContract FindContractById(int id);
        List<Insurance> GetInsurances();
        List<RentContract> GetTruckRelatedConTracts();
        List<RentContract> GetCarRelatedConTracts();
    }
}
