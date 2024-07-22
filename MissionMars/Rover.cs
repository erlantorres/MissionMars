namespace MissionMars;

public class Rover
{
    private int _x;
    private int _y;
    private char _direction;
    private readonly IMovement _movement;

    public Rover(int x, int y, char direction)
    {
        _x = x;
        _y = y;
        _direction = direction;
        _movement = new RoverMovement(x, y, direction);
    }

    public void Move(string commands)
    {
        foreach (char command in commands)
        {
            //forward
            if (command == 'f')
            {
                _movement.MoveForward();
            }
            //backward
            else if (command == 'b')
            {
                _movement.MoveBackward();
            }
            //left
            else if (command == 'l')
            {
                TurnLeft();
            }
            //right 
            else if (command == 'r')
            {
                TurnRight();
            }
        }
    }

    private void TurnLeft()
    {
        if (_direction == 'N') _direction = 'W';
        else if (_direction == 'W') _direction = 'S';
        else if (_direction == 'S') _direction = 'E';
        else if (_direction == 'E') _direction = 'N';
    }

    private void TurnRight()
    {
        if (_direction == 'N') _direction = 'E';
        else if (_direction == 'E') _direction = 'S';
        else if (_direction == 'S') _direction = 'W';
        else if (_direction == 'W') _direction = 'N';
    }

    public (int x, int y) GetPosition()
    {
        return ((RoverMovement)_movement).GetPosition();
    }

    public string PrintPosition()
    {
        return $"Rover Position: {_x}, {_y}, {_direction}";
    }
}
