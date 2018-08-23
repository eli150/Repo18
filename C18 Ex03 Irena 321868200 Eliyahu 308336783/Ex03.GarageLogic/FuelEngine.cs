using System;
using System.Collections.Generic;
using Ex03.GarageLogic.Enums;

namespace Ex03.GarageLogic
{
    public class FuelEngine : Engine
    {
        private eFuelTypes m_FuelType;
        private float m_CurrentFuel;
        private float m_MaxFuel;

        public FuelEngine(List<String> i_EngineParam)
        {
            foreach (Object engineItem in i_EngineParam)
            {

            }
            //m_FuelType = i_FuelType;
            //m_MaxFuel = i_TankSize;
        }
        public void refueling(float i_FuelLiters, eFuelTypes i_FuelType)
        {
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
        public static List<String> ShowEngineParameters()
        {
            List<String> m_EngineList = new List<String>();
            String strColorType = StringParser.EnumToOptions(typeof(eFuelTypes));
            m_EngineList.Add("Fuel type. Option are:\n" + strColorType);
            m_EngineList.Add("Current fuel in liters");
            m_EngineList.Add("Max fuel in liters");

            return m_EngineList;
        }
    }
}
