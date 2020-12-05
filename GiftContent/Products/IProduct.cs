using GiftContent.Products.Characteristics;

namespace GiftContent.Products
{
    public interface IProduct
    {
        string Name { get; set; }
        string ManufacturerName { get; set; }

        double SugarContent { get; set; }
        double Weight { get; set; }

        int PricePerKilogram { get; set; }

        NutritionalValue NutritionalValue { get; set; }
        ExpirationDate ExpirationDate { get; set; }
    }
}