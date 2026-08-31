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
    public partial class uc_product : UserControl
    {



        BindingSource bs_product = new BindingSource();
        ProductController product = new ProductController();

        BindingSource bs_category = new BindingSource();
        CategoryController category = new CategoryController();


        BindingSource bs_suppler = new BindingSource();
        ProductController supplier = new ProductController();


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
        public uc_product()
        {
            InitializeComponent();
          //  pnl_2.Visible = false;
            Program.MyDG(dg_product);
            txtproid.Enabled = false;
        }

        private void materialCard2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uc_product_Load(object sender, EventArgs e)
        {
            bs_product.DataSource = product.GetAll();
            bs_category.DataSource = category.GetAll();
            bs_suppler.DataSource = supplier.GetAll();
            dg_product.DataSource = bs_product;

            txtproid.DataBindings.Add("text",bs_product, "product_id", true);
            txtproname.DataBindings.Add("text", bs_product, "product_name", true);

            cbocategoryid.DataSource = bs_category;
            cbocategoryid.DisplayMember = "category_name";
            cbocategoryid.ValueMember = "category_id";

            cbosupplierid.DataSource = bs_suppler;
            cbosupplierid.DisplayMember = "supplier_name";
            cbosupplierid.ValueMember = "supplier_id";


            cbocategoryid.DataBindings.Add("selectedvalue", bs_product, "category_id", true);
            cbosupplierid.DataBindings.Add("selectedvalue", bs_product, "supplier_id", true);



            txtprice.DataBindings.Add("value", bs_product, "product_price", true);
            txtcost.DataBindings.Add("value", bs_product, "product_cost", true);
            chkstatus.DataBindings.Add("checked", bs_product, "product_status", true);
            chkstock.DataBindings.Add("checked", bs_product, "is_stock", true);
            Program.full_dg(dg_product);





            dg_product.Columns[4].Visible = false;
            dg_product.Columns[5].Visible = false;
            dg_product.Columns[6].Visible = false;


            dg_product.Columns[0].DisplayIndex = dg_product.Columns.Count - 1;

            dg_product.Columns[1].DisplayIndex = dg_product.Columns.Count - 1;
   
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bs_product.AddNew();
            EnableBTN(true);
            chkstatus.Checked = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
