namespace Garden
{
    class Tree
    {
        public string color { get; set; }
        public double waterAmount { get; set; }

        public Tree(int waterAmount)
        {
            this.waterAmount = waterAmount;
        }

        public bool DoesNeedWater()
        {
            if (waterAmount < 10)
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
