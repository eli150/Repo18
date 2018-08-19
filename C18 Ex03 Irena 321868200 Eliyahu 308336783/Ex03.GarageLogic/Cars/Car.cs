
namespace Ex03.GarageLogic.Cars
{
    abstract public class Car : Vehicle
    {
        private eCarColors m_CarColor;
        //private eFuelTypes m_FuelType;
        //private eNumberOfCarDoors m_NumberOfCarDoors;
        private int m_NumberOfCarDoors;

        public Car(string i_ModelName, string i_LicenseNumber, int i_NumberOfWheels,
            eCarColors i_carColor, int i_DoorsQuantity) 
            :base (i_ModelName, i_LicenseNumber, i_NumberOfWheels)
        {
            m_CarColor = i_carColor;
            m_NumberOfCarDoors = i_DoorsQuantity;
        }
        
    }
}
