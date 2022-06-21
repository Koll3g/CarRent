using System.Text.Json.Serialization;

namespace CarRent.Car.Api.v1
{
    public class CarResponseDto
    {
        public Guid Id { get; set; }

        [JsonPropertyName("car-number")]
        public string CarNumber { get; set; }

        public string Brand { get; set; }

        public string CarClass { get; set; }

        public string Type { get; set; }
    }
}
