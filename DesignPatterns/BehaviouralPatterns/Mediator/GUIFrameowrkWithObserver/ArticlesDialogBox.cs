using DesignPatterns.BehaviouralPatterns.Mediator.GUIFrameowrk.Components;
using DesignPatterns.BehaviouralPatterns.Mediator.GUIFrameowrkWithObserver.Components.Observable;
using System;

namespace DesignPatterns.BehaviouralPatterns.Mediator.GUIFrameowrkWithObserver.Components
{
    class ArticlesDialogBox
    {
        private ListBox articlesListBox;
        private TextBox titleTextBox;
        private Button saveButton;

        public ArticlesDialogBox()
        {
            articlesListBox = new ListBox("My List");
            titleTextBox = new TextBox();
            saveButton = new Button();

            articlesListBox.AddEventHandler(new ActionEventHandler(OnArticleSelected));
            titleTextBox.AddEventHandler(new ActionEventHandler(OnTitleChanged));
        }

        public void SimulateUserInteraction()
        {
            articlesListBox.Selection = "Article 1";
            titleTextBox.Content = "";
            titleTextBox.Content = "Article 2";
            Console.WriteLine($"TextBox: {titleTextBox.Content}");
            Console.WriteLine($"Button: {saveButton.IsEnabled}");
        }

        private void OnArticleSelected()
        {
            titleTextBox.Content = articlesListBox.Selection;
            saveButton.IsEnabled = true;
        }

        private void OnTitleChanged()
        {
            var titleContent = titleTextBox.Content;
            saveButton.IsEnabled = string.IsNullOrWhiteSpace(titleContent) == false;
        }
    }
}
