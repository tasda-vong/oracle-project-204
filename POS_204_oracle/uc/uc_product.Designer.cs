namespace POS_204_oracle.uc
{
    partial class uc_product
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_1 = new System.Windows.Forms.Panel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNew = new Krypton.Toolkit.KryptonButton();
            this.txtid = new System.Windows.Forms.TextBox();
            this.pnl_2 = new System.Windows.Forms.Panel();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.chkstock = new System.Windows.Forms.CheckBox();
            this.txtproname = new Krypton.Toolkit.KryptonTextBox();
            this.txtproid = new Krypton.Toolkit.KryptonTextBox();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.btnClose = new Krypton.Toolkit.KryptonButton();
            this.pnl_3 = new System.Windows.Forms.Panel();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.dg_product = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.cbocategoryid = new Krypton.Toolkit.KryptonComboBox();
            this.cbosupplierid = new Krypton.Toolkit.KryptonComboBox();
            this.txtcost = new Krypton.Toolkit.KryptonNumericUpDown();
            this.txtprice = new Krypton.Toolkit.KryptonNumericUpDown();
            this.chkstatus = new System.Windows.Forms.CheckBox();
            this.pnl_1.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.pnl_2.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.pnl_3.SuspendLayout();
            this.materialCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbocategoryid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbosupplierid)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_1
            // 
            this.pnl_1.Controls.Add(this.materialCard1);
            this.pnl_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_1.Location = new System.Drawing.Point(0, 0);
            this.pnl_1.Name = "pnl_1";
            this.pnl_1.Size = new System.Drawing.Size(728, 67);
            this.pnl_1.TabIndex = 2;
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.label1);
            this.materialCard1.Controls.Add(this.btnNew);
            this.materialCard1.Controls.Add(this.txtid);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(14, 6);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(700, 54);
            this.materialCard1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "MANAGE PRODUCT";
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.ButtonStyle = Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnNew.Location = new System.Drawing.Point(540, 9);
            this.btnNew.Name = "btnNew";
            this.btnNew.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlackDarkMode;
            this.btnNew.Size = new System.Drawing.Size(143, 36);
            this.btnNew.StateCommon.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btnNew.StateCommon.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btnNew.StateCommon.Border.Color1 = System.Drawing.Color.SteelBlue;
            this.btnNew.StateCommon.Border.Color2 = System.Drawing.Color.SteelBlue;
            this.btnNew.StateCommon.Border.Rounding = 7F;
            this.btnNew.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btnNew.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btnNew.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnNew.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnNew.TabIndex = 3;
            this.btnNew.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnNew.Values.Image = global::POS_204_oracle.Properties.Resources.icons8_user_24;
            this.btnNew.Values.Text = "New Product";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(47, 19);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 5;
            // 
            // pnl_2
            // 
            this.pnl_2.Controls.Add(this.materialCard2);
            this.pnl_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_2.Location = new System.Drawing.Point(0, 67);
            this.pnl_2.Name = "pnl_2";
            this.pnl_2.Size = new System.Drawing.Size(728, 262);
            this.pnl_2.TabIndex = 3;
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.chkstatus);
            this.materialCard2.Controls.Add(this.txtprice);
            this.materialCard2.Controls.Add(this.txtcost);
            this.materialCard2.Controls.Add(this.cbosupplierid);
            this.materialCard2.Controls.Add(this.cbocategoryid);
            this.materialCard2.Controls.Add(this.chkstock);
            this.materialCard2.Controls.Add(this.txtproname);
            this.materialCard2.Controls.Add(this.txtproid);
            this.materialCard2.Controls.Add(this.btnSave);
            this.materialCard2.Controls.Add(this.btnClose);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(14, 6);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(700, 249);
            this.materialCard2.TabIndex = 0;
            this.materialCard2.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard2_Paint);
            // 
            // chkstock
            // 
            this.chkstock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkstock.AutoSize = true;
            this.chkstock.Location = new System.Drawing.Point(374, 106);
            this.chkstock.Name = "chkstock";
            this.chkstock.Size = new System.Drawing.Size(65, 17);
            this.chkstock.TabIndex = 11;
            this.chkstock.Text = "Is Stock";
            this.chkstock.UseVisualStyleBackColor = true;
            // 
            // txtproname
            // 
            this.txtproname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtproname.Location = new System.Drawing.Point(74, 64);
            this.txtproname.Name = "txtproname";
            this.txtproname.Size = new System.Drawing.Size(284, 27);
            this.txtproname.StateCommon.Border.Rounding = 7F;
            this.txtproname.TabIndex = 7;
            this.txtproname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtproid
            // 
            this.txtproid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtproid.Location = new System.Drawing.Point(74, 31);
            this.txtproid.Name = "txtproid";
            this.txtproid.Size = new System.Drawing.Size(284, 27);
            this.txtproid.StateCommon.Border.Rounding = 7F;
            this.txtproid.TabIndex = 6;
            this.txtproid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.ButtonStyle = Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnSave.Location = new System.Drawing.Point(275, 189);
            this.btnSave.Name = "btnSave";
            this.btnSave.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlackDarkMode;
            this.btnSave.Size = new System.Drawing.Size(83, 36);
            this.btnSave.StateCommon.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btnSave.StateCommon.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btnSave.StateCommon.Border.Color1 = System.Drawing.Color.SteelBlue;
            this.btnSave.StateCommon.Border.Color2 = System.Drawing.Color.SteelBlue;
            this.btnSave.StateCommon.Border.Rounding = 7F;
            this.btnSave.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btnSave.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btnSave.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSave.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSave.TabIndex = 5;
            this.btnSave.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClose.ButtonStyle = Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnClose.Location = new System.Drawing.Point(364, 189);
            this.btnClose.Name = "btnClose";
            this.btnClose.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlackDarkMode;
            this.btnClose.Size = new System.Drawing.Size(87, 36);
            this.btnClose.StateCommon.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btnClose.StateCommon.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btnClose.StateCommon.Border.Color1 = System.Drawing.Color.SteelBlue;
            this.btnClose.StateCommon.Border.Color2 = System.Drawing.Color.SteelBlue;
            this.btnClose.StateCommon.Border.Rounding = 7F;
            this.btnClose.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btnClose.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btnClose.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnClose.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnClose.TabIndex = 4;
            this.btnClose.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnClose.Values.Text = "Cancel";
            // 
            // pnl_3
            // 
            this.pnl_3.Controls.Add(this.materialCard3);
            this.pnl_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_3.Location = new System.Drawing.Point(0, 329);
            this.pnl_3.Name = "pnl_3";
            this.pnl_3.Size = new System.Drawing.Size(728, 188);
            this.pnl_3.TabIndex = 4;
            // 
            // materialCard3
            // 
            this.materialCard3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.dg_product);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(14, 6);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(700, 175);
            this.materialCard3.TabIndex = 0;
            // 
            // dg_product
            // 
            this.dg_product.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dg_product.Location = new System.Drawing.Point(17, 17);
            this.dg_product.Name = "dg_product";
            this.dg_product.RowHeadersWidth = 82;
            this.dg_product.Size = new System.Drawing.Size(666, 152);
            this.dg_product.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Edit";
            this.Column1.Image = global::POS_204_oracle.Properties.Resources.icons8_edit_30;
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Dlete";
            this.Column2.Image = global::POS_204_oracle.Properties.Resources.icons8_trash_24;
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 50;
            // 
            // cbocategoryid
            // 
            this.cbocategoryid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbocategoryid.Location = new System.Drawing.Point(74, 97);
            this.cbocategoryid.Name = "cbocategoryid";
            this.cbocategoryid.Size = new System.Drawing.Size(283, 26);
            this.cbocategoryid.StateCommon.ComboBox.Border.Rounding = 7F;
            this.cbocategoryid.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbocategoryid.TabIndex = 12;
            // 
            // cbosupplierid
            // 
            this.cbosupplierid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbosupplierid.Location = new System.Drawing.Point(75, 129);
            this.cbosupplierid.Name = "cbosupplierid";
            this.cbosupplierid.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.cbosupplierid.Size = new System.Drawing.Size(283, 26);
            this.cbosupplierid.StateCommon.ComboBox.Border.Rounding = 7F;
            this.cbosupplierid.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbosupplierid.TabIndex = 13;
            // 
            // txtcost
            // 
            this.txtcost.AllowDecimals = true;
            this.txtcost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtcost.DecimalPlaces = 2;
            this.txtcost.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtcost.Location = new System.Drawing.Point(374, 32);
            this.txtcost.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txtcost.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtcost.Name = "txtcost";
            this.txtcost.Size = new System.Drawing.Size(245, 26);
            this.txtcost.StateCommon.Border.Rounding = 5F;
            this.txtcost.TabIndex = 14;
            this.txtcost.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // txtprice
            // 
            this.txtprice.AllowDecimals = true;
            this.txtprice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtprice.DecimalPlaces = 2;
            this.txtprice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtprice.Location = new System.Drawing.Point(374, 64);
            this.txtprice.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txtprice.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(245, 26);
            this.txtprice.StateCommon.Border.Rounding = 5F;
            this.txtprice.TabIndex = 15;
            this.txtprice.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // chkstatus
            // 
            this.chkstatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkstatus.AutoSize = true;
            this.chkstatus.Location = new System.Drawing.Point(374, 138);
            this.chkstatus.Name = "chkstatus";
            this.chkstatus.Size = new System.Drawing.Size(56, 17);
            this.chkstatus.TabIndex = 16;
            this.chkstatus.Text = "Active";
            this.chkstatus.UseVisualStyleBackColor = true;
            // 
            // uc_product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_3);
            this.Controls.Add(this.pnl_2);
            this.Controls.Add(this.pnl_1);
            this.Name = "uc_product";
            this.Size = new System.Drawing.Size(728, 517);
            this.Load += new System.EventHandler(this.uc_product_Load);
            this.pnl_1.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.pnl_2.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.pnl_3.ResumeLayout(false);
            this.materialCard3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbocategoryid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbosupplierid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.Label label1;
        private Krypton.Toolkit.KryptonButton btnNew;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Panel pnl_2;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.CheckBox chkstock;
        private Krypton.Toolkit.KryptonTextBox txtproname;
        private Krypton.Toolkit.KryptonTextBox txtproid;
        private Krypton.Toolkit.KryptonButton btnSave;
        private Krypton.Toolkit.KryptonButton btnClose;
        private System.Windows.Forms.Panel pnl_3;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private System.Windows.Forms.DataGridView dg_product;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private Krypton.Toolkit.KryptonComboBox cbocategoryid;
        private Krypton.Toolkit.KryptonComboBox cbosupplierid;
        private System.Windows.Forms.CheckBox chkstatus;
        private Krypton.Toolkit.KryptonNumericUpDown txtprice;
        private Krypton.Toolkit.KryptonNumericUpDown txtcost;
    }
}
