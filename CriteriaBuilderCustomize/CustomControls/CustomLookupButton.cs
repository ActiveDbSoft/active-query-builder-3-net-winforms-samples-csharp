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
using System.Drawing;
using System.Windows.Forms;
using ActiveQueryBuilder.View;
using ActiveQueryBuilder.View.CriteriaBuilder.CustomEditors;
using CriteriaBuilderCustomize.Properties;

namespace CriteriaBuilderCustomize.CustomControls
{
    public sealed class CustomLookupButton :Button, ICriteriaBuilderCustomLookupButton
    {
        public new Rectangle Bounds
        {
            get { return base.Bounds; }
            set
            {
                base.Bounds = new Rectangle(value.X, value.Y + (value.Height - Height) / 2, Bounds.Width,
                    Bounds.Height);
            }
        }

        CRectangle ICriteriaBuilderCustomElement.Bounds
        {
            get { return new CRectangle(Bounds.X, Bounds.Y, Bounds.Width, Bounds.Height); }
            set { Bounds = new Rectangle((int)value.X, (int)value.Y, Bounds.Width, Bounds.Height); }
        }

        public CustomLookupButton()
        {
            SetStyle(ControlStyles.Selectable, false);
            Size = new Size(30, 30);
            Margin = new Padding(0);

            BackgroundImage = Resources.icon;
            BackgroundImageLayout = ImageLayout.Zoom;
        }
    }
}
