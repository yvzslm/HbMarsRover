using Hb.MarsRover.Domain.Models;

namespace Hb.MarsRover.Domain
{
    public abstract class Direction
    {
        protected Rover rover;

        public Rover Rover
        {
            get { return rover; }
            set { rover = value; }
        }

        public abstract void Move(char command);
    }
}
