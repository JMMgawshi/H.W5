using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMarket.libraries
{
    class DbOperations
    {

        public static DataTable getAllGoods()
        {

            DbCommand comm = DatabaseConnection.getConnection();
            comm.CommandText = "SELECT rooms as [Rooms] , teachers as [Teachers], courses as [Courses] , date as [Date] , start_time as [Start Time] , leaving_time as [Leaving Time], comment as [Comment] FROM attendance";
            DataTable table = new DataTable();
            try
            {
                comm.Connection.Open();
                DbDataReader reader = comm.ExecuteReader();
                table.Load(reader);
                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                //throw;
            }
            finally
            {
                comm.Connection.Close();
            }
            return table;
        }

        public static void addnewProduct(string productname, string qty, string price, string reg_date, string comment)
        {
            DbCommand comm = DatabaseConnection.getConnection();
            comm.CommandText = "INSERT INTO [attendance] ([Rooms], [Teachers], [Courses], [Date], [Start Time], [Leaving Time], [Comment]) VALUES (@rooms, @teachers, @courses, @date, @start_time, @leaving_time, @comment)";

            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Product_Name";
            param.Value = productname;
            param.DbType = DbType.String;
            param.Size = 100;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Quantity";
            param.Value = qty;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Price";
            param.Value = price;
            param.DbType = DbType.Int64;
            comm.Parameters.Add(param);

            /*param.DbType = DbType.Decimal;
            param.Precision = 2;
            param.Scale = 2;*/


            param = comm.CreateParameter();
            param.ParameterName = "@Date_of_Reg";
            param.Value = reg_date;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Note";
            param.Value = comment;
            param.DbType = DbType.String;
            param.Size = 200;
            comm.Parameters.Add(param);

            int affectedRows = -1;
            try
            {
                // Open the connection of the command
                comm.Connection.Open();
                // Execute the command and get the number of affected rows
                affectedRows = comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Log eventual errors and rethrow them
                //Utilities.LogError(ex);
                throw;
            }
            finally
            {
                // Close the connection
                comm.Connection.Close();
            }
 
        }

        public static void creatProduct(string productname, string qty, string price, string reg_date, string comment)
        {
            DbCommand comm = DatabaseConnection.getConnection();
            String Sql = "INSERT INTO [goods_list] ";
            Sql += "([goods_name], [QTY], [Price], [reg_date], [comment]) ";
            Sql += "VALUES ('" + productname + "'," +  qty + "," ;
            Sql += price + ",'" + reg_date + "','" +  comment +"')";
            comm.CommandText = Sql;

            //MessageBox.Show(Sql);

            int affectedRows = -1;
            try
            {
                // Open the connection of the command
                comm.Connection.Open();
                // Execute the command and get the number of affected rows
                affectedRows = comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Log eventual errors and rethrow them
                //Utilities.LogError(ex);
                throw;
            }
            finally
            {
                // Close the connection
                comm.Connection.Close();
            }

        }

        public static void creatProducts(string productname, string qty, string price, string reg_date, string comment)
        {
            DbCommand comm = DatabaseConnection.getConnection();
            String Sql = "INSERT INTO [goods_list] ";
            Sql += "([goods_name], [QTY], [Price], [reg_date],";
            Sql += "[comment]) ";
            Sql += String.Format("VALUES ('{0}',{1},{2},'{3}','{4}')", productname,qty, price,  reg_date,  comment);
            comm.CommandText = Sql;
            //MessageBox.Show(Sql);

            int affectedRows = -1;
            try
            {
                // Open the connection of the command
                comm.Connection.Open();
                // Execute the command and get the number of affected rows
                affectedRows = comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Log eventual errors and rethrow them
                //Utilities.LogError(ex);
                throw;
            }
            finally
            {
                // Close the connection
                comm.Connection.Close();
            }

        }

    }


}
