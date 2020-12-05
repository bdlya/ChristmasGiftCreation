using GiftContent.Builders.ConfectionBuilders;
using GiftContent.Products.Characteristics;

namespace GiftContent.Products.Confections

{
    public class ConfectioneryProduct : IProduct
    {
        public string Name { get; set; }
        public string ManufacturerName { get; set; }

        public double SugarContent { get; set; }
        public double Weight { get; set; }

        public int PricePerKilogram { get; set; }

        public NutritionalValue NutritionalValue { get; set; }
        public ExpirationDate ExpirationDate { get; set; }

        public static ConfectionBuilder CreateBuilder() => new ConfectionBuilder();

        public override string ToString() => 
            $"Name: {Name}\nManufacturer: {ManufacturerName}\nSugar: {SugarContent}\nWeight: {Weight}\nPrice: {PricePerKilogram}\n" +
            $"{NutritionalValue}\n{ExpirationDate}";

    }
}