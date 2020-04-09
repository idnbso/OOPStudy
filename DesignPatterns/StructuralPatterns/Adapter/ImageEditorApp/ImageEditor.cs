using DesignPatterns.StructuralPatterns.Adapter.ImageEditorApp.AvaFilters;
using DesignPatterns.StructuralPatterns.Adapter.ImageEditorApp.Filter;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Adapter.ImageEditorApp
{
    public class ImageEditor
    {
        public static void Run()
        {
            var imageView = new ImageView(new Image());
            var avaCaramelFilter = new Caramel();
            var caramelFilterAdapter = new CaramelFilter(avaCaramelFilter);
            imageView.Apply(caramelFilterAdapter);
        }
    }
}
