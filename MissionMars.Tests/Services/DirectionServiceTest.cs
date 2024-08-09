
using MissionMars.Services;
using MissionMars.Settings;

namespace MissionMars.tests.Services;

public class DirectionServiceTest
{
    [Fact]
    public void TurnLeft_WhenNorth_ReturnsWest()
    {
        //arrange
        var expectedDirection = 'W';
        var initialDirection = new InitialDirectionSettings('N');
        var directionService = new DirectionService(initialDirection);

        //act
        directionService.TurnLeft();
        var direction = directionService.GetDirection();

        //assert
        Assert.Equal(expectedDirection, direction);
    }

    [Fact]
    public void TurnLeft_WhenWest_ReturnsSouth()
    {
        //arrange
        var expectedDirection = 'S';
        var initialDirection = new InitialDirectionSettings('W');
        var directionService = new DirectionService(initialDirection);

        //act
        directionService.TurnLeft();
        var direction = directionService.GetDirection();

        //assert
        Assert.Equal(expectedDirection, direction);
    }

    [Fact]
    public void TurnLeft_WhenSouth_ReturnsEast()
    {
        //arrange
        var expectedDirection = 'E';
        var initialDirection = new InitialDirectionSettings('S');
        var directionService = new DirectionService(initialDirection);

        //act
        directionService.TurnLeft();
        var direction = directionService.GetDirection();

        //assert
        Assert.Equal(expectedDirection, direction);
    }

    [Fact]
    public void TurnLeft_WhenEast_ReturnsNorth()
    {
        //arrange
        var expectedDirection = 'N';
        var initialDirection = new InitialDirectionSettings('E');
        var directionService = new DirectionService(initialDirection);

        //act
        directionService.TurnLeft();
        var direction = directionService.GetDirection();

        //assert
        Assert.Equal(expectedDirection, direction);
    }

    [Fact]
    public void TurnLeft_WhenWrongDirection_ReturnsThrowsArgumentException()
    {
        //arrange
        var expectedExceptionMessage = "_direction (Parameter 'An invalid direction has been given!')";
        var expectedExceptionParamName = "An invalid direction has been given!";
        var initialDirection = new InitialDirectionSettings('Q');
        var directionService = new DirectionService(initialDirection);

        //act & //assert
        var exception = Assert.Throws<ArgumentException>(() => directionService.TurnLeft());
        Assert.Equal(expectedExceptionMessage, exception.Message);
        Assert.Equal(expectedExceptionParamName, exception.ParamName);
    }

    [Fact]
    public void TurnRight_WhenNorth_ReturnsEast()
    {
        //arrange
        var expectedDirection = 'E';
        var initialDirection = new InitialDirectionSettings('N');
        var directionService = new DirectionService(initialDirection);

        //act
        directionService.TurnRight();
        var direction = directionService.GetDirection();

        //assert
        Assert.Equal(expectedDirection, direction);
    }

    [Fact]
    public void TurnRight_WhenEast_ReturnsSouth()
    {
        //arrange
        var expectedDirection = 'S';
        var initialDirection = new InitialDirectionSettings('E');
        var directionService = new DirectionService(initialDirection);

        //act
        directionService.TurnRight();
        var direction = directionService.GetDirection();

        //assert
        Assert.Equal(expectedDirection, direction);
    }

    [Fact]
    public void TurnRight_WhenSouth_ReturnsWest()
    {
        //arrange
        var expectedDirection = 'W';
        var initialDirection = new InitialDirectionSettings('S');
        var directionService = new DirectionService(initialDirection);

        //act
        directionService.TurnRight();
        var direction = directionService.GetDirection();

        //assert
        Assert.Equal(expectedDirection, direction);
    }

    [Fact]
    public void TurnRight_WhenWest_ReturnsNorth()
    {
        //arrange
        var expectedDirection = 'N';
        var initialDirection = new InitialDirectionSettings('W');
        var directionService = new DirectionService(initialDirection);

        //act
        directionService.TurnRight();
        var direction = directionService.GetDirection();

        //assert
        Assert.Equal(expectedDirection, direction);
    }

    [Fact]
    public void TurnRight_WhenWrongDirection_ReturnsThrowsArgumentException()
    {
        //arrange
        var expectedExceptionMessage = "_direction (Parameter 'An invalid direction has been given!')";
        var expectedExceptionParamName = "An invalid direction has been given!";
        var initialDirection = new InitialDirectionSettings('Q');
        var directionService = new DirectionService(initialDirection);

        //act & //assert
        var exception = Assert.Throws<ArgumentException>(() => directionService.TurnRight());
        Assert.Equal(expectedExceptionMessage, exception.Message);
        Assert.Equal(expectedExceptionParamName, exception.ParamName);
    }
}
