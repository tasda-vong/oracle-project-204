namespace POS_204_oracle.uc
{
    partial class uc_user
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
            this.pnl_2 = new System.Windows.Forms.Panel();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.chkstatus = new System.Windows.Forms.CheckBox();
            this.cbotype = new Krypton.Toolkit.KryptonComboBox();
            this.txtfullname = new Krypton.Toolkit.KryptonTextBox();
            this.txtpassword = new Krypton.Toolkit.KryptonTextBox();
            this.txtusername = new Krypton.Toolkit.KryptonTextBox();
            this.txtuserID = new Krypton.Toolkit.KryptonTextBox();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.btnClose = new Krypton.Toolkit.KryptonButton();
            this.pnl_3 = new System.Windows.Forms.Panel();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.dg_user = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnl_1.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.pnl_2.SuspendLayout();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbotype)).BeginInit();
            this.pnl_3.SuspendLayout();
            this.materialCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_user)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_1
            // 
            this.pnl_1.Controls.Add(this.materialCard1);
            this.pnl_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_1.Location = new System.Drawing.Point(0, 0);
            this.pnl_1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnl_1.Name = "pnl_1";
            this.pnl_1.Size = new System.Drawing.Size(1578, 129);
            this.pnl_1.TabIndex = 0;
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.label1);
            this.materialCard1.Controls.Add(this.btnNew);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(28, 12);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(28, 27, 28, 27);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(28, 27, 28, 27);
            this.materialCard1.Size = new System.Drawing.Size(1522, 104);
            this.materialCard1.TabIndex = 0;
            this.materialCard1.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "MANAGE USERS";
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.ButtonStyle = Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnNew.Location = new System.Drawing.Point(1254, 17);
            this.btnNew.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnNew.Name = "btnNew";
            this.btnNew.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlackDarkMode;
            this.btnNew.Size = new System.Drawing.Size(234, 69);
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
            this.btnNew.Values.Text = "New User";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // pnl_2
            // 
            this.pnl_2.Controls.Add(this.materialCard2);
            this.pnl_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_2.Location = new System.Drawing.Point(0, 129);
            this.pnl_2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnl_2.Name = "pnl_2";
            this.pnl_2.Size = new System.Drawing.Size(1578, 631);
            this.pnl_2.TabIndex = 1;
            this.pnl_2.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_2_Paint);
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.chkstatus);
            this.materialCard2.Controls.Add(this.cbotype);
            this.materialCard2.Controls.Add(this.txtfullname);
            this.materialCard2.Controls.Add(this.txtpassword);
            this.materialCard2.Controls.Add(this.txtusername);
            this.materialCard2.Controls.Add(this.txtuserID);
            this.materialCard2.Controls.Add(this.btnSave);
            this.materialCard2.Controls.Add(this.btnClose);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(28, 12);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(28, 27, 28, 27);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(28, 27, 28, 27);
            this.materialCard2.Size = new System.Drawing.Size(1522, 606);
            this.materialCard2.TabIndex = 0;
            this.materialCard2.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard2_Paint);
            // 
            // chkstatus
            // 
            this.chkstatus.AutoSize = true;
            this.chkstatus.Location = new System.Drawing.Point(404, 375);
            this.chkstatus.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkstatus.Name = "chkstatus";
            this.chkstatus.Size = new System.Drawing.Size(103, 29);
            this.chkstatus.TabIndex = 11;
            this.chkstatus.Text = "Active";
            this.chkstatus.UseVisualStyleBackColor = true;
            // 
            // cbotype
            // 
            this.cbotype.Location = new System.Drawing.Point(404, 313);
            this.cbotype.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbotype.Name = "cbotype";
            this.cbotype.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.cbotype.Size = new System.Drawing.Size(566, 42);
            this.cbotype.StateCommon.ComboBox.Border.Rounding = 7F;
            this.cbotype.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbotype.TabIndex = 10;
            this.cbotype.Text = "USER";
            // 
            // txtfullname
            // 
            this.txtfullname.Location = new System.Drawing.Point(400, 238);
            this.txtfullname.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(568, 43);
            this.txtfullname.StateCommon.Border.Rounding = 7F;
            this.txtfullname.TabIndex = 9;
            this.txtfullname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(400, 175);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(568, 43);
            this.txtpassword.StateCommon.Border.Rounding = 7F;
            this.txtpassword.TabIndex = 8;
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(400, 112);
            this.txtusername.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(568, 43);
            this.txtusername.StateCommon.Border.Rounding = 7F;
            this.txtusername.TabIndex = 7;
            this.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // txtuserID
            // 
            this.txtuserID.Location = new System.Drawing.Point(400, 48);
            this.txtuserID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtuserID.Name = "txtuserID";
            this.txtuserID.Size = new System.Drawing.Size(568, 43);
            this.txtuserID.StateCommon.Border.Rounding = 7F;
            this.txtuserID.TabIndex = 6;
            this.txtuserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.ButtonStyle = Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnSave.Location = new System.Drawing.Point(536, 504);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlackDarkMode;
            this.btnSave.Size = new System.Drawing.Size(166, 69);
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
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.ButtonStyle = Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnClose.Location = new System.Drawing.Point(714, 504);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlackDarkMode;
            this.btnClose.Size = new System.Drawing.Size(174, 69);
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
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnl_3
            // 
            this.pnl_3.Controls.Add(this.materialCard3);
            this.pnl_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_3.Location = new System.Drawing.Point(0, 760);
            this.pnl_3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnl_3.Name = "pnl_3";
            this.pnl_3.Size = new System.Drawing.Size(1578, 248);
            this.pnl_3.TabIndex = 2;
            // 
            // materialCard3
            // 
            this.materialCard3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.dg_user);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(28, 12);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(28, 27, 28, 27);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(28, 27, 28, 27);
            this.materialCard3.Size = new System.Drawing.Size(1522, 223);
            this.materialCard3.TabIndex = 0;
            // 
            // dg_user
            // 
            this.dg_user.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_user.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dg_user.Location = new System.Drawing.Point(34, 33);
            this.dg_user.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dg_user.Name = "dg_user";
            this.dg_user.RowHeadersWidth = 82;
            this.dg_user.Size = new System.Drawing.Size(1454, 179);
            this.dg_user.TabIndex = 0;
            this.dg_user.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_user_CellClick);
            this.dg_user.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Edit";
            this.dataGridViewImageColumn1.Image = global::POS_204_oracle.Properties.Resources.icons8_edit_30;
            this.dataGridViewImageColumn1.MinimumWidth = 10;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 200;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Dlete";
            this.dataGridViewImageColumn2.Image = global::POS_204_oracle.Properties.Resources.icons8_trash_24;
            this.dataGridViewImageColumn2.MinimumWidth = 10;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 200;
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
            // uc_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.pnl_3);
            this.Controls.Add(this.pnl_2);
            this.Controls.Add(this.pnl_1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "uc_user";
            this.Size = new System.Drawing.Size(1578, 1008);
            this.Load += new System.EventHandler(this.uc_user_Load);
            this.pnl_1.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.pnl_2.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbotype)).EndInit();
            this.pnl_3.ResumeLayout(false);
            this.materialCard3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_user)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.Panel pnl_2;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.Panel pnl_3;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private Krypton.Toolkit.KryptonButton btnNew;
        private System.Windows.Forms.DataGridView dg_user;
        private Krypton.Toolkit.KryptonButton btnClose;
        private Krypton.Toolkit.KryptonButton btnSave;
        private System.Windows.Forms.Label label1;
        private Krypton.Toolkit.KryptonTextBox txtpassword;
        private Krypton.Toolkit.KryptonTextBox txtusername;
        private Krypton.Toolkit.KryptonTextBox txtuserID;
        private System.Windows.Forms.CheckBox chkstatus;
        private Krypton.Toolkit.KryptonComboBox cbotype;
        private Krypton.Toolkit.KryptonTextBox txtfullname;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
    }
}
