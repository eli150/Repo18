using System;

namespace Ex03.GarageLogic
{
    public class Wheel
    {
        private string m_ManufacturerName;
        private float m_CurrentPsi;
        private float m_MaxPsi;

        public Wheel(string i_ManufacturerName, float i_CurrentPsi, float i_MaxPsi)
        {
            m_ManufacturerName = i_ManufacturerName;
            m_CurrentPsi = i_CurrentPsi;
            m_MaxPsi = i_MaxPsi;
        }

        public string ManufacturerName
        {
            get { return m_ManufacturerName; }
        }

        public float CurrentPsi
        {
            get { return m_CurrentPsi; }
        }

        public float MaxPsi
        {
            get { return m_MaxPsi; }
        }

        public void InflateWheel(float i_WheelPsiToAdd)
        {
            if (i_WheelPsiToAdd > m_MaxPsi - m_CurrentPsi)
            {
                throw new OutOfRangeException(0, m_MaxPsi - m_CurrentPsi);
            }
            else
            {
                m_CurrentPsi += i_WheelPsiToAdd;
            }
        }

        public void InflateWheelToMaxPsi()
        {
            m_CurrentPsi = m_MaxPsi;
        }
    }
}
