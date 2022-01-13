//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2022 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ActiveQueryBuilder.Core.PropertiesEditors;
using ActiveQueryBuilder.View.PropertiesEditors;
using MetadataEditorDemo.CollapsingControls;

namespace MetadataEditorDemo.Common
{

    internal partial class GroupContainer : CollapsingControl, IGroupContainer
    {
        public static readonly int GroupPropertyPadding = 20;
        private readonly List<IPropertyItem> _items = new List<IPropertyItem>();
        public ObjectProperties ObjectProperties { get; set; }

        public void SetEditorsOptions(PropertiesEditorsOptions options)
        {
            foreach (var editor in PropertiesEditors)
            {
                editor.SetEditorsOptions(options);
            }
        }

        public GroupContainer()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ContainerControl, true);

            CollapsingDivider = new TextCollapsingDivider();
        }

        public bool IsPrimary { get; set; }

        public override string Text
        {
            get
            {
                return ((TextCollapsingDivider) CollapsingDivider).Text;
            }
            set
            {
                ((TextCollapsingDivider) CollapsingDivider).Text = value;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if(disposing)
            {
                ObjectProperties?.Dispose();
                components?.Dispose();
            }

            base.Dispose(disposing);
        }

        public void Add(IPropertyItem editor)
        {
            Control control = editor as Control;
            if(control == null)
            {
                return;
            }
            _items.Add(editor);
            control.Padding = new Padding(control.Padding.Left + GroupPropertyPadding, control.Padding.Top, control.Padding.Right, control.Padding.Bottom);
            AddSecondaryControl(control);
        }

        public void InsertHeader(object control)
        {
            var castedControl = control as Control;
            if (castedControl == null)
                return;

            AddSecondaryControl(castedControl);
            var blankControl = secondaryPanel.Controls[0];
            blankControl.SendToBack();
            castedControl.SendToBack();
        }

        public IGroupContainer[] GroupContainers => _items.OfType<IGroupContainer>().ToArray();

        public IPropertyEditor[] PropertiesEditors
        {
            get
            {
                return _items.SelectMany(item => item.FindPropertiesEditors()).ToArray();
            }
        }
    }
}
