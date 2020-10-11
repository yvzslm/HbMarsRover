using Hb.MarsRover.Domain.Models;

namespace Hb.MarsRover.Domain
{
    public class East : Direction
    {
        public East(Direction direction) : this(direction.Rover)
        {
        }

        public East(Rover rover)
        {
            this.rover = rover;
        }

        public override void Move(char command)
        {
            if (command == 'L')
                rover.Direction = new North(this);
            else if (command == 'R')
                rover.Direction = new South(this);
            else
                rover.CoordinateX++;
        }
    }
}
