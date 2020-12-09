using Domain.Products.Confections.Characteristics;

namespace Domain.Products.Confections
{
    public class CandyBar: ConfectioneryProductBase
    {
        public bool IsGlazed { get; set; }

        public Nut NutType { get; set; }
        public Size Size { get; set; }

        public override string ToString() => base.ToString() + $"\nGlazing: {IsGlazed}\nNut: {NutType}\nSize: {Size}";
    }
}