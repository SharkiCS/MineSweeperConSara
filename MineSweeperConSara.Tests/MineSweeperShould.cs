using Xunit;
using FluentAssertions;

namespace MineSweeperConSara.Tests
{
    public class MineSweeperShould
    {
        [Fact]
        public void PrintTheBoard()
        {
            Matrix matrix = new Matrix(3,3);
            MineSweeper mineSweeper =  new  MineSweeper(matrix);
            mineSweeper.Print().Should().Be("...\n...\n...");
        }
    }
}