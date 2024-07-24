using Microsoft.Extensions.DependencyInjection;
using MissionMars;

var serviceProvider = new ServiceCollection()
    .AddSingleton<IMovement>(new RoverMovement(0, 0, 'N'))
    .AddSingleton<IDirection>(new RoverDirection('N'))
    .BuildServiceProvider();

var movementService = serviceProvider.GetRequiredService<IMovement>();
var directionService = serviceProvider.GetRequiredService<IDirection>();
Rover rover = new Rover(movementService, directionService);
rover.Move("lblblblbb");
(int x, int y) = rover.GetPosition();
char direction = rover.GetDirection();
Console.WriteLine($"Rover Position: {x}, {y}, {directionService}");

Console.ReadKey();
