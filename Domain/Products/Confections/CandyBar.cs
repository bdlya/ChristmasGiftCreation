using GiftContent.Builders.ConfectionBuilders;
using GiftContent.Products.Confections.Characteristics;

namespace GiftContent.Products.Confections
{
    public class CandyBar: ConfectioneryProduct
    {
        public bool IsGlazed { get; set; }

        public Nut NutType { get; set; }
        public Size Size { get; set; }

        public new static CandyBarBuilder CreateBuilder() => new CandyBarBuilder();

        public override string ToString() => base.ToString() + $"\nGlazing: {IsGlazed}\nNut: {NutType}\nSize: {Size}";
    }
}