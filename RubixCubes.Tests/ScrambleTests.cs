using FluentAssertions;
using RubixCubes.Core;
using RubixCubes.Core.Enums;
using System;
using Xunit;

namespace RubixCubes.Tests
{
    public class ScrambleTests
    {
        [Fact]
        public void SpecifiedScramble_ShouldReturnCorrectScrambledCube()
        {
            var cube = new Cube();

            cube.Move(TurnType.Front, false);
            cube.Move(TurnType.Back, false);
            cube.Move(TurnType.Up, false);
            cube.Move(TurnType.Right, false);
            cube.Move(TurnType.Back, false);
            cube.Move(TurnType.Right, false);
            cube.Move(TurnType.Left, false);
            cube.Move(TurnType.Up);
            cube.Move(TurnType.Down, false);
            cube.Move(TurnType.Back, true, 2);
            cube.Move(TurnType.Front, false);
            cube.Move(TurnType.Right, false);
            cube.Move(TurnType.Down, false);
            cube.Move(TurnType.Back, false);
            cube.Move(TurnType.Front);
            cube.Move(TurnType.Up);
            cube.Move(TurnType.Right, false);
            cube.Move(TurnType.Down, true, 2);
            cube.Move(TurnType.Back, false);
            cube.Move(TurnType.Down);

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
        public void Scrambler_ShouldReturnUnsolvedCube()
        {
            var cube = new Cube();
            var scrambler = new Scrambler();
            var result = scrambler.ScrambleCube();
            foreach (var (turn, clockwise, count) in result.Turns)
            {
                cube.Move(turn, clockwise, count);
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