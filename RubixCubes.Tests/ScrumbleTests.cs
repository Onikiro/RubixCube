using FluentAssertions;
using RubixCubes.Core;
using RubixCubes.Core.Enums;
using Xunit;

namespace RubixCubes.Tests
{
    public class ScrumbleTests
    {
        [Fact]
        public void SpecifiedScrumble_ShouldReturnCorrectScrumbledCube()
        {
            var cube = new Cube();

            cube.Rotate(Turn.Front, false, 1);
            cube.Rotate(Turn.Back, false, 1);
            cube.Rotate(Turn.Up, false, 1);
            cube.Rotate(Turn.Right, false, 1);
            cube.Rotate(Turn.Back, false, 1);
            cube.Rotate(Turn.Right, false, 1);
            cube.Rotate(Turn.Left, false, 1);
            cube.Rotate(Turn.Up, true, 1);
            cube.Rotate(Turn.Down, false, 1);
            cube.Rotate(Turn.Back, true, 2);
            cube.Rotate(Turn.Front, false, 1);
            cube.Rotate(Turn.Right, false, 1);
            cube.Rotate(Turn.Down, false, 1);
            cube.Rotate(Turn.Back, false, 1);
            cube.Rotate(Turn.Front, true, 1);
            cube.Rotate(Turn.Up, true, 1);
            cube.Rotate(Turn.Right, false, 1);
            cube.Rotate(Turn.Down, true, 2);
            cube.Rotate(Turn.Back, false, 1);
            cube.Rotate(Turn.Down, true, 1);

            cube.Blue[0, 0].Should().Be(Color.Orange);
            cube.Blue[0, 1].Should().Be(Color.Yellow);
            cube.Blue[0, 2].Should().Be(Color.Orange);
            cube.Blue[1, 0].Should().Be(Color.Orange);
            cube.Blue[1, 1].Should().Be(Color.Blue);
            cube.Blue[1, 2].Should().Be(Color.Red);
            cube.Blue[2, 0].Should().Be(Color.Blue);
            cube.Blue[2, 1].Should().Be(Color.Red);
            cube.Blue[2, 2].Should().Be(Color.Green);

            cube.Yellow[0, 0].Should().Be(Color.Green);
            cube.Yellow[0, 1].Should().Be(Color.Blue);
            cube.Yellow[0, 2].Should().Be(Color.Green);
            cube.Yellow[1, 0].Should().Be(Color.Green);
            cube.Yellow[1, 1].Should().Be(Color.Yellow);
            cube.Yellow[1, 2].Should().Be(Color.Green);
            cube.Yellow[2, 0].Should().Be(Color.Green);
            cube.Yellow[2, 1].Should().Be(Color.Blue);
            cube.Yellow[2, 2].Should().Be(Color.Orange);

            cube.Red[0, 0].Should().Be(Color.Yellow);
            cube.Red[0, 1].Should().Be(Color.Orange);
            cube.Red[0, 2].Should().Be(Color.Blue);
            cube.Red[1, 0].Should().Be(Color.Green);
            cube.Red[1, 1].Should().Be(Color.Red);
            cube.Red[1, 2].Should().Be(Color.White);
            cube.Red[2, 0].Should().Be(Color.White);
            cube.Red[2, 1].Should().Be(Color.Yellow);
            cube.Red[2, 2].Should().Be(Color.Red);
        } 
    }
}