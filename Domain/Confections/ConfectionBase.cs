using Domain.Confections.Characteristics;
using System;

namespace Domain.Confections
{
    public abstract class ConfectionBase
    {
        public string Name { get; set; }

        public string ManufacturerName { get; set; }

        public double SugarContent { get; set; }

        public double Weight { get; set; }

        public int PricePerKilogram { get; set; }

        public NutritionalValue NutritionalValue { get; set; }

        public DateTime StartDate { get; set; }

        public override string ToString() =>
            $"\nName: {Name}\nManufacturer: {ManufacturerName}\nSugar: {SugarContent}\nWeight: {Weight}\nPrice: {PricePerKilogram}\n" +
            $"{NutritionalValue}\n{StartDate}";
    }
}