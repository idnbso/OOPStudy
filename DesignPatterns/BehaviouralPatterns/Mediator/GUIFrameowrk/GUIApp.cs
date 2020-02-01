using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Mediator.GUIFrameowrk
{
    public class GUIApp
    {
        public static void Run()
        {
            var dialog = new ArticlesDialogBox();
            dialog.SimulateUserInteraction();
        }
    }
}
