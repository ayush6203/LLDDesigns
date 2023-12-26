namespace SnakeAndLadderImplementation.Models
{
    public class Player
    {
        private string Name { get; set; }
        public int Position { get; set; }

        public Player(string name)
        {
            this.Name = name;
            this.Position = 0;
        }

        public string PlayerName
        {
            get { return Name; }
        }

        public void MovePlayer(int postion)
        {
            this.Position = postion;
        }
    }
}
