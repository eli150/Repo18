using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic.Engines
{
    public class FuelEngine : Engine
    {
        private eFuelTypes m_FuelType;
        private float m_CurrentFuel;
        private float m_MaxFuel;

        public FuelEngine(eFuelTypes i_FuelType, float i_TankSize)
        {
            m_FuelType = i_FuelType;
            m_MaxFuel = i_TankSize;
        }
        public void refueling(float i_FuelLiters, eFuelTypes i_FuelType)
        {
            //Need to be change add exptions
            if (i_FuelType == m_FuelType)
            {
                if (i_FuelLiters <= m_MaxFuel - m_CurrentFuel)
                {
                    m_CurrentFuel += i_FuelLiters;
                }
            }
        }
        public override float EnergyPercentage()
        {
            return (m_CurrentFuel / m_MaxFuel) * 100;
        }
    }
}
