// See https://aka.ms/new-console-template for more information

using MissionMars;

Rover rover = new Rover(0, 0, 'N');
rover.Move("lblblblbb");
Console.WriteLine(rover.PrintPosition());

Console.ReadKey();
