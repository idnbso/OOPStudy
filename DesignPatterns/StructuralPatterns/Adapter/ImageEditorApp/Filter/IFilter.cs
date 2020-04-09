using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Adapter.ImageEditorApp.Filter
{
    public interface IFilter
    {
        void Apply(Image image);
    }
}
