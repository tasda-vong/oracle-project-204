using MaterialSkin.Controls;
using Oracle.ManagedDataAccess.Client;
using POS_204_oracle.uc;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_204_oracle
{
    internal static class Program
    {
        public static int UserID;
        public static string UserName;
        public static string UserType;
        public static string UserPassword;



        public static OracleConnection con = new OracleConnection();
        public static void MySN(UserControl u,String msg,Color c)
        {
            MaterialSnackBar sn = new MaterialSnackBar();
            sn.Text = msg;
            sn.BackColor = c;
            sn.Show(u);
        }
        public static void OpenConnection() {
       
                con.ConnectionString = Properties.Settings.Default.con_str ;
                con.Open();
      
        }


        public static void full_dg(DataGridView dg)
        {
            int sum_col_width = 0;
            int sum_col_width_full = 0;
            for (int i = 0; i < dg.ColumnCount - 2; i++)
            {
                sum_col_width += dg.Columns[i].Width;
            }
            sum_col_width_full = sum_col_width + dg.Columns[dg.ColumnCount-1].Width;
            if (sum_col_width_full >= dg.Width)
            {
                return;
            }
            dg.Columns[dg.ColumnCount - 1].Width = dg.Width - sum_col_width - 120;
        }

        public static void MyDG(DataGridView dg) {
            dg.BorderStyle = BorderStyle.None;
            dg.BackgroundColor = Color.White;
            dg.AllowUserToAddRows = false;
            dg.AllowUserToResizeRows = false;
            dg.ReadOnly = true;
            dg.RowHeadersVisible = false;
            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg.MultiSelect = false;
            dg.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dg.RowTemplate.Height = 50;
            dg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dg.EnableHeadersVisualStyles = false;
            dg.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray;
            dg.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.DarkGray;
            dg.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dg.ColumnHeadersHeight = 40;

        }



        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                OpenConnection();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                Application.Run(new frm_login());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
 
        }
    }
}
