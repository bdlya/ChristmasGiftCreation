using Domain.Confections.Characteristics;

namespace Domain.Confections
{
    public class CandyBar: ConfectionBase
    {
        public bool IsGlazed { get; set; }

        public Nut NutType { get; set; }

        public Size Size { get; set; }

        public override string ToString() => base.ToString() + $"\nGlazing: {IsGlazed}\nNut: {NutType}\nSize: {Size}\n";
    }
}