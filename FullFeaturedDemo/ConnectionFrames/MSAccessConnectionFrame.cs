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
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;


namespace FullFeaturedDemo.ConnectionFrames
{
	public sealed partial class MSAccessConnectionFrame : ConnectionFrameBase
	{
		private string _connectionString;
	    private string _serverType;

        private List<string> _knownAceProviders = new List<string>
        {            
            "Microsoft.ACE.OLEDB.16.0",
            "Microsoft.ACE.OLEDB.15.0",
            "Microsoft.ACE.OLEDB.14.0",
            "Microsoft.ACE.OLEDB.12.0"                                    
        };

		public override string ConnectionString
		{
			get { return GetConnectionString(); }
			set { SetConnectionString(value); }
		}

		public MSAccessConnectionFrame(string connectionString)
		{
			InitializeComponent();

			if (String.IsNullOrEmpty(connectionString))
			{
				tbUserID.Text = "Admin";
			}
			else
			{
				ConnectionString = connectionString;
			}
		}

	    public override void SetServerType(string serverType)
	    {
	        _serverType = serverType;
	    }

	    private static List<string> GetProvidersList()
	    {
	        var reader = OleDbEnumerator.GetRootEnumerator();
	        var result = new List<string>();
	        while (reader.Read())
	        {
	            for (int i = 0; i < reader.FieldCount; i++)
	            {
	                if (reader.GetName(i) == "SOURCES_NAME")
	                    result.Add(reader.GetValue(i).ToString());
	            }
	        }
            reader.Close();

	        return result;
	    }

	    private string DetectProvider()
	    {
	        var providersList = GetProvidersList();
	        var provider = string.Empty;

	        var ext = Path.GetExtension(tbDataSource.Text);
	        if (ext == ".accdb")
	        {
	            for (int i = 0; i < _knownAceProviders.Count; i++)
	            {
	                if (providersList.Contains(_knownAceProviders[i]))
	                {
	                    provider = _knownAceProviders[i];
	                    break;
	                }
	            }
				
				if (provider == string.Empty)
				{
					provider = "Microsoft.ACE.OLEDB.12.0";
				}	
	        }
	        else if (_serverType == "Access 97")
	        {
	            provider = "Microsoft.Jet.OLEDB.3.0";
	        }
	        else if (_serverType == "Access 2000 and newer")
	        {
	            for (int i = 0; i < _knownAceProviders.Count; i++)
	            {
	                if (providersList.Contains(_knownAceProviders[i]))
	                {
	                    provider = _knownAceProviders[i];
	                    break;
	                }
	            }

	            if (provider == string.Empty)
	            {
	                provider = "Microsoft.Jet.OLEDB.4.0";
	            }
	        }

	        return provider;
	    }

	    public string GetConnectionString()
		{
			try
			{
                OleDbConnectionStringBuilder builder = new OleDbConnectionStringBuilder
                {
                    ConnectionString = _connectionString,
                    DataSource = tbDataSource.Text,
                    Provider = DetectProvider()
                };

                builder["User ID"] = tbUserID.Text;
			    builder["Password"] = tbPassword.Text;			    

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

					tbDataSource.Text = builder.DataSource;
					tbUserID.Text = builder["User ID"].ToString();
					tbPassword.Text = builder["Password"].ToString();

					_connectionString = builder.ConnectionString;
				}
				catch
				{
				}
			}
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				tbDataSource.Text = openFileDialog1.FileName;
			}
		}

		private void btnEditConnectionString_Click(object sender, EventArgs e)
		{
			using (ConnectionStringEditForm csef = new ConnectionStringEditForm())
			{
				csef.ConnectionString = this.ConnectionString;

				if (csef.ShowDialog() == DialogResult.OK)
				{
					if (csef.Modified)
					{
						this.ConnectionString = csef.ConnectionString;
					}
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
				MessageBox.Show(e.Message, Program.Name);
				return false;
			}
			finally
			{
				Cursor.Current = Cursors.Default;
			}

			return true;
		}
	}
}
