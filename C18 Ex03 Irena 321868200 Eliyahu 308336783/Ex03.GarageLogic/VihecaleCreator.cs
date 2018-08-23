using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class VihecaleCreator
    {
        public static Vehicle AddVehicleToGarage(string i_VehicleType, List<String> i_GeneralParam, List<String> i_SpecificParam, Engine i_EngineType, List<String> i_EngineParam)
        {
            Vehicle newVehicle = null;

            switch (i_VehicleType)
            {
                case "Motorcycle":
                    newVehicle = new Motorcycle(i_GeneralParam, i_SpecificParam, i_EngineType, i_EngineParam);
                    break;
                case "Car":
                    newVehicle = new Car(i_GeneralParam, i_SpecificParam, i_EngineType, i_EngineParam);
                    break;
                case "Track":
                    newVehicle = new Track(i_GeneralParam, i_SpecificParam, i_EngineType, i_EngineParam);
                    break;
            }

            return newVehicle;
        }

        public static Vehicle AddTempVhicale(string i_VehicleType)
        {
            Vehicle newVehicle = null;

            switch (i_VehicleType)
            {
                case "Motorcycle":
                    newVehicle = new Motorcycle();
                    break;
                case "Car":
                    newVehicle = new Car();
                    break;
                case "Track":
                    newVehicle = new Track();
                    break;
            }

            return newVehicle;
        }
        public enum VihecaleSupport
        {
            Motorcycle = 1,
            Car,
            Track

        }
        public static List<Type> VehicleSupportedInGarage()
        {
            List<Type> lsVhicale = new List<Type>();
            lsVhicale.Add(typeof(Motorcycle));
            lsVhicale.Add(typeof(Car));
            lsVhicale.Add(typeof(Track));

            return lsVhicale;
        }

        public static List<Type> EngineTypeSupported()
        {
            List<Type> lsEngine = new List<Type>();
            lsEngine.Add(typeof(ElectricEngine));
            lsEngine.Add(typeof(FuelEngine));

            return lsEngine;

        }
    }
}
