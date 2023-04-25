using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace AssignmentForm
{
    class ComparingDate
    {
        public static DateTime Dreturn;
        public static void DateCompare(ref string idbook)
        {
            AC.openConnection();
            AC.cmdSearch = new OleDbCommand("Select * From borrowbookdb where BookID=@bookid");
            AC.cmdSearch.Connection = AC.con;
            AC.cmdSearch.Parameters.AddWithValue("@bookid", idbook);
            AC.dr = AC.cmdSearch.ExecuteReader();
            if (AC.dr.Read())
            {
                Dreturn = Convert.ToDateTime(AC.dr["DateofReturn"]);
            }
            AC.dr.Close();
            //AC.con.Close();
        }
    }
}
