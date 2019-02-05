//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2019 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using ActiveQueryBuilder.View.WinForms;

namespace FullFeaturedDemo
{
	public partial class AboutForm : Form
	{
		public AboutForm()
		{
			InitializeComponent();

			lblQueryBuilderVersion.Text = "v" + typeof(QueryBuilder).Assembly.GetName().Version;
			lblDemoVersion.Text = "v" + Assembly.GetExecutingAssembly().GetName().Version;
		}

		private void linkHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://www.activequerybuilder.com/");
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://www.famfamfam.com/lab/icons/silk/");
		}
	}
}
