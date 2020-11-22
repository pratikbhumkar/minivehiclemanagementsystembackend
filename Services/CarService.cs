using System.Collections.Generic;
using System.Threading.Tasks;
using VehicleManagementSystem.Interfaces;
using VehicleManagementSystem.Models;

namespace VehicleManagementSystem.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        public Task<Car> GetCar(string id)
        {
            return _carRepository.GetCar(id);
        }

        public Task<List<Car>> GetAllCars()
        {
            return _carRepository.GetAllCars();
        }

        public Car AddCar(Car car)
        {
            return _carRepository.AddCar(car);
        }

        public Car UpdateCar(Car car)
        {
            return _carRepository.UpdateCar(car);
        }

        public bool DeleteCar(Car car)
        {
            var result = _carRepository.DeleteCar(car);
            if (result > 0)
            {
                return true;
            }
            return false;
        }
    }
}
