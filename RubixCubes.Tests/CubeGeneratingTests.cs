using FluentAssertions;
using RubixCubes.Core;
using Xunit;

namespace RubixCubes.Tests
{
    public class CubeGeneratingTests
    {
        [Fact]
        public void InitializatingCube_ShouldReturnSolvedCube()
        {
            var cube = new Cube();

            CubeGenerator.IsSideSolved(cube.Orange, Color.Orange).Should().Be(true);
            CubeGenerator.IsSideSolved(cube.Green, Color.Green).Should().Be(true);
            CubeGenerator.IsSideSolved(cube.Yellow, Color.Yellow).Should().Be(true);
            CubeGenerator.IsSideSolved(cube.White, Color.White).Should().Be(true);
            CubeGenerator.IsSideSolved(cube.Blue, Color.Blue).Should().Be(true);
            CubeGenerator.IsSideSolved(cube.Red, Color.Red).Should().Be(true);
        }

        [Fact]
        public void CubeGenerator_ShouldReturnUnsolvedCube()
        {
            var unsolvedCube = CubeGenerator.GenerateRandomUnsolvedCube();

            CubeGenerator.IsSideSolved(unsolvedCube.Orange, Color.Orange).Should().Be(false);
            CubeGenerator.IsSideSolved(unsolvedCube.Green, Color.Green).Should().Be(false);
            CubeGenerator.IsSideSolved(unsolvedCube.Yellow, Color.Yellow).Should().Be(false);
            CubeGenerator.IsSideSolved(unsolvedCube.White, Color.White).Should().Be(false);
            CubeGenerator.IsSideSolved(unsolvedCube.Blue, Color.Blue).Should().Be(false);
            CubeGenerator.IsSideSolved(unsolvedCube.Red, Color.Red).Should().Be(false);
        }

        [Fact]
        public void SolvedCube_ShouldReturnCorrectRotateLeftClockwise()
        {
            var cube = new Cube();

            cube.Rotate(Turn.Left, true, 2);

            cube.Red[0, 0].Should().Be(Color.Orange);
            cube.Red[1, 0].Should().Be(Color.Orange);
            cube.Red[2, 0].Should().Be(Color.Orange);

            cube.Yellow[0, 0].Should().Be(Color.White);
            cube.Yellow[1, 0].Should().Be(Color.White);
            cube.Yellow[2, 0].Should().Be(Color.White);

            cube.Orange[0, 2].Should().Be(Color.Red);
            cube.Orange[1, 2].Should().Be(Color.Red);
            cube.Orange[2, 2].Should().Be(Color.Red);

            cube.White[0, 0].Should().Be(Color.Yellow);
            cube.White[1, 0].Should().Be(Color.Yellow);
            cube.White[2, 0].Should().Be(Color.Yellow);
        }

        [Fact]
        public void SolvedCube_ShouldReturnCorrectRotateLeftCounterClockwise()
        {
            var cube = new Cube();

            cube.Rotate(Turn.Left, false, 1);

            cube.Red[0, 0].Should().Be(Color.White);
            cube.Red[1, 0].Should().Be(Color.White);
            cube.Red[2, 0].Should().Be(Color.White);

            cube.Yellow[0, 0].Should().Be(Color.Red);
            cube.Yellow[1, 0].Should().Be(Color.Red);
            cube.Yellow[2, 0].Should().Be(Color.Red);

            cube.Orange[0, 2].Should().Be(Color.Yellow);
            cube.Orange[1, 2].Should().Be(Color.Yellow);
            cube.Orange[2, 2].Should().Be(Color.Yellow);

            cube.White[0, 0].Should().Be(Color.Orange);
            cube.White[1, 0].Should().Be(Color.Orange);
            cube.White[2, 0].Should().Be(Color.Orange);
        }
    }
}