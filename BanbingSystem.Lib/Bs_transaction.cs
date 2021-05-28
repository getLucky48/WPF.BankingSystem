using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystem.Lib
{

    interface IBs_transaction
    {

        int id { get; set; }
        double sum { get; set; }
        string descr { get; set; }
        int bs_account_id_src { get; set; }
        int bs_account_id_dist { get; set; }

    }

    public class Bs_transaction : IBs_transaction
    {

        public Bs_transaction() { }

        public int id { get; set; }
        public double sum { get; set; }
        public string descr { get; set; }
        public int bs_account_id_src { get; set; }
        public int bs_account_id_dist { get; set; }

        public static void Add(Bs_transaction obj)
        {

            string descr = obj.descr;
            if (string.IsNullOrEmpty(descr)) { descr = "null"; }
            else { descr = $"'{descr}'"; }

            string query = $@"insert into bs_transaction(sum, descr, bs_account_id_src, bs_account_id_dist) 

               values({obj.sum}, {descr}, {obj.bs_account_id_src}, {obj.bs_account_id_dist})

            ";

            DBUtils.ExecQuery(query);

        }

        public static List<Bs_transaction> GetList(int accountId, bool expenses)
        {

            List<Bs_transaction> list = new List<Bs_transaction>();

            string query = $@"

                select

                * 

                from bs_transaction 

                where {(expenses ? "bs_account_id_src" : "bs_account_id_dist")} = {accountId}

            ";

            MySqlConnection connection = DBUtils.GetConnection();

            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                Bs_transaction user = new Bs_transaction()
                {

                    id = int.Parse(reader["id"].ToString()),
                    sum = double.Parse(reader["sum"].ToString()),
                    descr = reader["descr"].ToString(),
                    bs_account_id_src = int.Parse(reader["bs_account_id_src"].ToString()),
                    bs_account_id_dist = int.Parse(reader["bs_account_id_dist"].ToString())

                };

                list.Add(user);

            }

            connection.Close();

            return list;

        }

    }

}
