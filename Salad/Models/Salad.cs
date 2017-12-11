using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Salad.Interfaces;
using System.IO;
using Salad.Breakers;

namespace Salad.Models
{
    class Salad : IReadFiles, IWriteToFiles
    {

        List<Vegetable> _salad = new List<Vegetable>();

        internal List<Vegetable> _Salad { get => _salad; set => _salad = value; }

        public void ReadingFile(string fileName)
        {
            string str;
            using (StreamReader reader = new StreamReader(fileName))
            {
                while ((str = reader.ReadLine()) != null)
                {
                    string[] words = LineBreaker.ReturnWordArr(' ', str, 0);
                    _Salad.Add(new Vegetable(words[0], words[1], words[2], words[3]));
                }
            }
        }

        public override string ToString()
        {
            string str = String.Empty;
            foreach (var element in _Salad)
            {
                str += element.ToString() + "\r\n";
            }
            return str;
        }

        public void WriteToFiles(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.Write(ToString());
                writer.WriteLine("СaloriesInSalad: " + СountsСalories());
            }
        }

        public int СountsСalories()
        {
            int _caloricity = 0;
            foreach (Vegetable vegatable in _Salad)
            {
                _caloricity += vegatable.Caloricity;
            }
            return _caloricity;
        }

    }
}
