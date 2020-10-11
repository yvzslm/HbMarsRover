using Hb.MarsRover.Application.Dtos;

namespace Hb.MarsRover.Application.Factories
{
    public class PlateuDtoFactory
    {
        public static PlateuDto CreatePlateuDto(int coordinateX, int coordinateY)
        {
            return new PlateuDto(coordinateX, coordinateY);
        }
    }
}
