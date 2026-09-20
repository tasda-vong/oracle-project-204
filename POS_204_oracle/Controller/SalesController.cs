using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_204_oracle.Controller
{
    internal class SalesController
    {
        OracleCommand cmd = new OracleCommand();
        OracleDataAdapter da = new OracleDataAdapter();
        DataTable dt = new DataTable();


        public DataTable GetByDate(DateTime d1, DateTime d2)
        {
            dt = new DataTable();
            cmd = new OracleCommand();


            cmd.Connection = Program.con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM POS204.V_SALES WHERE  (SALE_DATE BETWEEN :d1 AND :d2)";
            cmd.Parameters.Add(new OracleParameter("d1", d1));
            cmd.Parameters.Add(new OracleParameter("d2", d2));
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        public DataTable GetByDateByUserID(DateTime d1, DateTime d2,int user_id)
        {
            dt = new DataTable();
            cmd = new OracleCommand();


            cmd.Connection = Program.con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT  * FROM POS204.V_SALES WHERE USER_ID = :user_id and  (SALE_DATE BETWEEN :d1 AND :d2)";
            cmd.Parameters.Add(new OracleParameter("user_id", user_id));
            cmd.Parameters.Add(new OracleParameter("d1", d1));
            cmd.Parameters.Add(new OracleParameter("d2", d2));
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }






        public int Insert(DateTime SALE_DATE,int CUSTOMER_ID,string SALE_NOTES,
            int EXCHANGE_RATE,int USER_ID,decimal SALE_SUB_TOTAL, 
            decimal SALE_DISCOUNT_AMOUNT,decimal SALE_GRAND_TOTAL, int PAID)
        {
            int x = 0;
            cmd = new OracleCommand();
            try
            {
                cmd.Connection = Program.con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO POS204.TBL_SALE (SALE_DATE, CUSTOMER_ID, SALE_NOTES, EXCHANGE_RATE, USER_ID, SALE_SUB_TOTAL, SALE_DISCOUNT_AMOUNT, SALE_GRAND_TOTAL, PAID) VALUES (:SALE_DATE, :CUSTOMER_ID, :SALE_NOTES, :EXCHANGE_RATE, :EXCHANGE_RATE, :SALE_SUB_TOTAL, :SALE_DISCOUNT_AMOUNT, :SALE_GRAND_TOTAL, :SALE_GRAND_TOTAL)";
                cmd.Parameters.Add(new OracleParameter("SALE_DATE", SALE_DATE));
                cmd.Parameters.Add(new OracleParameter("CUSTOMER_ID", CUSTOMER_ID));
                cmd.Parameters.Add(new OracleParameter("SALE_NOTES", SALE_NOTES));
                cmd.Parameters.Add(new OracleParameter("EXCHANGE_RATE", EXCHANGE_RATE));
                cmd.Parameters.Add(new OracleParameter("USER_ID", USER_ID));
                cmd.Parameters.Add(new OracleParameter("SALE_SUB_TOTAL", SALE_SUB_TOTAL));
                cmd.Parameters.Add(new OracleParameter("SALE_DISCOUNT_AMOUNT", SALE_DISCOUNT_AMOUNT));
                cmd.Parameters.Add(new OracleParameter("SALE_GRAND_TOTAL", SALE_GRAND_TOTAL));
                cmd.Parameters.Add(new OracleParameter("PAID", PAID));
                x = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                x = -1;
            }
            return x;
        }
        public int Delete(int sale_id)
        {
            int s = 0;
            try
            {
                cmd.Connection = Program.con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete From tbl_sale where sale_id=:sale_od";
                cmd.Parameters.Add(new OracleParameter("sale_od", sale_id));
                s = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                s = -1;
            }
            return s;
        }

        public int Update(int SALE_ID, DateTime SALE_DATE, int CUSTOMER_ID, string SALE_NOTES,
            int EXCHANGE_RATE, int USER_ID, decimal SALE_SUB_TOTAL,
            decimal SALE_DISCOUNT_AMOUNT, decimal SALE_GRAND_TOTAL, int PAID)
        {
            int x = 0;
            cmd = new OracleCommand();
            try
            {
                cmd.Connection = Program.con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE POS204.TBL_SALE SET  SALE_DATE = :SALE_DATE, CUSTOMER_ID = :CUSTOMER_ID, SALE_NOTES = :SALE_NOTES, EXCHANGE_RATE = :EXCHANGE_RATE, USER_ID = :EXCHANGE_RATE, SALE_SUB_TOTAL = :SALE_SUB_TOTAL,   SALE_DISCOUNT_AMOUNT = :SALE_DISCOUNT_AMOUNT, SALE_GRAND_TOTAL = :SALE_GRAND_TOTAL, PAID = :SALE_GRAND_TOTAL";
                cmd.Parameters.Add(new OracleParameter("SALE_ID", SALE_ID));
                cmd.Parameters.Add(new OracleParameter("SALE_DATE", SALE_DATE));
                cmd.Parameters.Add(new OracleParameter("CUSTOMER_ID", CUSTOMER_ID));
                cmd.Parameters.Add(new OracleParameter("SALE_NOTES", SALE_NOTES));
                cmd.Parameters.Add(new OracleParameter("EXCHANGE_RATE", EXCHANGE_RATE));
                cmd.Parameters.Add(new OracleParameter("USER_ID", USER_ID));
                cmd.Parameters.Add(new OracleParameter("SALE_SUB_TOTAL", SALE_SUB_TOTAL));
                cmd.Parameters.Add(new OracleParameter("SALE_DISCOUNT_AMOUNT", SALE_DISCOUNT_AMOUNT));
                cmd.Parameters.Add(new OracleParameter("SALE_GRAND_TOTAL", SALE_GRAND_TOTAL));
                cmd.Parameters.Add(new OracleParameter("PAID", PAID));


                x = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                x = -1;
            }
            return x;
        }
    }
}
