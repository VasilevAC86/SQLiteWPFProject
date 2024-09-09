using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Reflection;
using System.Data; // Для возможности использования типа данных DataSet

namespace SQLiteDEmo
{
    internal class DBWork
    {
        
        static public string MakeDB(string _dbname = "test02")
        {
            string result = "Ошибка чтения данных...";
            string path = $"Data Source={_dbname};";
            string init_db = "CREATE TABLE IF NOT EXISTS " +
                "Category " +
                "(id INTEGER  PRIMARY KEY AUTOINCREMENT, " +
                "Name VARCHAR);";
            string init_data = "INSERT INTO " +
                "Category" +
                "(Name) " +
                "VALUES" +
                "('SportwatchWatch');";
            string show_all_data = "SELECT * FROM Category;";
            SQLiteConnection conn = new SQLiteConnection(path);
            SQLiteCommand cmd01 = conn.CreateCommand();
            SQLiteCommand cmd02 = conn.CreateCommand();
            SQLiteCommand cmd03 = conn.CreateCommand();
            cmd01.CommandText = init_db;
            cmd02.CommandText = init_data;
            cmd03.CommandText = show_all_data;
            conn.Open();
            cmd01.ExecuteNonQuery();
            //cmd02.ExecuteNonQuery();
            var reader = cmd03.ExecuteReader();
            if (reader.HasRows)
            {
                result = " ";
                // reader.FieldCount - количество полей
                while (reader.Read())
                {
                    result += reader.GetValue(0).ToString();
                    result += " | ";
                    result += reader.GetValue(1).ToString();
                    result += "\n";
                }
            }
            conn.Close();
            return result;
        }
        static public void AddData(string _newCategoryInsert, string _dbname = "test02") 
        {
            string path = $"Data Source={_dbname}";
            // Выделяем ресурс, который должен финализироваться по завершении
            using (SQLiteConnection conn = new SQLiteConnection(path)) 
            {
                SQLiteCommand cmd = new SQLiteCommand(conn); // cmd - это ссылка                
                cmd.CommandText = _newCategoryInsert;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        static public DataSet Refresh(string _dbname = "test02")
        {
            DataSet result = new DataSet();
            string path = $"Data Source={_dbname}";
            string show_all_data = "SELECT * FROM Category;"; // SQL-запрос для вывода всех данных
            // Описываем время существования соединения (создаём соединение и финализируем его)
            using (SQLiteConnection conn = new SQLiteConnection(path)) 
            {                
                conn.Open();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(show_all_data, conn); // Создаём адаптер и наполняем его данными
                adapter.Fill(result);
            }
            return result;
        }
        static public void Save(DataTable ds, out string _query, string _dbname = "test02")
        {
            // Описание запросов (как раздел var в Pascale)
            string path = $"Data Source={_dbname}";
            string show_all_data = "SELECT * FROM Category;";
            using (SQLiteConnection conn = new SQLiteConnection(path))
            {
                conn.Open();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(show_all_data, conn);
                SQLiteCommandBuilder commandBuilder = new SQLiteCommandBuilder(adapter); // Берёт инфу о структуре таблицы
                adapter.Update(ds); // Обновляем данные
                _query = commandBuilder.GetUpdateCommand().CommandText; // Обновлённый текст
            }
        }
    }
}
