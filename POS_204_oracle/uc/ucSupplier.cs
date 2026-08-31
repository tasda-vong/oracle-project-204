using POS_204_oracle.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_204_oracle.uc
{
    public partial class ucSupplier : UserControl
    {
        SupplierController suppler = new SupplierController();
        BindingSource bs_suppler = new BindingSource();
        public ucSupplier()
        {
            InitializeComponent();
            pnl_2.Visible = false;
            Program.MyDG(dg_supplier);
            txtsupplierid.Enabled = false;
        }

        public void EnableBTN(bool b)
        {
            if (b == true)
            {
                pnl_1.Enabled = false;
                pnl_2.Visible = true;
                pnl_3.Visible = false;
            }
            else
            {
                pnl_1.Enabled = true;
                pnl_2.Visible = false;
                pnl_3.Visible = true;
            }
        }
    
        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialCard2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucSupplier_Load(object sender, EventArgs e)
        {
            bs_suppler.DataSource = suppler.GetAll();
            dg_supplier.DataSource = bs_suppler;


            dg_supplier.Columns[0].DisplayIndex = dg_supplier.ColumnCount - 1;

            dg_supplier.Columns[1].DisplayIndex = dg_supplier.ColumnCount - 1;

            Program.full_dg(dg_supplier);


        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }
    }
}
