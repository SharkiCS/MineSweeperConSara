using Xunit;
using FluentAssertions;

namespace MineSweeperConSara.Tests
{
    public class MatrixShould
    {
        [Fact]
        public void BeFalseForVisibilityAndIsMineWhenInstantiated()
        {
            Matrix matrixShould = new Matrix(3, 33);
            matrixShould.At(new Coordinates(1, 1)).Mines.Should().Be(false);
        }
    }
}