using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VehicleManagementSystem.Interfaces;
using VehicleManagementSystem.Models;

namespace VehicleManagementSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        private readonly ILogger<CarController> _logger;
        private readonly ICarService _carService;
        public CarController(ICarService carService, ILogger<CarController> logger)
        {
            _carService = carService;
            _logger = logger;
        }
        
        [HttpGet]
        [Route("GetAllCars")]
        public async Task<ActionResult> GetAllCars()
        {
            _logger.LogInformation("Get all Cars called");
            var result = await _carService.GetAllCars();
            return Ok(result);
        }

        [HttpGet]
        [Route("GetCarDetails")]
        public async Task<ActionResult> GetCarDetails(string id)
        {
            _logger.LogInformation("Get Car details called");
            var result = await _carService.GetCar(id);
            return Ok(result);
        }

        [HttpPost]
        [Route("AddCar")]
        public ActionResult AddCar([FromBody]Car car)
        {
            _logger.LogInformation("AddCar Car called");
            if (!ModelState.IsValid)
                return BadRequest("Please check data entered");

            var result = _carService.AddCar(car);
            return Ok(result);
        }

        [HttpPost]
        [Route("DeleteCar")]
        public ActionResult DeleteCar(Car car)
        {
            _logger.LogInformation("Remove Car called");
            if (!ModelState.IsValid)
                return BadRequest("Please check data entered");

            var result = _carService.DeleteCar(car);
            return Ok(result);

        }

        [HttpPost]
        [Route("UpdateCar")]
        public ActionResult UpdateCar(Car car)
        {
            _logger.LogInformation("UpdateCar Car called");
            if (!ModelState.IsValid)
                return BadRequest("Please check data entered");

            var result = _carService.UpdateCar(car);
            return Ok(result);
        }
    }
}
