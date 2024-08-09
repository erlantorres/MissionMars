using MissionMars.Services;
using MissionMars.Services.Interfaces;
using Moq;

namespace MissionMars.tests.Services;

public class RoverServiceTest
{
    [Fact]
    public void Move_ShouldMove_Returns()
    {
        //arrange
        var movementServiceMock = new Mock<IMovementService>();
        var directionServiceMock = new Mock<IDirectionService>();

        var expectedDirection = 'N';
        var (expectedPosX, expectedPosY) = (0, -5);

        directionServiceMock.Setup(m => m.GetDirection()).Returns(expectedDirection);
        movementServiceMock.Setup(m => m.GetPosition()).Returns((expectedPosX, expectedPosY));

        var roverService = new RoverService(movementServiceMock.Object, directionServiceMock.Object);

        //act
        roverService.Move("lblblblbb");
        var (posX, posY) = roverService.GetPosition();
        var direction = roverService.GetDirection();

        //assert
        Assert.Equal(expectedDirection, direction);
        Assert.Equal(expectedPosX, posX);
        Assert.Equal(expectedPosY, posY);
    }

    [Fact]
    public void Move_ShouldThrowsExceptionWhenInvalidCommand_ReturnsArgumentException()
    {
        //arrange
        var movementServiceMock = new Mock<IMovementService>();
        var directionServiceMock = new Mock<IDirectionService>();
        var expectedExceptionMessage = "command not valid";

        var roverService = new RoverService(movementServiceMock.Object, directionServiceMock.Object);

        //act & //assert
        var exception = Assert.Throws<ArgumentException>(() => roverService.Move("asdfasdf"));
        Assert.Equal(expectedExceptionMessage, exception.Message);
    }
}