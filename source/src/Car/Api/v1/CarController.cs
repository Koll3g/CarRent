using Microsoft.AspNetCore.Mvc;
using CarRent.Car.Application;
using CarRent.Car.Persistence;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarRent.Car.Api.v1
{
    [Route("api/v1/car")]
    [ApiController]
    public class CarController : ControllerBase
    {
        // GET: api/<CarController>
        [HttpGet]
        public IEnumerable<CarResponseDto> Get()
        {
            var carApplication = new CarApplication(new CarRepository());
            var cars = carApplication.GetAll();
            foreach (var car in cars)
            {
                yield return new CarResponseDto(car);
            }
        }

        // GET api/<CarController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CarController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CarController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            new CarRepository().Add(new Domain.Car()
            {
                Id = new Guid(),
                CarNumber = "123456",
                Type = new Domain.Type(new Guid(), "type"),
                Brand = new Domain.Brand(new Guid(), "brand"),
                CarClass = new Domain.CarClass(new Guid(), "class")
            }) ;

        }

        // DELETE api/<CarController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
