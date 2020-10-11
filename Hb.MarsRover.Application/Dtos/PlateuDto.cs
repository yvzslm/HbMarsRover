namespace Hb.MarsRover.Application.Dtos
{
    public class PlateuDto
    {
        public int CoordinateX { get; private set; }
        public int CoordinateY { get; private set; }

        public PlateuDto(int coordinateX, int coordinateY)
        {
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
        }
    }
}
