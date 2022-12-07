using FluentAssertions;

namespace Proto.Api.Test
{
    public class TestWeatherForecast
    {
        [Fact]
        public void TestTemperatureF()
        {
            WeatherForecast model = new ();
            model.TemperatureC = 32;
            int tempF = model.TemperatureF;
            tempF.Should().Be(89);
        }
    }
}