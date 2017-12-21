namespace Garden
{
    class Flower
    {
        public string color { get; set; }
        public double waterAmount{ get; set; }

        public Flower(int waterAmount)
        {
            this.waterAmount = waterAmount;
        }

        public bool DoesNeedWater()
        {
            if (waterAmount < 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
