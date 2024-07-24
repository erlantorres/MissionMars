using MissionMars.Services.Interfaces;

namespace MissionMars.Services;

public class RoverDirection(char direction) : IDirection
{
    public void TurnLeft()
    {
        if (direction == 'N') direction = 'W';
        else if (direction == 'W') direction = 'S';
        else if (direction == 'S') direction = 'E';
        else if (direction == 'E') direction = 'N';
    }

    public void TurnRight()
    {
        if (direction == 'N') direction = 'E';
        else if (direction == 'E') direction = 'S';
        else if (direction == 'S') direction = 'W';
        else if (direction == 'W') direction = 'N';
    }

    public char GetDirection()
    {
        return direction;
    }
}
