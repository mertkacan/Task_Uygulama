using Task_Uygulama.Data.Classes;
using Task_Uygulama.Data.Interfaces;

namespace Task_Uygulama.Data.RepositoryClasses
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly List<Car> _cars = new List<Car>();
        private readonly List<Boat> _boats = new List<Boat>();
        private readonly List<Bus> _buses = new List<Bus>();

        public VehicleRepository()
        {
            // Create sample data
            _cars.Add(new Car { Id = 1, Colour = "red", Wheels = 4, HeadlightsOn = true });
            _cars.Add(new Car { Id = 2, Colour = "blue", Wheels = 4, HeadlightsOn = false });
            _cars.Add(new Car { Id = 3, Colour = "black", Wheels = 4, HeadlightsOn = false });
            _cars.Add(new Car { Id = 4, Colour = "white", Wheels = 4, HeadlightsOn = false });

            _boats.Add(new Boat { Id = 1, Colour = "red" });
            _boats.Add(new Boat { Id = 2, Colour = "blue" });
            _boats.Add(new Boat { Id = 3, Colour = "black" });
            _boats.Add(new Boat { Id = 4, Colour = "white" });

            _buses.Add(new Bus { Id = 1, Colour = "red" });
            _buses.Add(new Bus { Id = 2, Colour = "blue" });
            _buses.Add(new Bus { Id = 3, Colour = "black" });
            _buses.Add(new Bus { Id = 4, Colour = "white" });
        }

        public IEnumerable<Car> GetCarsByColor(string color)
        {
            return _cars.Where(c => c.Colour == color);
        }

        public IEnumerable<Boat> GetBoatsByColor(string color)
        {
            return _boats.Where(b => b.Colour == color);
        }

        public IEnumerable<Bus> GetBusesByColor(string color)
        {
            return _buses.Where(b => b.Colour == color);
        }

        public Car GetCarById(int id)
        {
            return _cars.FirstOrDefault(c => c.Id == id);
        }

        public void DeleteCar(Car car)
        {
            _cars.Remove(car);
        }
    }
}

