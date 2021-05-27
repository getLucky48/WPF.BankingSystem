using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystem.Lib
{
    interface IBS_user
    {

        int id { get; set; }
        string name { get; set; }        
        string login { get; set; }
        string password { get; set; }
        int bs_role_id { get; set; }
        string role { get; set; }

    }

    public class Bs_user : IBS_user
    {

        public Bs_user() { }

        public int id { get; set; }
        public string name { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public int bs_role_id { get; set; }
        public string role { get; set; }

        public static void Add(Bs_user obj)
        {

            string query = $"insert into bs_user(name, login, password, role) values('{obj.name}', '{obj.login}', '{obj.password}', '{obj.bs_role_id}')";

            DBUtils.ExecQuery(query);

        }

        public static void Update(int id, Bs_user obj)
        {

            string query = $@"

                update bs_user 

                set 

                name = '{obj.name}', 
                login = '{obj.login}', 
                password = '{obj.password}', 
                role = '{obj.bs_role_id}'

                where id = {id}

            ";

            DBUtils.ExecQuery(query);

        }

        public static bool IsExists(Bs_user obj)
        {

            string query = $"select * from bs_user where login = '{obj.login}'";

            return DBUtils.ExecQuery(query);

        }

        public static List<Bs_user> GetList()
        {

            List<Bs_user> list = new List<Bs_user>();

            MySqlConnection connection = DBUtils.GetConnection();

            connection.Open();

            string query = $@"

                select 

                bsu.id,
                bsu.login,
                bsu.password,
                bsu.name,
                bsu.bs_role_id,
                bsr.name as role

                from bs_user bsu

                join bs_role bsr on bsr.id = bsu.bs_role_id


            ";

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                Bs_user user = new Bs_user()
                {
                    id = int.Parse(reader["id"].ToString()),
                    name = reader["name"].ToString(),
                    login = reader["login"].ToString(),
                    password = reader["password"].ToString(),
                    bs_role_id = int.Parse(reader["bs_role_id"].ToString()),
                    role = reader["role"].ToString()
                };

                list.Add(user);

            }

            connection.Close();

            return list;

        }

        public static bool IsAuthorized(Bs_user obj)
        {

            if (string.IsNullOrEmpty(obj.password)) { return false; }
            if (string.IsNullOrEmpty(obj.login)) { return false; }

            string query = $@"select * from bs_user where login = '{obj.login}' and password = '{obj.password}' ";

            return DBUtils.ExecQuery(query);

        }

    }

}
