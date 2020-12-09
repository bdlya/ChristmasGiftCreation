using Domain.Products.Confections;
using Domain.Products.Confections.Characteristics;

namespace Utils.Builders.Confection
{
    public class ChocolateBuilder : ConfectionBuilderBase<Chocolate>
    {
        public ChocolateBuilder SetChocolateType(ChocolateType chocolateType)
        {
            Confection.ChocolateType = chocolateType;
            return this;
        }
    }
}