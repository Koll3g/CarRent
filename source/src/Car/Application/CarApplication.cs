

using CarRent.Car.Domain;

namespace CarRent.Car.Application
{
    public class CarApplication
    {
        private readonly ICarRepository _carRepository;
        
        public CarApplication(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        

        public IEnumerable<Domain.Car> GetAll()
        {
            return _carRepository.GetAll();
        }
    }
}