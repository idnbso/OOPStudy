using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.AbstractFactoryMethod.ComponentsLibrary.AntDesign
{
    class AntButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Ant Button");
        }
    }
}
