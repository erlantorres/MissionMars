namespace MissionMars;

public class RoverDirection : IDirection
{
    private char _direction;

    public RoverDirection(char direction)
    {
        _direction = direction;
    }

    public void TurnLeft()
    {
        if (_direction == 'N') _direction = 'W';
        else if (_direction == 'W') _direction = 'S';
        else if (_direction == 'S') _direction = 'E';
        else if (_direction == 'E') _direction = 'N';
    }

    public void TurnRight()
    {
        if (_direction == 'N') _direction = 'E';
        else if (_direction == 'E') _direction = 'S';
        else if (_direction == 'S') _direction = 'W';
        else if (_direction == 'W') _direction = 'N';
    }

    public char GetDirection()
    {
        return _direction;
    }
}
