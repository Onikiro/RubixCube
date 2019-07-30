using FluentAssertions;
using RubixCubes.Core;
using RubixCubes.Core.Enums;
using Xunit;

namespace RubixCubes.Tests
{
    public class CubeSidesTests
    {
        [Fact]
        public void InitializatingCube_ShouldReturnSolvedCube()
        {
            var cube = new Cube();

            cube.Orange.IsSolved.Should().Be(true);
            cube.Green.IsSolved.Should().Be(true);
            cube.Yellow.IsSolved.Should().Be(true);
            cube.White.IsSolved.Should().Be(true);
            cube.Blue.IsSolved.Should().Be(true);
            cube.Red.IsSolved.Should().Be(true);
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

        [Fact]
        public void SolvedCube_ShouldReturnCorrectRotateRightClockwise()
        {
            var cube = new Cube();

            cube.Rotate(Turn.Right, true, 2);

            cube.Red[0, 2].Should().Be(Color.Orange);
            cube.Red[1, 2].Should().Be(Color.Orange);
            cube.Red[2, 2].Should().Be(Color.Orange);

            cube.Yellow[0, 2].Should().Be(Color.White);
            cube.Yellow[1, 2].Should().Be(Color.White);
            cube.Yellow[2, 2].Should().Be(Color.White);

            cube.Orange[0, 0].Should().Be(Color.Red);
            cube.Orange[1, 0].Should().Be(Color.Red);
            cube.Orange[2, 0].Should().Be(Color.Red);

            cube.White[0, 2].Should().Be(Color.Yellow);
            cube.White[1, 2].Should().Be(Color.Yellow);
            cube.White[2, 2].Should().Be(Color.Yellow);
        }

        [Fact]
        public void SolvedCube_ShouldReturnCorrectRotateRightCounterClockwise()
        {
            var cube = new Cube();

            cube.Rotate(Turn.Right, false, 1);

            cube.Red[0, 2].Should().Be(Color.Yellow);
            cube.Red[1, 2].Should().Be(Color.Yellow);
            cube.Red[2, 2].Should().Be(Color.Yellow);

            cube.White[0, 2].Should().Be(Color.Red);
            cube.White[1, 2].Should().Be(Color.Red);
            cube.White[2, 2].Should().Be(Color.Red);

            cube.Orange[0, 0].Should().Be(Color.White);
            cube.Orange[1, 0].Should().Be(Color.White);
            cube.Orange[2, 0].Should().Be(Color.White);

            cube.Yellow[0, 2].Should().Be(Color.Orange);
            cube.Yellow[1, 2].Should().Be(Color.Orange);
            cube.Yellow[2, 2].Should().Be(Color.Orange);
        }

        [Fact]
        public void SolvedCube_ShouldReturnCorrectRotateUpClockwise()
        {
            var cube = new Cube();

            cube.Rotate(Turn.Up, true, 2);

            cube.Red[0, 0].Should().Be(Color.Orange);
            cube.Red[0, 1].Should().Be(Color.Orange);
            cube.Red[0, 2].Should().Be(Color.Orange);

            cube.Green[0, 0].Should().Be(Color.Blue);
            cube.Green[0, 1].Should().Be(Color.Blue);
            cube.Green[0, 2].Should().Be(Color.Blue);

            cube.Orange[0, 0].Should().Be(Color.Red);
            cube.Orange[0, 1].Should().Be(Color.Red);
            cube.Orange[0, 2].Should().Be(Color.Red);

            cube.Blue[0, 0].Should().Be(Color.Green);
            cube.Blue[0, 1].Should().Be(Color.Green);
            cube.Blue[0, 2].Should().Be(Color.Green);
        }

        [Fact]
        public void SolvedCube_ShouldReturnCorrectRotateUpCounterClockwise()
        {
            var cube = new Cube();

            cube.Rotate(Turn.Up, false, 1);

            cube.Red[0, 0].Should().Be(Color.Blue);
            cube.Red[0, 1].Should().Be(Color.Blue);
            cube.Red[0, 2].Should().Be(Color.Blue);

            cube.Green[0, 0].Should().Be(Color.Red);
            cube.Green[0, 1].Should().Be(Color.Red);
            cube.Green[0, 2].Should().Be(Color.Red);

            cube.Orange[0, 0].Should().Be(Color.Green);
            cube.Orange[0, 1].Should().Be(Color.Green);
            cube.Orange[0, 2].Should().Be(Color.Green);

            cube.Blue[0, 0].Should().Be(Color.Orange);
            cube.Blue[0, 1].Should().Be(Color.Orange);
            cube.Blue[0, 2].Should().Be(Color.Orange);
        }

        [Fact]
        public void SolvedCube_ShouldReturnCorrectRotateDownClockwise()
        {
            var cube = new Cube();

            cube.Rotate(Turn.Down, true, 2);

            cube.Red[2, 0].Should().Be(Color.Orange);
            cube.Red[2, 1].Should().Be(Color.Orange);
            cube.Red[2, 2].Should().Be(Color.Orange);

            cube.Green[2, 0].Should().Be(Color.Blue);
            cube.Green[2, 1].Should().Be(Color.Blue);
            cube.Green[2, 2].Should().Be(Color.Blue);

            cube.Orange[2, 0].Should().Be(Color.Red);
            cube.Orange[2, 1].Should().Be(Color.Red);
            cube.Orange[2, 2].Should().Be(Color.Red);

            cube.Blue[2, 0].Should().Be(Color.Green);
            cube.Blue[2, 1].Should().Be(Color.Green);
            cube.Blue[2, 2].Should().Be(Color.Green);
        }

        [Fact]
        public void SolvedCube_ShouldReturnCorrectRotateDownCounterClockwise()
        {
            var cube = new Cube();

            cube.Rotate(Turn.Down, false, 1);

            cube.Red[2, 0].Should().Be(Color.Green);
            cube.Red[2, 1].Should().Be(Color.Green);
            cube.Red[2, 2].Should().Be(Color.Green);

            cube.Blue[2, 0].Should().Be(Color.Red);
            cube.Blue[2, 1].Should().Be(Color.Red);
            cube.Blue[2, 2].Should().Be(Color.Red);

            cube.Orange[2, 0].Should().Be(Color.Blue);
            cube.Orange[2, 1].Should().Be(Color.Blue);
            cube.Orange[2, 2].Should().Be(Color.Blue);

            cube.Green[2, 0].Should().Be(Color.Orange);
            cube.Green[2, 1].Should().Be(Color.Orange);
            cube.Green[2, 2].Should().Be(Color.Orange);
        }

        [Fact]
        public void SolvedCube_ShouldReturnCorrectRotateFrontClockwise()
        {
            var cube = new Cube();

            cube.Rotate(Turn.Front, true, 2);

            cube.Yellow[2, 0].Should().Be(Color.White);
            cube.Yellow[2, 1].Should().Be(Color.White);
            cube.Yellow[2, 2].Should().Be(Color.White);

            cube.Green[0, 0].Should().Be(Color.Blue);
            cube.Green[1, 0].Should().Be(Color.Blue);
            cube.Green[2, 0].Should().Be(Color.Blue);

            cube.White[0, 0].Should().Be(Color.Yellow);
            cube.White[0, 1].Should().Be(Color.Yellow);
            cube.White[0, 2].Should().Be(Color.Yellow);

            cube.Blue[0, 2].Should().Be(Color.Green);
            cube.Blue[1, 2].Should().Be(Color.Green);
            cube.Blue[2, 2].Should().Be(Color.Green);
        }

        [Fact]
        public void SolvedCube_ShouldReturnCorrectRotateFrontCounterClockwise()
        {
            var cube = new Cube();

            cube.Rotate(Turn.Front, false, 1);

            cube.Yellow[2, 0].Should().Be(Color.Green);
            cube.Yellow[2, 1].Should().Be(Color.Green);
            cube.Yellow[2, 2].Should().Be(Color.Green);

            cube.Green[0, 0].Should().Be(Color.White);
            cube.Green[1, 0].Should().Be(Color.White);
            cube.Green[2, 0].Should().Be(Color.White);

            cube.White[0, 0].Should().Be(Color.Blue);
            cube.White[0, 1].Should().Be(Color.Blue);
            cube.White[0, 2].Should().Be(Color.Blue);

            cube.Blue[0, 2].Should().Be(Color.Yellow);
            cube.Blue[1, 2].Should().Be(Color.Yellow);
            cube.Blue[2, 2].Should().Be(Color.Yellow);
        }

        [Fact]
        public void SolvedCube_ShouldReturnCorrectRotateBackClockwise()
        {
            var cube = new Cube();

            cube.Rotate(Turn.Back, true, 2);

            cube.Yellow[0, 2].Should().Be(Color.White);
            cube.Yellow[0, 1].Should().Be(Color.White);
            cube.Yellow[0, 0].Should().Be(Color.White);

            cube.Green[2, 2].Should().Be(Color.Blue);
            cube.Green[1, 2].Should().Be(Color.Blue);
            cube.Green[0, 2].Should().Be(Color.Blue);

            cube.White[2, 2].Should().Be(Color.Yellow);
            cube.White[2, 1].Should().Be(Color.Yellow);
            cube.White[2, 0].Should().Be(Color.Yellow);

            cube.Blue[2, 0].Should().Be(Color.Green);
            cube.Blue[1, 0].Should().Be(Color.Green);
            cube.Blue[0, 0].Should().Be(Color.Green);
        }

        [Fact]
        public void SolvedCube_ShouldReturnCorrectRotateBackCounterClockwise()
        {
            var cube = new Cube();

            cube.Rotate(Turn.Back, false, 1);

            cube.Yellow[0, 2].Should().Be(Color.Blue);
            cube.Yellow[0, 1].Should().Be(Color.Blue);
            cube.Yellow[0, 0].Should().Be(Color.Blue);

            cube.Blue[0, 0].Should().Be(Color.White);
            cube.Blue[1, 0].Should().Be(Color.White);
            cube.Blue[2, 0].Should().Be(Color.White);

            cube.White[2, 2].Should().Be(Color.Green);
            cube.White[2, 1].Should().Be(Color.Green);
            cube.White[2, 0].Should().Be(Color.Green);

            cube.Green[0, 2].Should().Be(Color.Yellow);
            cube.Green[1, 2].Should().Be(Color.Yellow);
            cube.Green[2, 2].Should().Be(Color.Yellow);
        }
    }
}