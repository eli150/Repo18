using Ex03.GarageLogic.Engines;

namespace Ex03.GarageLogic.Motorcycles
{
    public class FueldMotorcycle : Motorcycle
    {
        public FueldMotorcycle(string i_ModelName, string i_LicenseNumber, int i_NumberOfWheels,
            eTypesOfDriversLicense i_LicennseType, int i_EnengineCapacity,
            eFuelTypes i_FuelType, float i_TankSize)
            : base(i_ModelName, i_LicenseNumber, i_NumberOfWheels, i_LicennseType, i_EnengineCapacity)
        {
            if (m_Engine == null)
            {
                m_Engine = new FuelEngine(i_FuelType, i_TankSize);
            }
            
        }
    }
}
