using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_204_oracle.Controller
{
    internal class SaleDetailController
    {
        OracleCommand cmd = new OracleCommand();
        OracleDataAdapter da = new OracleDataAdapter();
        DataTable dt = new DataTable();

        public void updateProductQty(int sale_id, int product_id) {

     
            cmd = new OracleCommand();
        
                cmd.Connection = Program.con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update TBL_SALE_DETAIL set sale_qty=sale_qty+1 WHERE SALE_ID = :sale_id AND PRODUCT_ID = :product_id";
                cmd.Parameters.Add(new OracleParameter("sale_id", sale_id));
                cmd.Parameters.Add(new OracleParameter("product_id", product_id));
                Convert.ToInt32(cmd.ExecuteScalar());
       
        }


        

        public int CheckExistingSaleProduct(int sale_id, int product_id)
        {
            int x = 0;
            cmd = new OracleCommand();
            try
            {
                cmd.Connection = Program.con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT COUNT(*) FROM POS204.TBL_SALE_DETAIL WHERE SALE_ID = :sale_id AND PRODUCT_ID = :product_id";
                cmd.Parameters.Add(new OracleParameter("sale_id", sale_id));
                cmd.Parameters.Add(new OracleParameter("product_id", product_id));
                x = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                x = -1;
            }
            return x;
        }
        public DataTable GetAll()
        {
            dt = new DataTable();
            cmd = new OracleCommand();


            cmd.Connection = Program.con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from V_SALE_DETAIL";
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }


        public DataTable GetBySaleID(int sale_id)
        {
            dt = new DataTable();
            cmd = new OracleCommand();


            cmd.Connection = Program.con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from V_SALE_DETAIL where sale_id =:saled_id";
            cmd.Parameters.Add(new OracleParameter("category_id", sale_id));
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        public int Insert(int SALE_ID, int PRODUCT_ID,int SALE_QTY,decimal SALE_PRICE,int ITEM_DISCOUNT)
        {
            int x = 0;
            cmd = new OracleCommand();
            try
            {
                cmd.Connection = Program.con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO POS204.TBL_SALE_DETAIL (SALE_ID, PRODUCT_ID, SALE_QTY, SALE_PRICE, ITEM_DISCOUNT) VALUES  (:SALE_ID, :PRODUCT_ID, :SALE_QTY, :SALE_PRICE, :ITEM_DISCOUNT)";
                cmd.Parameters.Add(new OracleParameter("SALE_ID", SALE_ID));
                cmd.Parameters.Add(new OracleParameter("PRODUCT_ID", PRODUCT_ID));
                cmd.Parameters.Add(new OracleParameter("SALE_QTY", SALE_QTY));
                cmd.Parameters.Add(new OracleParameter("SALE_PRICE", SALE_PRICE));
                cmd.Parameters.Add(new OracleParameter("ITEM_DISCOUNT", ITEM_DISCOUNT));

                x = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                x = -1;
            }
            return x;
        }
    public int DeleteRecord(int id)
        {
            int x = 0;
            cmd = new OracleCommand();
            cmd.Connection = Program.con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from TBL_SALE_DETAIL where sale_detail_id=:id ";
            cmd.Parameters.Add(new OracleParameter("id", id));
            x = cmd.ExecuteNonQuery();
        
            


            return x;

        }
        public int Update(int SALE_DETAIL_ID, int PRODUCT_ID, int SALE_QTY, decimal SALE_PRICE, int ITEM_DISCOUNT)
        {
            int x = 0;
            cmd = new OracleCommand();
            try
            {
                cmd.Connection = Program.con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE POS204.TBL_SALE_DETAIL SET PRODUCT_ID = :PRODUCT_ID, SALE_QTY = :SALE_QTY, SALE_PRICE = :SALE_PRICE, ITEM_DISCOUNT = :ITEM_DISCOUNT WHERE (POS204.TBL_SALE_DETAIL.SALE_DETAIL_ID = :SALE_DETAIL_ID)";
                cmd.Parameters.Add(new OracleParameter("PRODUCT_ID", PRODUCT_ID));
                cmd.Parameters.Add(new OracleParameter("SALE_QTY", SALE_QTY));
                cmd.Parameters.Add(new OracleParameter("SALE_PRICE", SALE_PRICE));
                cmd.Parameters.Add(new OracleParameter("ITEM_DISCOUNT", ITEM_DISCOUNT));
                cmd.Parameters.Add(new OracleParameter("SALE_DETAIL_ID", SALE_DETAIL_ID));
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
