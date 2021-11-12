using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.AbstractFactoryMethod.ComponentsLibrary.MaterialDesign
{
    class MaterialButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Material Button");
        }
    }
}
