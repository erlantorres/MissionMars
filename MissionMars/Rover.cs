
using Microsoft.Extensions.DependencyInjection;
using MissionMars.Services.Interfaces;

namespace MissionMars;

public class Rover(IServiceProvider serviceProvider)
{
    public void Start()
    {
        var roverService = serviceProvider.GetRequiredService<IRoverService>();

        var (roverPositionX, roverPositionY) = roverService.GetPosition();
        var roverDirection = roverService.GetDirection();

        WriteCoordinates(roverPositionX, roverPositionY, roverDirection);

        roverService.Move("lblblblbb");
        roverService.Move("lfffffflllrr");

        (roverPositionX, roverPositionY) = roverService.GetPosition();
        roverDirection = roverService.GetDirection();

        WriteCoordinates(roverPositionX, roverPositionY, roverDirection);
    }

    private static void WriteCoordinates(int x, int y, char direction)
    {
        Console.WriteLine($"Rover actual position and direction: d: {direction}, x: {x}, y: {y}");
    }
}