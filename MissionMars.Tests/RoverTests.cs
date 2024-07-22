namespace MissionMars.Tests;

public class RoverTests
{
    [Fact]
    public void GetPosition_ShouldReturnsPosition_ReturnsPosition()
    {
        //arrange
        (int, int) positionExpected = (0, 0);
        Rover rover = new Rover(0, 0, 'N');

        //act
        (int, int) positionActual = rover.GetPosition();

        //assert
        Assert.Equal(positionExpected, positionActual);
    }
}