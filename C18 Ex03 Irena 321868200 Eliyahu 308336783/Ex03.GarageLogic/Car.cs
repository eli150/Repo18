using System;
using System.Collections.Generic;
using Ex03.GarageLogic.Enums;

namespace Ex03.GarageLogic
{
     public class Car : Vehicle
    {
        private eCarColors m_CarColor;
        private eNumOfCarDoors m_NumberOfCarDoors;

        public Car() { }
        public Car(List<String> i_GeneralParam, List<String> i_SpecificParam, Engine i_EngineType, List<String> i_EngineParam)
            : base(i_GeneralParam, i_EngineType, i_EngineParam)
        {
            if (i_SpecificParam.Count == 2)
            {
                m_CarColor = (eCarColors)StringParser.StringToEnum(i_SpecificParam[0], typeof(eCarColors));
                m_NumberOfCarDoors = (eNumOfCarDoors)StringParser.StringToEnum(i_SpecificParam[1], typeof(eNumOfCarDoors));
            }

        }

        public override List<String> GetSpecificDitails()
        {
            m_specificParams = new List<String>();
            String strColorType = StringParser.EnumToOptions(typeof(eCarColors));
            m_specificParams.Add("CarColor. Options are:\n" + strColorType);
            String strDoorsNum = StringParser.EnumToOptions(typeof(eNumOfCarDoors));
            m_specificParams.Add("Number Of Car Doors\n" + strDoorsNum);

            return m_specificParams;
        }

    }
}
