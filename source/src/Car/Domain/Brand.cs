namespace CarRent.Car.Domain
{
    public class Brand
    {
        public Brand(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
        
        public Guid Id { get; }

        public string Name { get; }

    }
}
