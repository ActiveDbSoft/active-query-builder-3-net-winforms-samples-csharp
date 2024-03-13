//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2024 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.View;
using Helpers = ActiveQueryBuilder.View.Helpers;

namespace MetadataEditorDemo.Common
{
    [ToolboxItem(false)]
    internal partial class InformationPanel : UserControl, IInformationPanel
    {
        private const int LineWidthLimit = 50;

        private InfoIconLocation _iconLocation = InfoIconLocation.Right;
        public InfoIconLocation IconLocation
        {
            get { return _iconLocation; }
            set
            {
                _iconLocation = value;
                if (_iconLocation == InfoIconLocation.Right)
                {
                    pictureBox1.Left = pnlMain.Width - pictureBox1.Width - 3;
                    lbText.Left = 3;
                    pictureBox1.Anchor = AnchorStyles.Right;
                }
                else if (_iconLocation == InfoIconLocation.Left)
                {
                    pictureBox1.Left = 3;
                    lbText.Left = pnlMain.Width - lbText.Width - 3;
                    pictureBox1.Anchor = AnchorStyles.Left;
                }
            }
        }

        private string _tooltip = string.Empty;
        public string Tooltip
        {
            get { return _tooltip; }
            set
            {
                _tooltip = value;
                var text = !string.IsNullOrEmpty(_tooltip) ? WrapText(_tooltip) : _tooltip;
                _toolTip.SetToolTip(pnlMain, text);
                _toolTip.SetToolTip(lbText, text);
            }
        }

        public string InfoText
        {
            get { return lbText.Text; }
            set
            {
                lbText.Text = value;
                UpdateHeight(value);
                UpdateIconLocation();
            }
        }

        public string IconTooltip
        {
            get { return _iconTooltip; }
            set
            {
                _iconTooltip = value;
                _toolTip.SetToolTip(pictureBox1, !string.IsNullOrEmpty(_iconTooltip) ? WrapText(_iconTooltip) : _iconTooltip);
            }
        }

        public bool ShowIcon
        {
            get { return pictureBox1.Visible; }
            set
            {
                pictureBox1.Visible = value;
                if (value)
                    lbText.Width = Width - 26;
                else
                    lbText.Width = Width;
            }
        }

        private string _iconTooltip = string.Empty;
        private readonly ToolTip _toolTip = new ToolTip();
        private readonly IDisposable _iconSubscription;

        public InformationPanel()
        {
            InitializeComponent();
            
            _iconSubscription = ActiveQueryBuilder.View.WinForms.Images.Common.Info.Subscribe(x => pictureBox1.Image = x);

            UpdateHeight(lbText.Text);
            UpdateIconLocation();
        }

        public InformationPanel(string text, string iconTooltip)
            : this()
        {
            InfoText = text;
            IconTooltip = iconTooltip;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _iconSubscription.Dispose();
                components?.Dispose();
            }

            base.Dispose(disposing);
        }

        protected override void OnResize(EventArgs e)
        {
            UpdateHeight(lbText.Text);
            UpdateIconLocation();
            base.OnResize(e);
        }

        private void UpdateHeight(string text)
        {
            using (Graphics g = CreateGraphics())
            {
                SizeF size = g.MeasureString(text, lbText.Font, lbText.Width);
                Height = (int)Math.Ceiling(size.Height) + 7;
            }
        }

        private void UpdateIconLocation()
        {
            pictureBox1.Top = Height / 2 - pictureBox1.Height / 2;
        }

        private string WrapText(string text)
        {
            string[] words = text.Split(' ');
            StringBuilder newSentence = new StringBuilder();

            string line = "";
            foreach (string word in words)
            {
                if ((line + word).Length > LineWidthLimit)
                {
                    newSentence.AppendLine(line);
                    line = "";
                }

                line += string.Format("{0} ", word);
            }

            if (line.Length > 0)
                newSentence.AppendLine(line);

            return newSentence.ToString();
        }
    }
}
