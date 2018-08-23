using System;
using System.Collections.Generic;
using Ex03.GarageLogic.Enums;

namespace Ex03.GarageLogic
{
    public class Motorcycle : Vehicle
    {
        private eTypesOfDriversLicense m_LicenseType;
        private int m_EngineCapacity;

        public Motorcycle() { }
        public Motorcycle(List<String> i_GeneralParam, List<String> i_SpecificParam, Engine i_EngineType, List<String> i_EngineParam)
            : base(i_GeneralParam, i_EngineType, i_EngineParam)
        {
            if (i_SpecificParam.Count == 2)
            {
                m_LicenseType = (eTypesOfDriversLicense)StringParser.StringToEnum(i_SpecificParam[0], typeof(eTypesOfDriversLicense));
                m_EngineCapacity = StringParser.StringToInt(i_SpecificParam[1]);
            }

        }

        public eTypesOfDriversLicense LicenseType { get => m_LicenseType; set => m_LicenseType = value; }
        public int EngineCapacity { get => m_EngineCapacity; set => m_EngineCapacity = value; }

        public override List<String> GetSpecificDitails()
        {
            m_specificParams = new List<String>();
            String strLicenseType = StringParser.EnumToOptions(typeof(eTypesOfDriversLicense));
            m_specificParams.Add("LicenseType. Options are:\n" + strLicenseType);
            m_specificParams.Add("EngineCapacity");

            return m_specificParams;
        }
    }
}
