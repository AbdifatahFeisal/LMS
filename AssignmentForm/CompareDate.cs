using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace AssignmentForm
{
    class CompareDate
    {
        public static DateTime DateReturn;
        public static void DateCompare(ref string titlebook)
        {
            AC.openConnection();
            AC.cmdSearch = new OleDbCommand("Select *  From borrowbookdb where Title=@title", AC.con);
            AC.cmdSearch.Connection = AC.con;
            AC.cmdSearch.Parameters.AddWithValue("@title", titlebook);
            AC.dr = AC.cmdSearch.ExecuteReader();
            if (AC.dr.Read())
            {
                DateReturn = Convert.ToDateTime(AC.dr["DateofReturn"]);
            }
            AC.dr.Close();
            AC.con.Close();
        }

    }
}