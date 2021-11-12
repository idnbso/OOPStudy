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
            //DesignPatterns.BehaviouralPatterns.Visitor.HtmlEditor.HtmlEditor.Run();
            //DesignPatterns.StructuralPatterns.Composite.DiagramApp.DiagramEditor.Run();
            //DesignPatterns.StructuralPatterns.Adapter.ImageEditorApp.ImageEditor.Run();
            //DesignPatterns.StructuralPatterns.Decorator.CloudApp.CloudApp.Run();
            //DesignPatterns.StructuralPatterns.Facade.NotificationSystem.NotificationSender.Run();
            //DesignPatterns.StructuralPatterns.Flyweight.MapsApp.MapsApp.Run();
            //DesignPatterns.StructuralPatterns.Bridge.UniversalRemoteControl.RemoteControlApp.Run();
            //DesignPatterns.StructuralPatterns.Proxy.EbookReader.EbookReaderApp.Run();
            //DesignPatterns.CreationalPatterns.BuilderRecursiveGenerics.Program.Demo(null);
            //DesignPatterns.CreationalPatterns.Prototype.Keynote.KeynoteApp.Run();
            //DesignPatterns.CreationalPatterns.Singleton.AppConfig.App.Run();
            //DesignPatterns.CreationalPatterns.FactoryMethod.ViewEngineLibrary.Client.Run();
            DesignPatterns.CreationalPatterns.AbstractFactoryMethod.ComponentsLibrary.App.App.Run();
        }
    }
}
