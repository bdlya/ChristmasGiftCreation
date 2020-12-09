using GiftContent.Products.Confections;
using GiftContent.Products.Confections.Characteristics;

namespace GiftContent.Builders.ConfectionBuilders
{
    public class ChocolateBuilder : ConfectionBuilder
    {
        public ChocolateBuilder() => Confection = new Chocolate();

        public ChocolateBuilder SetChocolateType(ChocolateType chocolateType)
        {
            ((Chocolate) Confection).ChocolateType = chocolateType;
            return this;
        }
    }
}