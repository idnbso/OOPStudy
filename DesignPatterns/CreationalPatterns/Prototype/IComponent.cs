using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Prototype.Keynote
{
    public interface IComponent
    {
        void Render();
        IComponent Clone();
    }
}
