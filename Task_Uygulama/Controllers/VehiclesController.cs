using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task_Uygulama.Data.Interfaces;

namespace Task_Uygulama.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly IVehicleRepository _vehicleRepository;

        public VehiclesController(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        [HttpGet("cars/{color}")]
        public IActionResult GetCarsByColor(string color)
        {
            var cars = _vehicleRepository.GetCarsByColor(color);
            return Ok(cars);
        }

        [HttpGet("boats/{color}")]
        public IActionResult GetBoatsByColor(string color)
        {
            var boats = _vehicleRepository.GetBoatsByColor(color);
            return Ok(boats);
        }

        [HttpGet("buses/{color}")]
        public IActionResult GetBusesByColor(string color)
        {
            var buses = _vehicleRepository.GetBusesByColor(color);
            return Ok(buses);
        }

        [HttpPost("cars/{id}/headlights")]
        public IActionResult ToggleHeadlights(int id)
        {
            var car = _vehicleRepository.GetCarById(id);

            if (car == null)
            {
                return NotFound();
            }

            car.HeadlightsOn = !car.HeadlightsOn;
            return Ok(@$"{car.Colour} car {(car.HeadlightsOn ? "headlights open" : "headlights close")} ");
        }

        [HttpDelete("cars/{id}")]
        public IActionResult DeleteCar(int id)
        {
            var car = _vehicleRepository.GetCarById(id);

            if (car == null)
            {
                return NotFound();
            }

            _vehicleRepository.DeleteCar(car);

            return Ok();
        }
    }
}
