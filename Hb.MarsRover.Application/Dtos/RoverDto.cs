namespace Hb.MarsRover.Application.Dtos
{
    public class RoverDto
    {
        public int Id { get; private set; }
        public int CoordinateX { get; private set; }
        public int CoordinateY { get; private set; }
        public string Command { get; private set; }
        public char Direction { get; private set; }
        public PlateuDto Plateu { get; private set; }

        public RoverDto(int id, int coordinateX, int coordinateY, char direction, string command, PlateuDto plateu)
        {
            Id = id;
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
            Command = command;
            Plateu = plateu;
            Direction = direction;
        }
    }
}
