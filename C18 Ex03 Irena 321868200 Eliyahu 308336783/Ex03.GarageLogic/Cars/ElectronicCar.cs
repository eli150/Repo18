using System;
using System.Collections.Generic;
using System.Text;
using Ex03.GarageLogic.Engines;

namespace Ex03.GarageLogic.Cars
{
    public class ElectronicCar : Car
    {
        public ElectronicCar(string i_ModelName, string i_LicenseNumber, int i_NumberOfWheels,
                eCarColors i_carColor, int i_DoorsQuantity, float i_MaxBatteryTime)
                : base(i_ModelName, i_LicenseNumber, i_NumberOfWheels, i_carColor, i_DoorsQuantity)
        {
            if (this.m_Engine == null)
            {
                m_Engine = new ElectricEngine(i_MaxBatteryTime);
            }
        }
    }
}
