namespace _1._3._24
{
    public abstract class SkyObject
    {
        protected SkyObject(int mass, int diameter)
        {
            this.Mass = mass;
            this.Diameter = diameter;
        }

        public int Mass { get; set; }
        public int Diameter { get; set; }
    
    }
}
