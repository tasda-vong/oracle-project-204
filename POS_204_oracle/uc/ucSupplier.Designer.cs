namespace POS_204_oracle.uc
{
    partial class ucSupplier
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
            this.txtsupplernotes = new Krypton.Toolkit.KryptonTextBox();
            this.txtsuppliercontact = new Krypton.Toolkit.KryptonTextBox();
            this.txtsupplername = new Krypton.Toolkit.KryptonTextBox();
            this.txtsupplierid = new Krypton.Toolkit.KryptonTextBox();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.btnClose = new Krypton.Toolkit.KryptonButton();
            this.pnl_3 = new System.Windows.Forms.Panel();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.dg_supplier = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnl_1.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.pnl_2.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.pnl_3.SuspendLayout();
            this.materialCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_supplier)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_1
            // 
            this.pnl_1.Controls.Add(this.materialCard1);
            this.pnl_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_1.Location = new System.Drawing.Point(0, 0);
            this.pnl_1.Name = "pnl_1";
            this.pnl_1.Size = new System.Drawing.Size(711, 67);
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
            this.materialCard1.Size = new System.Drawing.Size(683, 54);
            this.materialCard1.TabIndex = 0;
            this.materialCard1.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "MANAGE SUPPLIER";
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.ButtonStyle = Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnNew.Location = new System.Drawing.Point(523, 9);
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
            this.btnNew.Values.Text = "New Supplier";
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
            this.pnl_2.Size = new System.Drawing.Size(711, 225);
            this.pnl_2.TabIndex = 3;
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.txtsupplernotes);
            this.materialCard2.Controls.Add(this.txtsuppliercontact);
            this.materialCard2.Controls.Add(this.txtsupplername);
            this.materialCard2.Controls.Add(this.txtsupplierid);
            this.materialCard2.Controls.Add(this.btnSave);
            this.materialCard2.Controls.Add(this.btnClose);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(14, 6);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(683, 212);
            this.materialCard2.TabIndex = 0;
            this.materialCard2.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard2_Paint);
            // 
            // txtsupplernotes
            // 
            this.txtsupplernotes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtsupplernotes.Location = new System.Drawing.Point(203, 125);
            this.txtsupplernotes.Name = "txtsupplernotes";
            this.txtsupplernotes.Size = new System.Drawing.Size(284, 27);
            this.txtsupplernotes.StateCommon.Border.Rounding = 7F;
            this.txtsupplernotes.TabIndex = 9;
            this.txtsupplernotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtsuppliercontact
            // 
            this.txtsuppliercontact.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtsuppliercontact.Location = new System.Drawing.Point(203, 92);
            this.txtsuppliercontact.Name = "txtsuppliercontact";
            this.txtsuppliercontact.Size = new System.Drawing.Size(284, 27);
            this.txtsuppliercontact.StateCommon.Border.Rounding = 7F;
            this.txtsuppliercontact.TabIndex = 8;
            this.txtsuppliercontact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtsupplername
            // 
            this.txtsupplername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtsupplername.Location = new System.Drawing.Point(203, 59);
            this.txtsupplername.Name = "txtsupplername";
            this.txtsupplername.Size = new System.Drawing.Size(284, 27);
            this.txtsupplername.StateCommon.Border.Rounding = 7F;
            this.txtsupplername.TabIndex = 7;
            this.txtsupplername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtsupplierid
            // 
            this.txtsupplierid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtsupplierid.Location = new System.Drawing.Point(203, 26);
            this.txtsupplierid.Name = "txtsupplierid";
            this.txtsupplierid.Size = new System.Drawing.Size(284, 27);
            this.txtsupplierid.StateCommon.Border.Rounding = 7F;
            this.txtsupplierid.TabIndex = 6;
            this.txtsupplierid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.ButtonStyle = Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnSave.Location = new System.Drawing.Point(251, 159);
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
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClose.ButtonStyle = Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnClose.Location = new System.Drawing.Point(340, 159);
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
            this.pnl_3.Location = new System.Drawing.Point(0, 292);
            this.pnl_3.Name = "pnl_3";
            this.pnl_3.Size = new System.Drawing.Size(711, 202);
            this.pnl_3.TabIndex = 4;
            // 
            // materialCard3
            // 
            this.materialCard3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.dg_supplier);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(14, 6);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(683, 189);
            this.materialCard3.TabIndex = 0;
            // 
            // dg_supplier
            // 
            this.dg_supplier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_supplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_supplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dg_supplier.Location = new System.Drawing.Point(17, 17);
            this.dg_supplier.Name = "dg_supplier";
            this.dg_supplier.RowHeadersWidth = 82;
            this.dg_supplier.Size = new System.Drawing.Size(649, 166);
            this.dg_supplier.TabIndex = 0;
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
            // ucSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_3);
            this.Controls.Add(this.pnl_2);
            this.Controls.Add(this.pnl_1);
            this.Name = "ucSupplier";
            this.Size = new System.Drawing.Size(711, 494);
            this.Load += new System.EventHandler(this.ucSupplier_Load);
            this.pnl_1.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.pnl_2.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.pnl_3.ResumeLayout(false);
            this.materialCard3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_supplier)).EndInit();
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
        private Krypton.Toolkit.KryptonTextBox txtsuppliercontact;
        private Krypton.Toolkit.KryptonTextBox txtsupplername;
        private Krypton.Toolkit.KryptonTextBox txtsupplierid;
        private Krypton.Toolkit.KryptonButton btnSave;
        private Krypton.Toolkit.KryptonButton btnClose;
        private Krypton.Toolkit.KryptonTextBox txtsupplernotes;
        private System.Windows.Forms.Panel pnl_3;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private System.Windows.Forms.DataGridView dg_supplier;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
    }
}
