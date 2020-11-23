using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using VehicleManagementSystem;
using VehicleManagementSystem.Interfaces;
using VehicleManagementSystem.Models;
using Moq;
namespace VehicleUnitTests
{
    public class TestCarService
    {
        private ServiceProvider _serviceProvider;
        private Car _car;
        private ICarService _sut;
        private Mock<ICarRepository> _mockCarRepository;
        [SetUp]
        public void Setup()
        {
            var configuration = Configuration.Generate();
            var startup = new Startup(configuration);
            ServiceCollection serviceCollection = new ServiceCollection();
            startup.ConfigureServices(serviceCollection);
            _serviceProvider = serviceCollection.BuildServiceProvider();
            _sut = _serviceProvider.GetService<ICarService>();
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
            _mockCarRepository = new Mock<ICarRepository>();
            _mockCarRepository.Setup(s => s.DeleteCar(It.IsAny<Car>())).Returns(10);
        }

        [Test]
        public void TestDeleteCar()
        {
            Assert.AreEqual(true,_sut.DeleteCar(_car));
        }
    }
}