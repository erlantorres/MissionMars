using MissionMars.Services;
using MissionMars.Services.Interfaces;

namespace MissionMars.Tests;

public class RoverTests
{
    public Rover GetRover(int pointX, int pointY, char direction)
    {
        IDirection directionService = new RoverDirection(direction);
        IMovement movementService = new RoverMovement(pointX, pointY, direction);


        return new Rover(movementService, directionService);
    }

    [Fact]
    public void GetDirectionAndGetPosition_ShouldBeInitial_ReturnsInitial()
    {
        //arrange
        (int, int) positionExpected = (0, 0);
        char directionExpected = 'N';
        Rover rover = GetRover(0, 0, 'N');

        //act
        (int, int) positionActual = rover.GetPosition();
        char directionActual = rover.GetDirection();

        //assert
        Assert.Equal(positionExpected, positionActual);
        Assert.Equal(directionExpected, directionActual);
    }

    [Fact]
    public void MoveForward_ShouldMove_ReturnsPosition()
    {
        //arrange
        (int, int) positionExpected = (0, 1);
        Rover rover = GetRover(0, 0, 'N');

        //act
        rover.Move("f");
        (int, int) positionActual = rover.GetPosition();

        //assert
        Assert.Equal(positionExpected, positionActual);
    }

    [Fact]
    public void MoveBackward_ShouldMove_ReturnsInitialPosition()
    {
        //arrange
        (int, int) positionExpected = (0, 0);
        Rover rover = GetRover(0, 1, 'N');

        //act
        rover.Move("b");
        (int, int) positionActual = rover.GetPosition();

        //assert
        Assert.Equal(positionExpected, positionActual);
    }

    [Fact]
    public void TurnLeft_ShouldMove_ReturnsDirectionWest()
    {
        //arrange
        char directionExpected = 'W';
        Rover rover = GetRover(0, 0, 'N');

        //act
        rover.Move("l");
        char directionActual = rover.GetDirection();

        //assert
        Assert.Equal(directionExpected, directionActual);
    }

    [Fact]
    public void TurnLeft_ShouldMove_ReturnsDirectionSouth()
    {
        //arrange
        char directionExpected = 'S';
        Rover rover = GetRover(0, 0, 'W');

        //act
        rover.Move("l");
        char directionActual = rover.GetDirection();

        //assert
        Assert.Equal(directionExpected, directionActual);
    }

    [Fact]
    public void TurnLeft_ShouldMove_ReturnsDirectionEast()
    {
        //arrange
        char directionExpected = 'E';
        Rover rover = GetRover(0, 0, 'S');

        //act
        rover.Move("l");
        char directionActual = rover.GetDirection();

        //assert
        Assert.Equal(directionExpected, directionActual);
    }

    [Fact]
    public void TurnLeft_ShouldMove_ReturnsDirectionNorth()
    {
        //arrange
        char directionExpected = 'N';
        Rover rover = GetRover(0, 0, 'E');

        //act
        rover.Move("l");
        char directionActual = rover.GetDirection();

        //assert
        Assert.Equal(directionExpected, directionActual);
    }

    [Fact]
    public void TurnRight_ShouldMove_ReturnsDirectionEast()
    {
        //arrange
        char directionExpected = 'E';
        Rover rover = GetRover(0, 0, 'N');

        //act
        rover.Move("r");
        char directionActual = rover.GetDirection();

        //assert
        Assert.Equal(directionExpected, directionActual);
    }

    [Fact]
    public void TurnRight_ShouldMove_ReturnsDirectionSouth()
    {
        //arrange
        char directionExpected = 'S';
        Rover rover = GetRover(0, 0, 'E');

        //act
        rover.Move("r");
        char directionActual = rover.GetDirection();

        //assert
        Assert.Equal(directionExpected, directionActual);
    }

    [Fact]
    public void TurnRight_ShouldMove_ReturnsDirectionWest()
    {
        //arrange
        char directionExpected = 'W';
        Rover rover = GetRover(0, 0, 'S');

        //act
        rover.Move("r");
        char directionActual = rover.GetDirection();

        //assert
        Assert.Equal(directionExpected, directionActual);
    }

    [Fact]
    public void TurnRight_ShouldMove_ReturnsDirectionNorth()
    {
        //arrange
        char directionExpected = 'N';
        Rover rover = GetRover(0, 0, 'W');

        //act
        rover.Move("r");
        char directionActual = rover.GetDirection();

        //assert
        Assert.Equal(directionExpected, directionActual);
    }

    [Fact]
    public void MoveMultiplesDirection_ShouldBeMove_ReturnsPositionDirection()
    {
        //arrange
        char directionExpected = 'N';
        (int, int) positionExpected = (0, -5);
        Rover rover = GetRover(0, 0, 'N');

        //act
        rover.Move("lblblblbb");
        (int, int) positionActual = rover.GetPosition();
        char directionActual = rover.GetDirection();

        //assert
        Assert.Equal(directionExpected, directionActual);
        Assert.Equal(positionExpected, positionActual);
    }
}