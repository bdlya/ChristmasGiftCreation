using Domain.Confections;
using Domain.Confections.Characteristics;

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