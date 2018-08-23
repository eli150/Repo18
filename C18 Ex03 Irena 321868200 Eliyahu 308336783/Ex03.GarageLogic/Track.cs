using System;
using System.Collections.Generic;

namespace Ex03.GarageLogic

{
    public class Track : Vehicle
    {
        private bool m_IsCoolTrunk;
        private float m_TrunkVolume;

        public Track() { }
        public Track(List<String> i_GeneralParam, List<String> i_SpecificParam, Engine i_EngineType, List<String> i_EngineParam)
            : base(i_GeneralParam, i_EngineType, i_EngineParam)
        {
            if (i_SpecificParam.Count == 2)
            {
                m_IsCoolTrunk = StringParser.StringToBool(i_SpecificParam[0]);
                m_TrunkVolume = StringParser.StringToFloat(i_SpecificParam[1]);
            }

        }
        public override List<String> GetSpecificDitails()
        {
            m_specificParams = new List<String>();
            m_specificParams.Add("If Trunk is cooled? (Y/N):");
            m_specificParams.Add("Trunk Volume");

            return m_specificParams;
        }
    }
}
