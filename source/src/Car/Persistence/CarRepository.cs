﻿using CarRent.Car.Domain;

namespace CarRent.Car.Persistence
{
    public class CarRepository : ICarRepository
    {
        public void Add(Domain.Car car)
        {
            throw new NotImplementedException();
        }

        public Domain.Car GetByCarNumber(string carNumber)
        {
            throw new NotImplementedException();
        }

        public Domain.Car GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Domain.Car car)
        {
            throw new NotImplementedException();
        }

        public void Update(Domain.Car car)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Domain.Car> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
