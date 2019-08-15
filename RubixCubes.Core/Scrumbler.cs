using RubixCubes.Core.DTOs;
using RubixCubes.Core.Enums;
using System;
using System.Collections.Generic;

namespace RubixCubes.Core
{   
    public static class Scrumbler
    {
        public static ScrumblerDto ScrumbleCube()
        {
            var cube = new Cube();
            List<Tuple<Turn,int>> Turns = new List<Tuple<Turn,int>>();

            

            return new ScrumblerDto
            {
                Cube = cube,
                Turns = Turns,
            };
        }
    }
}