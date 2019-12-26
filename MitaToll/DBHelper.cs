using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace MitaToll.DAL
{
	internal class DBHelper
	{
		private bool connectStatus = true;

		private static SqlConnection conn = null;

		private string strConn;

		public bool ConnectStatus
		{
			get
			{
				return this.connectStatus;
			}
			set
			{
				this.connectStatus = value;
			}
		}

		public DBHelper()
		{
			try
			{
				if (DBHelper.conn == null || DBHelper.conn.State == ConnectionState.Closed)
				{
					this.initConnection();
				}
			}
			catch (SqlException e)
			{
				this.ConnectStatus = false;
				Console.WriteLine("Can not open Connection" + e.Message);
			}
		}

		public void initConnection()
		{
			
			if (DbConfig.DbUser != "" && DbConfig.DbPass != "")
			{
				this.strConn = string.Concat(new string[]
				{
					"Server ='",
					DbConfig.DbServer,
					"';Initial Catalog ='",
					DbConfig.DbName,
					"';User Id='",
					DbConfig.DbUser,
					"';pwd='",
                    DbConfig.DbPass,
					"';"
				});
			}
			else
			{
				this.strConn = string.Concat(new string[]
				{
					"Server ='",
                    DbConfig.DbServer,
					"';Initial Catalog ='",
                    DbConfig.DbName,
					"';Integrated Security=true;"
				});
			}
			DBHelper.conn = new SqlConnection(this.strConn);
			DBHelper.conn.Open();
			Console.WriteLine("Connection is opening");
		}


		public DataSet ExecuteDSQuery(string sql, List<SqlParameter> paramlist)
		{
			SqlCommand cmd = new SqlCommand();
			this.prepareCommand(cmd, sql, paramlist);
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.SelectCommand = cmd;
			DataSet dataset = new DataSet();
			adapter.Fill(dataset);
			return dataset;
		}

		protected void prepareCommand(SqlCommand cmd, string sql, List<SqlParameter> paramlist)
		{
			if (DBHelper.conn == null || DBHelper.conn.State == ConnectionState.Closed)
			{
				this.initConnection();
			}
			cmd.CommandTimeout = 1000;
			cmd.Connection = DBHelper.conn;
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = sql;
			if (paramlist != null)
			{
				foreach (SqlParameter param in paramlist)
				{
					cmd.Parameters.Add(param);
				}
			}
		}

		public SqlDataReader ExecuteQuery(string sql)
		{
			SqlDataReader reader = null;
			SqlDataReader result;
			try
			{
				SqlCommand cmd = new SqlCommand(sql, DBHelper.conn);
				reader = (result = cmd.ExecuteReader());
				return result;
			}
			catch (SqlException e)
			{
				Console.WriteLine("Can not create Command" + e.Message);
			}
			result = reader;
			return result;
		}

		public SqlDataReader ExecuteQuery(string sql, List<SqlParameter> paramlist)
		{
			SqlDataReader reader = null;
			try
			{
				SqlCommand cmd = new SqlCommand();
				this.prepareCommand(cmd, sql, paramlist);
				reader = cmd.ExecuteReader();
			}
			catch (SqlException e)
			{
				Console.WriteLine("Can not create Command" + e.Message);
			}
			return reader;
		}

		public int ExecuteNonQuery(string sql)
		{
			SqlCommand cmd = new SqlCommand(sql, DBHelper.conn);
			return cmd.ExecuteNonQuery();
		}

		public int ExecuteNonQuery(string sql, List<SqlParameter> paramlist)
		{
			SqlCommand cmd = new SqlCommand();
			this.prepareCommand(cmd, sql, paramlist);
			return cmd.ExecuteNonQuery();
		}

		public int ExecuteScalar(string sql, List<SqlParameter> paramlist)
		{
			int num = 0;
			try
			{
				SqlCommand cmd = new SqlCommand();
				this.prepareCommand(cmd, sql, paramlist);
				num = Convert.ToInt32(cmd.ExecuteScalar());
			}
			catch (SqlException e)
			{
				Console.WriteLine("Can not create Command" + e.Message);
				num = 0;
			}
			catch (InvalidCastException e2)
			{
				Console.WriteLine("Can not get Data" + e2.Message);
				num = 0;
			}
			return num;
		}

		public int ExecuteScalar(string query)
		{
			return Convert.ToInt32(new SqlCommand
			{
				CommandType = CommandType.Text,
				CommandText = query,
				Connection = DBHelper.conn
			}.ExecuteScalar());
		}

		public int FillDataTable(DataTable dt, string sql)
		{
			SqlDataAdapter da = new SqlDataAdapter(new SqlCommand
			{
				CommandType = CommandType.Text,
				CommandText = sql,
				Connection = DBHelper.conn
			});
			return da.Fill(dt);
		}

		public void Dispose()
		{
			if (DBHelper.conn != null || DBHelper.conn.State != ConnectionState.Closed)
			{
				DBHelper.conn.Close();
				this.ConnectStatus = false;
			}
		}
	}
}
