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
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;

namespace FormattingOptionsDemo.OptionsControls
{
    public partial class FormattingOptions : UserControl
    {
        private readonly Dictionary<int, object> _tabsContainer = new Dictionary<int, object>();
        private readonly IQueryController _query = new SQLQuery();

        private FormattedSQLBuilder _builder;
        private SQLFormattingOptions _sqlFormattingOptions = new SQLFormattingOptions();
        private SQLContext _sqlContext = new SQLContext();
        private UserControl _currentOptionsControl;

        private readonly MainQueryTab _mainQueryTab;
        private readonly CommonTab _mCommonTab;
        private readonly ExpressionsTab _mExpressionsTab;

        private readonly SubQueryTab _subQueryInExprTab;
        private readonly CommonTab _sCommonTab;
        private readonly ExpressionsTab _sExpressionsTab;

        private readonly SubQueryTab _derivedTab;
        private readonly CommonTab _dCommonTab;
        private readonly ExpressionsTab _dExpressionsTab;

        private readonly SubQueryTab _cteTab;
        private readonly CommonTab _cCommonTab;
        private readonly ExpressionsTab _cExpressionsTab;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public SQLFormattingOptions SqlFormattingOptions
        {
            get { return _sqlFormattingOptions; }
            set { SetOptions(value); }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public SQLContext SqlContext
        {
            get { return _sqlContext; }
            set { SetSqlContext(value); }
        }

        public event EventHandler OptionsUpdated;

        public FormattingOptions()
        {
            InitializeComponent();

            _sqlContext.SyntaxProvider = new MSSQLSyntaxProvider();
            _builder = new FormattedSQLBuilder(_sqlFormattingOptions);
            _query.SQLContext = _sqlContext;

            _sqlFormattingOptions.Updated += OnPropertyChanged;
            _query.SQLUpdated += sqlQuery1_SQLUpdated;

            _query.SQL = "With CTE1 As (Select first, second, third From Orders, Products)" +
                        "SELECT\r\n  customer.first_name,\r\n  customer.last_name,\r\n  rental.return_date\r\nFROM\r\n  customer\r\n  " +
                        "INNER JOIN rental ON rental.customer_id = customer.customer_id\r\n  INNER JOIN (SELECT\r\n      address.*\r\n   " +
                        " FROM\r\n      address\r\n      INNER JOIN city ON address.city_id = city.city_id\r\n    WHERE\r\n      city.country_id = 5)" +
                        " addr ON customer.address_id = addr.address_id\r\nWHERE\r\n  customer.store_id IN (SELECT\r\n      store.store_id\r\n    FROM\r\n     " +
                        " store\r\n    WHERE\r\n      (store.manager_staff_id = 10 AND\r\n      store.store_id < 11) OR\r\n      (((store.manager_staff_id = TRUE) OR\r\n      " +
                        "  (store.manager_staff_id BETWEEN 10 AND 20))))\r\nORDER BY\r\n  rental.return_date";

            // MainQuery options
            _mainQueryTab = new MainQueryTab(_builder) {Dock = DockStyle.Fill};
            _mCommonTab = new CommonTab(_sqlFormattingOptions, _sqlFormattingOptions.MainQueryFormat) {Dock = DockStyle.Fill};
            _mExpressionsTab = new ExpressionsTab(_sqlFormattingOptions,_sqlFormattingOptions.MainQueryFormat) {Dock = DockStyle.Fill};
            _tabsContainer.Add(0, _mainQueryTab);
            _tabsContainer.Add(1, _mCommonTab);
            _tabsContainer.Add(2, _mExpressionsTab);
            // SubQuery in expression options
            _subQueryInExprTab = new SubQueryTab(_sqlFormattingOptions) {Dock = DockStyle.Fill};
            _sCommonTab = new CommonTab(_sqlFormattingOptions, _sqlFormattingOptions.ExpressionSubQueryFormat){ Dock = DockStyle.Fill};
            _sExpressionsTab = new ExpressionsTab(_sqlFormattingOptions, _sqlFormattingOptions.ExpressionSubQueryFormat){Dock = DockStyle.Fill};
            _tabsContainer.Add(3, _subQueryInExprTab);
            _tabsContainer.Add(4, _sCommonTab);
            _tabsContainer.Add(5, _sExpressionsTab);
            // Derived tables options
            _derivedTab = new SubQueryTab(_sqlFormattingOptions, "Derived Tables") {Dock = DockStyle.Fill};
            _dCommonTab = new CommonTab(_sqlFormattingOptions, _sqlFormattingOptions.DerivedQueryFormat) {Dock = DockStyle.Fill};
            _dExpressionsTab = new ExpressionsTab(_sqlFormattingOptions, _sqlFormattingOptions.ExpressionSubQueryFormat){Dock = DockStyle.Fill};
            _tabsContainer.Add(6, _derivedTab);
            _tabsContainer.Add(7, _dCommonTab);
            _tabsContainer.Add(8, _dExpressionsTab);
            // Common table expression options
            _cteTab = new SubQueryTab(_sqlFormattingOptions, "CTE") {Dock = DockStyle.Fill};
            _cCommonTab = new CommonTab(_sqlFormattingOptions, _sqlFormattingOptions.CTESubQueryFormat) {Dock = DockStyle.Fill};
            _cExpressionsTab = new ExpressionsTab(_sqlFormattingOptions, _sqlFormattingOptions.ExpressionSubQueryFormat){Dock = DockStyle.Fill};
            _tabsContainer.Add(9, _cteTab);
            _tabsContainer.Add(10, _cCommonTab);
            _tabsContainer.Add(11, _cExpressionsTab);

            SetCurrentOptionsControl((UserControl)_tabsContainer[0]);
        }

        public void UpdateOptions()
        {
            foreach (var control in _tabsContainer.Values)
            {
                var loader = control as IOptionsLoader;
                if (loader != null) loader.LoadOptionsOnForm();
            }
            sqlTextEditor1.Text = _builder.GetSQL(_query.QueryRoot);
        }

        private void SetSqlContext(SQLContext value)
        {
            if (_sqlContext != null && _sqlContext != value)
            {
                _sqlContext = value;
            }
        }

        private void SetOptions(SQLFormattingOptions value)
        {
            if (_sqlFormattingOptions == value) return;

            _sqlFormattingOptions.Updated -= OnPropertyChanged;
            _sqlFormattingOptions.Dispose();
            _builder.Dispose();
            
            _sqlFormattingOptions = value;
            _builder = new FormattedSQLBuilder(_sqlFormattingOptions);
            SetOptionsOnChildControls();

            _sqlFormattingOptions.Updated += OnPropertyChanged;
            UpdateOptions();
        }

        private void SetOptionsOnChildControls()
        {
            // Main
            _mainQueryTab.Builder = _builder;
            _mainQueryTab.Options = SqlFormattingOptions;
 
            _mCommonTab.FormattingOptions = _sqlFormattingOptions;
            _mCommonTab.SelectFormat = _sqlFormattingOptions.MainQueryFormat;

            _mExpressionsTab.FormattingOptions = _sqlFormattingOptions;
            _mExpressionsTab.SelectFormat = _sqlFormattingOptions.MainQueryFormat;
            // SubQuery
            _subQueryInExprTab.FormattingOptions = _sqlFormattingOptions;
            _subQueryInExprTab.SelectFormat = _sqlFormattingOptions.ExpressionSubQueryFormat;

            _sCommonTab.FormattingOptions = _sqlFormattingOptions;
            _sCommonTab.SelectFormat = _sqlFormattingOptions.ExpressionSubQueryFormat;

            _sExpressionsTab.FormattingOptions = _sqlFormattingOptions;
            _sExpressionsTab.SelectFormat = _sqlFormattingOptions.ExpressionSubQueryFormat;
            // Derived
            _derivedTab.FormattingOptions = _sqlFormattingOptions;
            _derivedTab.SelectFormat = _sqlFormattingOptions.DerivedQueryFormat;

            _dCommonTab.FormattingOptions = _sqlFormattingOptions;
            _dCommonTab.SelectFormat = _sqlFormattingOptions.DerivedQueryFormat;

            _dExpressionsTab.FormattingOptions = _sqlFormattingOptions;
            _dExpressionsTab.SelectFormat = _sqlFormattingOptions.DerivedQueryFormat;
            // Cte
            _cteTab.FormattingOptions = _sqlFormattingOptions;
            _cteTab.SelectFormat = _sqlFormattingOptions.CTESubQueryFormat;

            _cCommonTab.FormattingOptions = _sqlFormattingOptions;
            _cCommonTab.SelectFormat = _sqlFormattingOptions.CTESubQueryFormat;

            _cExpressionsTab.FormattingOptions = _sqlFormattingOptions;
            _cExpressionsTab.SelectFormat = _sqlFormattingOptions.CTESubQueryFormat;
        }

        private void SetCurrentOptionsControl(UserControl control)
        {
            _currentOptionsControl = control;

            currentTabPanel.Controls.Clear();

            currentTabPanel.Controls.Add(_currentOptionsControl);

            ((IOptionsLoader)_currentOptionsControl).LoadOptionsOnForm();

            Invalidate();
        }

        private void sqlQuery1_SQLUpdated(object sender, EventArgs e)
        {
            sqlTextEditor1.Text = _builder.GetSQL(_query.QueryRoot);
        }

        private void sqlTextEditor1_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                // Update the query builder with manually edited query text:
                _query.SQL = sqlTextEditor1.Text;

                // Hide error banner if any
                ShowErrorBanner(sqlTextEditor1, "");
            }
            catch (SQLParsingException ex)
            {
                // Set caret to error position
                sqlTextEditor1.SelectionStart = ex.ErrorPos.pos;

                // Show banner with error text
                ShowErrorBanner(sqlTextEditor1, ex.Message);
                //MessageBox.Show(ex.Message);
            }
        }

        public void ShowErrorBanner(Control control, String text)
        {
            // Destory banner if already showing
            {
                Control[] banners = control.Controls.Find("ErrorBanner", true);

                if (banners.Length > 0)
                {
                    foreach (Control banner in banners)
                        banner.Dispose();
                }
            }

            // Show new banner if text is not empty
            if (!String.IsNullOrEmpty(text))
            {
                Label label = new Label
                {
                    Name = "ErrorBanner",
                    Text = text,
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.LightPink,
                    AutoSize = true,
                    Visible = true
                };

                control.Controls.Add(label);
                label.Location = new Point(control.Width - label.Width - SystemInformation.VerticalScrollBarWidth - 6, 2);
                label.BringToFront();
                control.Focus();
            }
        }

        private void OnPropertyChanged(object sender, EventArgs e)
        {
            sqlTextEditor1.Text = _builder.GetSQL(_query.QueryRoot);

            if (OptionsUpdated != null)
                OptionsUpdated.Invoke(this, EventArgs.Empty);
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Font font;
            if (e.Index == 0 || e.Index == 3 || e.Index == 6 || e.Index == 9)
                font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            else
                font = new Font("Microsoft Sans Serif", 10);

            e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), font, Brushes.Black, e.Bounds);
            e.DrawFocusRectangle();
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0) return;

            _currentOptionsControl =(UserControl) _tabsContainer[listBox1.SelectedIndex];

            SetCurrentOptionsControl(_currentOptionsControl);
        }
    }
}
