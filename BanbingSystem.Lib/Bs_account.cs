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

        //todo


    }

}
