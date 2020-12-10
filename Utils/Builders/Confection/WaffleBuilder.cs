using Domain.Confections;
using Domain.Confections.Characteristics;


namespace Utils.Builders.Confection
{
    public class WaffleBuilder: ConfectionBuilderBase<Waffle>
    {
        public WaffleBuilder SetTaste(string taste)
        {
            Confection.Taste = taste;
            return this;
        }

        public WaffleBuilder SetWaffleType(WaffleType waffleType)
        {
            Confection.WaffleType = waffleType;
            return this;
        }
    }
}