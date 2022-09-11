namespace CarRent.Car.Domain
{
    public class Car
    {
        public Guid Id { get; set; }

        public string CarNumber { get; set; }

        public Brand Brand { get; set; }

        public Type Type { get; set; }

        public CarClass CarClass { get; set; }

    }
}
