namespace Hb.MarsRover.Domain.Models
{
    public class Plateu
    {
        public int CoordinateX { get; private set; }
        public int CoordinateY { get; private set; }

        internal Plateu(int coordinateX, int coordinateY)
        {
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
        }
    }
}
