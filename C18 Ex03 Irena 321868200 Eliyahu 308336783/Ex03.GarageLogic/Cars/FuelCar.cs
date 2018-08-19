using Ex03.GarageLogic.Engines;

namespace Ex03.GarageLogic.Cars
{
    public class FuelCar : Car
    {
        public FuelCar(string i_ModelName, string i_LicenseNumber, int i_NumberOfWheels,
                eCarColors i_carColor, int i_DoorsQuantity,
                eFuelTypes i_FuelType, float i_TankSize)
                : base(i_ModelName, i_LicenseNumber, i_NumberOfWheels, i_carColor, i_DoorsQuantity)
        {
            if (this.m_Engine == null)
            {
                m_Engine = new FuelEngine(i_FuelType, i_TankSize);
            }
        }
    }
}

