using RubixCubes.Core.Enums;
using System;
using System.Collections.Generic;

namespace RubixCubes.Core.DTOs
{
    public class ScrumblerDto
    {
        public Cube Cube { get; set; }
        public List<Tuple<Turn,bool, int>> Turns { get; set; }
    }
}
