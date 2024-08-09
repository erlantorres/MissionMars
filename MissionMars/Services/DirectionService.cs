
using MissionMars.Services.Interfaces;
using MissionMars.Settings;

namespace MissionMars.Services;

public class DirectionService(InitialDirectionSettings initialDirection) : IDirectionService
{
    private char _direction = initialDirection.Direction;

    public char GetDirection() => _direction;

    public void TurnLeft() => _direction = _direction switch
    {
        'N' => 'W',
        'W' => 'S',
        'S' => 'E',
        'E' => 'N',
        _ => throw new ArgumentException(nameof(_direction), "An invalid direction has been given!")
    };

    public void TurnRight() => _direction = _direction switch
    {
        'N' => 'E',
        'E' => 'S',
        'S' => 'W',
        'W' => 'N',
        _ => throw new ArgumentException(nameof(_direction), "An invalid direction has been given!")
    };
}
