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
            txNewPassword = new TextBox();
            lbNewPassword = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txPhoneNumber
            // 
            txPhoneNumber.BackColor = Color.FromArgb(255, 255, 192);
            txPhoneNumber.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txPhoneNumber.Location = new Point(686, 191);
            txPhoneNumber.Name = "txPhoneNumber";
            txPhoneNumber.Size = new Size(256, 48);
            txPhoneNumber.TabIndex = 17;
            txPhoneNumber.Tag = "";
            // 
            // txSmsPassword
            // 
            txSmsPassword.BackColor = Color.FromArgb(255, 255, 192);
            txSmsPassword.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txSmsPassword.Location = new Point(452, 274);
            txSmsPassword.Name = "txSmsPassword";
            txSmsPassword.Size = new Size(200, 48);
            txSmsPassword.TabIndex = 16;
            txSmsPassword.Tag = "";
            // 
            // lbSmsPassword
            // 
            lbSmsPassword.AutoSize = true;
            lbSmsPassword.Font = new Font("Trebuchet MS", 22.2F);
            lbSmsPassword.Location = new Point(83, 272);
            lbSmsPassword.Name = "lbSmsPassword";
            lbSmsPassword.Size = new Size(331, 46);
            lbSmsPassword.TabIndex = 14;
            lbSmsPassword.Text = "Sms kodni kiriting:";
            // 
            // lbPhoneNumber
            // 
            lbPhoneNumber.AutoSize = true;
            lbPhoneNumber.Font = new Font("Trebuchet MS", 22.2F);
            lbPhoneNumber.Location = new Point(83, 193);
            lbPhoneNumber.Name = "lbPhoneNumber";
            lbPhoneNumber.Size = new Size(511, 46);
            lbPhoneNumber.TabIndex = 13;
            lbPhoneNumber.Text = "Telefon raqamingizni kiriting:";
            // 
            // txConfirmation
            // 
            txConfirmation.BackColor = Color.LightSkyBlue;
            txConfirmation.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txConfirmation.Location = new Point(686, 274);
            txConfirmation.Name = "txConfirmation";
            txConfirmation.Size = new Size(256, 53);
            txConfirmation.TabIndex = 18;
            txConfirmation.Text = "Kod olish";
            txConfirmation.UseVisualStyleBackColor = false;
            txConfirmation.Click += txConfirmation_Click;
            // 
            // btBack
            // 
            btBack.BackColor = Color.Silver;
            btBack.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btBack.Location = new Point(693, 746);
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
            lb998.Location = new Point(585, 194);
            lb998.Name = "lb998";
            lb998.Size = new Size(95, 45);
            lb998.TabIndex = 20;
            lb998.Text = "+998";
            // 
            // btNewLogPass
            // 
            btNewLogPass.BackColor = Color.FromArgb(128, 255, 128);
            btNewLogPass.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btNewLogPass.Location = new Point(83, 452);
            btNewLogPass.Name = "btNewLogPass";
            btNewLogPass.Size = new Size(859, 60);
            btNewLogPass.TabIndex = 15;
            btNewLogPass.Text = "Saqlash";
            btNewLogPass.UseVisualStyleBackColor = false;
            btNewLogPass.Click += btNewLogPass_Click;
            // 
            // txNewPassword
            // 
            txNewPassword.BackColor = Color.FromArgb(255, 255, 192);
            txNewPassword.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txNewPassword.Location = new Point(452, 363);
            txNewPassword.Name = "txNewPassword";
            txNewPassword.Size = new Size(490, 48);
            txNewPassword.TabIndex = 23;
            // 
            // lbNewPassword
            // 
            lbNewPassword.AutoSize = true;
            lbNewPassword.Font = new Font("Trebuchet MS", 22.2F);
            lbNewPassword.Location = new Point(83, 361);
            lbNewPassword.Name = "lbNewPassword";
            lbNewPassword.Size = new Size(363, 46);
            lbNewPassword.TabIndex = 22;
            lbNewPassword.Text = "Yangi parol yarating:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(btNewLogPass);
            panel1.Controls.Add(txNewPassword);
            panel1.Controls.Add(lbPhoneNumber);
            panel1.Controls.Add(lbNewPassword);
            panel1.Controls.Add(lbSmsPassword);
            panel1.Controls.Add(lb998);
            panel1.Controls.Add(txSmsPassword);
            panel1.Controls.Add(btBack);
            panel1.Controls.Add(txPhoneNumber);
            panel1.Controls.Add(txConfirmation);
            panel1.Location = new Point(464, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(1016, 862);
            panel1.TabIndex = 24;
            // 
            // NewLogPassForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1917, 1033);
            Controls.Add(panel1);
            Name = "NewLogPassForm";
            Text = "NewLogPassForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
        private TextBox txNewPassword;
        private Label lbNewPassword;
        private Panel panel1;
    }
}