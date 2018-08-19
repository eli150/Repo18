using Ex03.GarageLogic.Engines;

namespace Ex03.GarageLogic.Tracks
{
    public class Track : Vehicle
    {
        private bool m_IsCoolTrunk;
        private float m_TrunkVolume;

        public Track(string i_ModelName, string i_LicenseNumber, int i_NumberOfWheels,
            bool i_IsCoolTrunk, float i_TrunkVolume,
            eFuelTypes i_FuelType, float i_TankSize)
            : base(i_ModelName, i_LicenseNumber, i_NumberOfWheels)
        {
            m_IsCoolTrunk = i_IsCoolTrunk;
            m_TrunkVolume = i_TrunkVolume;
            if (m_Engine == null)
            {
                m_Engine = new FuelEngine(i_FuelType, i_TankSize);
            }
        }
    }
}
