using FluentAssertions;
using RubixCubes.Core;
using RubixCubes.Core.Enums;
using Xunit;

namespace RubixCubes.Tests
{
    public class CubeSidesTests
    {
        [Fact]
        public void InitializationCube_ShouldReturnSolvedCube()
        {
            var cube = new Cube();

            cube.Back.IsSolved.Should().Be(true);
            cube.Right.IsSolved.Should().Be(true);
            cube.Up.IsSolved.Should().Be(true);
            cube.Down.IsSolved.Should().Be(true);
            cube.Left.IsSolved.Should().Be(true);
            cube.Front.IsSolved.Should().Be(true);
        }

        [Fact]
        public void SolvedCube_ShouldReturnCorrectRotateLeftClockwise()
        {
            var cube = new Cube();

            cube.Move(TurnType.Left, true, 2);

            cube.Front[0, 0].Should().Be(Color.Orange);
            cube.Front[1, 0].Should().Be(Color.Orange);
            cube.Front[2, 0].Should().Be(Color.Orange);

            cube.Up[0, 0].Should().Be(Color.White);
            cube.Up[1, 0].Should().Be(Color.White);
            cube.Up[2, 0].Should().Be(Color.White);

            cube.Back[0, 2].Should().Be(Color.Red);
            cube.Back[1, 2].Should().Be(Color.Red);
            cube.Back[2, 2].Should().Be(Color.Red);

            cube.Down[0, 0].Should().Be(Color.Yellow);
            cube.Down[1, 0].Should().Be(Color.Yellow);
            cube.Down[2, 0].Should().Be(Color.Yellow);
        }

        [Fact]
        public void SolvedCube_ShouldReturnCorrectRotateLeftCounterClockwise()
        {
            var cube = new Cube();

            cube.Move(TurnType.Left, false);

            cube.Front[0, 0].Should().Be(Color.White);
            cube.Front[1, 0].Should().Be(Color.White);
            cube.Front[2, 0].Should().Be(Color.White);

            cube.Up[0, 0].Should().Be(Color.Red);
            cube.Up[1, 0].Should().Be(Color.Red);
            cube.Up[2, 0].Should().Be(Color.Red);

            cube.Back[0, 2].Should().Be(Color.Yellow);
            cube.Back[1, 2].Should().Be(Color.Yellow);
            cube.Back[2, 2].Should().Be(Color.Yellow);

            cube.Down[0, 0].Should().Be(Color.Orange);
            cube.Down[1, 0].Should().Be(Color.Orange);
            cube.Down[2, 0].Should().Be(Color.Orange);
        }

        [Fact]
        public void SolvedCube_ShouldReturnCorrectRotateRightClockwise()
        {
            var cube = new Cube();

            cube.Move(TurnType.Right, true, 2);

            cube.Front[0, 2].Should().Be(Color.Orange);
            cube.Front[1, 2].Should().Be(Color.Orange);
            cube.Front[2, 2].Should().Be(Color.Orange);

            cube.Up[0, 2].Should().Be(Color.White);
            cube.Up[1, 2].Should().Be(Color.White);
            cube.Up[2, 2].Should().Be(Color.White);

            cube.Back[0, 0].Should().Be(Color.Red);
            cube.Back[1, 0].Should().Be(Color.Red);
            cube.Back[2, 0].Should().Be(Color.Red);

            cube.Down[0, 2].Should().Be(Color.Yellow);
            cube.Down[1, 2].Should().Be(Color.Yellow);
            cube.Down[2, 2].Should().Be(Color.Yellow);
        }

        [Fact]
        public void SolvedCube_ShouldReturnCorrectRotateRightCounterClockwise()
        {
            var cube = new Cube();

            cube.Move(TurnType.Right, false);

            cube.Front[0, 2].Should().Be(Color.Yellow);
            cube.Front[1, 2].Should().Be(Color.Yellow);
            cube.Front[2, 2].Should().Be(Color.Yellow);

            cube.Down[0, 2].Should().Be(Color.Red);
            cube.Down[1, 2].Should().Be(Color.Red);
            cube.Down[2, 2].Should().Be(Color.Red);

            cube.Back[0, 0].Should().Be(Color.White);
            cube.Back[1, 0].Should().Be(Color.White);
            cube.Back[2, 0].Should().Be(Color.White);

            cube.Up[0, 2].Should().Be(Color.Orange);
            cube.Up[1, 2].Should().Be(Color.Orange);
            cube.Up[2, 2].Should().Be(Color.Orange);
        }

        [Fact]
        public void SolvedCube_ShouldReturnCorrectRotateUpClockwise()
        {
            var cube = new Cube();

            cube.Move(TurnType.Up, true, 2);

            cube.Front[0, 0].Should().Be(Color.Orange);
            cube.Front[0, 1].Should().Be(Color.Orange);
            cube.Front[0, 2].Should().Be(Color.Orange);

            cube.Right[0, 0].Should().Be(Color.Blue);
            cube.Right[0, 1].Should().Be(Color.Blue);
            cube.Right[0, 2].Should().Be(Color.Blue);

            cube.Back[0, 0].Should().Be(Color.Red);
            cube.Back[0, 1].Should().Be(Color.Red);
            cube.Back[0, 2].Should().Be(Color.Red);

            cube.Left[0, 0].Should().Be(Color.Green);
            cube.Left[0, 1].Should().Be(Color.Green);
            cube.Left[0, 2].Should().Be(Color.Green);
        }

        [Fact]
        public void SolvedCube_ShouldReturnCorrectRotateUpCounterClockwise()
        {
            var cube = new Cube();

            cube.Move(TurnType.Up, false);

            cube.Front[0, 0].Should().Be(Color.Blue);
            cube.Front[0, 1].Should().Be(Color.Blue);
            cube.Front[0, 2].Should().Be(Color.Blue);

            cube.Right[0, 0].Should().Be(Color.Red);
            cube.Right[0, 1].Should().Be(Color.Red);
            cube.Right[0, 2].Should().Be(Color.Red);

            cube.Back[0, 0].Should().Be(Color.Green);
            cube.Back[0, 1].Should().Be(Color.Green);
            cube.Back[0, 2].Should().Be(Color.Green);

            cube.Left[0, 0].Should().Be(Color.Orange);
            cube.Left[0, 1].Should().Be(Color.Orange);
            cube.Left[0, 2].Should().Be(Color.Orange);
        }

        [Fact]
        public void SolvedCube_ShouldReturnCorrectRotateDownClockwise()
        {
            var cube = new Cube();

            cube.Move(TurnType.Down, true, 2);

            cube.Front[2, 0].Should().Be(Color.Orange);
            cube.Front[2, 1].Should().Be(Color.Orange);
            cube.Front[2, 2].Should().Be(Color.Orange);

            cube.Right[2, 0].Should().Be(Color.Blue);
            cube.Right[2, 1].Should().Be(Color.Blue);
            cube.Right[2, 2].Should().Be(Color.Blue);

            cube.Back[2, 0].Should().Be(Color.Red);
            cube.Back[2, 1].Should().Be(Color.Red);
            cube.Back[2, 2].Should().Be(Color.Red);

            cube.Left[2, 0].Should().Be(Color.Green);
            cube.Left[2, 1].Should().Be(Color.Green);
            cube.Left[2, 2].Should().Be(Color.Green);
        }

        [Fact]
        public void SolvedCube_ShouldReturnCorrectRotateDownCounterClockwise()
        {
            var cube = new Cube();

            cube.Move(TurnType.Down, false);

            cube.Front[2, 0].Should().Be(Color.Green);
            cube.Front[2, 1].Should().Be(Color.Green);
            cube.Front[2, 2].Should().Be(Color.Green);

            cube.Left[2, 0].Should().Be(Color.Red);
            cube.Left[2, 1].Should().Be(Color.Red);
            cube.Left[2, 2].Should().Be(Color.Red);

            cube.Back[2, 0].Should().Be(Color.Blue);
            cube.Back[2, 1].Should().Be(Color.Blue);
            cube.Back[2, 2].Should().Be(Color.Blue);

            cube.Right[2, 0].Should().Be(Color.Orange);
            cube.Right[2, 1].Should().Be(Color.Orange);
            cube.Right[2, 2].Should().Be(Color.Orange);
        }

        [Fact]
        public void SolvedCube_ShouldReturnCorrectRotateFrontClockwise()
        {
            var cube = new Cube();

            cube.Move(TurnType.Front, true, 2);

            cube.Up[2, 0].Should().Be(Color.White);
            cube.Up[2, 1].Should().Be(Color.White);
            cube.Up[2, 2].Should().Be(Color.White);

            cube.Right[0, 0].Should().Be(Color.Blue);
            cube.Right[1, 0].Should().Be(Color.Blue);
            cube.Right[2, 0].Should().Be(Color.Blue);

            cube.Down[0, 0].Should().Be(Color.Yellow);
            cube.Down[0, 1].Should().Be(Color.Yellow);
            cube.Down[0, 2].Should().Be(Color.Yellow);

            cube.Left[0, 2].Should().Be(Color.Green);
            cube.Left[1, 2].Should().Be(Color.Green);
            cube.Left[2, 2].Should().Be(Color.Green);
        }

        [Fact]
        public void SolvedCube_ShouldReturnCorrectRotateFrontCounterClockwise()
        {
            var cube = new Cube();

            cube.Move(TurnType.Front, false);

            cube.Up[2, 0].Should().Be(Color.Green);
            cube.Up[2, 1].Should().Be(Color.Green);
            cube.Up[2, 2].Should().Be(Color.Green);

            cube.Right[0, 0].Should().Be(Color.White);
            cube.Right[1, 0].Should().Be(Color.White);
            cube.Right[2, 0].Should().Be(Color.White);

            cube.Down[0, 0].Should().Be(Color.Blue);
            cube.Down[0, 1].Should().Be(Color.Blue);
            cube.Down[0, 2].Should().Be(Color.Blue);

            cube.Left[0, 2].Should().Be(Color.Yellow);
            cube.Left[1, 2].Should().Be(Color.Yellow);
            cube.Left[2, 2].Should().Be(Color.Yellow);
        }

        [Fact]
        public void SolvedCube_ShouldReturnCorrectRotateBackClockwise()
        {
            var cube = new Cube();

            cube.Move(TurnType.Back, true, 2);

            cube.Up[0, 2].Should().Be(Color.White);
            cube.Up[0, 1].Should().Be(Color.White);
            cube.Up[0, 0].Should().Be(Color.White);

            cube.Right[2, 2].Should().Be(Color.Blue);
            cube.Right[1, 2].Should().Be(Color.Blue);
            cube.Right[0, 2].Should().Be(Color.Blue);

            cube.Down[2, 2].Should().Be(Color.Yellow);
            cube.Down[2, 1].Should().Be(Color.Yellow);
            cube.Down[2, 0].Should().Be(Color.Yellow);

            cube.Left[2, 0].Should().Be(Color.Green);
            cube.Left[1, 0].Should().Be(Color.Green);
            cube.Left[0, 0].Should().Be(Color.Green);
        }

        [Fact]
        public void SolvedCube_ShouldReturnCorrectRotateBackCounterClockwise()
        {
            var cube = new Cube();

            cube.Move(TurnType.Back, false);

            cube.Up[0, 2].Should().Be(Color.Blue);
            cube.Up[0, 1].Should().Be(Color.Blue);
            cube.Up[0, 0].Should().Be(Color.Blue);

            cube.Left[0, 0].Should().Be(Color.White);
            cube.Left[1, 0].Should().Be(Color.White);
            cube.Left[2, 0].Should().Be(Color.White);

            cube.Down[2, 2].Should().Be(Color.Green);
            cube.Down[2, 1].Should().Be(Color.Green);
            cube.Down[2, 0].Should().Be(Color.Green);

            cube.Right[0, 2].Should().Be(Color.Yellow);
            cube.Right[1, 2].Should().Be(Color.Yellow);
            cube.Right[2, 2].Should().Be(Color.Yellow);
        }
    }
}