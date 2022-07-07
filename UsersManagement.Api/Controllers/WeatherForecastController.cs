using AppTest;
using Microsoft.AspNetCore.Mvc;
using UsersManagement.Application.Models;
using UsersManagement.Infrastructure.Interfaces;

namespace UsersManagement.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IUsersRepository _usersRepository;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        //_usersRepository = usersRepository;
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
    }

    [HttpPost]
    public async Task<IActionResult> PostUser([FromBody] UserModel userModel)
    {
        try
        {
            await _usersRepository.Add(userModel);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            throw;
        }

        return Ok();
    }
}