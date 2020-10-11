using Hb.MarsRover.Domain.Models;

namespace Hb.MarsRover.Domain
{
    public class North : Direction
    {
        public North(Direction direction) : this(direction.Rover)
        {
        }

        public North(Rover rover)
        {
            this.rover = rover;
        }

        public override void Move(char command)
        {
            if (command == 'L')
                rover.Direction = new West(this);
            else if (command == 'R')
                rover.Direction = new East(this);
            else
                rover.CoordinateY++;
        }
    }
}
