
using MissionMars.Services.Interfaces;

namespace MissionMars.Services;

public class RoverService(
    IMovementService movementService,
    IDirectionService directionService
    ) : IRoverService
{
    public (int pointX, int pointY) GetPosition() => movementService.GetPosition();

    public char GetDirection() => directionService.GetDirection();

    public void Move(string commands)
    {
        foreach (char command in commands)
        {
            SendCommand(command);
        }
    }

    private void SendCommand(char command)
    {
        switch (command)
        {
            case 'f': //forward
                movementService.MoveForward();
                break;
            case 'b': //backward
                movementService.MoveBackward();
                break;
            case 'l': //left
                directionService.TurnLeft();
                break;
            case 'r': //right 
                directionService.TurnRight();
                break;
            default:
                throw new ArgumentException("command not valid");
        }
    }
}
