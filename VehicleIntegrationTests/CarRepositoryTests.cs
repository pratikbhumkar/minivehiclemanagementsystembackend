using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using VehicleManagementSystem;
using VehicleManagementSystem.Interfaces;
using VehicleManagementSystem.Models;

namespace VehicleIntegrationTests
{
    public class TestCarRepository
    {
        private ServiceProvider _serviceProvider;
        private Car _car;
        private ICarRepository _sut;
        [SetUp]
        public void Setup()
        {
            var configuration = Configuration.Generate();
            var startup = new Startup(configuration);
            ServiceCollection serviceCollection = new ServiceCollection();
            startup.ConfigureServices(serviceCollection);
            _serviceProvider = serviceCollection.BuildServiceProvider();
            _sut =_serviceProvider.GetService<ICarRepository>();
            _car = new Car()
            {
                Id = "123",
                BodyType = "HatchBack",
                Doors = 4,
                Engine = "IVtec",
                Make = "2020",
                Model = "Civic",
                VehicleType = "Car",
                Wheels = 4
            };
        }

        [Test]
        public void ThenReturnsAllCars()
        {
            Assert.DoesNotThrowAsync(() => _sut.GetAllCars());
        }

        [Test]
        public void ThenAddsCar()
        {
            Assert.AreEqual(_car, _sut.AddCar(_car));
        }

        [Test]
        public async Task ThenReturnsCar()
        {
            Assert.AreEqual(_car, _sut.AddCar(_car));
        }

        [Test]
        public void ThenCarIsRemoved()
        {
            Assert.AreEqual(1, _sut.DeleteCar(_car));
        }
    }
}