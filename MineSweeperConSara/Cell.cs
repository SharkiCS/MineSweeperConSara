namespace MineSweeperConSara
{
    public class Cell
    {
        public bool Visible { get; set; }
        public bool IsMine { get; set; }

        public void SetMine()
        {
            IsMine = true;
        }
        public void SetVisibility()
        {
            Visible = true;
        }
    }
}