using Hb.MarsRover.Domain;
using Hb.MarsRover.Domain.Factories;
using System;
using Xunit;

namespace Hb.MarsRover.Tests
{
    public class RoverTests
    {
        [InlineData(5, 5, 1, 1, 2, 'N', "LMLMLMLMM", 1, 3, typeof(North), false)]
        [InlineData(5, 5, 2, 3, 3, 'E', "MMRMMRMRRM", 5, 1, typeof(East), false)]
        [InlineData(3, 7, 3, 4, 2, 'W', "MRLMRMMLMMM", -1, 4, typeof(West), true)]
        [InlineData(6, 4, 4, 3, 0, 'E', "MMRMMRMRRM", 5, -2, typeof(East), true)]
        [Theory]
        public void Test_Move_Rover(int plateuXCoordinate, int plateuYCoordinate, int roverId, int coordinateX, int coordinateY, char direction, string command, int expectedX, int expectedY, Type expectedDirection, bool isOutOfThePlateu)
        {
            var plateu = PlateuFactory.CreatePlateu(plateuXCoordinate, plateuYCoordinate);
            var rover = RoverFactory.CreateRover(roverId, coordinateX, coordinateY, direction, command, plateu);

            rover.Move();

            Assert.Equal(expectedX, rover.CoordinateX);
            Assert.Equal(expectedY, rover.CoordinateY);
            Assert.Equal(expectedDirection, rover.Direction.GetType());
            Assert.Equal(isOutOfThePlateu, rover.IsOutOfThePlateu);
        }
    }
}
