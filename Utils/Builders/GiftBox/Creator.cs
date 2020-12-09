using Box;

namespace Utils.Builders.GiftBox
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