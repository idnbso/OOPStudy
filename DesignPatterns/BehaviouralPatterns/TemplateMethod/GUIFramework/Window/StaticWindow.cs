using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.TemplateMethod.GUIFramework.Window
{
    public class StaticWindow : Window
    {
        protected override void OnBeforeClose()
        {
            base.OnBeforeClose();

            Console.WriteLine("Before Static Window is Closed");
        }

        protected override void OnAfterClose()
        {
            base.OnAfterClose();

            Console.WriteLine("After Static Window is Closed");
        }

    }
}
