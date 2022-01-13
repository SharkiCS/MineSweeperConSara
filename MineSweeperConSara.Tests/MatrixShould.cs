using Xunit;
using FluentAssertions;

namespace MineSweeperConSara.Tests
{
    public class MatrixShould
    {
        [Fact]
        public void CheckIfCellInPosition1_1IsNotAMine()
        {
            Matrix matrix = new Matrix(3, 33);
            matrix.At(new Coordinates(1, 1)).Mines.Should().Be(false);
        }
        
        [Fact]
        public void CheckIfCellInPosition1_1IsAMine()
        {
            Matrix matrix = new Matrix(3, 33);

            matrix.SetMine(new Coordinates(1,1));
            
            matrix.At(new Coordinates(1, 1)).Mines.Should().Be(true);
        }
    }
}