using System;
using System.Collections.Generic;
using Ex03.GarageLogic.Enums;

namespace Ex03.GarageLogic
{
    public abstract class Vehicle
    {
        private string m_ModelName;
        private string m_LicenseNumber;
        private Engine m_Engine;
        protected static List<String> m_specificParams;
        private List<Wheel> m_Wheels;
        private int m_WheelsNumber;
        private eVehicleStatus m_VhicaleStatus;
        private Customer m_Customer;

        public Vehicle() { }
        public Vehicle(List<String> i_GeneralParam, Engine i_EngineType, List<String> i_EngineParam)
        {
            if (i_GeneralParam.Count == 8)
            {
                m_Customer = new Customer(i_GeneralParam[0], i_GeneralParam[1]);
                m_ModelName = i_GeneralParam[2];
                m_LicenseNumber = i_GeneralParam[3];
                m_WheelsNumber = StringParser.StringToInt(i_GeneralParam[4]);
                m_Wheels = new List<Wheel>(m_WheelsNumber);
                foreach (Wheel wheel in m_Wheels)
                {
                    m_Wheels.Add(new Wheel(i_GeneralParam[5], StringParser.StringToFloat(i_GeneralParam[6]), StringParser.StringToFloat(i_GeneralParam[7])));
                }
                CreateEngine(i_EngineType, i_EngineParam);
            }
            m_VhicaleStatus = eVehicleStatus.Repairing;
        }

        public string ModelName
        {
            get { return m_ModelName; }
        }

        public string LicenseNumber
        {
            get { return m_LicenseNumber; }
        }

        public eVehicleStatus VhicaleStatus { get => m_VhicaleStatus; set => m_VhicaleStatus = value; }

        public List<Wheel> Wheels { get => m_Wheels; set => m_Wheels = value; }

        public Engine Engine { get => m_Engine; set => m_Engine = value; }

        public float EnergyPercentage()
        {
            return m_Engine.EnergyPercentage();
        }

        public List<String> GetGeneralDitails()
        {

            List<String> o_paramsNames = new List<String>();
            o_paramsNames.Add("Owner Name");
            o_paramsNames.Add("Owner Phone Number");
            o_paramsNames.Add("Model Name");
            o_paramsNames.Add("License Number");
            o_paramsNames.Add("Wheels Number");
            o_paramsNames.Add("Manufacturer Name");
            o_paramsNames.Add("Current Psi");
            o_paramsNames.Add("Max Psi");

            return o_paramsNames;
        }

        private void CreateEngine(Engine i_EngineType, List<String> i_EngineParam)
        {
            if (i_EngineType is ElectricEngine)
            {
                m_Engine = new ElectricEngine(i_EngineParam);
            }
            else if (i_EngineType is FuelEngine)
            {
                m_Engine = new FuelEngine(i_EngineParam);
            }
        }

        public abstract List<String> GetSpecificDitails();

    }
}
