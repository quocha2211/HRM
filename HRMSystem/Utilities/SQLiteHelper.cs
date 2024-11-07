using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Reflection;
using System.Collections.Generic;

namespace HRMSystem.Utilities
{
    public static class SQLiteHelper
    {
        private static string LoadPath()
        {
            try
            {
                var outputDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                var templatePath = Path.Combine(outputDirectory, "LocalDB\\DB.db");
                return templatePath;
            }
            catch (Exception ex)
            {
                SaveToLog(ex.Message, nameof(LoadPath), ex.StackTrace);
                return string.Empty;
            }
        }

        public static SQLiteConnection CreateConnection()
        {
            string path = LoadPath();
            if (string.IsNullOrEmpty(path))
                throw new InvalidOperationException("Database path is not loaded properly.");

            return new SQLiteConnection($"Data Source={path};Version=3;");
        }

        // Method for executing a single SQL command without parameters
        public static int ExecuteNonQuery(string sqlQuery)
        {
            try
            {
                using (var con = CreateConnection())
                {
                    using (var cmd = new SQLiteCommand(sqlQuery, con))
                    {
                        con.Open();
                        return cmd.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception ex)
            {
                SaveToLog(ex.Message, nameof(ExecuteNonQuery), ex.StackTrace);
                return -1;
            }
        }

        // Method for executing a single SQL command with parameters
        public static int ExecuteNonQuery(string sqlQuery, List<SQLiteParameter> parameters)
        {
            try
            {
                using (var con = CreateConnection())
                {
                    using (var cmd = new SQLiteCommand(sqlQuery, con))
                    {
                        if (parameters != null)
                            cmd.Parameters.AddRange(parameters.ToArray());

                        con.Open();
                        //Trả về số dòng thay đổi
                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                SaveToLog(ex.Message, nameof(ExecuteNonQuery), ex.StackTrace);
                return -1;
            }
        }

        // Method for executing multiple SQL commands without parameters
        public static int ExecuteMultipleNonQuery(List<string> sqlQueries)
        {
            try
            {
                using (var con = CreateConnection())
                {
                    con.Open();
                    int totalAffectedRows = 0;
                    using (var cmd = con.CreateCommand())
                    {
                        foreach (var sqlQuery in sqlQueries)
                        {
                            cmd.CommandText = sqlQuery;
                            totalAffectedRows += cmd.ExecuteNonQuery();
                        }
                    }
                    return totalAffectedRows;
                }
            }
            catch (Exception ex)
            {
                SaveToLog(ex.Message, nameof(ExecuteMultipleNonQuery), ex.StackTrace);
                return -1;
            }
        }

        // Method for executing a single SQL command and returning a scalar value without parameters
        public static object ExecuteScalar(string sqlQuery)
        {
            try
            {
                //Dòng đầu tiên và cột đầu tiên
                using (var con = CreateConnection())
                {
                    using (var cmd = new SQLiteCommand(sqlQuery, con))
                    {
                        con.Open();
                        return cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                SaveToLog(ex.Message, nameof(ExecuteScalar), ex.StackTrace);
                return null;
            }
        }

        // Method for executing a single SQL command and returning a scalar value with parameters
        public static object ExecuteScalar(string sqlQuery, List<SQLiteParameter> parameters)
        {
            try
            {
                using (var con = CreateConnection())
                {
                    using (var cmd = new SQLiteCommand(sqlQuery, con))
                    {
                        if (parameters != null)
                            cmd.Parameters.AddRange(parameters.ToArray());

                        con.Open();
                        return cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                SaveToLog(ex.Message, nameof(ExecuteScalar), ex.StackTrace);
                return null;
            }
        }

        // Method for retrieving data from a SQL query without parameters
        public static DataTable GetTableData(string sqlQuery)
        {
            try
            {
                using (var con = CreateConnection())
                {
                    using (var da = new SQLiteDataAdapter(sqlQuery, con))
                    {
                        DataTable dt = new DataTable();
                        con.Open();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                SaveToLog(ex.Message, nameof(GetTableData), ex.StackTrace);
                return new DataTable();
            }
        }

        //Method for retrieving data from a SQL query with parameters
        public static DataTable GetTableData(string sqlQuery, List<SQLiteParameter> parameters)
        {
            try
            {
                using (var con = CreateConnection())
                {
                    using (var da = new SQLiteDataAdapter(sqlQuery, con))
                    {
                        if (parameters != null)
                            da.SelectCommand.Parameters.AddRange(parameters.ToArray());

                        DataTable dt = new DataTable();
                        con.Open();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                SaveToLog(ex.Message, nameof(GetTableData), ex.StackTrace);
                return new DataTable();
            }
        }

        public static int ExecuteTransaction(List<string> sqlQueries)
        {
            try
            {
                using (var con = CreateConnection())
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
                                // Tắt journaling để tăng tốc độ chèn
                                cmd.CommandText = "PRAGMA journal_mode = OFF";
                                cmd.ExecuteNonQuery();
                                // Chuẩn bị command để tăng hiệu suất
                                cmd.Prepare();
                                foreach (var sqlQuery in sqlQueries)
                                {
                                    cmd.CommandText = sqlQuery;
                                    totalAffectedRows += cmd.ExecuteNonQuery();
                                }

                                transaction.Commit();
                                // Bật lại journaling
                                cmd.CommandText = "PRAGMA journal_mode = DELETE";
                                cmd.ExecuteNonQuery();
                                return totalAffectedRows;
                            }
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            SaveToLog(ex.Message, nameof(ExecuteTransaction), ex.StackTrace);
                            return -1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                SaveToLog(ex.Message, nameof(ExecuteTransaction), ex.StackTrace);
                return -1;
            }
        }

        // Method for logging errors to the database
        public static void SaveToLog(string err, string form, string detail)
        {
            try
            {
                string sql = "INSERT INTO Log (Content, Form, Time, Detail) VALUES (@Content, @Form, @Time, @Detail)";
                var parameters = new List<SQLiteParameter>
                {
                    new SQLiteParameter("@Content", err),
                    new SQLiteParameter("@Form", form),
                    new SQLiteParameter("@Time", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")),
                    new SQLiteParameter("@Detail", detail)
                };
                ExecuteNonQuery(sql, parameters);
            }
            catch (Exception ex)
            {
                // Optional: Handle or log the error occurring in the logging process itself
            }
        }
    }
}
