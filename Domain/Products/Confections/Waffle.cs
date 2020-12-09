using GiftContent.Builders.ConfectionBuilders;
using GiftContent.Products.Confections.Characteristics;

namespace GiftContent.Products.Confections
{
    public class Waffle: ConfectioneryProduct
    {
        public string Taste { get; set; }

        public WaffleType WaffleType { get; set; }

        public new static WaffleBuilder CreateBuilder() => new WaffleBuilder();

        public override string ToString() => base.ToString() + $"\nTaste: {Taste}\nWaffle: {WaffleType}";
    }
}