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
using System.Collections.ObjectModel;
using System.Drawing;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;

namespace BasicDemo.Common
{
    internal partial class ErrorBox : UserControl
    {
        private bool _allowChangedSyntax = true;

        public event EventHandler SyntaxProviderChanged;
        public event EventHandler GoToErrorPositionEvent;
        public event EventHandler RevertValidTextEvent;
        
        public BaseSyntaxProvider CurrentSyntaxProvider { get; set; }
        public ObservableCollection<BaseSyntaxProvider> SyntaxProviders { get; } 
        public string Message
        {
            get { return labelMessage.Text; }
            set { labelMessage.Text = value; }
        }
        
        public ErrorBox()
        {
            InitializeComponent();
            SyntaxProviders =  new ObservableCollection<BaseSyntaxProvider>();
            SyntaxProviders.CollectionChanged += SyntaxProviders_CollectionChanged;   
        }

        public void SetSyntaxProvider(BaseSyntaxProvider baseSyntaxProvider)
        {
            CurrentSyntaxProvider = baseSyntaxProvider;

            _allowChangedSyntax = false;
            if (CurrentSyntaxProvider != null)
                comboBoxSyntaxProvider.Text = CurrentSyntaxProvider.ToString();
            _allowChangedSyntax = true;
        }

        private void SyntaxProviders_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            comboBoxSyntaxProvider.Items.Clear();

            foreach (var baseSyntaxProvider in SyntaxProviders)
            {
                comboBoxSyntaxProvider.Items.Add(new ComboBoxItem(baseSyntaxProvider));
            }
        }

        public new void Dispose()
        {
            SyntaxProviders.CollectionChanged -= SyntaxProviders_CollectionChanged;
            base.Dispose();
        }

        protected virtual void OnSyntaxProviderChanged()
        {
            if (!_allowChangedSyntax) return;
            CurrentSyntaxProvider = ((ComboBoxItem) comboBoxSyntaxProvider.SelectedItem).SyntaxProvider;
            SyntaxProviderChanged?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnGoToErrorPositionEvent()
        {
            GoToErrorPositionEvent?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnRevertValidTextEvent()
        {
            RevertValidTextEvent?.Invoke(this, EventArgs.Empty);
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
