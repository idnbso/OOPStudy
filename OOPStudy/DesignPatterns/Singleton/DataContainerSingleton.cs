using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class DataContainerSingleton : IDatabase
    {
        private readonly Dictionary<string, int> _capitals = new Dictionary<string, int>();

        private DataContainerSingleton()
        {
            Console.WriteLine("Initializing singleton object");

            var elements = File.ReadAllLines("capitals.txt");
            for (int i = 0; i < elements.Length; i+=2)
            {
                _capitals.Add(elements[i], int.Parse(elements[i + 1]));
            }
        }

        public int GetPopulation(string name)
        {
            return _capitals[name];
        }

        private readonly static Lazy<DataContainerSingleton> instance = new Lazy<DataContainerSingleton>(() => new DataContainerSingleton());

        public static DataContainerSingleton Instance => instance.Value;
    }
}
