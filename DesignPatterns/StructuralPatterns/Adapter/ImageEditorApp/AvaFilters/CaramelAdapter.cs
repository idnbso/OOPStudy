using DesignPatterns.StructuralPatterns.Adapter.ImageEditorApp.Filter;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Adapter.ImageEditorApp.AvaFilters
{
    class CaramelAdapter : Caramel, IFilter
    {
        public void Apply(Image image)
        {
            Init();
            Render(image);
        }
    }
}
