using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace AssignmentForm
{
    class MaxBorrow
    {
        public static int BorrowLimit;
        public static int TotalBorrow;

        public static void getMaxAmount(ref string MemberID)
        {
            AC.cmd = new OleDbCommand("Select * From memberdb where member_id=@memberID", AC.con);
            AC.cmd.Connection = AC.con;
            AC.cmd.Parameters.AddWithValue("@memberID", MemberID);
            AC.dr = AC.cmd.ExecuteReader();
            if (AC.dr.Read())
            {
                BorrowLimit = Convert.ToInt32(AC.dr["max_item_allowed"]);
            }
            AC.dr.Close();
        }
        public static void getMaxAmountFromBorrowBook(ref string MemberID)
        {
            AC.cmd = new OleDbCommand("SELECT COUNT(*) FROM [borrowbookdb] WHERE MemberID=@memberID", AC.con);
            AC.cmd.Connection = AC.con;
            AC.cmd.Parameters.AddWithValue("@memberID", MemberID);
            AC.dr = AC.cmd.ExecuteReader();
            if (AC.dr.Read())
            {
                AC.dr.Close();
                TotalBorrow = Convert.ToInt32(AC.cmd.ExecuteScalar());
            }
            AC.dr.Close();
        }
    }
}
