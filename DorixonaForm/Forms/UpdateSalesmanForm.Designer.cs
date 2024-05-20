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
            dGVUpdateEmploye = new DataGridView();
            label6 = new Label();
            panel2 = new Panel();
            txUpdateLog = new TextBox();
            txUpdateTel = new TextBox();
            label2 = new Label();
            btDeleteSalesman = new Button();
            txUpdatePassword = new TextBox();
            label3 = new Label();
            lbNewLogin = new Label();
            txUpdateFio = new TextBox();
            lbNewPassword = new Label();
            btBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dGVUpdateEmploye).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btExit
            // 
            btExit.BackColor = Color.Silver;
            btExit.Font = new Font("Trebuchet MS", 14F);
            btExit.Location = new Point(1753, 53);
            btExit.Name = "btExit";
            btExit.Size = new Size(124, 44);
            btExit.TabIndex = 94;
            btExit.Text = "Chiqish";
            btExit.UseVisualStyleBackColor = false;
            btExit.Click += btExit_Click;
            // 
            // btPlacement
            // 
            btPlacement.BackColor = Color.LightSkyBlue;
            btPlacement.Font = new Font("Trebuchet MS", 18F);
            btPlacement.Location = new Point(591, 59);
            btPlacement.Name = "btPlacement";
            btPlacement.Size = new Size(142, 47);
            btPlacement.TabIndex = 93;
            btPlacement.Text = "Joylash";
            btPlacement.UseVisualStyleBackColor = false;
            btPlacement.Click += btPlacement_Click;
            // 
            // txId
            // 
            txId.BackColor = Color.FromArgb(255, 255, 192);
            txId.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txId.Location = new Point(444, 58);
            txId.Name = "txId";
            txId.Size = new Size(108, 48);
            txId.TabIndex = 92;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 22.2F);
            label1.Location = new Point(34, 60);
            label1.Name = "label1";
            label1.Size = new Size(415, 46);
            label1.TabIndex = 91;
            label1.Text = "Sotuvchi Id sini kiriting:";
            // 
            // dGVUpdateEmploye
            // 
            dGVUpdateEmploye.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVUpdateEmploye.Location = new Point(108, 184);
            dGVUpdateEmploye.Name = "dGVUpdateEmploye";
            dGVUpdateEmploye.RowHeadersWidth = 51;
            dGVUpdateEmploye.Size = new Size(679, 701);
            dGVUpdateEmploye.TabIndex = 87;
            dGVUpdateEmploye.CellContentClick += dGVEmploye_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 24F);
            label6.Location = new Point(273, 132);
            label6.Name = "label6";
            label6.Size = new Size(359, 49);
            label6.TabIndex = 86;
            label6.Text = "Sotuvchilar royxati";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCyan;
            panel2.Controls.Add(txUpdateLog);
            panel2.Controls.Add(txUpdateTel);
            panel2.Controls.Add(btPlacement);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txId);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btDeleteSalesman);
            panel2.Controls.Add(txUpdatePassword);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lbNewLogin);
            panel2.Controls.Add(txUpdateFio);
            panel2.Controls.Add(lbNewPassword);
            panel2.Location = new Point(949, 263);
            panel2.Name = "panel2";
            panel2.Size = new Size(783, 661);
            panel2.TabIndex = 85;
            // 
            // txUpdateLog
            // 
            txUpdateLog.BackColor = Color.FromArgb(255, 255, 192);
            txUpdateLog.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txUpdateLog.Location = new Point(318, 318);
            txUpdateLog.Name = "txUpdateLog";
            txUpdateLog.Size = new Size(438, 48);
            txUpdateLog.TabIndex = 97;
            // 
            // txUpdateTel
            // 
            txUpdateTel.BackColor = Color.FromArgb(255, 255, 192);
            txUpdateTel.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txUpdateTel.Location = new Point(318, 238);
            txUpdateTel.Name = "txUpdateTel";
            txUpdateTel.Size = new Size(438, 48);
            txUpdateTel.TabIndex = 86;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 22.2F);
            label2.Location = new Point(34, 320);
            label2.Name = "label2";
            label2.Size = new Size(123, 46);
            label2.TabIndex = 96;
            label2.Text = "Login:";
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
            btDeleteSalesman.Click += btDeleteSalesman_Click;
            // 
            // txUpdatePassword
            // 
            txUpdatePassword.BackColor = Color.FromArgb(255, 255, 192);
            txUpdatePassword.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txUpdatePassword.Location = new Point(318, 392);
            txUpdatePassword.Name = "txUpdatePassword";
            txUpdatePassword.Size = new Size(438, 48);
            txUpdatePassword.TabIndex = 99;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 22.2F);
            label3.Location = new Point(34, 394);
            label3.Name = "label3";
            label3.Size = new Size(117, 46);
            label3.TabIndex = 98;
            label3.Text = "Parol:";
            // 
            // lbNewLogin
            // 
            lbNewLogin.AutoSize = true;
            lbNewLogin.Font = new Font("Trebuchet MS", 22.2F);
            lbNewLogin.Location = new Point(34, 163);
            lbNewLogin.Name = "lbNewLogin";
            lbNewLogin.Size = new Size(88, 46);
            lbNewLogin.TabIndex = 84;
            lbNewLogin.Text = "FIO:";
            // 
            // txUpdateFio
            // 
            txUpdateFio.BackColor = Color.FromArgb(255, 255, 192);
            txUpdateFio.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txUpdateFio.Location = new Point(137, 161);
            txUpdateFio.Name = "txUpdateFio";
            txUpdateFio.Size = new Size(619, 48);
            txUpdateFio.TabIndex = 87;
            // 
            // lbNewPassword
            // 
            lbNewPassword.AutoSize = true;
            lbNewPassword.Font = new Font("Trebuchet MS", 22.2F);
            lbNewPassword.Location = new Point(34, 240);
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
            btBack.Click += btBack_Click;
            // 
            // UpdateSalesmanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1917, 1033);
            Controls.Add(btBack);
            Controls.Add(btExit);
            Controls.Add(dGVUpdateEmploye);
            Controls.Add(label6);
            Controls.Add(panel2);
            Name = "UpdateSalesmanForm";
            Text = "UpdateSalesmanForm";
            Load += UpdateSalesmanForm_Load;
            ((System.ComponentModel.ISupportInitialize)dGVUpdateEmploye).EndInit();
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
        private DataGridView dGVUpdateEmploye;
        private Label label6;
        private Panel panel2;
        private TextBox txUpdateTel;
        private Button btDeleteSalesman;
        private Label lbNewLogin;
        private TextBox txUpdateFio;
        private Label lbNewPassword;
        private Button btBack;
        private TextBox txUpdateLog;
        private Label label2;
        private TextBox txUpdatePassword;
        private Label label3;
    }
}