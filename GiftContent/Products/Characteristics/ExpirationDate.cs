using System;

namespace GiftContent.Products.Characteristics
{
    public class ExpirationDate
    {
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }

        public ExpirationDate(DateTime startDate, DateTime endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
        }

        public override string ToString() => $"Start date: {StartDate}\nEnd date: {EndDate}";
    }
}