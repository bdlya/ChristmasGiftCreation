using GiftContent.Builders.ConfectionBuilders;
using GiftContent.Products.Confections.Characteristics;

namespace GiftContent.Products.Confections
{
    public class Chocolate: ConfectioneryProduct
    {
        public ChocolateType ChocolateType { get; set; }

        public new static ChocolateBuilder CreateBuilder() => new ChocolateBuilder();

        public override string ToString() => base.ToString() + $"Chocolate: {ChocolateType}";

    }
}