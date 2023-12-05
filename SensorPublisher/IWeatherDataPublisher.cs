
namespace SensorPublisher
{
    public interface IWeatherDataPublisher
    {
        Task ProduceAsync(Weather weather);
    }
}