using Hb.MarsRover.Domain.Models;

namespace Hb.MarsRover.Domain
{
    public class West : Direction
    {
        public West(Direction direction) : this(direction.Rover)
        {
        }

        public West(Rover rover)
        {
            this.rover = rover;
        }

        public override void Move(char command)
        {
            if (command == 'L')
                rover.Direction = new South(this);
            else if (command == 'R')
                rover.Direction = new North(this);
            else
                rover.CoordinateX--;
        }
    }
}
