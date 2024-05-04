namespace DorixonaForm
{
    partial class NewLogPassForm
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
            txPhoneNumber = new TextBox();
            txSmsPassword = new TextBox();
            lbSmsPassword = new Label();
            lbPhoneNumber = new Label();
            txConfirmation = new Button();
            btBack = new Button();
            lb998 = new Label();
            btNewLogPass = new Button();
            txNewLogin = new TextBox();
            txNewPassword = new TextBox();
            lbNewPassword = new Label();
            lbNewLogin = new Label();
            SuspendLayout();
            // 
            // txPhoneNumber
            // 
            txPhoneNumber.BackColor = Color.FromArgb(255, 255, 192);
            txPhoneNumber.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txPhoneNumber.Location = new Point(929, 227);
            txPhoneNumber.Name = "txPhoneNumber";
            txPhoneNumber.Size = new Size(165, 48);
            txPhoneNumber.TabIndex = 17;
            txPhoneNumber.Tag = "";
            // 
            // txSmsPassword
            // 
            txSmsPassword.BackColor = Color.FromArgb(255, 255, 192);
            txSmsPassword.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txSmsPassword.Location = new Point(672, 296);
            txSmsPassword.Name = "txSmsPassword";
            txSmsPassword.Size = new Size(204, 48);
            txSmsPassword.TabIndex = 16;
            txSmsPassword.Tag = "";
            // 
            // lbSmsPassword
            // 
            lbSmsPassword.AutoSize = true;
            lbSmsPassword.Font = new Font("Trebuchet MS", 22.2F);
            lbSmsPassword.Location = new Point(335, 294);
            lbSmsPassword.Name = "lbSmsPassword";
            lbSmsPassword.Size = new Size(331, 46);
            lbSmsPassword.TabIndex = 14;
            lbSmsPassword.Text = "Sms kodni kiriting:";
            // 
            // lbPhoneNumber
            // 
            lbPhoneNumber.AutoSize = true;
            lbPhoneNumber.Font = new Font("Trebuchet MS", 22.2F);
            lbPhoneNumber.Location = new Point(335, 227);
            lbPhoneNumber.Name = "lbPhoneNumber";
            lbPhoneNumber.Size = new Size(511, 46);
            lbPhoneNumber.TabIndex = 13;
            lbPhoneNumber.Text = "Telefon raqamingizni kiriting:";
            // 
            // txConfirmation
            // 
            txConfirmation.BackColor = Color.LightSkyBlue;
            txConfirmation.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txConfirmation.Location = new Point(903, 293);
            txConfirmation.Name = "txConfirmation";
            txConfirmation.Size = new Size(191, 53);
            txConfirmation.TabIndex = 18;
            txConfirmation.Text = "Tasdiqlash";
            txConfirmation.UseVisualStyleBackColor = false;
            txConfirmation.Click += txConfirmation_Click;
            // 
            // btBack
            // 
            btBack.BackColor = Color.Silver;
            btBack.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btBack.Location = new Point(845, 595);
            btBack.Name = "btBack";
            btBack.Size = new Size(249, 53);
            btBack.TabIndex = 19;
            btBack.Text = "Orqaga qaytish";
            btBack.UseVisualStyleBackColor = false;
            btBack.Click += btBack_Click;
            // 
            // lb998
            // 
            lb998.AutoSize = true;
            lb998.Font = new Font("Calibri Light", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lb998.Location = new Point(833, 228);
            lb998.Name = "lb998";
            lb998.Size = new Size(95, 45);
            lb998.TabIndex = 20;
            lb998.Text = "+998";
            // 
            // btNewLogPass
            // 
            btNewLogPass.BackColor = Color.LightSkyBlue;
            btNewLogPass.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btNewLogPass.Location = new Point(335, 508);
            btNewLogPass.Name = "btNewLogPass";
            btNewLogPass.Size = new Size(759, 60);
            btNewLogPass.TabIndex = 15;
            btNewLogPass.Text = "Tiklash";
            btNewLogPass.UseVisualStyleBackColor = false;
            btNewLogPass.Click += btNewLogPass_Click;
            // 
            // txNewLogin
            // 
            txNewLogin.BackColor = Color.FromArgb(255, 255, 192);
            txNewLogin.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txNewLogin.Location = new Point(780, 365);
            txNewLogin.Name = "txNewLogin";
            txNewLogin.Size = new Size(314, 48);
            txNewLogin.TabIndex = 24;
            // 
            // txNewPassword
            // 
            txNewPassword.BackColor = Color.FromArgb(255, 255, 192);
            txNewPassword.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txNewPassword.Location = new Point(780, 432);
            txNewPassword.Name = "txNewPassword";
            txNewPassword.PasswordChar = '*';
            txNewPassword.Size = new Size(314, 48);
            txNewPassword.TabIndex = 23;
            // 
            // lbNewPassword
            // 
            lbNewPassword.AutoSize = true;
            lbNewPassword.Font = new Font("Trebuchet MS", 22.2F);
            lbNewPassword.Location = new Point(335, 430);
            lbNewPassword.Name = "lbNewPassword";
            lbNewPassword.Size = new Size(458, 46);
            lbNewPassword.TabIndex = 22;
            lbNewPassword.Text = "Yangi parolingizni kiriting:";
            // 
            // lbNewLogin
            // 
            lbNewLogin.AutoSize = true;
            lbNewLogin.Font = new Font("Trebuchet MS", 22.2F);
            lbNewLogin.Location = new Point(335, 363);
            lbNewLogin.Name = "lbNewLogin";
            lbNewLogin.Size = new Size(454, 46);
            lbNewLogin.TabIndex = 21;
            lbNewLogin.Text = "Yangi loginingizni kiriting:";
            // 
            // NewLogPassForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1482, 903);
            Controls.Add(txNewLogin);
            Controls.Add(txNewPassword);
            Controls.Add(lbNewPassword);
            Controls.Add(lbNewLogin);
            Controls.Add(lb998);
            Controls.Add(btBack);
            Controls.Add(txConfirmation);
            Controls.Add(txPhoneNumber);
            Controls.Add(txSmsPassword);
            Controls.Add(btNewLogPass);
            Controls.Add(lbSmsPassword);
            Controls.Add(lbPhoneNumber);
            Name = "NewLogPassForm";
            Text = "NewLogPassForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txPhoneNumber;
        private TextBox txSmsPassword;
        private Label lbSmsPassword;
        private Label lbPhoneNumber;
        private Button txConfirmation;
        private Button btBack;
        private Label lb998;
        private Button btNewLogPass;
        private TextBox txNewLogin;
        private TextBox txNewPassword;
        private Label lbNewPassword;
        private Label lbNewLogin;
    }
}