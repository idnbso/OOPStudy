using DesignPatterns.BehaviouralPatterns.Mediator.GUIFrameowrkWithObserver.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Mediator.GUIFrameowrkWithObserver
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
