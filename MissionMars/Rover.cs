using MissionMars.Services.Interfaces;

namespace MissionMars;

public class Rover(IMovement movement, IDirection direction)
{
    public void Move(string commands)
    {
        foreach (char command in commands)
        {
            switch (command)
            {
                case 'f': //forward
                    movement.MoveForward();
                    break;
                case 'b': //backward
                    movement.MoveBackward();
                    break;
                case 'l': //left
                    direction.TurnLeft();
                    break;
                case 'r': //right 
                    direction.TurnRight();
                    break;
                default:
                    throw new ArgumentException("command not valid");
            }
        }
    }

    public (int x, int y) GetPosition()
    {
        return movement.GetPosition();
    }

    public char GetDirection()
    {
        return direction.GetDirection();
    }
}
