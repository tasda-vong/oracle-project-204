namespace POS_204_oracle
{
    partial class frm_login
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtusername = new Krypton.Toolkit.KryptonTextBox();
            this.txtpassword = new Krypton.Toolkit.KryptonTextBox();
            this.btnlogin = new Krypton.Toolkit.KryptonButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnClose = new Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(157, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(50, 67);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(284, 27);
            this.txtusername.StateCommon.Border.Rounding = 7F;
            this.txtusername.TabIndex = 0;
            this.txtusername.Text = "TASDA";
            this.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            this.txtusername.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtusername_KeyUp);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(50, 118);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(284, 27);
            this.txtpassword.StateCommon.Border.Rounding = 7F;
            this.txtpassword.TabIndex = 9;
            this.txtpassword.Text = "123";
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            this.txtpassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtpassword_KeyUp);
            // 
            // btnlogin
            // 
            this.btnlogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnlogin.ButtonStyle = Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnlogin.Location = new System.Drawing.Point(50, 179);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.btnlogin.Size = new System.Drawing.Size(137, 27);
            this.btnlogin.StateCommon.Back.Color1 = System.Drawing.Color.SeaGreen;
            this.btnlogin.StateCommon.Back.Color2 = System.Drawing.Color.SeaGreen;
            this.btnlogin.StateCommon.Border.Color1 = System.Drawing.Color.SteelBlue;
            this.btnlogin.StateCommon.Border.Color2 = System.Drawing.Color.SteelBlue;
            this.btnlogin.StateCommon.Border.Rounding = 7F;
            this.btnlogin.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btnlogin.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btnlogin.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnlogin.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnlogin.TabIndex = 8;
            this.btnlogin.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnlogin.Values.Text = "Log In";
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(23, 24);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(1, 0);
            this.materialLabel1.TabIndex = 11;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl1.Location = new System.Drawing.Point(47, 97);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(161, 15);
            this.lbl1.TabIndex = 12;
            this.lbl1.Text = "Username is Required *";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl2.Location = new System.Drawing.Point(47, 148);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(150, 15);
            this.lbl2.TabIndex = 13;
            this.lbl2.Text = "Pasword is Required *";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.ButtonStyle = Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnClose.Location = new System.Drawing.Point(193, 181);
            this.btnClose.Name = "btnClose";
            this.btnClose.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlackDarkMode;
            this.btnClose.Size = new System.Drawing.Size(141, 23);
            this.btnClose.StateCommon.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btnClose.StateCommon.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btnClose.StateCommon.Border.Color1 = System.Drawing.Color.SteelBlue;
            this.btnClose.StateCommon.Border.Color2 = System.Drawing.Color.SteelBlue;
            this.btnClose.StateCommon.Border.Rounding = 7F;
            this.btnClose.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btnClose.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btnClose.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnClose.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnClose.TabIndex = 14;
            this.btnClose.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnClose.Values.Text = "Cancel";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(385, 231);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_login";
            this.Load += new System.EventHandler(this.frm_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Krypton.Toolkit.KryptonTextBox txtusername;
        private Krypton.Toolkit.KryptonTextBox txtpassword;
        private Krypton.Toolkit.KryptonButton btnlogin;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private Krypton.Toolkit.KryptonButton btnClose;
    }
}