using DesignPatterns.CreationalPatterns.AbstractFactoryMethod.ComponentsLibrary.AntDesign;
using DesignPatterns.CreationalPatterns.AbstractFactoryMethod.ComponentsLibrary.MaterialDesign;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.AbstractFactoryMethod.ComponentsLibrary.App
{
    class ContactForm
    {
        public void Render(IWidgetFactory widgetFactory)
        {
            widgetFactory.CreateButton().Render();
            widgetFactory.CreateTextBox().Render();
        }
    }
}
