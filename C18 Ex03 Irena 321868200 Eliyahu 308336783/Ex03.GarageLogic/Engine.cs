using System;
using System.Collections.Generic;

namespace Ex03.GarageLogic

{
    public abstract class Engine
    {
        public List<String> m_EngineList;

        abstract public float EnergyPercentage();

        //abstract public void ShowEngineParameters();
    }
}
