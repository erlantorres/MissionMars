using MissionMars.Services;
using MissionMars.Settings;

namespace MissionMars.tests.Services;

public class MovementServiceTest
{
    [Fact]
    public void MoveBackward_WhenGoNorth_ReturnsPosition()
    {
        //arange
        var (expectedPosX, expectedPosY) = (0, -1);

        var initialDirection = new InitialDirectionSettings('N');
        var initialPosition = new InitialPositionSettings(0, 0);

        var movement = new MovementService(initialDirection, initialPosition);

        //act
        movement.MoveBackward();
        var (posX, posY) = movement.GetPosition();

        //asert
        Assert.Equal(expectedPosX, posX);
        Assert.Equal(expectedPosY, posY);
    }

    [Fact]
    public void MoveBackward_WhenGoEast_ReturnsPosition()
    {
        //arange
        var (expectedPosX, expectedPosY) = (-1, 0);

        var initialDirection = new InitialDirectionSettings('E');
        var initialPosition = new InitialPositionSettings(0, 0);

        var movement = new MovementService(initialDirection, initialPosition);

        //act
        movement.MoveBackward();
        var (posX, posY) = movement.GetPosition();

        //asert
        Assert.Equal(expectedPosX, posX);
        Assert.Equal(expectedPosY, posY);
    }

    [Fact]
    public void MoveBackward_WhenGoSouth_ReturnsPosition()
    {
        //arange
        var (expectedPosX, expectedPosY) = (0, 1);

        var initialDirection = new InitialDirectionSettings('S');
        var initialPosition = new InitialPositionSettings(0, 0);

        var movement = new MovementService(initialDirection, initialPosition);

        //act
        movement.MoveBackward();
        var (posX, posY) = movement.GetPosition();

        //asert
        Assert.Equal(expectedPosX, posX);
        Assert.Equal(expectedPosY, posY);
    }

    [Fact]
    public void MoveBackward_WhenGoWest_ReturnsPosition()
    {
        //arange
        var (expectedPosX, expectedPosY) = (1, 0);

        var initialDirection = new InitialDirectionSettings('W');
        var initialPosition = new InitialPositionSettings(0, 0);

        var movement = new MovementService(initialDirection, initialPosition);

        //act
        movement.MoveBackward();
        var (posX, posY) = movement.GetPosition();

        //asert
        Assert.Equal(expectedPosX, posX);
        Assert.Equal(expectedPosY, posY);
    }

    [Fact]
    public void MoveBackward_WhenGoWrongDirection_ReturnsThrowsArgumentException()
    {
        //arange
        var expectedExceptionParamName = "An invalid direction has been given!";
        var expectedExceptionMessage = "_direction (Parameter 'An invalid direction has been given!')";

        var initialDirection = new InitialDirectionSettings('Q');
        var initialPosition = new InitialPositionSettings(0, 0);

        var movement = new MovementService(initialDirection, initialPosition);

        //act
        var exception = Assert.Throws<ArgumentException>(() => movement.MoveBackward());

        //asert
        Assert.Equal(expectedExceptionParamName, exception.ParamName);
        Assert.Equal(expectedExceptionMessage, exception.Message);
    }


    [Fact]
    public void MoveForward_WhenGoNorth_ReturnsPosition()
    {
        //arange
        var (expectedPosX, expectedPosY) = (0, 1);

        var initialDirection = new InitialDirectionSettings('N');
        var initialPosition = new InitialPositionSettings(0, 0);

        var movement = new MovementService(initialDirection, initialPosition);

        //act
        movement.MoveForward();
        var (posX, posY) = movement.GetPosition();

        //asert
        Assert.Equal(expectedPosX, posX);
        Assert.Equal(expectedPosY, posY);
    }

    [Fact]
    public void MoveForward_WhenGoEast_ReturnsPosition()
    {
        //arange
        var (expectedPosX, expectedPosY) = (1, 0);

        var initialDirection = new InitialDirectionSettings('E');
        var initialPosition = new InitialPositionSettings(0, 0);

        var movement = new MovementService(initialDirection, initialPosition);

        //act
        movement.MoveForward();
        var (posX, posY) = movement.GetPosition();

        //asert
        Assert.Equal(expectedPosX, posX);
        Assert.Equal(expectedPosY, posY);
    }

    [Fact]
    public void MoveForward_WhenGoSouth_ReturnsPosition()
    {
        //arange
        var (expectedPosX, expectedPosY) = (0, -1);

        var initialDirection = new InitialDirectionSettings('S');
        var initialPosition = new InitialPositionSettings(0, 0);

        var movement = new MovementService(initialDirection, initialPosition);

        //act
        movement.MoveForward();
        var (posX, posY) = movement.GetPosition();

        //asert
        Assert.Equal(expectedPosX, posX);
        Assert.Equal(expectedPosY, posY);
    }

    [Fact]
    public void MoveForward_WhenGoWest_ReturnsPosition()
    {
        //arange
        var (expectedPosX, expectedPosY) = (-1, 0);

        var initialDirection = new InitialDirectionSettings('W');
        var initialPosition = new InitialPositionSettings(0, 0);

        var movement = new MovementService(initialDirection, initialPosition);

        //act
        movement.MoveForward();
        var (posX, posY) = movement.GetPosition();

        //asert
        Assert.Equal(expectedPosX, posX);
        Assert.Equal(expectedPosY, posY);
    }

    [Fact]
    public void MoveForward_WhenGoWrongDirection_ReturnsThrowsArgumentException()
    {
        //arange
        var expectedExceptionParamName = "An invalid direction has been given!";
        var expectedExceptionMessage = "_direction (Parameter 'An invalid direction has been given!')";

        var initialDirection = new InitialDirectionSettings('Q');
        var initialPosition = new InitialPositionSettings(0, 0);

        var movement = new MovementService(initialDirection, initialPosition);

        //act
        var exception = Assert.Throws<ArgumentException>(() => movement.MoveForward());

        //asert
        Assert.Equal(expectedExceptionParamName, exception.ParamName);
        Assert.Equal(expectedExceptionMessage, exception.Message);
    }
}
