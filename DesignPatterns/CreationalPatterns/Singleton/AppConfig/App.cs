using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Singleton.AppConfig
{
    public class App
    {
        public static void Run()
        {
            var manager = ConfigManager.Instance;
            manager.Set("name", "Idan");

            var otherManager = ConfigManager.Instance;
            Console.WriteLine(otherManager.Get("name"));
        }
    }
}
