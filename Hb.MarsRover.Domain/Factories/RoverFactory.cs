using Hb.MarsRover.Domain.Models;

namespace Hb.MarsRover.Domain.Factories
{
    public class RoverFactory
    {
        public static Rover CreateRover(int id, int coordinateX, int coordinateY, char direction, string command, Plateu plateu)
        {
            return new Rover(id, coordinateX, coordinateY, direction, command, plateu);
        }
    }
}
