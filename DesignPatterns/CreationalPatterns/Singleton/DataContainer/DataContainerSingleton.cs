using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Singleton.DataContainer
{
    public sealed class DataContainerSingleton : IDatabase
    {
        private readonly Dictionary<string, int> _capitals = new Dictionary<string, int>();
        private readonly static Lazy<DataContainerSingleton> _instance = new Lazy<DataContainerSingleton>(() => new DataContainerSingleton());

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


        public static DataContainerSingleton Instance => _instance.Value;
    }
}
