using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.AbstractFactoryMethod.ComponentsLibrary.MaterialDesign
{
    class MaterialTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Material TextBox");
        }
    }
}
