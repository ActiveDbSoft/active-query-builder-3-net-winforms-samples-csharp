//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2025 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.Core.PropertiesEditors;
using Helpers = ActiveQueryBuilder.View.Helpers;

namespace MetadataEditorDemo.Common
{
    internal partial class InformationMessageControl : UserControl
    {
        public event EventHandler FixIssueEvent;
        public event EventHandler Closing;

        public object Owner { set; get; }
        private PropertyErrorDescription _errorDescription;
        public PropertyErrorDescription ErrorDescription { get { return _errorDescription; } }
        public int MaxLengthValue { set; get; }
        private static readonly Regex Regex = new Regex("\"([^\"]+)\"");
        private readonly CompositeDisposable _subscriptions = new CompositeDisposable();

        public InformationMessageControl()
        {
            InitializeComponent();
            BindIcons();

            MaxLengthValue = 20;
            Hide();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _subscriptions.Dispose();
                components?.Dispose();
            }

            base.Dispose(disposing);
        }

        private void BindIcons()
        {
            _subscriptions.Add(ActiveQueryBuilder.View.WinForms.Images.Common.CloseMessage.Subscribe(x => button1.Image = x));
        }        

        public void Show(PropertyErrorDescription description)
        {
            _errorDescription = description;            
            var message = description.Message;
            if (ErrorDescription.Message.Last() != '.') message = message + ". ";

            var match = Regex.Match(message);

            while (match.Success)
            {
                var value = match.Groups[1].ToString();

                if (value.Length > MaxLengthValue)
                    message = message.Replace(value, value.Remove(MaxLengthValue) + "...");

                match = match.NextMatch();
            }

            Show(message, description.IsError);
        }

        public void Show(string message, bool isError)
        {
            if (string.IsNullOrEmpty(message)) message = string.Empty;

            labelMessage.LinkArea = new LinkArea(0, 0);
            pictureBoxIcon.Image = isError ? ActiveQueryBuilder.View.WinForms.Images.Common.Exclamation.Value : ActiveQueryBuilder.View.WinForms.Images.Common.AlertExclamation.Value;
            labelMessage.Text = message;

            if (isError)
            {
                var fixIssue = " " + Helpers.Localizer.GetString("strFixIssue", LocalizableConstantsUI.strFixIssue);
                labelMessage.Text += fixIssue;
                labelMessage.LinkArea = new LinkArea(message.Length + 1, fixIssue.Length);
            }
                        
            Visible = true;
        }

        protected virtual void OnFixIssueEvent()
        {
            FixIssueEvent?.Invoke(this, EventArgs.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Closing?.Invoke(this, EventArgs.Empty);
            Hide();
        }

        private void labelMessage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OnFixIssueEvent();
        }
    }
}
