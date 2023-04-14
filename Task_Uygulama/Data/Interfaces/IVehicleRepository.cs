using Task_Uygulama.Data.Classes;

namespace Task_Uygulama.Data.Interfaces
{
    public interface IVehicleRepository
    {
        IEnumerable<Car> GetCarsByColor(string color);
        IEnumerable<Boat> GetBoatsByColor(string color);
        IEnumerable<Bus> GetBusesByColor(string color);
        Car GetCarById(int id);
        void DeleteCar(Car car);
    }
}
