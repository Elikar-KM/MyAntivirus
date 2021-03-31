using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;

namespace AntiLib
{
    static class DBManager
    {
        //private static string source = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\NWAntivirus\AntiDB.db";
        private static string source = @"C:\NWAntivirus\AntiDB.db";
        //private static string source;

        static DBManager()
        {
            Connect(@"D:\AntiDB.db");
        }
        static private void Connect(string source)
        {
            //source = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\NWAntivirus\AntiDB.db";
            //connection = new SqliteConnection("Data Source=" + source);
        }

        static public string[] GetObserver()
        {
            var connection = new SqliteConnection("Data Source=" + source);
            connection.Open();

            int count = 0;

            var command = connection.CreateCommand();
            command.CommandText = @"SELECT count(id) FROM observer";
            using (var reader = command.ExecuteReader())
            {
                reader.Read();
                count = Convert.ToInt32(reader.GetString(0));
            }

            command.CommandText = @"SELECT * FROM observer ";

            string[] arr = new string[count];


            using (var reader = command.ExecuteReader())
            {
                for (int i = 0; reader.Read(); i++)
                {
                    arr[i] = reader.GetString(1) + '|' + reader.GetString(2);
                }
            }

            connection.Close();
            return arr;
        }
        static public void UpdateObserver(string oldPath, string path, DateValue.Operation operation)
        {
            var connection = new SqliteConnection("Data Source=" + source);
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = $"UPDATE observer SET path='{path}', operation={(int)operation} WHERE path = '{oldPath}';";
            command.ExecuteScalar();
            connection.Close();
        }
        static public void AddObserver(string path, DateValue.Operation operation)
        {
            var connection = new SqliteConnection("Data Source=" + source);
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = $"INSERT INTO observer (path, operation) VALUES('{path}',{(int)operation});";
            command.ExecuteScalar();
            connection.Close();
        }
        static public void DeleteObserver(string path)
        {
            var connection = new SqliteConnection("Data Source=" + source);
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = $"DELETE FROM observer WHERE path='{path}'";
            command.ExecuteScalar();
            connection.Close();
        }
        static public string IsObserver(string path)
        {
            string res = "";

            var connection = new SqliteConnection("Data Source=" + source);
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = $"SELECT * FROM observer WHERE path='{path}';";
            using (var reader = command.ExecuteReader())
            {
                for (int i = 0; reader.Read(); i++)
                {
                    res = reader.GetString(1) + '|' + reader.GetString(2);
                }

            }
            connection.Close();
            return res;
        }

        static public string[] GetQuarantine()
        {
            var connection = new SqliteConnection("Data Source=" + source);
            connection.Open();
            int count = 0;

            var command = connection.CreateCommand();
            command.CommandText = @"select count(id) from (select * from quarantine GROUP BY file);";
            using (var reader = command.ExecuteReader())
            {
                reader.Read();
                count = Convert.ToInt32(reader.GetString(0));
            }

            command.CommandText = @"select * from (select * from quarantine ORDER BY ID DESC) GROUP BY file;";

            string[] arr = new string[count];


            using (var reader = command.ExecuteReader())
            {
                for (int i = 0; reader.Read(); i++)
                {
                    arr[i] = reader.GetString(1) + '|' + reader.GetString(2) + '|' + reader.GetString(3);
                }
            }

            connection.Close();
            return arr;
        }
        static public void AddQuarantine(string date, string path, string type)
        {
            var connection = new SqliteConnection("Data Source=" + source);
            connection.Open();
            try
            {
                var command = connection.CreateCommand();
                command.CommandText = $"INSERT INTO quarantine (date, file, type) VALUES('{date}','{path}','{type}');";
                command.ExecuteScalar();
            }
            catch (Exception e) { };
            connection.Close();
        }
        static public void DeleteQuarantine(string path)
        {
            var connection = new SqliteConnection("Data Source=" + source);
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = $"DELETE FROM quarantine WHERE file='{path}'";
            command.ExecuteNonQuery();
            connection.Close();
        }

        static public void AddSignature(string sign, int offsetBegin, int offsetEnd, string virusName)
        {
            var connection = new SqliteConnection("Data Source=" + source);
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = $"INSERT INTO signature (sign, offsetBegin, offsetEnd, virusName) VALUES('{sign}',{offsetBegin},{offsetEnd},'{virusName}');";
            command.ExecuteScalar();
            connection.Close();
        }
        static public List<string> GetSignature4byte()
        {
            var connection = new SqliteConnection("Data Source=" + source);
            connection.Open();

            var command = connection.CreateCommand();

            command.CommandText = @"select * from signature;";

            List<string> arr = new List<string>();


            using (var reader = command.ExecuteReader())
            {
                for (int i = 0; reader.Read(); i++)
                {
                    arr.Add(reader.GetString(1).Substring(0,8));
                }
            }

            connection.Close();
            return arr;
        }
        static public void DeleteSignature(string sign)
        {
            var connection = new SqliteConnection("Data Source=" + source);
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = $"DELETE FROM signature WHERE sign='{sign}'";
            command.ExecuteScalar();
            connection.Close();
        }
        static public List<string> SearchSignature(string sign, int pos)
        {
            var connection = new SqliteConnection("Data Source=" + source);
            connection.Open();
            var list = new List<string>();
            var command = connection.CreateCommand();
            command.CommandText = $"SELECT * FROM signature WHERE sign Like '{sign}%' AND (OffsetBegin <= {pos} OR OffsetBegin = -1) AND (OffsetEnd >= {pos}+length OR OffsetEnd = -1)";
            using (var reader = command.ExecuteReader())
            {
                for (int i = 0; reader.Read(); i++)
                {
                    list.Add(reader.GetString(1));
                }
            }
            connection.Close();
            return list;
        }

        static public string GetTypeSignature(string sign)
        {
            string res = "";

            var connection = new SqliteConnection("Data Source=" + source);
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = $"SELECT * FROM signature WHERE sign='{sign}';";
            using (var reader = command.ExecuteReader())
            {
                for (int i = 0; reader.Read(); i++)
                {
                    res = reader.GetString(5);
                }

            }
            connection.Close();
            return res;
        }

        static public string[] GetTime()
        {
            var connection = new SqliteConnection("Data Source=" + source);
            connection.Open();
            int count = 0;

            var command = connection.CreateCommand();
            command.CommandText = @"SELECT count(id) FROM time";
            using (var reader = command.ExecuteReader())
            {
                reader.Read();
                count = Convert.ToInt32(reader.GetString(0));
            }

            command.CommandText = @"SELECT * FROM time";

            string[] arr = new string[count];


            using (var reader = command.ExecuteReader())
            {
                for (int i = 0; reader.Read(); i++)
                {
                    arr[i] = reader.GetString(1) + '|' + reader.GetString(2) + '|' + reader.GetString(3);
                }
            }

            connection.Close();
            return arr;
        }

        static public void AddTime(string time, string path, DateValue.Operation oper)
        {
            var connection = new SqliteConnection("Data Source=" + source);
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = $"INSERT INTO time (time, path, operation) VALUES('{time}','{path}',{(int)oper});";
            command.ExecuteScalar();
            connection.Close();
        }

        static public string[] IsTime(string time)
        {
            var connection = new SqliteConnection("Data Source=" + source);
            connection.Open();
            int count = 0;

            var command = connection.CreateCommand();
            command.CommandText = $"SELECT count(id) FROM time WHERE time.time='{time}';";
            using (var reader = command.ExecuteReader())
            {
                reader.Read();
                count = Convert.ToInt32(reader.GetString(0));
            }

            command.CommandText = $"SELECT * FROM time WHERE time.time='{time}';";

            string[] arr = new string[count];


            using (var reader = command.ExecuteReader())
            {
                for (int i = 0; reader.Read(); i++)
                {
                    arr[i] = reader.GetString(1) + '|' + reader.GetString(2) + '|' + reader.GetString(3);
                }
            }

            connection.Close();
            return arr;
        }

        static public void DeleteTime(string time, string path)
        {
            var connection = new SqliteConnection("Data Source=" + source);
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = $"DELETE FROM time WHERE time='{time}' AND path='{path}'";
            command.ExecuteScalar();
            connection.Close();
        }

        static public string[] GetFile(int idReport)
        {
            var connection = new SqliteConnection("Data Source=" + source);
            connection.Open();
            int count = 0;

            var command = connection.CreateCommand();
            command.CommandText = $"SELECT count(id) FROM file WHERE idReport={idReport}";
            using (var reader = command.ExecuteReader())
            {
                reader.Read();
                count = Convert.ToInt32(reader.GetString(0));
            }

            command.CommandText = $"SELECT * FROM file WHERE idReport={idReport}";

            string[] arr = new string[count];


            using (var reader = command.ExecuteReader())
            {
                for (int i = 0; reader.Read(); i++)
                {
                    arr[i] = reader.GetString(1) + '|' + reader.GetString(2) + '|' + reader.GetString(3) + '|' + reader.GetString(4);
                }
            }

            connection.Close();
            return arr;
        }

        static public void AddFile(int idReport, string path, DateValue.Operation oper, string type)
        {
            var connection = new SqliteConnection("Data Source=" + source);
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = $"INSERT INTO file (idReport,path,operation,type) VALUES({idReport},'{path}',{(int)oper},'{type}');";
            command.ExecuteScalar();
            connection.Close();
        }

        static public string[] GetReport()
        {
            var connection = new SqliteConnection("Data Source=" + source);
            connection.Open();
            int count = 0;

            var command = connection.CreateCommand();
            command.CommandText = $"SELECT count(id) FROM report";
            using (var reader = command.ExecuteReader())
            {
                reader.Read();
                count = Convert.ToInt32(reader.GetString(0));
            }

            command.CommandText = @"SELECT * FROM report";

            string[] arr = new string[count];


            using (var reader = command.ExecuteReader())
            {
                for (int i = 0; reader.Read(); i++)
                {
                    arr[i] = reader.GetString(0) + '|' + reader.GetString(1) + '|' + reader.GetString(2) + '|' + reader.GetString(3) + '|' + reader.GetString(4) + '|' + reader.GetString(5);
                }
            }

            connection.Close();
            return arr;
        }

        static public int GetNextIdReport()
        {
            int res = 1;

            var connection = new SqliteConnection("Data Source=" + source);
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = $"SELECT MAX(id) FROM report;";
            using (var reader = command.ExecuteReader())
            {
                for (int i = 0; reader.Read(); i++)
                {
                    if (reader.IsDBNull(0)) break;
                    res = int.Parse(reader.GetString(0));
                    res++;
                }

            }
            connection.Close();
            return res;
        }

        static public void AddReport(int id,string dateStart, string dateEnd, string dir, int countFile, int countVirus)
        {
            var connection = new SqliteConnection("Data Source=" + source);
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = $"INSERT INTO report (id,dateStart,dateEnd,dir,countFile,countVirus) VALUES({id},'{dateStart}','{dateEnd}','{dir}',{countFile},{countVirus});";
            command.ExecuteScalar();
            connection.Close();
        }
    }
}
