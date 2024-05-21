namespace DorixonaForm.Forms
{
    partial class AddSalesmanForm
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
            label5 = new Label();
            panel1 = new Panel();
            txPhoneNumber = new TextBox();
            txAddLogin = new TextBox();
            lbPhoneNumber = new Label();
            lbSmsPassword = new Label();
            txAddSmsPassword = new TextBox();
            txConfirmation = new Button();
            lb998 = new Label();
            lbNewLogin = new Label();
            lbNewPassword = new Label();
            btSaveNewLogPass = new Button();
            txAddFIO = new TextBox();
            txAddPassword = new TextBox();
            label1 = new Label();
            dGVAddEmploye = new DataGridView();
            btExit = new Button();
            btBack = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGVAddEmploye).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 24F);
            label5.Location = new Point(190, 54);
            label5.Name = "label5";
            label5.Size = new Size(359, 49);
            label5.TabIndex = 60;
            label5.Text = "Sotuvchilar royxati\r\n";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(txPhoneNumber);
            panel1.Controls.Add(txAddLogin);
            panel1.Controls.Add(lbPhoneNumber);
            panel1.Controls.Add(lbSmsPassword);
            panel1.Controls.Add(txAddSmsPassword);
            panel1.Controls.Add(txConfirmation);
            panel1.Controls.Add(lb998);
            panel1.Controls.Add(lbNewLogin);
            panel1.Controls.Add(lbNewPassword);
            panel1.Controls.Add(btSaveNewLogPass);
            panel1.Controls.Add(txAddFIO);
            panel1.Controls.Add(txAddPassword);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(802, 93);
            panel1.Name = "panel1";
            panel1.Size = new Size(787, 815);
            panel1.TabIndex = 59;
            // 
            // txPhoneNumber
            // 
            txPhoneNumber.BackColor = Color.FromArgb(255, 255, 192);
            txPhoneNumber.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txPhoneNumber.Location = new Point(435, 116);
            txPhoneNumber.Name = "txPhoneNumber";
            txPhoneNumber.Size = new Size(319, 48);
            txPhoneNumber.TabIndex = 40;
            txPhoneNumber.Tag = "";
            // 
            // txAddLogin
            // 
            txAddLogin.BackColor = Color.FromArgb(255, 255, 192);
            txAddLogin.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txAddLogin.Location = new Point(316, 307);
            txAddLogin.Name = "txAddLogin";
            txAddLogin.Size = new Size(438, 48);
            txAddLogin.TabIndex = 35;
            // 
            // lbPhoneNumber
            // 
            lbPhoneNumber.AutoSize = true;
            lbPhoneNumber.Font = new Font("Trebuchet MS", 22.2F);
            lbPhoneNumber.Location = new Point(41, 114);
            lbPhoneNumber.Name = "lbPhoneNumber";
            lbPhoneNumber.Size = new Size(270, 46);
            lbPhoneNumber.TabIndex = 25;
            lbPhoneNumber.Text = "Telefon raqam:";
            // 
            // lbSmsPassword
            // 
            lbSmsPassword.AutoSize = true;
            lbSmsPassword.Font = new Font("Trebuchet MS", 22.2F);
            lbSmsPassword.Location = new Point(41, 178);
            lbSmsPassword.Name = "lbSmsPassword";
            lbSmsPassword.Size = new Size(331, 46);
            lbSmsPassword.TabIndex = 26;
            lbSmsPassword.Text = "Sms kodni kiriting:";
            // 
            // txAddSmsPassword
            // 
            txAddSmsPassword.BackColor = Color.FromArgb(255, 255, 192);
            txAddSmsPassword.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txAddSmsPassword.Location = new Point(378, 180);
            txAddSmsPassword.Name = "txAddSmsPassword";
            txAddSmsPassword.Size = new Size(158, 48);
            txAddSmsPassword.TabIndex = 28;
            txAddSmsPassword.Tag = "";
            // 
            // txConfirmation
            // 
            txConfirmation.BackColor = Color.LightSkyBlue;
            txConfirmation.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txConfirmation.Location = new Point(552, 177);
            txConfirmation.Name = "txConfirmation";
            txConfirmation.Size = new Size(202, 53);
            txConfirmation.TabIndex = 30;
            txConfirmation.Text = "Kod yuborish";
            txConfirmation.UseVisualStyleBackColor = false;
            txConfirmation.Click += txConfirmation_Click;
            // 
            // lb998
            // 
            lb998.AutoSize = true;
            lb998.Font = new Font("Calibri Light", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lb998.Location = new Point(334, 115);
            lb998.Name = "lb998";
            lb998.Size = new Size(95, 45);
            lb998.TabIndex = 32;
            lb998.Text = "+998";
            // 
            // lbNewLogin
            // 
            lbNewLogin.AutoSize = true;
            lbNewLogin.Font = new Font("Trebuchet MS", 22.2F);
            lbNewLogin.Location = new Point(41, 240);
            lbNewLogin.Name = "lbNewLogin";
            lbNewLogin.Size = new Size(88, 46);
            lbNewLogin.TabIndex = 33;
            lbNewLogin.Text = "FIO:";
            // 
            // lbNewPassword
            // 
            lbNewPassword.AutoSize = true;
            lbNewPassword.Font = new Font("Trebuchet MS", 22.2F);
            lbNewPassword.Location = new Point(41, 305);
            lbNewPassword.Name = "lbNewPassword";
            lbNewPassword.Size = new Size(269, 46);
            lbNewPassword.TabIndex = 34;
            lbNewPassword.Text = "Login yarating:";
            // 
            // btSaveNewLogPass
            // 
            btSaveNewLogPass.BackColor = Color.LightSkyBlue;
            btSaveNewLogPass.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btSaveNewLogPass.Location = new Point(41, 656);
            btSaveNewLogPass.Name = "btSaveNewLogPass";
            btSaveNewLogPass.Size = new Size(713, 60);
            btSaveNewLogPass.TabIndex = 39;
            btSaveNewLogPass.Text = "Qo'shish";
            btSaveNewLogPass.UseVisualStyleBackColor = false;
            btSaveNewLogPass.Click += btSaveNewLogPass_Click;
            // 
            // txAddFIO
            // 
            txAddFIO.BackColor = Color.FromArgb(255, 255, 192);
            txAddFIO.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txAddFIO.Location = new Point(135, 242);
            txAddFIO.Name = "txAddFIO";
            txAddFIO.Size = new Size(619, 48);
            txAddFIO.TabIndex = 36;
            // 
            // txAddPassword
            // 
            txAddPassword.BackColor = Color.FromArgb(255, 255, 192);
            txAddPassword.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txAddPassword.Location = new Point(316, 372);
            txAddPassword.Name = "txAddPassword";
            txAddPassword.Size = new Size(438, 48);
            txAddPassword.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 22.2F);
            label1.Location = new Point(41, 370);
            label1.Name = "label1";
            label1.Size = new Size(263, 46);
            label1.TabIndex = 37;
            label1.Text = "Parol yarating:";
            // 
            // dGVAddEmploye
            // 
            dGVAddEmploye.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVAddEmploye.Location = new Point(41, 106);
            dGVAddEmploye.Name = "dGVAddEmploye";
            dGVAddEmploye.RowHeadersWidth = 51;
            dGVAddEmploye.Size = new Size(679, 701);
            dGVAddEmploye.TabIndex = 61;
            dGVAddEmploye.CellContentClick += dGVAddEmploye_CellContentClick;
            // 
            // btExit
            // 
            btExit.BackColor = Color.Silver;
            btExit.Font = new Font("Trebuchet MS", 14F);
            btExit.Location = new Point(1754, 24);
            btExit.Name = "btExit";
            btExit.Size = new Size(124, 44);
            btExit.TabIndex = 62;
            btExit.Text = "Chiqish";
            btExit.UseVisualStyleBackColor = false;
            btExit.Click += btExit_Click;
            // 
            // btBack
            // 
            btBack.BackColor = Color.Silver;
            btBack.Font = new Font("Trebuchet MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btBack.Location = new Point(1669, 916);
            btBack.Name = "btBack";
            btBack.Size = new Size(193, 44);
            btBack.TabIndex = 63;
            btBack.Text = "Orqaga qaytish";
            btBack.UseVisualStyleBackColor = false;
            btBack.Click += btBack_Click;
            // 
            // AddSalesmanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1917, 1033);
            Controls.Add(btBack);
            Controls.Add(btExit);
            Controls.Add(dGVAddEmploye);
            Controls.Add(label5);
            Controls.Add(panel1);
            Name = "AddSalesmanForm";
            Text = "AddSalesmanForm";
            Load += AddSalesmanForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dGVAddEmploye).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Panel panel1;
        private TextBox txAddLogin;
        private Label lbPhoneNumber;
        private Label lbSmsPassword;
        private TextBox txAddSmsPassword;
        private Button txConfirmation;
        private Label lb998;
        private Label lbNewLogin;
        private Label lbNewPassword;
        private Button btSaveNewLogPass;
        private TextBox txAddFIO;
        private TextBox txAddPassword;
        private Label label1;
        private DataGridView dGVAddEmploye;
        private Button btExit;
        private Button btBack;
        private TextBox txPhoneNumber;
    }
}