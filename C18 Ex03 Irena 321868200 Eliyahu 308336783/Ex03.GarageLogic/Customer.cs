
namespace Ex03.GarageLogic
{
    public class Customer
    {
        private string m_Name;
        private string m_PhoneNumber;

        public Customer(string i_Name, string i_PhoneNumber)
        {
            m_Name = i_Name;
            m_PhoneNumber = i_PhoneNumber;
        }
        public string Name { get => m_Name; set => m_Name = value; }
        public string OwnersPhoneNumber { get => m_PhoneNumber; set => m_PhoneNumber = value; }
    }
}
