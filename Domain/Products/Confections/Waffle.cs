using Domain.Products.Confections.Characteristics;

namespace Domain.Products.Confections
{
    public class Waffle: ConfectioneryProductBase
    {
        public string Taste { get; set; }

        public WaffleType WaffleType { get; set; }

        public override string ToString() => base.ToString() + $"\nTaste: {Taste}\nWaffle: {WaffleType}";
    }
}