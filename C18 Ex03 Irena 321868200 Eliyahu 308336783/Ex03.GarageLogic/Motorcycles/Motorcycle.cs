
namespace Ex03.GarageLogic.Motorcycles
{
    public abstract class Motorcycle : Vehicle
    {
        private eTypesOfDriversLicense m_LicenseType;
        private int m_EngineCapacity;

        public Motorcycle(string i_ModelName, string i_LicenseNumber, int i_NumberOfWheels,
            eTypesOfDriversLicense i_LicennseType, int i_EnengineCapacity)
            :base(i_ModelName, i_LicenseNumber, i_NumberOfWheels)
        {
            m_LicenseType = i_LicennseType;
            m_EngineCapacity = i_EnengineCapacity;
        }
    }
}
