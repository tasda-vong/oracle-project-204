using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_204_oracle.Controller
{
    internal class ProductController
    {
        OracleCommand cmd = new OracleCommand();
        OracleDataAdapter da = new OracleDataAdapter();
        DataTable dt = new DataTable();


        public DataTable GetAll()
        {
            dt = new DataTable();
            cmd = new OracleCommand();


            cmd.Connection = Program.con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from v_product";
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        public int Insert(String product_name, int category_id, int supplier_id,int user_id,int is_stock,Decimal product_cost, decimal product_price, int product_status)
        {
            int x = 0;
            cmd = new OracleCommand();
            try
            {
                cmd.Connection = Program.con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into tbl_product(product_name,category_id,supplier_id,user_id,is_stock,product_cost,product_price,product_status) " +
                    "values (:product_name,:category_id,:supplier_id,:user_id,:is_stock,:product_cost,:product_price,:product_status";
                cmd.Parameters.Add(new OracleParameter("product_name", product_name));
                cmd.Parameters.Add(new OracleParameter("category_id", category_id));
                cmd.Parameters.Add(new OracleParameter("supplier_id", supplier_id));
                cmd.Parameters.Add(new OracleParameter("user_id", user_id));
                cmd.Parameters.Add(new OracleParameter("is_stock", is_stock));
                cmd.Parameters.Add(new OracleParameter("product_cost", product_cost));
                cmd.Parameters.Add(new OracleParameter("product_price", product_price));
                cmd.Parameters.Add(new OracleParameter("product_status", product_status));
                x = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                x = -1;
            }
            return x;
        }
        public int Delete(int product_id)
        {
            int s = 0;
            try
            {
                cmd.Connection = Program.con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete From tbl_product where product_id=:product_id";
                cmd.Parameters.Add(new OracleParameter("product_id", product_id));
                s = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                s = -1;
            }
            return s;
        }

        public int Update(int product_id,
            String product_name, int category_id, 
            int supplier_id, int is_stock, Decimal product_cost,
            decimal product_price, int product_status)
        {
            int x = 0;
            cmd = new OracleCommand();
            try
            {
                cmd.Connection = Program.con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update tbl_product set " +
                    "product_name=:product_name," +
                    "category_id=:category_id," +
                    "supplier_id=:supplier_id " +
                    "is_stock=:is_stock," +
                    "product_cost=:product_cost," +
                    "product_price=:product_price " +
                    "product_status=:product_status," +
                    "where product_id=:product_id ";
                cmd.Parameters.Add(new OracleParameter("product_name", product_name));
                cmd.Parameters.Add(new OracleParameter("category_id", category_id));
                cmd.Parameters.Add(new OracleParameter("supplier_id", supplier_id));
                cmd.Parameters.Add(new OracleParameter("is_stock", is_stock));
                cmd.Parameters.Add(new OracleParameter("product_cost", product_cost));
                cmd.Parameters.Add(new OracleParameter("product_price", product_price));
                cmd.Parameters.Add(new OracleParameter("product_status", product_status));
                cmd.Parameters.Add(new OracleParameter("product_id", product_id));

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
