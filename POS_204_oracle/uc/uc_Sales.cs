using Oracle.ManagedDataAccess.Client;
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
    public partial class uc_Sales : UserControl
    {
        SalesController sales = new SalesController();
        CustomerController customer = new CustomerController();
        CategoryController category = new CategoryController();
        ProductController product = new ProductController();
        SaleDetailController saleDetail = new SaleDetailController();
        BindingSource bs_sale = new BindingSource();
        BindingSource bs_customer = new BindingSource();
        BindingSource bs_category = new BindingSource();
        BindingSource bs_product = new BindingSource();
        BindingSource bs_saledetail = new BindingSource();









        public uc_Sales()
        {
            InitializeComponent();
            Program.MyDG(dg_sale);
            Program.MyDG(dg_category);
            Program.MyDG(dg_product);
            Program.MyDG(dg_saledetail);
            pnl_sale.Visible = false;
            txtsaleId.Enabled = false;
            pnl_sale_detail.Visible = false;

           pnl_sale.Dock = DockStyle.Fill;
            pnl_sale_detail.Dock = DockStyle.Fill;
            pnl_sale.SendToBack();
        }

        private void dg_sale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnl_sale_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNewSale_Click(object sender, EventArgs e)
        {
            bs_sale.AddNew();
            pnl_sale.Visible = true;
            pnl_left.Visible = false;
            pnl_top.Visible = false;
            pnl_data.Visible = false;
         
            dtsaleDate.Value = DateTime.Today;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            pnl_sale.Visible = false;
            pnl_left.Visible = true;
            pnl_top.Visible = true;
            pnl_data.Visible = true;
            bs_sale.CancelEdit();
        }

        private void btnShowSale_Click(object sender, EventArgs e)
        {
            if (Program.UserType == "ADMIN")
            {
               bs_customer.DataSource= sales.GetByDate(c1.SelectionStart.Date, c2.SelectionStart.Date);
            }
            else
            {
             bs_sale.DataSource=   sales.GetByDateByUserID(c1.SelectionStart.Date, c2.SelectionStart.Date,Program.UserID);
            }
        }

        private void pnl_left_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uc_Sales_Load(object sender, EventArgs e)
        {

            if (Program.UserType == "ADMIN")
            {
             bs_sale.DataSource = sales.GetByDate(c1.SelectionStart.Date, c2.SelectionStart.Date);
                pnl_user.Visible = true;
            }
            else
            {
             bs_sale.DataSource = sales.GetByDateByUserID(c1.SelectionStart.Date, c2.SelectionStart.Date, Program.UserID);
                pnl_user.Visible = false;
            }

            bs_customer.DataSource = customer.GetAll();
            bs_category.DataSource = category.GetAll();
            bs_product.DataSource = product.GetByCateID(0);
            bs_saledetail.DataSource = saleDetail.GetBySaleID(0);
            dg_category.DataSource = bs_category;
            dg_product.DataSource = bs_product;


            txtsaleId.DataBindings.Add("text",bs_sale, "sale_id", true);
            txtsaleid99.DataBindings.Add("text", bs_sale, "sale_id", true);
            cboCustomer.DataSource = bs_customer;
            cboCustomer.ValueMember = "customer_id";
            cboCustomer.DisplayMember = "customer_name";
            cboCustomer.DataBindings.Add("selectedvalue", bs_sale, "customer_id", true);

            dtsaleDate.DataBindings.Add("value", bs_sale, "sale_date", true);
            txtsalenotes.DataBindings.Add("text", bs_sale, "sale_notes", true);
            txtexhange.DataBindings.Add("text", bs_sale, "exchange_rate", true);
            txtcateid.DataBindings.Add("text", bs_category, "category_id", true);
            txtsaleid77.DataBindings.Add("text", bs_sale, "sale_id", true);
            txtproid.DataBindings.Add("text", bs_product,"product_id",true);
            txtsaleprice.DataBindings.Add("text", bs_product, "product_price",true);
            txtsaledetailid.DataBindings.Add("text", bs_saledetail, "sale_detail_id", true);
            dg_sale.DataSource = bs_sale;

            dg_saledetail.DataSource = bs_saledetail;

            dg_category.Columns[0].Visible = false;
            dg_category.Columns[2].Visible = false;
            dg_category.Columns[3].Visible = false;

            dg_product.Columns[1].Visible = false;
           dg_product.Columns[13].Visible = false;
            dg_product.Columns[3].Visible = false;
            dg_product.Columns[4].Visible = false;
            dg_product.Columns[5].Visible = false;
            dg_product.Columns[6].Visible = false;
            dg_product.Columns[7].Visible = false;
            dg_product.Columns[8].Visible = false;
            dg_product.Columns[9].Visible = false;
            dg_product.Columns[10].Visible = false;
            dg_product.Columns[11].Visible = false;
            dg_product.Columns[12].Visible = false;


            for (int i = 1; i < dg_saledetail.Columns.Count; i++)
            {
                dg_saledetail.Columns[i].Visible = false;
            }
            dg_saledetail.Columns[4].Visible = true;
            dg_saledetail.Columns[5].Visible = true;
            dg_saledetail.Columns[6].Visible = true;
            dg_saledetail.Columns[7].Visible = true;
            dg_saledetail.Columns[8].Visible = true;
            dg_saledetail.Columns[9].Visible = true;
            dg_saledetail.Columns[10].Visible = true;
    


            dg_product.Columns[4].Width = dg_product.Width - 200;

        }

        private void pnl_sale_detail_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialCard3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSaveSale_Click(object sender, EventArgs e)
        {
            int rs = 0;
            if (cboCustomer.SelectedIndex < 0)
            {
                MessageBox.Show("select customer");
                return;
            }

            if (txtsaleId.Text == "")
            {
               rs =  sales.Insert(dtsaleDate.Value,
                    Convert.ToInt32(cboCustomer.SelectedValue),
                    txtsalenotes.Text,
                    Convert.ToInt32(txtexhange.Text),Program.UserID,0,0,0,0);
            }

            if (rs > 0)
            {
                Program.MySN(this, "Sale Saved", Color.Green);

            }
            else
            {
                Program.MySN(this, "Sale error", Color.Red);
            }

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (txtsaleid99.Text == "")
            {
                MessageBox.Show("Select Sale First");
                return;
            }


            pnl_sale_detail.Visible = true;
            pnl_top.Visible = false;
            pnl_left.Visible = false;
            pnl_data.Visible = false;
        }

        private void materialCard5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dg_product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dg_category_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dg_product.Columns[1].Width = dg_product.Width - 200;
            if (txtcateid.TextLength ==0)
            {
                bs_product.DataSource = product.GetByCateID(0);
            }
            else
            {
                bs_product.DataSource = product.GetByCateID(Convert.ToInt32(txtcateid.Text));
            }
        }

        private void dg_saledetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dg_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int z = 0;
                z = saleDetail.CheckExistingSaleProduct(Convert.ToInt32(txtsaleid77.Text),
                    Convert.ToInt32(txtproid.Text)

                    );

                if (z > 0)
                {
                    saleDetail.updateProductQty(Convert.ToInt32(txtsaleid77.Text),
                     Convert.ToInt32(txtproid.Text)

                     );
                }
                else
                {
                    saleDetail.Insert
    (
        Convert.ToInt32(txtsaleid77.Text),
        Convert.ToInt32(txtproid.Text),
        1,
        Convert.ToDecimal(txtsaleprice.Text),
        0
    );
                }

                bs_saledetail.DataSource = saleDetail.GetBySaleID(Convert.ToInt32(txtsaleid77.Text));
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnl_sale_detail.Visible = false;
            pnl_top.Visible = true;
            pnl_left.Visible = true;
            pnl_data.Visible = true;
           
        }

        private void pnl_sale_detail_VisibleChanged(object sender, EventArgs e)
        {
            if (pnl_sale_detail.Visible == true)
            {
                bs_saledetail.DataSource = saleDetail.GetBySaleID(Convert.ToInt32(txtsaleid77.Text));
            }
        }

        private void dg_saledetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
           
                if (txtsaledetailid.Text == "")
                {
                    return;
                }
        
              int x =   saleDetail.DeleteRecord(Convert.ToInt32(txtsaledetailid.Text));


                bs_saledetail.DataSource = saleDetail.GetBySaleID(Convert.ToInt32(txtsaleid77.Text));
            }
        }

        private void dg_saledetail_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (txtsaledetailid.Text == "")
                {
                    return;
                }

                int x = saleDetail.DeleteRecord(Convert.ToInt32(txtsaledetailid.Text));


                bs_saledetail.DataSource = saleDetail.GetBySaleID(Convert.ToInt32(txtsaleid77.Text));
            }
        }
    }
}
