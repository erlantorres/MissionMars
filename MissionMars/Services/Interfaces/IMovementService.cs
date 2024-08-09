namespace MissionMars.Services.Interfaces;
public interface IMovementService
{
    void MoveBackward();
    void MoveForward();
    (int positionX, int positionY) GetPosition();
}