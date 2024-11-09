using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;

namespace HRMSystem.Utilities
{
    public static class SQLHelper
    {
        //public static string ConnectionString = @"Server=DESKTOP-QVR4L71;Database=Learning;uid=sa;pwd=123@123a;";
        public static string ConnectionString = "";
        public static string LoadPath()
        {
            //string path = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True";
            //string path = @"Server=DESKTOP-QVR4L71;Database=HRMsystem;Trusted_Connection=True;";
            string path = @"Server=QUOCHA\SQLEXPRESS;Database=HRMsystem;Trusted_Connection=True;";
            return path;
        }
        public static DataTable Select(string strComm)
        {
            using (SqlConnection cnn = new SqlConnection(LoadPath()))
            {
                using (SqlCommand cmd = new SqlCommand("spSearchAllForTrans", cnn))
                {
                    cmd.CommandTimeout = 6000;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@sqlCommand", strComm));

                    try
                    {
                        cnn.Open();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataSet ds = new DataSet();
                            da.Fill(ds);
                            return ds.Tables[0];
                        }
                    }
                    catch (SqlException se)
                    {
                        // Ghi log hoặc xử lý lỗi ở đây nếu cần
                        return new DataTable();
                    }
                }
            }
        }
        public static DataTable GetDataTableFromSP(string procedureName, string[] paramName, object[] paramValue)
        {
            using (SqlConnection cnn = new SqlConnection(LoadPath()))
            {
                using (SqlCommand cmd = new SqlCommand(procedureName, cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (paramName != null)
                    {
                        for (int i = 0; i < paramName.Length; i++)
                        {
                            cmd.Parameters.Add(new SqlParameter(paramName[i], paramValue[i]));
                        }
                    }

                    try
                    {
                        cnn.Open();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataSet ds = new DataSet();
                            da.Fill(ds);
                            return ds.Tables[0];
                        }
                    }
                    catch (Exception ex)
                    {
                        // Ghi log hoặc xử lý lỗi ở đây nếu cần
                        return new DataTable();
                    }
                }
            }
        }
        public static bool ExecuteStoredProcedure(string procedureName, string[] paramName, object[] paramValue)
        {
            // Kết nối với database
            using (SqlConnection cnn = new SqlConnection(LoadPath()))
            {
                using (SqlCommand cmd = new SqlCommand(procedureName, cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm các tham số vào câu lệnh nếu có
                    if (paramName != null)
                    {
                        for (int i = 0; i < paramName.Length; i++)
                        {
                            cmd.Parameters.Add(new SqlParameter(paramName[i], paramValue[i]));
                        }
                    }

                    try
                    {
                        // Mở kết nối và thực thi stored procedure
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        return true; // Thành công
                    }
                    catch (Exception ex)
                    {
                        // Ghi log hoặc xử lý lỗi ở đây nếu cần
                        Console.WriteLine("Lỗi: " + ex.Message);
                        return false; // Thất bại
                    }
                }
            }
        }

        public static int ExecuteBatchTransaction(List<string> sqlQueries)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(LoadPath()))
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            int totalAffectedRows = 0;

                            using (SqlCommand cmd = connection.CreateCommand())
                            {
                                cmd.Transaction = transaction;

                                foreach (string sqlQuery in sqlQueries)
                                {
                                    cmd.CommandText = sqlQuery;
                                    totalAffectedRows += cmd.ExecuteNonQuery();
                                }
                            }

                            transaction.Commit();
                            return totalAffectedRows;
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            Console.WriteLine($"Transaction failed: {ex.Message}");
                            return -1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Connection failed: {ex.Message}");
                return -1;
            }
        }
        public static int BulkInsert(DataTable dataTable, string destinationTableName)
        {
            try
            {
                using (var con = new SqlConnection(LoadPath()))
                {
                    con.Open();

                    using (var transaction = con.BeginTransaction())
                    {
                        try
                        {
                            using (var bulkCopy = new SqlBulkCopy(con, SqlBulkCopyOptions.Default, transaction))
                            {
                                bulkCopy.BulkCopyTimeout = 6000;
                                bulkCopy.DestinationTableName = destinationTableName;
                                bulkCopy.BatchSize = dataTable.Rows.Count;

                                bulkCopy.ColumnMappings.Add("StartTime", "StartTime");
                                bulkCopy.ColumnMappings.Add("Account", "Account");
                                bulkCopy.ColumnMappings.Add("TimeCall", "TimeCall");
                                bulkCopy.WriteToServer(dataTable);
                            }

                            transaction.Commit();
                            return dataTable.Rows.Count;
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            //SaveToLog(ex.Message, nameof(BulkInsert), ex.StackTrace);
                            return -1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //SaveToLog(ex.Message, nameof(BulkInsert), ex.StackTrace);
                return -1;
            }
        }
        public static int ExecuteTransaction(List<string> sqlQueries)
        {
            try
            {
                using (var con = new SqlConnection(LoadPath()))
                {
                    con.Open();
                    using (var transaction = con.BeginTransaction())
                    {
                        try
                        {
                            int totalAffectedRows = 0;
                            using (var cmd = con.CreateCommand())
                            {
                                cmd.Transaction = transaction;
                                foreach (var sqlQuery in sqlQueries)
                                {
                                    cmd.CommandText = sqlQuery;
                                    totalAffectedRows += cmd.ExecuteNonQuery();
                                }

                                transaction.Commit();
                                return totalAffectedRows;
                            }
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            
                            return -1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
               
                return -1;
            }
        }
        public static DataTableCollection SelectMultiTable(string strComm)
        {
            using (SqlConnection cnn = new SqlConnection(LoadPath()))
            {
                using (SqlCommand cmd = new SqlCommand("spSearchAllForTrans", cnn))
                {
                    cmd.CommandTimeout = 6000;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@sqlCommand", strComm));

                    try
                    {
                        cnn.Open();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataSet ds = new DataSet();
                            da.Fill(ds);
                            return ds.Tables;
                        }
                    }
                    catch (SqlException se)
                    {
                        // Ghi log hoặc xử lý lỗi ở đây nếu cần
                        return null;
                    }
                }
            }
        }
        public static bool IsConnect(string connectionString)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();
                    return true;
                }
            }
            catch
            {
                // Ghi log hoặc xử lý lỗi ở đây nếu cần
                return false;
            }
        }
        public static DataTable ExecuteSelect(string query)
        {
            using (SqlConnection connection = new SqlConnection(LoadPath()))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;

                    try
                    {
                        connection.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable resultTable = new DataTable();
                            adapter.Fill(resultTable);
                            return resultTable;
                        }
                    }
                    catch (SqlException ex)
                    {
                        // Ghi log hoặc xử lý lỗi ở đây
                        Console.WriteLine("SQL Error: " + ex.Message);
                        return null;
                    }
                }
            }
        }
        public static void ExecuteNonQuery(string strSQL)
        {
            using (SqlConnection cn = new SqlConnection(LoadPath()))
            {
                using (SqlCommand cmd = new SqlCommand(strSQL, cn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandTimeout = 0;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static object ExcuteScalar(string strSQL)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(LoadPath()))
                {
                    using (SqlCommand cmd = new SqlCommand(strSQL, cn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandTimeout = 0;
                        cn.Open();
                        return cmd.ExecuteScalar();
                    }
                }
            }
            catch
            {
                // Ghi log hoặc xử lý lỗi ở đây nếu cần
                return null;
            }
        }
    }
}
