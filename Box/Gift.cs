using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Confections;

namespace Box
{
    public class Gift
    {
        private ICollection<ConfectionBase> _confections;

        public Gift() => _confections = new List<ConfectionBase>();

        public void Add(ConfectionBase confection) => _confections.Add(confection);

        public void AddRange(params ConfectionBase[] confections)
        {
            foreach (var confection in confections)
            {
                Add(confection);
            }
        }

        public double CountWeight() => _confections.Sum(x => x.Weight);

        public void OrderByManufacturer() => _confections = _confections.OrderBy(x => x.ManufacturerName).ToList();

        public ConfectionBase GetFirstConfectionBySugarContent(int from, int to) =>
            _confections.FirstOrDefault(x => x.SugarContent >= from && x.SugarContent <= to);

        public IEnumerable GetAllConfectionsBySugarContent(int from, int to) => 
            _confections.Where(x => x.SugarContent >= from && x.SugarContent <= to);

        public override string ToString()
        {
            StringBuilder confections = new StringBuilder();

            foreach (var product in _confections)
            {
                confections.Append(product);
            }

            return confections.ToString();
        }
    }
}