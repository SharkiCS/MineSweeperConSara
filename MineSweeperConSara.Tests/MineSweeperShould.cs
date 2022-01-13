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
        
        [Fact]
        public void PrintTheBoardWithAMine()
        {
            Matrix matrix = new Matrix(3,3);
            matrix.SetMine(new Coordinates(0,0));
            MineSweeper mineSweeper =  new  MineSweeper(matrix);

            mineSweeper.Open(new Coordinates(0,0));
            mineSweeper.Print().Should().Be("*..\n...\n...");
        }
    }
}