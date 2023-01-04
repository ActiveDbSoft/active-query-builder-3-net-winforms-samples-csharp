//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2023 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ActiveQueryBuilder.View;
using ActiveQueryBuilder.View.ExpressionEditor;

namespace ExpressionEditorDemo.Common
{
    internal class TreeViewMod : TreeView, ITreeViewMod
    {
        private const int WM_LBUTTONDBLCLK = 0x0203;

        public event EventHandler SuperMouseDoubleClick;

        public TreeViewMod()
        {
            SetStyle(ControlStyles.EnableNotifyMessage, true);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_LBUTTONDBLCLK)
            {
                if (SuperMouseDoubleClick != null)
                {
                    SuperMouseDoubleClick(HitTest(PointToClient(MousePosition)).Node, EventArgs.Empty);
                    return;
                }
            }
            // Workaround for Microsoft's NullReferenceException bug of TreeView in custom draw mode
            // http://www.beta.microsoft.com/VisualStudio/feedback/details/553204/treeview-nullreferenceexception-with-drawmode-ownerdraw-xxx
            else if (m.Msg == 0x204E && DrawMode != TreeViewDrawMode.Normal && !Created)
            {
                // WM_REFLECT + WM_NOTIFY
                NMHDR lParam = (NMHDR)Marshal.PtrToStructure(m.LParam, typeof(NMHDR));
                // at this time, the base WndProc will call CustomDraw which would fail
                if (lParam.code == -12)
                    return;
            }

            base.WndProc(ref m);
        }

        protected override void OnNotifyMessage(Message m)
        {
            if (m.Msg == 0x0114 /*WM_HSCROLL*/)
            {
                BeginInvoke((MethodInvoker)Refresh);
                Refresh();
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct NMHDR
        {
            public IntPtr hwndFrom;
            public IntPtr idFrom;
            public int code;
        }

        public CDragDropEffects DoDragDrop(string text, CDragDropEffects effects)
        {
            return (CDragDropEffects)DoDragDrop(text, (DragDropEffects)effects);
        }
    }
}
