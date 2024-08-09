
namespace MissionMars.Services.Interfaces;

public interface IRoverService
{
    (int pointX, int pointY) GetPosition();
    char GetDirection();
    void Move(string commands);
}