using MissionMars.Services.Interfaces;

namespace MissionMars.Services;

public class RoverMovement(int pointX, int pointY, char direction) : IMovement
{
    public void MoveBackward()
    {
        if (direction == 'N') pointY -= 1;
        else if (direction == 'E') pointX -= 1;
        else if (direction == 'S') pointY += 1;
        else if (direction == 'W') pointX += 1;
    }

    public void MoveForward()
    {
        if (direction == 'N') pointY += 1;
        else if (direction == 'E') pointX += 1;
        else if (direction == 'S') pointY -= 1;
        else if (direction == 'W') pointX -= 1;
    }

    public (int x, int y) GetPosition()
    {
        return (pointX, pointY);
    }
}
