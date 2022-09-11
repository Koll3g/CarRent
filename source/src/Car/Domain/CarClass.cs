namespace CarRent.Car.Domain
{
    public class CarClass
    {
        public Guid Id { get; }

        public string Name { get; }

        public CarClass(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

    }
}
