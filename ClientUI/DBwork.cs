﻿using System;
using Microsoft.Data.Sqlite;

namespace ClientUI
{
    class DBwork
    {
        SqliteConnection connection;

        public enum DB { AntiDB, OptDB };

        public bool Connect(string source, DB nameDB)
        {
            try
            {
                connection = new SqliteConnection("Data Source=" + source + nameDB.ToString() + ".db");
                connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void Disconnect()
        {
            connection.Close();
        }

        public string[] getReport()
        {
            int count = 0;

            var command = connection.CreateCommand();
            command.CommandText =
                    @"
                SELECT count(id)
                FROM report
            ";
            using (var reader = command.ExecuteReader())
            {
                reader.Read();
                count = Convert.ToInt32(reader.GetString(0));
            }

            command.CommandText =
                @"
                SELECT *
                FROM report
            ";

            string[] arr = new string[count];


            using (var reader = command.ExecuteReader())
            {
                for (int i = 0; reader.Read(); i++)
                {
                    arr[i] = reader.GetString(1)+"|"+ reader.GetString(2)+"|" + reader.GetString(3) + "|" + reader.GetString(4) + "|" + reader.GetString(5);
                }
            }
            return arr;
        }

        public string[] getQuarantine()
        {
            int count = 0;

            var command = connection.CreateCommand();
            command.CommandText =
                    @"
                SELECT count(id)
                FROM quarantine
            ";
            using (var reader = command.ExecuteReader())
            {
                reader.Read();
                count = Convert.ToInt32(reader.GetString(0));
            }

            command.CommandText =
                @"
                SELECT *
                FROM quarantine
            ";

            string[] arr = new string[count];


            using (var reader = command.ExecuteReader())
            {
                for (int i = 0; reader.Read(); i++)
                {
                    arr[i] = reader.GetString(1) + "|" + reader.GetString(2) + "|" + reader.GetString(3);
                }
            }
            return arr;
        }

        public string[] getObserver(){
            int count = 0;

            var command = connection.CreateCommand();
            command.CommandText =
                    @"
                SELECT count(path)
                FROM observer
            ";
            using (var reader = command.ExecuteReader())
            {
                reader.Read();
                count = Convert.ToInt32(reader.GetString(0));
            }

            command.CommandText =
                @"
                SELECT *
                FROM observer
            ";

            string[] arr = new string[count];


            using (var reader = command.ExecuteReader())
            {
                for (int i = 0; reader.Read(); i++)
                {
                    arr[i] = reader.GetString(1);
                }
            }
            return arr;
        }

        public void getSign()
        {
            var command = connection.CreateCommand();
            command.CommandText =
                    @"
                SELECT *
                FROM virus_name
            ";

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var id = reader.GetString(0);
                    var name = reader.GetString(1);

                    Console.WriteLine($"id = {id}, name: {name}");
                }
            }
        }

        public string getVirusName(int idVirus)
        {
            return null;
        }
    }
}
