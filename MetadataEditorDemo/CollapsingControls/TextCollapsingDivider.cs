//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2021 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ActiveQueryBuilder.View.PropertiesEditors;

namespace MetadataEditorDemo.CollapsingControls
{
    internal partial class TextCollapsingDivider : UserControl, ICollapsingDivider
    {
        public event EventHandler<EventArgs> ButtonClick;
        private bool _canCollapse;
        private bool _isExpanded;

        public TextCollapsingDivider()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.Selectable, false);
            CanCollapse = true;

            Height = lblHeader.Height;
        }

        public bool IsExpanded
        {
            get
            {
                return _isExpanded;
            }
            set
            {
                if(_isExpanded == value || !CanCollapse)
                {
                    return;
                }
                _isExpanded = value;
                Invalidate();
            }
        }

        public bool CanCollapse
        {
            get
            {
                return _canCollapse;
            }
            set
            {
                if(_canCollapse == value)
                {
                    return;
                }
                _canCollapse = value;
                if(!value)
                {
                    pCollapse.Visible = false;
                    return;
                }
                pCollapse.Visible = true;
                Invalidate();
            }
        }

        [Browsable(true)]
        [Category("Header")]
        public override string Text
        {
            get
            {
                return lblHeader.Text;
            }
            set
            {
                lblHeader.Text = value;
            }
        }

        public new Font Font
        {
            get
            {
                return lblHeader.Font;
            }
            set
            {
                lblHeader.Font = value;
            }
        }

        [Category("Header")]
        public Image Image
        {
            get
            {
                return pbIcon.Image;
            }
            set
            {
                pbIcon.Visible = value != null;
                pbIcon.Image = value;
                Invalidate();
            }
        }

        void ICollapsingDivider.OnCollapse()
        {
            if(!IsExpanded || !CanCollapse)
            {
                return;
            }
            IsExpanded = false;
            Invalidate();
        }

        void ICollapsingDivider.OnExpand()
        {
            if(IsExpanded)
            {
                return;
            }
            IsExpanded = true;
            Invalidate();
        }

        private void pCollapse_Click(object sender, EventArgs e)
        {
            if(pCollapse.Visible)
            {
                ButtonClick?.Invoke(this, EventArgs.Empty);
            }
        }

        private void pCollapse_Paint(object sender, PaintEventArgs e)
        {
            if (!CanCollapse)
            {
                return;
            }
            float cx = pCollapse.Width / 2f;
            float cy = pCollapse.Height / 2f;
            float rad = pCollapse.Width / 4f;
            PointF[] points = IsExpanded
                ? new[]
                {
                    new PointF(cx - rad, cy - rad / 2),
                    new PointF(cx + rad, cy - rad / 2),
                    new PointF(cx, cy + rad / 2)
                }
                : new[]
                {
                    new PointF(cx - rad / 2, cy - rad),
                    new PointF(cx - rad / 2, cy + rad),
                    new PointF(cx + rad / 2, cy)
                };

            points = TranslateToRTL(points, pCollapse.Width);
            using (SolidBrush brush = new SolidBrush(Color.Black))
                e.Graphics.FillPolygon(brush, points);
        }

        private  PointF[] TranslateToRTL(PointF[] points, int rightEdge)
        {
            if (RightToLeft != RightToLeft.Yes) return points;

            var newPoints = new PointF[points.Length];

            for (int i = 0; i < points.Length; i++)
                newPoints[i] = new PointF(rightEdge - points[i].X, points[i].Y);

            return newPoints;
        }

    }
}
