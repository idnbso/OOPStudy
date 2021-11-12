using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.AbstractFactoryMethod.ComponentsLibrary
{
    interface IWidgetFactory
    {
        IButton CreateButton();
        ITextBox CreateTextBox();
    }
}
