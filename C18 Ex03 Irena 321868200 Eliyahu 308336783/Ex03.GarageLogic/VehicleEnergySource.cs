using System;

namespace Ex03.GarageLogic
{
    public class VehicleEnergySource
    {
        private float m_CurrentEnergy;
        private float m_MaxEnergy;

        public VehicleEnergySource(float i_CurrentEnergy, float i_MaxEnergy)
        {
            m_CurrentEnergy = i_CurrentEnergy;
            m_MaxEnergy = i_MaxEnergy;
        }

        public float CurrentEnergy
        {
            get { return m_CurrentEnergy; }
            set
            {
                m_CurrentEnergy = value;
            }
        }

        public float MaxEnergy
        {
            get { return m_MaxEnergy; }
        }

        public float CurrentEnergyPercentage
        {
            get { return (m_CurrentEnergy / m_MaxEnergy) * 100; }
        }

        public void AddEnergy(float i_EnergyToAdd)
        {
            if (i_EnergyToAdd > MaxEnergy - CurrentEnergy)
            {
                throw new ValueOutOfRangeException(0, MaxEnergy - CurrentEnergy);
            }
            else
            {
                CurrentEnergy += i_EnergyToAdd;
            }
        }
    }
}
