using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.AbstractFactoryMethod.ComponentsLibrary.AntDesign
{
    class AntTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Ant TextBox");
        }
    }
}
