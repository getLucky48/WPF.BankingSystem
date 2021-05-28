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

            string query = $@"insert into bs_transaction(sum, descr, bs_account_id_src, bs_account_id_dist) 

               values({obj.sum}, '{obj.descr}', {obj.bs_account_id_src}, {obj.bs_account_id_dist})

            ";

            DBUtils.ExecQuery(query);

        }

    }

}
