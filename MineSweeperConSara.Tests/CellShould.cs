using System.Threading;
using Xunit;
using FluentAssertions;

namespace MineSweeperConSara.Tests
{

    public class CellShould
    {
        [Fact]
        public void BeFalseForVisibilityAndIsMineWhenInstantiated()
        {
            Cell cell = new Cell();
            cell.Visible.Should().Be(false);
            cell.IsMine.Should().Be(false);
        }
        [Fact]
        public void BeTrueForIsMine()
        {
            Cell cell = new Cell();
            
            cell.SetMine();
            
            cell.IsMine.Should().Be(true);
        }
        [Fact]
        public void BeTrueForVisibility()
        {
            Cell cell = new Cell();
            
            cell.SetVisibility();
            
            cell.Visible.Should().Be(true);
        }
    }
}