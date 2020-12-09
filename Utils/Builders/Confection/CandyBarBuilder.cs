using GiftContent.Products.Confections;
using GiftContent.Products.Confections.Characteristics;

namespace GiftContent.Builders.ConfectionBuilders
{
    public class CandyBarBuilder : ConfectionBuilder
    {
        public CandyBarBuilder() => Confection = new CandyBar();

        public CandyBarBuilder SetGlazing(bool isGlazed)
        {
            ((CandyBar) Confection).IsGlazed = isGlazed;
            return this;
        }

        public CandyBarBuilder SetNutType(Nut nutType)
        {
            ((CandyBar) Confection).NutType = nutType;
            return this;
        }

        public CandyBarBuilder SetSize(Size size)
        {
            ((CandyBar) Confection).Size = size;
            return this;
        }
    }
}