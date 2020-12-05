using GiftContent.Builders.ConfectionBuilders;
using GiftContent.Products.Confections.Characteristics;

namespace GiftContent.Products.Confections
{
    public class Lollipop: ConfectioneryProduct
    {
        public LollipopType LollipopType { get; set; }

        public new static LollipopBuilder CreateBuilder() => new LollipopBuilder();

        public override string ToString() => base.ToString() + $"\nLollipop: {LollipopType}";

    }
}