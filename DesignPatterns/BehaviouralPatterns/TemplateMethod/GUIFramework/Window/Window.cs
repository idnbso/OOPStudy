using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.TemplateMethod.GUIFramework.Window
{
    public abstract class Window
    {
        /// <summary>
        /// Template Method
        /// </summary>
        public void Close()
        {
            OnBeforeClose(); 

            Console.WriteLine("Removing the window from the screen"); // mandatory lifecycle call

            OnAfterClose();
        }

        /// <summary>
        /// Template Method's Hook
        /// </summary>
        protected virtual void OnBeforeClose()
        {
            Console.WriteLine("Default Before Close Window Behaviour");
        }

        /// <summary>
        /// Template Method's Hook
        /// </summary>
        protected virtual void OnAfterClose()
        {
            Console.WriteLine("Default After Close Window Behaviour");
        }
    }
}
