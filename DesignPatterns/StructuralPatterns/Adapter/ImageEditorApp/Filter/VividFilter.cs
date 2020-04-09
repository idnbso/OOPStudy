using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Adapter.ImageEditorApp.Filter
{
    class VividFilter : IFilter
    {
        public void Apply(Image image)
        {
            Console.WriteLine("Applying Vivid Filter");
        }
    }
}
