using Hb.MarsRover.Domain.Models;

namespace Hb.MarsRover.Domain
{
    public class South : Direction
    {
        public South(Direction direction) : this(direction.Rover)
        {
        }

        public South(Rover rover)
        {
            this.rover = rover;
        }

        public override void Move(char command)
        {
            if (command == 'L')
                rover.Direction = new East(this);
            else if (command == 'R')
                rover.Direction = new West(this);
            else
                rover.CoordinateY--;
        }
    }
}
