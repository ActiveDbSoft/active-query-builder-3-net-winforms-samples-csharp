//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2019 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;

namespace AdvantageDemo.Common
{
    internal partial class ErrorBox : UserControl
    {
        private bool _allowChangedSyntax = true;

        [Browsable(true)]
        public bool IsVisibleCheckSyntaxPanel
        {
            get { return panelCheckSyntax.Visible; }
            set { panelCheckSyntax.Visible = value; }
        }
        public event EventHandler SyntaxProviderChanged;
        public event EventHandler GoToErrorPosition;
        public event EventHandler RevertValidText;
        
        public BaseSyntaxProvider CurrentSyntaxProvider { get; set; }

        public ErrorBox()
        {
            InitializeComponent();

            Visible = false;

            comboBoxSyntaxProvider.Items.Clear();

            foreach (Type baseSyntaxProvider in Helpers.SyntaxProviderList)
            {
                var instance = Activator.CreateInstance(baseSyntaxProvider) as BaseSyntaxProvider;
                comboBoxSyntaxProvider.Items.Add(new ComboBoxItem(instance));
            }
        }

        public void Show(string message, BaseSyntaxProvider baseSyntaxProvider)
        {
            labelMessage.Text = message;

            if (string.IsNullOrEmpty(message))
            {
                Visible = false;
                return;
            }

            Visible = true;

            CurrentSyntaxProvider = baseSyntaxProvider;

            _allowChangedSyntax = false;
            if (CurrentSyntaxProvider != null)
                comboBoxSyntaxProvider.Text = CurrentSyntaxProvider.ToString();
            _allowChangedSyntax = true;
        }

        protected virtual void OnSyntaxProviderChanged()
        {
            if (!_allowChangedSyntax) return;
            CurrentSyntaxProvider = ((ComboBoxItem) comboBoxSyntaxProvider.SelectedItem).SyntaxProvider;
            SyntaxProviderChanged?.Invoke(this, EventArgs.Empty);
            Visible = false;
        }

        protected virtual void OnGoToErrorPositionEvent()
        {
            GoToErrorPosition?.Invoke(this, EventArgs.Empty);
            Visible = false;
        }

        protected virtual void OnRevertValidTextEvent()
        {
            RevertValidText?.Invoke(this, EventArgs.Empty);
            Visible = false;
        }

        private void linkLabelGoTo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OnGoToErrorPositionEvent();
        }

        private void linkLabelRevert_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OnRevertValidTextEvent();
        }

        private void comboBoxSyntaxProvider_SelectedValueChanged(object sender, EventArgs e)
        {
            OnSyntaxProviderChanged();
        }
    }

    internal class ComboBoxItem
    {
        public BaseSyntaxProvider SyntaxProvider { get; }
        public string DisplayString => SyntaxProvider.ToString();
        public ComboBoxItem() { }

        public ComboBoxItem(BaseSyntaxProvider provider)
        {
            SyntaxProvider = provider;
        }
    }

    internal class GrowLabel : Label
    {
        private bool _mGrowing;

        public GrowLabel()
        {
            AutoSize = false;
        }

        public sealed override bool AutoSize
        {
            get { return base.AutoSize; }
            set { base.AutoSize = value; }
        }

        private void resizeLabel()
        {
            if (_mGrowing) return;
            try
            {
                _mGrowing = true;
                Size sz = new Size(this.Width, Int32.MaxValue);
                sz = TextRenderer.MeasureText(this.Text, this.Font, sz, TextFormatFlags.WordBreak);
                this.Height = sz.Height;
            }
            finally
            {
                _mGrowing = false;
            }
        }
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            resizeLabel();
        }
        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            resizeLabel();
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            resizeLabel();
        }
    }
}
