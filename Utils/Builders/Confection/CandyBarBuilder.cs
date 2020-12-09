using Domain.Products.Confections;
using Domain.Products.Confections.Characteristics;

namespace Utils.Builders.Confection
{
    public class CandyBarBuilder : ConfectionBuilderBase<CandyBar>
    {

        public CandyBarBuilder SetGlazing(bool isGlazed)
        {
            Confection.IsGlazed = isGlazed;
            return this;
        }

        public CandyBarBuilder SetNutType(Nut nutType)
        {
            Confection.NutType = nutType;
            return this;
        }

        public CandyBarBuilder SetSize(Size size)
        {
            Confection.Size = size;
            return this;
        }
    }
}