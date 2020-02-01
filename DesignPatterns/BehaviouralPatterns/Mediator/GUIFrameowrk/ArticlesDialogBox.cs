using DesignPatterns.BehaviouralPatterns.Mediator.GUIFrameowrk.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Mediator.GUIFrameowrk
{
    class ArticlesDialogBox : DialogBox
    {
        private ListBox articlesListBox;
        private TextBox titleTextBox;
        private Button saveButton;

        public ArticlesDialogBox()
        {
            articlesListBox = new ListBox(dialogOwner: this);
            titleTextBox = new TextBox(dialogOwner: this);
            saveButton = new Button(dialogOwner: this);
        }

        public void SimulateUserInteraction()
        {
            articlesListBox.Selection = "Article 1";
            titleTextBox.Content = "";
            titleTextBox.Content = "Article 2";
            Console.WriteLine($"TextBox: {titleTextBox.Content}");
            Console.WriteLine($"Button: {saveButton.IsEnabled}");
        }

        public override void OnChanged(UIControl control)
        {
            base.OnChanged(control);

            if (control == articlesListBox)
            {
                OnArticleSelected();
            }
            else if (control == titleTextBox)
            {
                OnTitleChanged();
            }
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
