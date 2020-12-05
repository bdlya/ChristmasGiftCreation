using GiftBox.Box;

namespace GiftBox.Builders
{
    public class Creator
    {
        public Gift CreateGift(GiftBuilder giftBuilder)
        {
            giftBuilder.AddCandyBar();
            giftBuilder.AddWaffle();
            giftBuilder.AddLollipop();
            giftBuilder.AddChocolate();
            return giftBuilder.Gift;
        }
    }
}