using Domain.Products.Confections;
using Domain.Products.Confections.Characteristics;

namespace Utils.Builders.Confection
{
    public class LollipopBuilder: ConfectionBuilderBase<Lollipop>
    {
        public LollipopBuilder SetLollipopType(LollipopType lollipopType)
        {
            Confection.LollipopType = lollipopType;
            return this;
        }
    }
}