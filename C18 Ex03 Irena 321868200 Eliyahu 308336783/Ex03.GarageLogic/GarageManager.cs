using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex03.GarageLogic.Enums;

namespace Ex03.GarageLogic
{
    public class GarageManager
    {
        private  Dictionary<string, Vehicle> m_VehiclesInGarage;

        public GarageManager()
        {
            m_VehiclesInGarage = new Dictionary<string, Vehicle>();
        }

        //public void AddVehicleToGarage(Type i_VehicleType, List<String> i_GeneralParam, List<String> i_SpecificParam,
        //    Engine i_EngineType, List<String> i_EngineParam)
        //{
        //    if (!IsVehicleInGarage(i_GeneralParam[0]))
        //    {
        //        //Vehicle newVehicle = VihecaleCreator.AddVehicleToGarage(i_VehicleType.Name, i_GeneralParam, i_SpecificParam,
        //        //                                                        i_EngineType, i_EngineParam);
        //        if (newVehicle != null)
        //        {
        //            m_VehiclesInGarage.Add(newVehicle.LicenseNumber, newVehicle);
        //        }
        //    }
        //    else
        //    {
        //        ChangeVehicleStatus(i_GeneralParam[0], eVehicleStatus.Repairing);
        //    }
        //}

        public bool IsVehicleInGarage(string i_LicenseNumber)
        {
            bool isIngarage = false;
            if (m_VehiclesInGarage.ContainsKey(i_LicenseNumber))
            {
                isIngarage = true;
            }

            return isIngarage;
        }

        public List<Vehicle> VehicleListByStatus(eVehicleStatus i_VehicleStatus)
        {
            List<Vehicle> vehiclesList = new List<Vehicle>();

            foreach (KeyValuePair<string, Vehicle> pair in m_VehiclesInGarage)
            {
                if (i_VehicleStatus.Equals(pair.Value.VhicaleStatus))
                {
                    vehiclesList.Add(pair.Value);
                }
            }

            return vehiclesList;
        }   

        public void ChangeVehicleStatus(string i_LicenseNumber, eVehicleStatus i_VehicleStatus)     
        {
            if (!IsVehicleInGarage(i_LicenseNumber))
            {
                throw new ArgumentException("Vhicale is not in garage!");
            }

            m_VehiclesInGarage[i_LicenseNumber].VhicaleStatus = i_VehicleStatus;
        }

        public void InflateWheelsToMax(string i_LicenseNumber)      
        {
            if (!m_VehiclesInGarage.ContainsKey(i_LicenseNumber))
            {
                throw new ArgumentException("Wrong License number");
            }
            else
            {
                for (int i = 0; i < m_VehiclesInGarage[i_LicenseNumber].Wheels.Count; i++)
                {
                    m_VehiclesInGarage[i_LicenseNumber].Wheels[i].InflateWheelToMaxPsi();
                }
            }
        }

        public void RefuelingVehicle(string i_LicenseNumber, eFuelTypes i_FuelType, float i_FueldQuantity) 
        {
            FuelEngine fueld = GetVehicleInGarage(i_LicenseNumber).Engine as FuelEngine;
            if (fueld == null)
            {
                throw new ArgumentException("Not current engine type");
            }

            fueld.refueling(i_FueldQuantity, i_FuelType);
        }

        public void ChargeVhicaleBattery(string i_LicenseNumber, float i_MinutesQuantity)   
        {
            float i_HoursToCharge;
            i_HoursToCharge = i_MinutesQuantity / 60;
            ElectricEngine electric = GetVehicleInGarage(i_LicenseNumber).Engine as ElectricEngine;
            if (electric == null)
            {
                throw new ArgumentException("Not current engine type");
            }

            electric.chargingBattery(i_HoursToCharge);
        }

        public Vehicle GetVehicleInGarage(string i_LicenseNumber)
        {
            if (!m_VehiclesInGarage.ContainsKey(i_LicenseNumber))
            {
                throw new ArgumentException("The vehicle is not in the garage");
            }
            else
            {
                return m_VehiclesInGarage[i_LicenseNumber];
            }
        }

        public void ShowVhicaleInformation(string i_LicenseNumber)
        {

        }
    }
}
