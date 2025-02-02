//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2025 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System.Drawing;
using System.Windows.Forms;
using ActiveQueryBuilder.View;
using ActiveQueryBuilder.View.CriteriaBuilder;

namespace MetadataEditorDemo.Common
{
    internal class FocuslessButton : Button, IFocuslessButton
    {
        public FocuslessButton()
        {
            SetStyle(ControlStyles.Selectable, false);
        }

        CRectangle IFocuslessButton.Bounds
        {
            get
            {
                var r = base.Bounds;
                return new CRectangle(r.X, r.Y, r.Width, r.Height);
            }
            set
            {
                CRectangle r = value;
                base.Bounds = new Rectangle((int)r.X, (int)r.Y, (int)r.Width, (int)r.Height);
            }
        }

        object IFocuslessButton.Image
        {
            get { return base.Image; }
            set { base.Image = (Image) value; }
        }
    }
}
