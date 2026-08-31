using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Navigator;


namespace POS_204_oracle
{
    public partial class Form1 : Form
    {
        public void AddPage2Tab(UserControl uc, String txt)
        {
           
            KryptonPage p = new KryptonPage();

            foreach (KryptonPage tp in MainTab.Pages)

            {
                if (tp.Text ==txt)
                {
                    MainTab.SelectedPage = tp;
                    return;
                }
            }
            uc.Width = MainTab.Width;
            uc.Height = MainTab.Height - 25;
            p.Text = txt;
            p.Controls.Add(uc);
            MainTab.Pages.Add(p);
            MainTab.SelectedPage = p;
        }


        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.Manual;
            this.Top = 0;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lbluser.Text = $"{Program.UserName} || {Program.UserType}";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            return;
            DialogResult rs;
            rs = MessageBox.Show("Are You Sure ?", "", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
               
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            AddPage2Tab(new uc.uc_user(), "USER");

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            AddPage2Tab(new uc.ucCategory(), "CATEGORY");
        }

        private void btnSuppler_Click(object sender, EventArgs e)
        {
            AddPage2Tab(new uc.ucSupplier(), "SUPPLIER");
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            AddPage2Tab(new uc.uc_product(), "PRODUCT");
        }
    }
}
