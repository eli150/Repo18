using Ex03.GarageLogic.Engines;

namespace Ex03.GarageLogic.Motorcycles
{
    public class ElectronicMotorcycle : Motorcycle
    {
        public ElectronicMotorcycle(string i_ModelName, string i_LicenseNumber, int i_NumberOfWheels,
            eTypesOfDriversLicense i_LicennseType, int i_EnengineCapacity, float i_MaxBatteryTime)
            : base(i_ModelName, i_LicenseNumber, i_NumberOfWheels, i_LicennseType, i_EnengineCapacity)
        {
            if (m_Engine == null)
            {
                m_Engine = new ElectricEngine(i_MaxBatteryTime);
            }
        }
    }
}
