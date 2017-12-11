using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salad.Models
{
    class Vegetable : IComparable<Vegetable>
    {
        private string _name;
        private short _weight;
        private short _caloricity;
        private double _price;

        public string Name { get => _name; set => _name = value; }
        public short Weight { get => _weight; set => _weight = value; }
        public short Caloricity { get => _caloricity; set => _caloricity = value; }
        public double Price { get => _price; set => _price = value; }

        public Vegetable(string name, string weight, string caloricity, string price)
        {
            Name = name;
            Weight = Int16.Parse(weight);
            Caloricity = Int16.Parse(caloricity);
            Price = Double.Parse(price);
        }

        public override string ToString()
        {
            return String.Format("Name: {0,-10}|Weight: {1,-4}|Caloricity: {2,-3}|Price: {3,-4}",
                Name, Weight, Caloricity, Price);
        }

        public int CompareTo(Vegetable obj)
        {
            if (Caloricity > obj.Caloricity)
                return 1;
            if (Caloricity < obj.Caloricity)
                return -1;
            else
                return 0;
        }
    }
}
