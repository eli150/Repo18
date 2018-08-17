using System;

namespace Ex03.GarageLogic
{
    public class OutOfRangeException : Exception
    {
        private float m_MinValue;
        private float m_MaxValue;

        public float MinValue
        {
            get { return m_MinValue; }
        }

        public float MaxValue
        {
            get { return m_MaxValue; }
        }

        public OutOfRangeException(float i_MinValue, float i_MaxValue)
            : base(string.Format("Value is out of range. please enter a number between {0} and {1}", i_MinValue, i_MaxValue))
        {
            m_MinValue = i_MinValue;
            m_MaxValue = i_MaxValue;
        }
    }
}
