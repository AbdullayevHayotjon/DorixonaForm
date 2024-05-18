namespace DorixonaForm.Forms
{
    partial class DeleteSalesmanForm
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
            label6 = new Label();
            panel2 = new Panel();
            btDeleteSalesman = new Button();
            dGVEmploye = new DataGridView();
            cbSearch = new ComboBox();
            btSearch = new Button();
            txPillName = new TextBox();
            btPlacement = new Button();
            txId = new TextBox();
            label1 = new Label();
            txAddLogin = new TextBox();
            lbNewLogin = new Label();
            lbNewPassword = new Label();
            txAddFIO = new TextBox();
            btExit = new Button();
            btBack = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGVEmploye).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 24F);
            label6.Location = new Point(490, 34);
            label6.Name = "label6";
            label6.Size = new Size(330, 49);
            label6.TabIndex = 61;
            label6.Text = "Sotuvchi o'chirish";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCyan;
            panel2.Controls.Add(txAddLogin);
            panel2.Controls.Add(btDeleteSalesman);
            panel2.Controls.Add(lbNewLogin);
            panel2.Controls.Add(txAddFIO);
            panel2.Controls.Add(lbNewPassword);
            panel2.Location = new Point(1046, 189);
            panel2.Name = "panel2";
            panel2.Size = new Size(783, 661);
            panel2.TabIndex = 60;
            // 
            // btDeleteSalesman
            // 
            btDeleteSalesman.BackColor = Color.LightSkyBlue;
            btDeleteSalesman.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btDeleteSalesman.Location = new Point(34, 482);
            btDeleteSalesman.Name = "btDeleteSalesman";
            btDeleteSalesman.Size = new Size(722, 60);
            btDeleteSalesman.TabIndex = 49;
            btDeleteSalesman.Text = "O'chirish";
            btDeleteSalesman.UseVisualStyleBackColor = false;
            btDeleteSalesman.Click += btDeleteSalesman_Click;
            // 
            // dGVEmploye
            // 
            dGVEmploye.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVEmploye.Location = new Point(205, 110);
            dGVEmploye.Name = "dGVEmploye";
            dGVEmploye.RowHeadersWidth = 51;
            dGVEmploye.Size = new Size(679, 701);
            dGVEmploye.TabIndex = 62;
            // 
            // cbSearch
            // 
            cbSearch.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cbSearch.FormattingEnabled = true;
            cbSearch.Items.AddRange(new object[] { "Nomi", "Id", "Soni", "Muddati", "Narxi" });
            cbSearch.Location = new Point(1063, 39);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(174, 49);
            cbSearch.TabIndex = 80;
            cbSearch.Text = "Nomi";
            // 
            // btSearch
            // 
            btSearch.BackColor = Color.LightSkyBlue;
            btSearch.Font = new Font("Trebuchet MS", 18F);
            btSearch.Location = new Point(1576, 42);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(142, 47);
            btSearch.TabIndex = 78;
            btSearch.Text = "Qidirish";
            btSearch.UseVisualStyleBackColor = false;
            // 
            // txPillName
            // 
            txPillName.BackColor = Color.FromArgb(255, 255, 192);
            txPillName.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txPillName.Location = new Point(1297, 41);
            txPillName.Name = "txPillName";
            txPillName.Size = new Size(243, 48);
            txPillName.TabIndex = 79;
            // 
            // btPlacement
            // 
            btPlacement.BackColor = Color.LightSkyBlue;
            btPlacement.Font = new Font("Trebuchet MS", 18F);
            btPlacement.Location = new Point(1655, 135);
            btPlacement.Name = "btPlacement";
            btPlacement.Size = new Size(142, 47);
            btPlacement.TabIndex = 83;
            btPlacement.Text = "Joylash";
            btPlacement.UseVisualStyleBackColor = false;
            // 
            // txId
            // 
            txId.BackColor = Color.FromArgb(255, 255, 192);
            txId.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txId.Location = new Point(1381, 135);
            txId.Name = "txId";
            txId.Size = new Size(243, 48);
            txId.TabIndex = 82;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 22.2F);
            label1.Location = new Point(1018, 137);
            label1.Name = "label1";
            label1.Size = new Size(343, 46);
            label1.TabIndex = 81;
            label1.Text = "Dori Id sini kiriting:";
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
            // txAddFIO
            // 
            txAddFIO.BackColor = Color.FromArgb(255, 255, 192);
            txAddFIO.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txAddFIO.Location = new Point(125, 125);
            txAddFIO.Name = "txAddFIO";
            txAddFIO.Size = new Size(619, 48);
            txAddFIO.TabIndex = 87;
            // 
            // btExit
            // 
            btExit.BackColor = Color.Silver;
            btExit.Font = new Font("Trebuchet MS", 14F);
            btExit.Location = new Point(1781, 87);
            btExit.Name = "btExit";
            btExit.Size = new Size(124, 44);
            btExit.TabIndex = 84;
            btExit.Text = "Chiqish";
            btExit.UseVisualStyleBackColor = false;
            // 
            // btBack
            // 
            btBack.BackColor = Color.Silver;
            btBack.Font = new Font("Trebuchet MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btBack.Location = new Point(1698, 937);
            btBack.Name = "btBack";
            btBack.Size = new Size(193, 44);
            btBack.TabIndex = 85;
            btBack.Text = "Orqaga qaytish";
            btBack.UseVisualStyleBackColor = false;
            // 
            // DeleteSalesmanForm
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
            Name = "DeleteSalesmanForm";
            Text = "DeleteSalesmanForm";
            Load += DeleteSalesmanForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dGVEmploye).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Panel panel2;
        private Button btDeleteSalesman;
        private DataGridView dGVEmploye;
        private ComboBox cbSearch;
        private Button btSearch;
        private TextBox txPillName;
        private Button btPlacement;
        private TextBox txId;
        private Label label1;
        private TextBox txAddLogin;
        private Label lbNewLogin;
        private TextBox txAddFIO;
        private Label lbNewPassword;
        private Button btExit;
        private Button btBack;
    }
}