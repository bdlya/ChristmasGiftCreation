using Box;

namespace Utils.Builders.GiftBox
{
    public interface IGiftBuilder
    {
        Gift Gift { get; }

        void AddCandyBar();

        void AddWaffle();

        void AddLollipop();

        void AddChocolate();

        Gift Build();
    }
}