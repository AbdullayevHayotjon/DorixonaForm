namespace DorixonaForm.Forms
{
    partial class UpdateSalesmanForm
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
            btExit = new Button();
            btPlacement = new Button();
            txId = new TextBox();
            label1 = new Label();
            cbSearch = new ComboBox();
            btSearch = new Button();
            txPillName = new TextBox();
            dGVEmploye = new DataGridView();
            label6 = new Label();
            panel2 = new Panel();
            txAddLogin = new TextBox();
            btDeleteSalesman = new Button();
            lbNewLogin = new Label();
            txAddFIO = new TextBox();
            lbNewPassword = new Label();
            btBack = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            txAddPassword = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dGVEmploye).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btExit
            // 
            btExit.BackColor = Color.Silver;
            btExit.Font = new Font("Trebuchet MS", 14F);
            btExit.Location = new Point(1684, 161);
            btExit.Name = "btExit";
            btExit.Size = new Size(124, 44);
            btExit.TabIndex = 94;
            btExit.Text = "Chiqish";
            btExit.UseVisualStyleBackColor = false;
            // 
            // btPlacement
            // 
            btPlacement.BackColor = Color.LightSkyBlue;
            btPlacement.Font = new Font("Trebuchet MS", 18F);
            btPlacement.Location = new Point(1558, 209);
            btPlacement.Name = "btPlacement";
            btPlacement.Size = new Size(142, 47);
            btPlacement.TabIndex = 93;
            btPlacement.Text = "Joylash";
            btPlacement.UseVisualStyleBackColor = false;
            // 
            // txId
            // 
            txId.BackColor = Color.FromArgb(255, 255, 192);
            txId.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txId.Location = new Point(1284, 209);
            txId.Name = "txId";
            txId.Size = new Size(243, 48);
            txId.TabIndex = 92;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 22.2F);
            label1.Location = new Point(921, 211);
            label1.Name = "label1";
            label1.Size = new Size(343, 46);
            label1.TabIndex = 91;
            label1.Text = "Dori Id sini kiriting:";
            // 
            // cbSearch
            // 
            cbSearch.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cbSearch.FormattingEnabled = true;
            cbSearch.Items.AddRange(new object[] { "Nomi", "Id", "Soni", "Muddati", "Narxi" });
            cbSearch.Location = new Point(966, 113);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(174, 49);
            cbSearch.TabIndex = 90;
            cbSearch.Text = "Nomi";
            // 
            // btSearch
            // 
            btSearch.BackColor = Color.LightSkyBlue;
            btSearch.Font = new Font("Trebuchet MS", 18F);
            btSearch.Location = new Point(1479, 116);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(142, 47);
            btSearch.TabIndex = 88;
            btSearch.Text = "Qidirish";
            btSearch.UseVisualStyleBackColor = false;
            // 
            // txPillName
            // 
            txPillName.BackColor = Color.FromArgb(255, 255, 192);
            txPillName.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txPillName.Location = new Point(1200, 115);
            txPillName.Name = "txPillName";
            txPillName.Size = new Size(243, 48);
            txPillName.TabIndex = 89;
            // 
            // dGVEmploye
            // 
            dGVEmploye.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVEmploye.Location = new Point(108, 184);
            dGVEmploye.Name = "dGVEmploye";
            dGVEmploye.RowHeadersWidth = 51;
            dGVEmploye.Size = new Size(679, 701);
            dGVEmploye.TabIndex = 87;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 24F);
            label6.Location = new Point(393, 108);
            label6.Name = "label6";
            label6.Size = new Size(330, 49);
            label6.TabIndex = 86;
            label6.Text = "Sotuvchi o'chirish";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCyan;
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(txAddLogin);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btDeleteSalesman);
            panel2.Controls.Add(txAddPassword);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lbNewLogin);
            panel2.Controls.Add(txAddFIO);
            panel2.Controls.Add(lbNewPassword);
            panel2.Location = new Point(949, 263);
            panel2.Name = "panel2";
            panel2.Size = new Size(783, 661);
            panel2.TabIndex = 85;
            // 
            // txAddLogin
            // 
            txAddLogin.BackColor = Color.FromArgb(255, 255, 192);
            txAddLogin.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txAddLogin.Location = new Point(260, 190);
            txAddLogin.Name = "txAddLogin";
            txAddLogin.Size = new Size(438, 48);
            txAddLogin.TabIndex = 86;
            // 
            // btDeleteSalesman
            // 
            btDeleteSalesman.BackColor = Color.LightSkyBlue;
            btDeleteSalesman.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btDeleteSalesman.Location = new Point(34, 482);
            btDeleteSalesman.Name = "btDeleteSalesman";
            btDeleteSalesman.Size = new Size(722, 60);
            btDeleteSalesman.TabIndex = 49;
            btDeleteSalesman.Text = "Yangilash";
            btDeleteSalesman.UseVisualStyleBackColor = false;
            // 
            // lbNewLogin
            // 
            lbNewLogin.AutoSize = true;
            lbNewLogin.Font = new Font("Trebuchet MS", 22.2F);
            lbNewLogin.Location = new Point(31, 123);
            lbNewLogin.Name = "lbNewLogin";
            lbNewLogin.Size = new Size(88, 46);
            lbNewLogin.TabIndex = 84;
            lbNewLogin.Text = "FIO:";
            // 
            // txAddFIO
            // 
            txAddFIO.BackColor = Color.FromArgb(255, 255, 192);
            txAddFIO.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txAddFIO.Location = new Point(125, 125);
            txAddFIO.Name = "txAddFIO";
            txAddFIO.Size = new Size(619, 48);
            txAddFIO.TabIndex = 87;
            // 
            // lbNewPassword
            // 
            lbNewPassword.AutoSize = true;
            lbNewPassword.Font = new Font("Trebuchet MS", 22.2F);
            lbNewPassword.Location = new Point(31, 188);
            lbNewPassword.Name = "lbNewPassword";
            lbNewPassword.Size = new Size(196, 46);
            lbNewPassword.TabIndex = 85;
            lbNewPassword.Text = "Tel raqam:";
            // 
            // btBack
            // 
            btBack.BackColor = Color.Silver;
            btBack.Font = new Font("Trebuchet MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btBack.Location = new Point(1684, 946);
            btBack.Name = "btBack";
            btBack.Size = new Size(193, 44);
            btBack.TabIndex = 95;
            btBack.Text = "Orqaga qaytish";
            btBack.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 255, 192);
            textBox1.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            textBox1.Location = new Point(297, 257);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(438, 48);
            textBox1.TabIndex = 97;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 22.2F);
            label2.Location = new Point(22, 255);
            label2.Name = "label2";
            label2.Size = new Size(123, 46);
            label2.TabIndex = 96;
            label2.Text = "Login:";
            // 
            // txAddPassword
            // 
            txAddPassword.BackColor = Color.FromArgb(255, 255, 192);
            txAddPassword.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txAddPassword.Location = new Point(297, 322);
            txAddPassword.Name = "txAddPassword";
            txAddPassword.Size = new Size(438, 48);
            txAddPassword.TabIndex = 99;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 22.2F);
            label3.Location = new Point(22, 320);
            label3.Name = "label3";
            label3.Size = new Size(117, 46);
            label3.TabIndex = 98;
            label3.Text = "Parol:";
            // 
            // UpdateSalesmanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1917, 1033);
            Controls.Add(btBack);
            Controls.Add(btExit);
            Controls.Add(btPlacement);
            Controls.Add(txId);
            Controls.Add(label1);
            Controls.Add(cbSearch);
            Controls.Add(btSearch);
            Controls.Add(txPillName);
            Controls.Add(dGVEmploye);
            Controls.Add(label6);
            Controls.Add(panel2);
            Name = "UpdateSalesmanForm";
            Text = "UpdateSalesmanForm";
            Load += UpdateSalesmanForm_Load;
            ((System.ComponentModel.ISupportInitialize)dGVEmploye).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btExit;
        private Button btPlacement;
        private TextBox txId;
        private Label label1;
        private ComboBox cbSearch;
        private Button btSearch;
        private TextBox txPillName;
        private DataGridView dGVEmploye;
        private Label label6;
        private Panel panel2;
        private TextBox txAddLogin;
        private Button btDeleteSalesman;
        private Label lbNewLogin;
        private TextBox txAddFIO;
        private Label lbNewPassword;
        private Button btBack;
        private TextBox textBox1;
        private Label label2;
        private TextBox txAddPassword;
        private Label label3;
    }
}