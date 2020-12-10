using Domain.Confections.Characteristics;

namespace Domain.Confections
{
    public class Chocolate: ConfectionBase
    {
        public ChocolateType ChocolateType { get; set; }

        public override string ToString() => base.ToString() + $"\nChocolate: {ChocolateType}\n";

    }
}