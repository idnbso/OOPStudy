using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Adapter.ImageEditorApp.AvaFilters
{
    public class Caramel
    {
        public void Init()
        {
            Console.WriteLine("Initializing Caramel Filter");
        }

        public void Render(Image image)
        {
            Console.WriteLine("Applying Caramel Filter");
        }
    }
}
