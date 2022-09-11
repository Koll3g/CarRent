namespace CarRent.Car.Domain
{
    public class Type
    {
        public Guid Id { get; }

        public string Name { get; }

        public Type(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
