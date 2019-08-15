using RubixCubes.Core.Enums;
using System;
using System.Collections.Generic;

namespace RubixCubes.Core.DTOs
{
    public class ScramblerDto
    {
        public Cube Cube { get; set; }
        public List<Tuple<TurnType, bool, int>> Turns { get; set; }
    }
}