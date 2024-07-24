namespace MissionMars.Services.Interfaces;

public interface IMovement
{
    void MoveForward();
    void MoveBackward();
    (int x, int y) GetPosition();
}
