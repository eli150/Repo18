
namespace Ex03.GarageLogic.Engines
{
    public class ElectricEngine : Engine
    {
        private float m_CurrentBatteryTime;
        private float m_MaxBatteryTime;

        public ElectricEngine(float i_MaxBatteryTime)
        {
            m_MaxBatteryTime = i_MaxBatteryTime;
        }
        public float CurrentBatteryTime
        {
            get { return m_CurrentBatteryTime; }
        }

        public float MaxBatteryTime
        {
            get { return m_MaxBatteryTime; }
        }

        public void chargingBattery(float i_hoursToCharcge)
        {
            if (m_CurrentBatteryTime <= m_MaxBatteryTime - i_hoursToCharcge)
            {
                m_CurrentBatteryTime += i_hoursToCharcge;
            }
        }

        public override float EnergyPercentage()
        {
            return (m_CurrentBatteryTime / m_MaxBatteryTime) * 100;

        }
    }
}
