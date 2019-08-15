using RubixCubes.Core.Enums;

namespace RubixCubes.Core
{
    public class CubeSolver
    {
        public void SolveCube()
        {
            var scrumbler = new Scrumbler();
            var dto = scrumbler.ScrumbleCube();
            var cube = dto.Cube;

            while (cube.Down[0, 1] != Color.White && cube.Down[1, 0] != Color.White && cube.Down[1, 2] != Color.White && cube.Down[2, 1] != Color.White)
            {

            }
        }
    }
}