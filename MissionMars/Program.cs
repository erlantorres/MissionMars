using MissionMars;

Rover rover = new Rover(0, 0, 'N');
rover.Move("lblblblbb");
(int x, int y) = rover.GetPosition();
char direction = rover.GetDirection();
Console.WriteLine($"Rover Position: {x}, {y}, {direction}");

Console.ReadKey();
