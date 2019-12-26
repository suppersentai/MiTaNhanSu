using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace MitaToll.DAL
{
	internal class Provider
	{
		private SqlConnection con;

		private SqlDataAdapter da;

		private SqlCommand cmd;

		private DataSet ds;

		protected static string strConnect;

		public static string sPass;

		public static string sUser;

		public void thu(string sql, List<SqlParameter> sqlParams)
		{
			this.connect();
			this.cmd = new SqlCommand(sql, this.con);
			if (sqlParams != null)
			{
				foreach (SqlParameter param in sqlParams)
				{
					this.cmd.Parameters.Add(param);
				}
			}
			this.cmd.ExecuteNonQuery();
			this.disconnect();
		}

		public DataTable executeNonQuerya(string spName, List<SqlParameter> sqlParams)
		{
			DataTable dt = new DataTable();
			try
			{
				this.connect();
				SqlCommand command = this.con.CreateCommand();
				command.CommandType = CommandType.StoredProcedure;
				command.CommandText = spName;
				if (sqlParams != null)
				{
					foreach (SqlParameter param in sqlParams)
					{
						command.Parameters.Add(param);
					}
				}
				new SqlDataAdapter
				{
					SelectCommand = command
				}.Fill(dt);
			}
			catch (Exception ex_95)
			{
				MessageBox.Show("Chưa kết nối tới máy chủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			return dt;
		}

		public void Procedure(string spName, List<SqlParameter> sqlParams)
		{
			try
			{
				this.connect();
				SqlCommand command = this.con.CreateCommand();
				command.CommandType = CommandType.StoredProcedure;
				command.CommandText = spName;
				if (sqlParams != null)
				{
					foreach (SqlParameter param in sqlParams)
					{
						command.Parameters.Add(param);
					}
				}
				command.ExecuteNonQuery();
				this.disconnect();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

        public int ProcedureWithReturnVal(string spName, List<SqlParameter> sqlParams)
        {
            int i = 0;
            try
            {
                this.connect();
                SqlCommand command = this.con.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = spName;
                if (sqlParams != null)
                {
                    foreach (SqlParameter param in sqlParams)
                    {
                        command.Parameters.Add(param);
                    }
                }
                i = command.ExecuteNonQuery();
                this.disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return i;
        }

        public static SqlConnection get_Connect()
		{
            Provider.strConnect = "server = "+DbConfig.DbServer+"; database = "+DbConfig.DbName+"; uid = "+DbConfig.DbUser+"; pwd = "+DbConfig.DbPass;
			SqlConnection cn = new SqlConnection(Provider.strConnect);
			cn.Open();
			return cn;
		}

		public static SqlConnection connect1()
		{
			SqlConnection result;
			while (true)
			{
				try
				{
					
						Provider.strConnect = string.Concat(new string[]
						{
							"server=",
							DbConfig.DbServer,
							";database=",
                            DbConfig.DbName,
							";integrated security = true"
						});
					SqlConnection cn = new SqlConnection(Provider.strConnect);
					cn.Open();
					result = cn;
				}
				catch
				{
					MessageBox.Show("Không tìm thấy server", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					continue;
				}
				break;
			}
			return result;
		}

		public void connect()
		{
			if (this.con == null)
			{
				this.con = Provider.get_Connect();
			}
			if (this.con.State == ConnectionState.Closed)
			{
				this.con.Open();
			}
		}

		public void disconnect()
		{
			if (this.con != null && this.con.State == ConnectionState.Open)
			{
				this.con.Close();
			}
		}

		public DataSet get(string sql)
		{
			this.connect();
			this.da = new SqlDataAdapter(sql, this.con);
			this.ds = new DataSet();
			this.da.Fill(this.ds);
			this.disconnect();
			return this.ds;
		}

		public void executeNonQuery(string sql)
		{
			this.connect();
			this.cmd = new SqlCommand(sql, this.con);
			this.cmd.ExecuteNonQuery();
			this.disconnect();
		}
	}
}
