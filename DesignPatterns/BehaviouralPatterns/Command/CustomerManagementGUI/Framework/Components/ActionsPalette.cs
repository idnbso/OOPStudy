using DesignPatterns.BehaviouralPatterns.Command.CustomerManagementGUI.Framework.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Command.CustomerManagementGUI.Framework.Components
{
    public class ActionsPalette
    {
        public void RunDefaultImageEnchancement()
        {
            var composite = new CompositeCommand();
            composite.Add(new ResizeCommand());
            composite.Add(new BlackAndWhiteFilterCommand());
            composite.Execute();
        }
    }
}
