using System.Resources;
using GiftContent.Products.Confections;
using GiftContent.Products.Confections.Characteristics;

namespace GiftContent.Builders.ConfectionBuilders
{
    public class WaffleBuilder: ConfectionBuilder
    {
        public WaffleBuilder() => Confection = new Waffle();

        public WaffleBuilder SetTaste(string taste)
        {
            ((Waffle) Confection).Taste = taste;
            return this;
        }

        public WaffleBuilder SetWaffleType(WaffleType waffleType)
        {
            ((Waffle) Confection).WaffleType = waffleType;
            return this;
        }
    }
}