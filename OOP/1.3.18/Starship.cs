namespace _1._3._18
{
    public class Starship
    {
        public Starship(int lightSpeed, int laserPower, int shield,int x, int y, int health)
        {
            this.LightSpeed = lightSpeed;
            this.LaserPower = laserPower;
            this.Shield = shield;
            this.X = x;
            this.Y = y;
            this.Health = health;
        }
        public int LightSpeed { get; set; }
        public int LaserPower { get; set; }
        public int Shield { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Health { get; set; }

        public void Attack(Starship starship)
        {
            starship.Shield -= this.LaserPower;
            if( starship.Shield < 0 )
            {
                starship.Health-= starship.Shield*-1;
                starship.Shield = 0;
            }
            if(starship.Health < 0)
            {
                starship.Health = 0;
            }
        }
    }
}
