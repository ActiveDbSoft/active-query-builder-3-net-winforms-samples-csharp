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
using System.Data.OleDb;
using System.Windows.Forms;

namespace GeneralAssembly.ConnectionFrames
{
	public sealed partial class OLEDBConnectionFrame : ConnectionFrameBase
	{
		private string _connectionString;

		public override string ConnectionString
		{
			get { return GetConnectionString(); }
			set { SetConnectionString(value); }
		}

		public OLEDBConnectionFrame(string connectionString)
		{
			InitializeComponent();

			ConnectionString = connectionString;
		}

		public string GetConnectionString()
		{
			try
			{
				OleDbConnectionStringBuilder builder = new OleDbConnectionStringBuilder();
				builder.ConnectionString = tbConnectionString.Text;
				_connectionString = builder.ConnectionString;
			}
			catch
			{
			}

			return _connectionString;
		}

		public void SetConnectionString(string value)
		{
			_connectionString = value;

			if (!String.IsNullOrEmpty(_connectionString))
			{
				try
				{
					OleDbConnectionStringBuilder builder = new OleDbConnectionStringBuilder();
					builder.ConnectionString = _connectionString;
					_connectionString = builder.ConnectionString;
					tbConnectionString.Text = _connectionString;
				}
				catch
				{
				}
			}
		}

		public override bool TestConnection()
		{
			Cursor.Current = Cursors.WaitCursor;

			try
			{
				OleDbConnection connection = new OleDbConnection(ConnectionString);
				connection.Open();
				connection.Close();
			}
			catch (System.Exception e)
			{
				MessageBox.Show(e.Message, "Demo project");
				return false;
			}
			finally
			{
				Cursor.Current = Cursors.Default;
			}

			return true;
		}

		private void btnBuild_Click(object sender, EventArgs e)
		{
			// Using COM interop with the OLE DB Service Component to display the Data Link Properties dialog box.
			//
			// Add reference to the Primary Interop Assembly (PIA) for ADO provided in the file ADODB.DLL:
			// select adodb from the .NET tab in Visual Studio .NET's Add Reference Dialog. 
			// You'll also need a reference to the Microsoft OLE DB Service Component 1.0 Type Library 
			// from the COM tab in Visual Studio .NET's Add Reference Dialog.

			try
			{
				MSDASC.DataLinks dlg = new MSDASC.DataLinks();
				ADODB.Connection adodbConnection = new ADODB.Connection();
				adodbConnection.ConnectionString = _connectionString;
				object connection = adodbConnection;

				if (dlg.PromptEdit(ref connection))
				{
					_connectionString = adodbConnection.ConnectionString;
					tbConnectionString.Text = _connectionString;
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show("Failed to show OLEDB Data Link Properties dialog box.\n" +
				                "Perhaps you have no required components installed or they are outdated.\n" +
				                "Try to rebuild this demo from the source code.\n\n" +
				                exception.Message);
			}
		}
	}
}
