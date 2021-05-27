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
        string role { get; set; }
        void Add(Bs_user obj);
        void Update(int id, Bs_user obj);
        bool IsExists(Bs_user obj);

    }

    public class Bs_user : IBS_user
    {
        
        public int id { get; set; }
        public string name { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string role { get; set; }

        public void Add(Bs_user obj)
        {

            string query = $"insert into bs_user(name, login, password, role) values('{obj.name}', '{obj.login}', '{obj.password}', '{obj.role}')";

            DBUtils.ExecQuery(query);

        }

        public void Update(int id, Bs_user obj)
        {

            string query = $@"

                update bs_user 

                set 

                name = '{obj.name}', 
                login = '{obj.login}', 
                password = '{obj.password}', 
                role = '{obj.role}'

                where id = {id}

            ";

            DBUtils.ExecQuery(query);

        }

        public bool IsExists(Bs_user obj)
        {

            string query = $"select * from bs_user where login = '{obj.login}'";

            return DBUtils.ExecQuery(query);

        }

    }

}
