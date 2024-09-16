namespace Model.Items
{
    public abstract class ItemStats
    {
        public int SunPoints { get; protected set; }
        public int RainPoints { get; protected set; }
        public int SnowPoints { get; protected set; }

        protected const int CorrectChoiceBoost = 100;
        protected const int InCorrectChoiceBoost1 = 30;
        protected const int InCorrectChoiceBoost2 = 10;

        public override string ToString()
        {
            return $"Sun Points: {SunPoints}. Rain Points: {RainPoints}. SnowPoints: {SnowPoints}";
        }
    }
}