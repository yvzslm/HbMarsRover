using System;
using Hb.MarsRover.Application;
using Hb.MarsRover.Application.Factories;

namespace Hb.MarsRover.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Upper-Right Coordinates Of The Plateu: ");
            var plateuCoordinates = Console.ReadLine().Split(' ');
            var plateuXCoordinate = int.Parse(plateuCoordinates[0]);
            var plateuYCoordinate = int.Parse(plateuCoordinates[1]);

            var plateuDto = PlateuDtoFactory.CreatePlateuDto(plateuXCoordinate, plateuYCoordinate);
            var roverManager = new RoverManager();
            Console.Write("Rover Count: ");
            var roverCount = int.Parse(Console.ReadLine());

            int count = 1;
            while (count <= roverCount)
            {
                Console.Write($"Rover{count} Initial Position: ");
                var roverPosition = Console.ReadLine().Split(' ');
                var roverXCoordinate = int.Parse(roverPosition[0]);
                var roverYCoordinate = int.Parse(roverPosition[1]);
                var roverDireciton = char.Parse(roverPosition[2]);

                Console.Write($"Rover{count} Command: ");
                var roverCommand = Console.ReadLine();

                var roverDto = RoverDtoFactory.CreateRoverDto(count, roverXCoordinate, roverYCoordinate, roverDireciton, roverCommand, plateuDto);
                roverManager.AddRoverToList(roverDto);

                count++;
            }

            roverManager.MoveRovers();
            Console.ReadLine();
        }
    }
}
