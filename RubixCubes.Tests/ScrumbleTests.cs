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

            cube.Move(Turn.Front, false, 1);
            cube.Move(Turn.Back, false, 1);
            cube.Move(Turn.Up, false, 1);
            cube.Move(Turn.Right, false, 1);
            cube.Move(Turn.Back, false, 1);
            cube.Move(Turn.Right, false, 1);
            cube.Move(Turn.Left, false, 1);
            cube.Move(Turn.Up);
            cube.Move(Turn.Down, false, 1);
            cube.Move(Turn.Back, true, 2);
            cube.Move(Turn.Front, false, 1);
            cube.Move(Turn.Right, false, 1);
            cube.Move(Turn.Down, false, 1);
            cube.Move(Turn.Back, false, 1);
            cube.Move(Turn.Front);
            cube.Move(Turn.Up);
            cube.Move(Turn.Right, false, 1);
            cube.Move(Turn.Down, true, 2);
            cube.Move(Turn.Back, false, 1);
            cube.Move(Turn.Down);

            cube.Left[0, 0].Should().Be(Color.Orange);
            cube.Left[0, 1].Should().Be(Color.Yellow);
            cube.Left[0, 2].Should().Be(Color.Orange);
            cube.Left[1, 0].Should().Be(Color.Orange);
            cube.Left[1, 1].Should().Be(Color.Blue);
            cube.Left[1, 2].Should().Be(Color.Red);
            cube.Left[2, 0].Should().Be(Color.Blue);
            cube.Left[2, 1].Should().Be(Color.Red);
            cube.Left[2, 2].Should().Be(Color.Green);

            cube.Up[0, 0].Should().Be(Color.Green);
            cube.Up[0, 1].Should().Be(Color.Blue);
            cube.Up[0, 2].Should().Be(Color.Green);
            cube.Up[1, 0].Should().Be(Color.Green);
            cube.Up[1, 1].Should().Be(Color.Yellow);
            cube.Up[1, 2].Should().Be(Color.Green);
            cube.Up[2, 0].Should().Be(Color.Green);
            cube.Up[2, 1].Should().Be(Color.Blue);
            cube.Up[2, 2].Should().Be(Color.Orange);

            cube.Front[0, 0].Should().Be(Color.Yellow);
            cube.Front[0, 1].Should().Be(Color.Orange);
            cube.Front[0, 2].Should().Be(Color.Blue);
            cube.Front[1, 0].Should().Be(Color.Green);
            cube.Front[1, 1].Should().Be(Color.Red);
            cube.Front[1, 2].Should().Be(Color.White);
            cube.Front[2, 0].Should().Be(Color.White);
            cube.Front[2, 1].Should().Be(Color.Yellow);
            cube.Front[2, 2].Should().Be(Color.Red);
        }
        [Fact]
        public void Scrumbler_ShouldReturnUnsolvedCube()
        {
            var cube = new Cube();
            var scrumbler = new Scrumbler();
            var result = scrumbler.ScrumbleCube();
            foreach (var el in result.Turns)
            {
                cube.Move(el.Item1, el.Item2, el.Item3);
            }

            cube.Left.Should().BeEquivalentTo(result.Cube.Left);
            cube.Front.Should().BeEquivalentTo(result.Cube.Front);
            cube.Up.Should().BeEquivalentTo(result.Cube.Up);
            cube.Right.Should().BeEquivalentTo(result.Cube.Right);
            cube.Down.Should().BeEquivalentTo(result.Cube.Down);
            cube.Back.Should().BeEquivalentTo(result.Cube.Back);
        }
    }
}