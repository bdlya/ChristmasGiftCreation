using Domain.Confections.Characteristics;

namespace Domain.Confections
{
    public class Waffle: ConfectionBase
    {
        public string Taste { get; set; }

        public WaffleType WaffleType { get; set; }

        public override string ToString() => base.ToString() + $"\nTaste: {Taste}\nWaffle: {WaffleType}\n";
    }
}