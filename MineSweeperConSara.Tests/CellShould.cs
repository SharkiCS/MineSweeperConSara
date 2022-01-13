using Xunit;
using FluentAssertions;

namespace MineSweeperConSara.Tests
{

    public class CellShould
    {
        [Fact]
        public void BeFalseForVisibilityAndIsMineWhenInstantiated()
        {
            Cell cell = new Cell(false, false);
            cell.Visibility.Should().Be(false);
            cell.Mines.Should().Be(false);
            
        }
        [Fact]
        
        public void BeTrueForIsMine()
        {
            Cell cell = new Cell(false, true);
            cell.Mines.Should().Be(true);
        }
        
        [Fact]
        public void BeTrueForVisibility()
        {
            Cell cell = new Cell(true, false);
            cell.Visibility.Should().Be(true);
        }
    }
}