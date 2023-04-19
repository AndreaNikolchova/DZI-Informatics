using _1._3._14;

namespace _1._3._21
{
    public class Hero
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Strength { get; set; }
        public int Health { get; set; }
        public Hero(int x, int y, int strength, int health)
        {
            this.X = x;
            this.Y = y;
            this.Strength = strength;
            this.Health = health;
        }
        public void Eat(Mushroom mushroom)
        {
            if (Distances.GetManhatynsko(this.X, mushroom.X, this.Y, mushroom.Y)<=this.Strength)
            {
                this.Health += mushroom.Healty;
            }

        }
    }
}
