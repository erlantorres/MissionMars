using MissionMars.Services.Interfaces;
using MissionMars.Settings;

namespace MissionMars.Services;
public class MovementService(
    InitialDirectionSettings initialDirection,
    InitialPositionSettings initialPosition
    ) : IMovementService
{
    private int _positionX = initialPosition.PositionX;
    private int _positionY = initialPosition.PositionY;
    private char _direction = initialDirection.Direction;

    public void MoveBackward()
    {
        switch (_direction)
        {
            case 'N': _positionY -= 1; break;
            case 'E': _positionX -= 1; break;
            case 'S': _positionY += 1; break;
            case 'W': _positionX += 1; break;
            default:
                throw new ArgumentException(nameof(_direction), "An invalid direction has been given!");
        }
    }

    public void MoveForward()
    {
        switch (_direction)
        {
            case 'N': _positionY += 1; break;
            case 'E': _positionX += 1; break;
            case 'S': _positionY -= 1; break;
            case 'W': _positionX -= 1; break;
            default: throw new ArgumentException(nameof(_direction), "An invalid direction has been given!");
        }
    }

    public (int positionX, int positionY) GetPosition()
    {
        return (_positionX, _positionY);
    }
}
