using System;

namespace Hb.MarsRover.Domain.Models
{
    public class Rover
    {
        public int Id { get; private set; }
        public int CoordinateX { get; internal set; }
        public int CoordinateY { get; internal set; }
        public string Command { get; private set; }
        public Direction Direction { get; internal set; }
        public Plateu Plateu { get; private set; }
        public bool IsOutOfThePlateu { get; private set; }

        internal Rover(int id, int coordinateX, int coordinateY, char direction, string command, Plateu plateu)
        {
            Id = id;
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
            Command = command;
            Plateu = plateu;
            Direction = ConvertCharToDirection(direction);
        }

        public void Move()
        {
            for (int i = 0; i < Command.Length; i++)
            {
                Direction.Move(Command[i]);              
            }

            IsOutOfThePlateu = CheckIfRoverIsOutOfThePlateu();
            if (IsOutOfThePlateu)
                return;

            Console.WriteLine($"Rover{Id} Last Position: {CoordinateX} {CoordinateY} {ConvertDirectionToChar(Direction)}");
        }

        private Direction ConvertCharToDirection(char direction)
        {
            if (direction == 'N')
                return new North(this);
            else if (direction == 'S')
                return new South(this);
            else if (direction == 'E')
                return new East(this);
            else if (direction == 'W')
                return new West(this);

            throw new Exception("Unknown direction.");
        }

        private char ConvertDirectionToChar(Direction direction)
        {
            if (direction is North)
                return 'N';
            else if (direction is South)
                return 'S';
            else if (direction is East)
                return 'E';
            else if (direction is West)
                return 'W';

            throw new Exception("Unknown direction.");
        }

        private bool CheckIfRoverIsOutOfThePlateu()
        {
            if (CoordinateX > Plateu.CoordinateX || CoordinateX < 0 || CoordinateY > Plateu.CoordinateY || CoordinateY < 0)
            {
                Console.WriteLine($"Rover{Id} is out of the plateu. Position: {CoordinateX} {CoordinateY} {ConvertDirectionToChar(Direction)}");
                return true;
            }

            return false;
        }
    }
}
