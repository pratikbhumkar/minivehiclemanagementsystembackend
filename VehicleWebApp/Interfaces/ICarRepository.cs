using System.Collections.Generic;
using System.Threading.Tasks;
using VehicleManagementSystem.Models;

namespace VehicleManagementSystem.Interfaces
{
    public interface ICarRepository
    {
        Task<Car> GetCar(string id);
        Task<List<Car>> GetAllCars();
        Car AddCar(Car car);
        Car UpdateCar(Car car);
        int DeleteCar(Car car);
    }
}
