using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystem.Lib
{

    interface IBs_account
    {

        int id { get; set; }
        string name { get; set; }
        double sum { get; set; }
        int bs_user_id { get; set; }

    }

    public class Bs_account : IBs_account
    {

        public int id { get; set; }
        public string name { get; set; }
        public double sum { get; set; }
        public int bs_user_id { get; set; }

        public static void Add(Bs_account obj)
        {

            string query = $@"insert into bs_account(name, sum, bs_user_id) values('{Guid.NewGuid()}', '0', {obj.bs_user_id})";

            DBUtils.ExecQuery(query);

        }

        public static List<Bs_account> GetList(int bs_iser_id)
        {

            List<Bs_account> list = new List<Bs_account>();

            string query = $@"select * from bs_account where bs_user_id = '{bs_iser_id}'";

            MySqlConnection connection = DBUtils.GetConnection();

            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                Bs_account obj = new Bs_account() {

                    id = int.Parse(reader["id"].ToString()),
                    name = reader["name"].ToString(),
                    sum = double.Parse(reader["sum"].ToString()),
                    bs_user_id = bs_iser_id
                
                };

                list.Add(obj);

            }

            connection.Close();

            return list;

        }

        public static bool IsExists(Bs_account obj)
        {

            string query = $"select * from bs_account where name = '{obj.name}'";

            return DBUtils.ExecQuery(query);

        }

        public static string GetOwner(int id)
        {

            string query = $@"

                select

                bsu.* 

                from bs_account bsa

                join bs_user bsu on bsu.id = bsa.bs_user_id

                where bsa.id = {id}

            ";

            MySqlConnection connection = DBUtils.GetConnection();

            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            string owner = string.Empty;

            while (reader.Read())
            {

                owner = reader["name"].ToString();

                break;

            }

            connection.Close();

            return owner;

        }

        public static int GetID(string name)
        {

            string query = $@"select * from bs_account where name = '{name}'";

            MySqlConnection connection = DBUtils.GetConnection();

            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            int id = -1;

            while (reader.Read())
            {

                id = int.Parse(reader["id"].ToString());

            }

            connection.Close();

            return id;

        }

        public static void Deposit(int id, double sum)
        {

            double balance = GetActualBalance(id);

            string query = $"update bs_account set sum = {balance + sum} where id = {id}";

            DBUtils.ExecQuery(query);

        }

        public static void Withdraw(int id, double sum)
        {

            double balance = GetActualBalance(id);

            string query = $"update bs_account set sum = {balance - sum} where id = {id}";

            DBUtils.ExecQuery(query);

        }

        public static double GetActualBalance(int id)
        {

            string query = $@"select * from bs_account where id = {id}";

            MySqlConnection connection = DBUtils.GetConnection();

            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            double balance = 0;

            while (reader.Read())
            {

                balance = double.Parse(reader["sum"].ToString());

            }

            connection.Close();

            return balance;

        }

    }

}
