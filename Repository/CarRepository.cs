using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VehicleManagementSystem.Interfaces;
using VehicleManagementSystem.Models;

namespace VehicleManagementSystem.Repository
{
    public class CarRepository:ICarRepository
    {
        private readonly AppDbContext _appDbContext;
        public CarRepository(AppDbContext appContext)
        {
            _appDbContext = appContext;
        }

        public Task<Car> GetCar(string id)
        {
            return _appDbContext.Car.SingleOrDefaultAsync(car => car.Id == id);
        }

        public async Task<List<Car>> GetAllCars()
        {
            return await _appDbContext.Car.ToListAsync();
        }

        public Car AddCar(Car car)
        {
            _appDbContext.Car.Add(car);
            _appDbContext.SaveChanges();
            return car;
        }

        public Car UpdateCar(Car car)
        {
            _appDbContext.Car.Update(car);
            _appDbContext.SaveChanges();
            return car;
        }

        public int DeleteCar(Car car)
        {
            _appDbContext.Car.Remove(car);
            return _appDbContext.SaveChanges();
        }
    }
}
