using System;

namespace Ex03.GarageLogic
{
    public class VehicleEnergySource
    {
        private float m_CurrentEnergy;
        private float m_MaxEnergy;

        public VehicleEnergySource(float i_CurrentPower, float i_MaxPower)
        {
            m_CurrentEnergy = i_CurrentPower;
            m_MaxEnergy = i_MaxPower;
        }

        public float CurrentEnergy
        {
            get { return m_CurrentEnergy; }
        }

        public float MaxEnergy
        {
            get { return m_MaxEnergy; }
        }

        public float CurrentEnergyPercentage
        {
            get { return (m_CurrentEnergy / m_MaxEnergy) * 100; }
        }
    }
}
