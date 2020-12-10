using Domain.Confections.Characteristics;

namespace Domain.Confections
{
    public class Lollipop: ConfectionBase
    {
        public LollipopType LollipopType { get; set; }

        public override string ToString() => base.ToString() + $"\nLollipop: {LollipopType}\n";

    }

}