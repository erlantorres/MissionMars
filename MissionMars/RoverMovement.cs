namespace MissionMars;

public class RoverMovement : IMovement
{
    private int _x;
    private int _y;
    private char _direction;

    public RoverMovement(int x, int y, char direction)
    {
        _x = x;
        _y = y;
        _direction = direction;
    }

    public void MoveBackward()
    {
        if (_direction == 'N') _y -= 1;
        else if (_direction == 'E') _x -= 1;
        else if (_direction == 'S') _y += 1;
        else if (_direction == 'W') _x += 1;
    }

    public void MoveForward()
    {
        if (_direction == 'N') _y += 1;
        else if (_direction == 'E') _x += 1;
        else if (_direction == 'S') _y -= 1;
        else if (_direction == 'W') _x -= 1;
    }

    public (int x, int y) GetPosition()
    {
        return (_x, _y);
    }
}
