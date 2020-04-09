using DesignPatterns.StructuralPatterns.Adapter.ImageEditorApp.AvaFilters;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Adapter.ImageEditorApp.Filter
{
    public class CaramelFilter : IFilter
    {
        private Caramel caramelFilter;

        public CaramelFilter(Caramel caramelFilter)
        {
            this.caramelFilter = caramelFilter;
        }

        public void Apply(Image image)
        {
            caramelFilter.Init();
            caramelFilter.Render(image);
        }
    }
}
