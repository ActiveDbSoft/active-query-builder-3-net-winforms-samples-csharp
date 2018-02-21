//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2018 Active Database Software              //
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

namespace FullFeaturedDemo.PropertiesForm
{
	internal partial class QueryPropertiesForm : Form
	{
		private readonly SqlSyntaxPage _sqlSyntaxPage;
		private readonly OfflineModePage _offlineModePage;
		private readonly GeneralPage _generalPage;
		private readonly SqlFormattingPage _mainQueryPage;
		private readonly SqlFormattingPage _derievedQueriesPage;
		private readonly SqlFormattingPage _expressionSubqueriesPage;

		private LinkLabel _currentSelectedLink;


		[DefaultValue(false)]
		[Browsable(false)]
		public bool Modified
		{
			get
			{
				return _sqlSyntaxPage.Modified || _offlineModePage.Modified || _generalPage.Modified ||
				        _mainQueryPage.Modified || _derievedQueriesPage.Modified || _expressionSubqueriesPage.Modified;
			}
			set
			{
				_sqlSyntaxPage.Modified = value;
				_offlineModePage.Modified = value;

				_generalPage.Modified = value;
				_mainQueryPage.Modified = value;
				_derievedQueriesPage.Modified = value;
				_expressionSubqueriesPage.Modified = value;
			}
		}


        public QueryPropertiesForm(SQLContext sqlContext, SQLFormattingOptions sqlFormattingOptions)
		{
			InitializeComponent();

            var syntaxProvider = sqlContext.SyntaxProvider != null
                ? sqlContext.SyntaxProvider.Clone()
                : new GenericSyntaxProvider();

            _sqlSyntaxPage = new SqlSyntaxPage(sqlContext, syntaxProvider);
            _offlineModePage = new OfflineModePage(sqlContext);


            _generalPage = new GeneralPage(sqlFormattingOptions);
            _mainQueryPage = new SqlFormattingPage(SqlBuilderOptionsPages.MainQuery, sqlFormattingOptions);
            _derievedQueriesPage = new SqlFormattingPage(SqlBuilderOptionsPages.DerievedQueries, sqlFormattingOptions);
            _expressionSubqueriesPage = new SqlFormattingPage(SqlBuilderOptionsPages.ExpressionSubqueries, sqlFormattingOptions);

			// Activate the first page
			SideMenu_LinkClicked(linkSqlSyntax, new LinkLabelLinkClickedEventArgs(linkSqlSyntax.Links[0], MouseButtons.Left));

			Application.Idle += Application_Idle;
		}

		private void Application_Idle(object sender, EventArgs e)
		{
			buttonApply.Enabled = Modified;
		}

		private void QueryBuilderPropertiesForm_Paint(object sender, PaintEventArgs e)
		{
			Rectangle r = Rectangle.Inflate(panel1.Bounds, 1, 1);

			e.Graphics.DrawRectangle(SystemPens.ControlDark, r);
		}

		private void SideMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (_currentSelectedLink != null)
				_currentSelectedLink.LinkColor = Color.Black;

			if (sender == linkSqlSyntax) SwitchPage(_sqlSyntaxPage);
			else if (sender == linkOfflineMode) SwitchPage(_offlineModePage);
			else if (sender == linkGeneral) SwitchPage(_generalPage);
			else if (sender == linkMainQuery) SwitchPage(_mainQueryPage);
			else if (sender == linkDerievedQueries) SwitchPage(_derievedQueriesPage);
			else if (sender == linkExpressionSubqueries) SwitchPage(_expressionSubqueriesPage);

			_currentSelectedLink = (LinkLabel) sender;
			_currentSelectedLink.LinkColor = Color.Blue;
		}

		private void buttonApply_Click(object sender, EventArgs e)
		{
			ApplyChanges();
		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
			ApplyChanges();
		}

		private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{
			Pen p = new Pen(SystemColors.ControlDark, 1);
			Point first = new Point(flowLayoutPanel1.ClientRectangle.Right - 1, flowLayoutPanel1.ClientRectangle.Top + 10);
			Point second = new Point(flowLayoutPanel1.ClientRectangle.Right - 1, flowLayoutPanel1.ClientRectangle.Bottom - 10);

			e.Graphics.DrawLine(p, first, second);
		}

		private void SwitchPage(UserControl page)
		{
			panelPages.SuspendLayout();
			panelPages.AutoScrollPosition = new Point(0, 0);
			panelPages.Controls.Clear();
			page.Location = new Point(10, 10);
			panelPages.Controls.Add(page);
			panelPages.ResumeLayout();
		}

	    public void ApplyChanges()
	    {
	        _sqlSyntaxPage.ApplyChanges();
	        _offlineModePage.ApplyChanges();
	        _generalPage.ApplyChanges();
	        _mainQueryPage.ApplyChanges();
	        _derievedQueriesPage.ApplyChanges();
	        _expressionSubqueriesPage.ApplyChanges();

	        Modified = false;
	    }
	}
}
