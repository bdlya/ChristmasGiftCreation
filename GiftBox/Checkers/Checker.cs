using GiftBox.Box;
using GiftContent.Products;

namespace GiftBox.Checkers
{
    public class Checker
    {
        public double FoundWeight(Gift gift) => default;

        public void SortConfections(Gift gift) {}

        public IProduct FindConfection(Gift gift, double sugarContent) => default;

    }
}