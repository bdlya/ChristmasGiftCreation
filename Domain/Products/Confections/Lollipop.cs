using Domain.Products.Confections.Characteristics;

namespace Domain.Products.Confections
{
    public class Lollipop: ConfectioneryProductBase
    {
        public LollipopType LollipopType { get; set; }

        public override string ToString() => base.ToString() + $"\nLollipop: {LollipopType}\n";

    }

}