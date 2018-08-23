using System;
using System.Collections.Generic;
using Ex03.GarageLogic;
using System.Reflection;

namespace Ex03.ConsoleUI
{
    public class GarageUI
    {
        public void AddVehicle()
        {
            int index;
            List<String> generalParamLs, specificParamLs;
            Object engineType = null;

            try
            {
                List<Type> lstOfTypes = VihecaleCreator.VehicleSupportedInGarage();
                index = 1;
                Console.WriteLine("Please select your vehicle:");
                foreach (Type type in lstOfTypes)
                {
                    Console.WriteLine(string.Format("{0} ---> {1}", index++, type.Name));
                }

                index = getIntFromUser() - 1;
                Object newVhicale = VihecaleCreator.AddTempVhicale(lstOfTypes[index].Name);
                //generalParamLs = getParametes(newVhicale, "GetGeneralDitails", newVhicale);
                Type d = null;
                setEngineParam(ref d);
                getParametes(d, "ShowEngineParameters", null);
                //specificParamLs = getParametes(newVhicale, "GetSpecificDitails", newVhicale);
                //Object newVhicale1 = VihecaleCreator.AddVehicleToGarage(lstOfTypes[index].Name, generalParamLs, specificParamLs, (FuelEngine)engineType, null);
            }
            catch (Exception ex)
            {

            }

        }
        private List<String> getParametes(Object i_obj, String i_MethodName, Object i_runObj)
        {
            MethodInfo mthods = i_obj.GetType().GetMethod(i_MethodName);
            List<string> paramLst = (List<string>)mthods.Invoke(i_runObj, new object[] { });
            List<string> vhicalParam = new List<string>(paramLst.Count);
            List<String> vehicleParameters = new List<String>(paramLst.Count);
            foreach (string param in paramLst)
            {
                Console.WriteLine(string.Format("Please enter {0}", param));
                vehicleParameters.Add(Console.ReadLine());
            }

            return vehicleParameters;
        }

        private void setEngineParam(ref Type io_EngineType)
        {
            try
            {
                List<Type> lstOfTypes = VihecaleCreator.EngineTypeSupported();
                int index = 1;
                Console.WriteLine("Please select your engine type:");
                foreach (Type type in lstOfTypes)
                {
                    Console.WriteLine(string.Format("{0} ---> {1}", index++, type.Name));
                }

                index = getIntFromUser() - 1;
                //io_EngineType = lstOfTypes[index];

                io_EngineType = lstOfTypes[index];
            }
            catch (Exception ex)
            {
                
            }
        }

        static private int getIntFromUser()
        {
            string intStr = Console.ReadLine();
            int intNum;
            if (!int.TryParse(intStr, out intNum))
            {
                throw new FormatException("Input is not an integer");
            }

            return intNum;
        }

        private object getEnumValueFromUser(Type i_EnumType)
        {
            printEnumOptions(i_EnumType);
            int tempParseInt;

            string inputNumberStr = Console.ReadLine();
            if (!int.TryParse(inputNumberStr, out tempParseInt) || !Enum.IsDefined(i_EnumType, tempParseInt))
            {
                throw new FormatException("Selection not availabe in enum");
            }

            return Enum.Parse(i_EnumType, inputNumberStr);
        }

        private void printEnumOptions(Type i_EnumType)
        {
            string[] enumNames = Enum.GetNames(i_EnumType);
            for (int i = 0; i < enumNames.Length; i++)
            {
                Console.WriteLine(string.Format("{0}) {1}", i + 1));
            }
        }
    }
}
