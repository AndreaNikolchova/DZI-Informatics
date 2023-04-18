namespace _1._3._12
{
    public class SmartPhone
    {
        public string Producer { get; set; }
        public string Model { get; set; }
        public string G { get; set; }
        public decimal Price { get; set; }
        public SmartPhone(string producer, string model, string g, decimal price)
        {
            this.Producer = producer;
            this.Model = model;
            this.G = g;
            this.Price = price;
        }
        public string printPhone()
        {
            return $"Производител: {this.Producer}" + Environment.NewLine +
                $"Модел: {this.Model}" + Environment.NewLine +
                $"Честотна лента: {this.G}" + Environment.NewLine +
                $"Цена: {this.Price}";

        }
    }
}
