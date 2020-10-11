using Hb.MarsRover.Domain.Models;

namespace Hb.MarsRover.Domain.Factories
{
    public class PlateuFactory
    {
        public static Plateu CreatePlateu(int coordinateX, int coordinateY)
        {
            return new Plateu(coordinateX, coordinateY);
        }
    }
}
