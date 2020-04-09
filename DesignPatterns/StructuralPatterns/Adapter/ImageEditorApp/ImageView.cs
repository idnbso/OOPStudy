using DesignPatterns.StructuralPatterns.Adapter.ImageEditorApp.Filter;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Adapter.ImageEditorApp
{
    public class ImageView
    {
        private Image image;

        public ImageView(Image image)
        {
            this.image = image;
        }

        public void Apply(IFilter filter)
        {
            filter.Apply(image);
        }
    }
}
