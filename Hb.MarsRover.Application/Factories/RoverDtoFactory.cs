using Hb.MarsRover.Application.Dtos;

namespace Hb.MarsRover.Application.Factories
{
    public class RoverDtoFactory
    {
        public static RoverDto CreateRoverDto(int id, int coordinateX, int coordinateY, char direction, string command, PlateuDto plateu)
        {
            return new RoverDto(id, coordinateX, coordinateY, direction, command, plateu);
        }
    }
}
