using DesignPatterns.CreationalPatterns.AbstractFactoryMethod.ComponentsLibrary.AntDesign;
using DesignPatterns.CreationalPatterns.AbstractFactoryMethod.ComponentsLibrary.MaterialDesign;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.AbstractFactoryMethod.ComponentsLibrary.App
{
    public class App
    {
        public static void Run()
        {
            var contactForm = new ContactForm();
            contactForm.Render(new AntWidgetFactory());
        }
    }
}
