namespace POS_204_oracle
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbluser = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSale = new Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.btnProduct = new Krypton.Toolkit.KryptonButton();
            this.btnSuppler = new Krypton.Toolkit.KryptonButton();
            this.btnCategory = new Krypton.Toolkit.KryptonButton();
            this.btnUser = new Krypton.Toolkit.KryptonButton();
            this.MainTab = new Krypton.Navigator.KryptonNavigator();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainTab)).BeginInit();
            this.MainTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lbluser);
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 28);
            this.panel1.TabIndex = 0;
            // 
            // lbluser
            // 
            this.lbluser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.ForeColor = System.Drawing.Color.White;
            this.lbluser.Location = new System.Drawing.Point(390, 5);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(236, 20);
            this.lbluser.TabIndex = 2;
            this.lbluser.Text = "user";
            this.lbluser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.btnSale);
            this.panel2.Controls.Add(this.kryptonButton1);
            this.panel2.Controls.Add(this.btnProduct);
            this.panel2.Controls.Add(this.btnSuppler);
            this.panel2.Controls.Add(this.btnCategory);
            this.panel2.Controls.Add(this.btnUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(122, 422);
            this.panel2.TabIndex = 1;
            // 
            // btnSale
            // 
            this.btnSale.ButtonStyle = Krypton.Toolkit.ButtonStyle.Custom3;
            this.btnSale.Location = new System.Drawing.Point(7, 299);
            this.btnSale.Name = "btnSale";
            this.btnSale.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlackDarkMode;
            this.btnSale.Size = new System.Drawing.Size(109, 52);
            this.btnSale.StateCommon.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btnSale.StateCommon.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btnSale.StateCommon.Border.Color1 = System.Drawing.Color.SteelBlue;
            this.btnSale.StateCommon.Border.Color2 = System.Drawing.Color.SteelBlue;
            this.btnSale.StateCommon.Border.Rounding = 7F;
            this.btnSale.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btnSale.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btnSale.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSale.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSale.TabIndex = 7;
            this.btnSale.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSale.Values.Text = "Sales";
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.ButtonStyle = Krypton.Toolkit.ButtonStyle.Custom3;
            this.kryptonButton1.Location = new System.Drawing.Point(7, 183);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlackDarkMode;
            this.kryptonButton1.Size = new System.Drawing.Size(109, 52);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.SteelBlue;
            this.kryptonButton1.StateCommon.Border.Color2 = System.Drawing.Color.SteelBlue;
            this.kryptonButton1.StateCommon.Border.Rounding = 7F;
            this.kryptonButton1.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.TabIndex = 6;
            this.kryptonButton1.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton1.Values.Text = "Customer";
            // 
            // btnProduct
            // 
            this.btnProduct.ButtonStyle = Krypton.Toolkit.ButtonStyle.Custom3;
            this.btnProduct.Location = new System.Drawing.Point(7, 241);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlackDarkMode;
            this.btnProduct.Size = new System.Drawing.Size(109, 52);
            this.btnProduct.StateCommon.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btnProduct.StateCommon.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btnProduct.StateCommon.Border.Color1 = System.Drawing.Color.SteelBlue;
            this.btnProduct.StateCommon.Border.Color2 = System.Drawing.Color.SteelBlue;
            this.btnProduct.StateCommon.Border.Rounding = 7F;
            this.btnProduct.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btnProduct.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btnProduct.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnProduct.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnProduct.TabIndex = 5;
            this.btnProduct.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnProduct.Values.Text = "Product";
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnSuppler
            // 
            this.btnSuppler.ButtonStyle = Krypton.Toolkit.ButtonStyle.Custom3;
            this.btnSuppler.Location = new System.Drawing.Point(7, 125);
            this.btnSuppler.Name = "btnSuppler";
            this.btnSuppler.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlackDarkMode;
            this.btnSuppler.Size = new System.Drawing.Size(109, 52);
            this.btnSuppler.StateCommon.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btnSuppler.StateCommon.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btnSuppler.StateCommon.Border.Color1 = System.Drawing.Color.SteelBlue;
            this.btnSuppler.StateCommon.Border.Color2 = System.Drawing.Color.SteelBlue;
            this.btnSuppler.StateCommon.Border.Rounding = 7F;
            this.btnSuppler.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btnSuppler.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btnSuppler.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSuppler.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSuppler.TabIndex = 4;
            this.btnSuppler.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSuppler.Values.Text = "Supplier";
            this.btnSuppler.Click += new System.EventHandler(this.btnSuppler_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.ButtonStyle = Krypton.Toolkit.ButtonStyle.Custom3;
            this.btnCategory.Location = new System.Drawing.Point(7, 67);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlackDarkMode;
            this.btnCategory.Size = new System.Drawing.Size(109, 52);
            this.btnCategory.StateCommon.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btnCategory.StateCommon.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btnCategory.StateCommon.Border.Color1 = System.Drawing.Color.SteelBlue;
            this.btnCategory.StateCommon.Border.Color2 = System.Drawing.Color.SteelBlue;
            this.btnCategory.StateCommon.Border.Rounding = 7F;
            this.btnCategory.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btnCategory.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btnCategory.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCategory.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnCategory.TabIndex = 3;
            this.btnCategory.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnCategory.Values.Text = "Category";
            this.btnCategory.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // btnUser
            // 
            this.btnUser.ButtonStyle = Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnUser.Location = new System.Drawing.Point(7, 9);
            this.btnUser.Name = "btnUser";
            this.btnUser.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlackDarkMode;
            this.btnUser.Size = new System.Drawing.Size(109, 52);
            this.btnUser.StateCommon.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btnUser.StateCommon.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btnUser.StateCommon.Border.Color1 = System.Drawing.Color.SteelBlue;
            this.btnUser.StateCommon.Border.Color2 = System.Drawing.Color.SteelBlue;
            this.btnUser.StateCommon.Border.Rounding = 7F;
            this.btnUser.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btnUser.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btnUser.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnUser.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnUser.TabIndex = 2;
            this.btnUser.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnUser.Values.Image = global::POS_204_oracle.Properties.Resources.icons8_user_24;
            this.btnUser.Values.Text = "USER";
            this.btnUser.Click += new System.EventHandler(this.btn1_Click);
            // 
            // MainTab
            // 
            this.MainTab.ControlKryptonFormFeatures = false;
            this.MainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTab.Location = new System.Drawing.Point(122, 28);
            this.MainTab.NavigatorMode = Krypton.Navigator.NavigatorMode.BarTabGroup;
            this.MainTab.Owner = null;
            this.MainTab.PageBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelClient;
            this.MainTab.Size = new System.Drawing.Size(562, 422);
            this.MainTab.TabIndex = 2;
            this.MainTab.Text = "MainTab";
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Image = global::POS_204_oracle.Properties.Resources.icons8_minimize_window_48;
            this.btnMin.Location = new System.Drawing.Point(629, 1);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(26, 25);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 1;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = global::POS_204_oracle.Properties.Resources.icons8_close_window_48;
            this.btnExit.Location = new System.Drawing.Point(657, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 25);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.MainTab);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainTab)).EndInit();
            this.MainTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.Panel panel2;
        private Krypton.Toolkit.KryptonButton btnUser;
        private Krypton.Navigator.KryptonNavigator MainTab;
        private Krypton.Toolkit.KryptonButton btnCategory;
        private Krypton.Toolkit.KryptonButton btnSuppler;
        private System.Windows.Forms.Label lbluser;
        private Krypton.Toolkit.KryptonButton btnProduct;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonButton btnSale;
    }
}

