//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2022 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace GeneralAssembly.DataViewerControl
{
    public partial class PaginationPanel : UserControl
    {
        public event EventHandler EnabledPaginationChanged;
        public event EventHandler CurrentPageChanged;
        public event EventHandler PageSizeChanged;

        public bool IsSupportLimitCount
        {
            get
            {
                return tbPageSize.Visible;
            }
            set
            {
                tbPageSize.Visible = value;
                labelPageSize.Visible = value;
            }
        }

        public bool IsSupportLimitOffset
        {
            get {
                return tbCurrentPage.Visible;
            }
            set
            {
                tbCurrentPage.Visible = value;
                labelCurrentPage.Visible = value;
                btnNextPage.Visible = value;
                btnPrevPage.Visible = value;
            }
        }

        public int PageSize
        {
            get
            {
                int value;                
                return int.TryParse(tbPageSize.Text, out value) ? value : 0;
            }
            set
            {
                tbPageSize.Text = value.ToString();
            }
        }

        public int CurrentPage
        {
            get
            {
                int value;
                return int.TryParse(tbCurrentPage.Text, out value) ? value : 0;
            }
            set
            {
                tbCurrentPage.Text = value.ToString();
            }
        }

        [Browsable(false)]
        public int RowsCount { get; set; }

        public bool PaginationEnabled {
            get {
                return ceEnabled.Checked;
            }
        }

        public PaginationPanel()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            ToggleEnabled(false);
            ceEnabled.Checked = false;
            CurrentPage = 1;
            PageSize = 10;
        }

        private void ToggleEnabled(bool value)
        {
            tbCurrentPage.ReadOnly = !value;
            tbPageSize.ReadOnly = !value;
            btnNextPage.Enabled = value;
            btnPrevPage.Enabled = value;
        }

        private void intTextBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if(tb == null)
            {
                return;
            }
            int value;
            if(!int.TryParse(tb.Text, out value))
            {
                e.Cancel = true;
            }
        }

        private void ceEnabled_CheckedChanged(object sender, EventArgs e)
        {
            ToggleEnabled(ceEnabled.Checked);
            if(EnabledPaginationChanged != null)
            {
                EnabledPaginationChanged(this, e);
            }
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            int currentPage = CurrentPage;
            if(currentPage == 1)
            {
                return;
            }
            CurrentPage = currentPage - 1;
            if (CurrentPageChanged != null)
            {
                CurrentPageChanged(this, e);
            }            
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            int currentPage = CurrentPage;
            CurrentPage = currentPage + 1;
            if (CurrentPageChanged != null)
            {
                CurrentPageChanged(this, e);
            }
        }

        private void tbCurrentPage_Validated(object sender, EventArgs e)
        {
            if (CurrentPageChanged != null)
            {
                CurrentPageChanged(this, e);
            }
        }

        private void tbPageSize_Validated(object sender, EventArgs e)
        {
            if (PageSizeChanged != null)
            {
                PageSizeChanged(this, e);
            }
        }

        private void tbPageSize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Validate();
            }
        }
    }
}
