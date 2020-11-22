using System.Collections.Generic;
using System.Threading.Tasks;
using VehicleManagementSystem.Models;

namespace VehicleManagementSystem.Interfaces
{
    public interface ICarService
    {
        Task<Car> GetCar(string id);
        Task<List<Car>> GetAllCars();
        Car AddCar(Car car);
        Car UpdateCar(Car car);
        bool DeleteCar(Car car);
    }
}
