﻿using Core.Tools.MyMessageBox;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Mssql
{
    public static class Connection
    {
        static string _connectionStr = "Server=SUFFATECH_11003\\ATG;Database=Ymg_Franchise;User Id=gnlts;Password=123456;";
        
        public static SqlConnection getConnection(SqlConnection con)
        {
            con = new SqlConnection(_connectionStr);
            con.Open();
            return con;
        }
        public static void endConnection(SqlConnection con)
        {
            con.Dispose();
            con.Close();
        }

    }
}
