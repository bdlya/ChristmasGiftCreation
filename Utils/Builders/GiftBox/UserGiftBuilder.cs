namespace Utils.Builders.GiftBox
{
    public class UserGiftBuilder : GiftBuilder
    {
        private int _candyBarAmount;
        private int _waffleAmount;
        private int _lollipopAmount;
        private int _chocolateAmount;

        public UserGiftBuilder(int candyBarAmount, int waffleAmount, int lollipopAmount, int chocolateAmount)
        {
            _candyBarAmount = candyBarAmount;
            _waffleAmount = waffleAmount;
            _lollipopAmount = lollipopAmount;
            _chocolateAmount = chocolateAmount;
        }
        public override void AddCandyBar()
        {
            throw new System.NotImplementedException();
        }

        public override void AddWaffle()
        {
            throw new System.NotImplementedException();
        }

        public override void AddLollipop()
        {
            throw new System.NotImplementedException();
        }

        public override void AddChocolate()
        {
            throw new System.NotImplementedException();
        }
    }
}