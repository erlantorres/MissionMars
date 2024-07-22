namespace MissionMars;

public class Rover
{
    private readonly IMovement _movement;
    private readonly IDirection _direction;

    public Rover(int x, int y, char direction)
    {
        _movement = new RoverMovement(x, y, direction);
        _direction = new RoverDirection(direction);
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
                _direction.TurnLeft();
            }
            //right 
            else if (command == 'r')
            {
                _direction.TurnRight();
            }
        }
    }

    public (int x, int y) GetPosition()
    {
        return ((RoverMovement)_movement).GetPosition();
    }

    public char GetDirection()
    {
        return ((RoverDirection)_direction).GetDirection();
    }
}
