using System;
using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public class ElectricEngine : Engine
    {
        private float m_CurrentBatteryTime;
        private float m_MaxBatteryTime;

        public ElectricEngine(List<String> i_EngineParam)
        {
            foreach (Object engineItem in i_EngineParam)
            {

            }
            //m_MaxBatteryTime = i_MaxBatteryTime;
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

        public static List<String> ShowEngineParameters()
        {
            List<String> m_EngineList = new List<String>();
            m_EngineList.Add("Current Battery Time");
            m_EngineList.Add("Max Battery Time");

            return m_EngineList;
        }
    }
}
