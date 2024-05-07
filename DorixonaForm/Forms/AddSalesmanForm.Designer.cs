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
            lb998 = new Label();
            btBack = new Button();
            txConfirmation = new Button();
            txAddPhoneNumber = new TextBox();
            txAddSmsPassword = new TextBox();
            lbSmsPassword = new Label();
            lbPhoneNumber = new Label();
            btSaveNewLogPass = new Button();
            txAddPassword = new TextBox();
            label1 = new Label();
            txAddFIO = new TextBox();
            txAddLogin = new TextBox();
            lbNewPassword = new Label();
            lbNewLogin = new Label();
            SuspendLayout();
            // 
            // lb998
            // 
            lb998.AutoSize = true;
            lb998.Font = new Font("Calibri Light", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lb998.Location = new Point(729, 210);
            lb998.Name = "lb998";
            lb998.Size = new Size(95, 45);
            lb998.TabIndex = 32;
            lb998.Text = "+998";
            // 
            // btBack
            // 
            btBack.BackColor = Color.Silver;
            btBack.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btBack.Location = new Point(794, 687);
            btBack.Name = "btBack";
            btBack.Size = new Size(249, 53);
            btBack.TabIndex = 31;
            btBack.Text = "Orqaga qaytish";
            btBack.UseVisualStyleBackColor = false;
            btBack.Click += btBack_Click;
            // 
            // txConfirmation
            // 
            txConfirmation.BackColor = Color.LightSkyBlue;
            txConfirmation.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txConfirmation.Location = new Point(830, 265);
            txConfirmation.Name = "txConfirmation";
            txConfirmation.Size = new Size(213, 53);
            txConfirmation.TabIndex = 30;
            txConfirmation.Text = "Kod yuborish";
            txConfirmation.UseVisualStyleBackColor = false;
            txConfirmation.Click += txConfirmation_Click;
            // 
            // txAddPhoneNumber
            // 
            txAddPhoneNumber.BackColor = Color.FromArgb(255, 255, 192);
            txAddPhoneNumber.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txAddPhoneNumber.Location = new Point(830, 205);
            txAddPhoneNumber.Name = "txAddPhoneNumber";
            txAddPhoneNumber.Size = new Size(213, 48);
            txAddPhoneNumber.TabIndex = 29;
            txAddPhoneNumber.Tag = "";
            // 
            // txAddSmsPassword
            // 
            txAddSmsPassword.BackColor = Color.FromArgb(255, 255, 192);
            txAddSmsPassword.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txAddSmsPassword.Location = new Point(830, 324);
            txAddSmsPassword.Name = "txAddSmsPassword";
            txAddSmsPassword.Size = new Size(213, 48);
            txAddSmsPassword.TabIndex = 28;
            txAddSmsPassword.Tag = "";
            // 
            // lbSmsPassword
            // 
            lbSmsPassword.AutoSize = true;
            lbSmsPassword.Font = new Font("Trebuchet MS", 22.2F);
            lbSmsPassword.Location = new Point(455, 322);
            lbSmsPassword.Name = "lbSmsPassword";
            lbSmsPassword.Size = new Size(331, 46);
            lbSmsPassword.TabIndex = 26;
            lbSmsPassword.Text = "Sms kodni kiriting:";
            // 
            // lbPhoneNumber
            // 
            lbPhoneNumber.AutoSize = true;
            lbPhoneNumber.Font = new Font("Trebuchet MS", 22.2F);
            lbPhoneNumber.Location = new Point(455, 209);
            lbPhoneNumber.Name = "lbPhoneNumber";
            lbPhoneNumber.Size = new Size(270, 46);
            lbPhoneNumber.TabIndex = 25;
            lbPhoneNumber.Text = "Telefon raqam:";
            // 
            // btSaveNewLogPass
            // 
            btSaveNewLogPass.BackColor = Color.LightSkyBlue;
            btSaveNewLogPass.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btSaveNewLogPass.Location = new Point(455, 607);
            btSaveNewLogPass.Name = "btSaveNewLogPass";
            btSaveNewLogPass.Size = new Size(588, 60);
            btSaveNewLogPass.TabIndex = 39;
            btSaveNewLogPass.Text = "Saqlash";
            btSaveNewLogPass.UseVisualStyleBackColor = false;
            btSaveNewLogPass.Click += btSaveNewLogPass_Click;
            // 
            // txAddPassword
            // 
            txAddPassword.BackColor = Color.FromArgb(255, 255, 192);
            txAddPassword.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txAddPassword.Location = new Point(729, 532);
            txAddPassword.Name = "txAddPassword";
            txAddPassword.Size = new Size(314, 48);
            txAddPassword.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 22.2F);
            label1.Location = new Point(455, 530);
            label1.Name = "label1";
            label1.Size = new Size(263, 46);
            label1.TabIndex = 37;
            label1.Text = "Parol yarating:";
            // 
            // txAddFIO
            // 
            txAddFIO.BackColor = Color.FromArgb(255, 255, 192);
            txAddFIO.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txAddFIO.Location = new Point(729, 390);
            txAddFIO.Name = "txAddFIO";
            txAddFIO.Size = new Size(314, 48);
            txAddFIO.TabIndex = 36;
            // 
            // txAddLogin
            // 
            txAddLogin.BackColor = Color.FromArgb(255, 255, 192);
            txAddLogin.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txAddLogin.Location = new Point(729, 457);
            txAddLogin.Name = "txAddLogin";
            txAddLogin.Size = new Size(314, 48);
            txAddLogin.TabIndex = 35;
            // 
            // lbNewPassword
            // 
            lbNewPassword.AutoSize = true;
            lbNewPassword.Font = new Font("Trebuchet MS", 22.2F);
            lbNewPassword.Location = new Point(455, 455);
            lbNewPassword.Name = "lbNewPassword";
            lbNewPassword.Size = new Size(269, 46);
            lbNewPassword.TabIndex = 34;
            lbNewPassword.Text = "Login yarating:";
            // 
            // lbNewLogin
            // 
            lbNewLogin.AutoSize = true;
            lbNewLogin.Font = new Font("Trebuchet MS", 22.2F);
            lbNewLogin.Location = new Point(455, 388);
            lbNewLogin.Name = "lbNewLogin";
            lbNewLogin.Size = new Size(88, 46);
            lbNewLogin.TabIndex = 33;
            lbNewLogin.Text = "FIO:";
            // 
            // AddSalesmanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1482, 903);
            Controls.Add(btSaveNewLogPass);
            Controls.Add(txAddPassword);
            Controls.Add(label1);
            Controls.Add(txAddFIO);
            Controls.Add(txAddLogin);
            Controls.Add(lbNewPassword);
            Controls.Add(lbNewLogin);
            Controls.Add(lb998);
            Controls.Add(btBack);
            Controls.Add(txConfirmation);
            Controls.Add(txAddPhoneNumber);
            Controls.Add(txAddSmsPassword);
            Controls.Add(lbSmsPassword);
            Controls.Add(lbPhoneNumber);
            Name = "AddSalesmanForm";
            Text = "AddSalesmanForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lb998;
        private Button btBack;
        private Button txConfirmation;
        private TextBox txAddPhoneNumber;
        private TextBox txAddSmsPassword;
        private Label lbSmsPassword;
        private Label lbPhoneNumber;
        private Button btSaveNewLogPass;
        private TextBox txAddPassword;
        private Label label1;
        private TextBox txAddFIO;
        private TextBox txAddLogin;
        private Label lbNewPassword;
        private Label lbNewLogin;
    }
}