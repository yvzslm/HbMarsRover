using Hb.MarsRover.Application.Dtos;
using Hb.MarsRover.Domain.Factories;
using Hb.MarsRover.Domain.Models;
using System.Collections.Generic;

namespace Hb.MarsRover.Application
{
    public class RoverManager
    {
        private List<Rover> rovers;

        public RoverManager()
        {
            rovers = new List<Rover>();
        }

        public void AddRoverToList(RoverDto roverDto)
        {
            var plateu = PlateuFactory.CreatePlateu(roverDto.Plateu.CoordinateX, roverDto.Plateu.CoordinateY);
            var rover = RoverFactory.CreateRover(roverDto.Id, roverDto.CoordinateX, roverDto.CoordinateY, roverDto.Direction, roverDto.Command, plateu);
            
            rovers.Add(rover);
        }

        public void MoveRovers()
        {
            foreach (var rover in rovers)
            {
                rover.Move();
            }
        }
    }
}
