using System;
using DesignPatterns.BehaviouralPatterns.State;

namespace OOPStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunObjectOrientedDesignProgram();
            RunDesignPatternsProgram();
        }

        static void RunObjectOrientedDesignProgram()
        {
            ObjectOrientedCodeDemo.Program.Demo();
        }

        static void RunDesignPatternsProgram()
        {
            //Memento.CodeEditor.CodeEditorProgram.Demo();
            //DesignPatterns.BehaviouralPatterns.State.Painter.PainterProgram.Demo();
            //DesignPatterns.BehaviouralPatterns.Iterator.HistoryBrowser.Browser.Run();
            //DesignPatterns.BehaviouralPatterns.Strategy.ImagesHoster.ImageHosterProgram.Run();
            //DesignPatterns.BehaviouralPatterns.Command.CustomerManagementGUI.CustomerManagementGUI.Run();
            //DesignPatterns.BehaviouralPatterns.Command.HtmlEditor.HtmlEditor.Run();
            //DesignPatterns.BehaviouralPatterns.Observer.SpreadsheetApp.SpreadsheetEditor.Run();
            //DesignPatterns.BehaviouralPatterns.Mediator.GUIFrameowrkWithObserver.GUIApp.Run();
            //DesignPatterns.BehaviouralPatterns.ChainOfResponsibility.ServerAndClient.WebApplication.Run();
            DesignPatterns.BehaviouralPatterns.Visitor.HtmlEditor.HtmlEditor.Run();
        }
    }
}
