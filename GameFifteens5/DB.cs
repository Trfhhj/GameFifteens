using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFifteens2
{
    public class DB
    {
        // подключились к БД
        MySqlConnection connection = new MySqlConnection("server = localhost; port = 3306; username = root; password = root; database = itproger");
        
        // соединяет с БД
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public bool IsConnectionOpen()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                return true;
            return false;   
        }

        // закрывает соединение к БД
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        //возвращает само соединение с БД
        public MySqlConnection getConnection() 
        { 
            return connection;
        }

        public bool Login(string loginUser, string passUser) 
        {
            if (string.IsNullOrEmpty(loginUser))
                return false;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            // объект для выборки данных из БД, запрос с заглушками
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP", getConnection());
            // меняем заглушки на переменные
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            // выбрали нужную команду и выполнили её, поместили внутрь объекта table
            adapter.SelectCommand = command;
            adapter.Fill(table);

            // проверяем соответствие веденных данных с данными БД
            if (table.Rows.Count > 0)
            {
                return true;
            }

            return false; 
        }
    }
}
