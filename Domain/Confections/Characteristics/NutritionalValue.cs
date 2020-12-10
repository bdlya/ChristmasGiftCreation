namespace Domain.Confections.Characteristics
{
    public class NutritionalValue
    {
        public double ProteinAmount { get; }
        public double FatAmount { get; }
        public double CarbohydrateAmount { get; }

        public NutritionalValue(double proteinAmount, double fatAmount, double carbohydrateAmount)
        {
            ProteinAmount = proteinAmount;
            FatAmount = fatAmount;
            CarbohydrateAmount = carbohydrateAmount;
        }

        public override string ToString() => $"Protein: {ProteinAmount}\nFat: {FatAmount}\nCarbohydrate: {CarbohydrateAmount}";
    }
}