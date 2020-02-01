using DesignPatterns.BehaviouralPatterns.TemplateMethod.GUIFramework.Window;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.TemplateMethod.GUIFramework
{
    public class GUIProgram
    {
        public static void Run()
        {
            var staticWindow = new StaticWindow();
            staticWindow.Close();

            var popupWindow = new PopupWindow();
            popupWindow.Close();
        }
    }
}
