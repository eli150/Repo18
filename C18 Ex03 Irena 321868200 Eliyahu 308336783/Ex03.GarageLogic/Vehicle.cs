using Ex03.GarageLogic.Engines;

namespace Ex03.GarageLogic
{
    abstract public class Vehicle
    {
        protected string m_ModelName;
        protected string m_LicenseNumber;
        //protected VehicleEnergySource m_VehicleEnergy;
        //protected float m_PrecentOfEnergy;
        protected Wheel[] m_Wheels;
        protected Engine m_Engine;

        public Vehicle(string i_ModelName, string i_LicenseNumber, int i_NumberOfWheels)
        {
            m_ModelName = i_ModelName;
            m_LicenseNumber = i_LicenseNumber;
            m_Wheels = new Wheel[i_NumberOfWheels]; //Maybe need change??
        }

        public string ModelName
        {
            get { return m_ModelName; }
        }

        public string LicenseNumber
        {
            get { return m_LicenseNumber; }
        }

        //abstract public float EnergyPercentage();
        //{
            //return m_VehicleEnergy.CurrentEnergyPercentage;
        //}
    }
}
