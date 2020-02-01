using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.TemplateMethod.GUIFramework.Window
{
    public class PopupWindow : Window
    {
        protected override void OnBeforeClose()
        {
            Console.WriteLine("Before Popup Window Closed");
        }
    }
}
