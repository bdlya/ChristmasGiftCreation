using GiftContent.Products.Confections;
using GiftContent.Products.Confections.Characteristics;

namespace GiftContent.Builders.ConfectionBuilders
{
    public class LollipopBuilder: ConfectionBuilder
    {
        public LollipopBuilder() => Confection = new Lollipop();

        public LollipopBuilder SetLollipopType(LollipopType lollipopType)
        {
            ((Lollipop) Confection).LollipopType = lollipopType;
            return this;
        }
    }
}