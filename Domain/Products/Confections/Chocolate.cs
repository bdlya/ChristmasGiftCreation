using Domain.Products.Confections.Characteristics;

namespace Domain.Products.Confections
{
    public class Chocolate: ConfectioneryProductBase
    {
        public ChocolateType ChocolateType { get; set; }

        public override string ToString() => base.ToString() + $"Chocolate: {ChocolateType}";

    }
}