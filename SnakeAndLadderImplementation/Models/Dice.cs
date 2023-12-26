namespace SnakeAndLadderImplementation.Models
{
    public class Dice
    {
        private readonly int MinValue;
        private readonly int MaxValue;

        public Dice()
        {
            MinValue = 1;
            MaxValue = 7;
        }

        public int Roll()
        {
            return new Random().Next(MinValue, MaxValue);
        }
    }
}
