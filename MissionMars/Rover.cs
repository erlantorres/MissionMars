namespace MissionMars;

public class Rover
{
    private readonly IMovement _movement;
    private readonly IDirection _direction;

    public Rover(int pointX, int pointY, char direction)
    {
        _movement = new RoverMovement(pointX, pointY, direction);
        _direction = new RoverDirection(direction);
    }

    public void Move(string commands)
    {
        foreach (char command in commands)
        {
            switch (command)
            {
                case 'f': //forward
                    _movement.MoveForward();
                    break;
                case 'b': //backward
                    _movement.MoveBackward();
                    break;
                case 'l': //left
                    _direction.TurnLeft();
                    break;
                case 'r': //right 
                    _direction.TurnRight();
                    break;
                default:
                    throw new ArgumentException("command not valid");
            }
        }
    }

    public (int x, int y) GetPosition()
    {
        return _movement.GetPosition();
    }

    public char GetDirection()
    {
        return _direction.GetDirection();
    }
}
