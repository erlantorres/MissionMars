using Microsoft.Extensions.DependencyInjection;
using MissionMars;
using MissionMars.Services;
using MissionMars.Services.Interfaces;
using MissionMars.Settings;

var serviceProvider = new ServiceCollection()
    .AddSingleton(new InitialDirectionSettings('N'))
    .AddSingleton(new InitialPositionSettings(0, 0))
    .AddSingleton<IMovementService, MovementService>()
    .AddSingleton<IDirectionService, DirectionService>()
    .AddSingleton<IRoverService, RoverService>()
    .BuildServiceProvider();

var rover = new Rover(serviceProvider);
rover.Start();