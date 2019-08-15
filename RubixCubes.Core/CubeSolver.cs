using System;
using RubixCubes.Core.Enums;

namespace RubixCubes.Core
{
    public class CubeSolver
    {
        public void SolveCube()
        {
            var scrambler = new Scrambler();
            var dto = scrambler.ScrambleCube();
            var cube = dto.Cube;

            cube.Rotate(RotatingCoordinate.Y, false);

            var bwEdge = new ValueTuple<int, int>(-1, -1);

            while (bwEdge.Item1 == -1 && bwEdge.Item2 == -1)
            {

            }
        }
    }
}