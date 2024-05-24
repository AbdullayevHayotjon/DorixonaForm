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
            txPhoneNumber.Location = new Point(681, 139);
            txPhoneNumber.Name = "txPhoneNumber";
            txPhoneNumber.Size = new Size(256, 48);
            txPhoneNumber.TabIndex = 17;
            txPhoneNumber.Tag = "";
            // 
            // txSmsPassword
            // 
            txSmsPassword.BackColor = Color.FromArgb(255, 255, 192);
            txSmsPassword.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txSmsPassword.Location = new Point(447, 222);
            txSmsPassword.Name = "txSmsPassword";
            txSmsPassword.Size = new Size(200, 48);
            txSmsPassword.TabIndex = 16;
            txSmsPassword.Tag = "";
            // 
            // lbSmsPassword
            // 
            lbSmsPassword.AutoSize = true;
            lbSmsPassword.Font = new Font("Trebuchet MS", 22.2F);
            lbSmsPassword.Location = new Point(78, 220);
            lbSmsPassword.Name = "lbSmsPassword";
            lbSmsPassword.Size = new Size(331, 46);
            lbSmsPassword.TabIndex = 14;
            lbSmsPassword.Text = "Sms kodni kiriting:";
            // 
            // lbPhoneNumber
            // 
            lbPhoneNumber.AutoSize = true;
            lbPhoneNumber.Font = new Font("Trebuchet MS", 22.2F);
            lbPhoneNumber.Location = new Point(78, 141);
            lbPhoneNumber.Name = "lbPhoneNumber";
            lbPhoneNumber.Size = new Size(511, 46);
            lbPhoneNumber.TabIndex = 13;
            lbPhoneNumber.Text = "Telefon raqamingizni kiriting:";
            // 
            // txConfirmation
            // 
            txConfirmation.BackColor = Color.LightSkyBlue;
            txConfirmation.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txConfirmation.Location = new Point(681, 222);
            txConfirmation.Name = "txConfirmation";
            txConfirmation.Size = new Size(256, 53);
            txConfirmation.TabIndex = 18;
            txConfirmation.Text = "Kod olish";
            txConfirmation.UseVisualStyleBackColor = false;
            txConfirmation.Click += txConfirmation_Click;
            // 
            // lb998
            // 
            lb998.AutoSize = true;
            lb998.Font = new Font("Calibri Light", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lb998.Location = new Point(580, 142);
            lb998.Name = "lb998";
            lb998.Size = new Size(95, 45);
            lb998.TabIndex = 20;
            lb998.Text = "+998";
            // 
            // btNewLogPass
            // 
            btNewLogPass.BackColor = Color.FromArgb(128, 255, 128);
            btNewLogPass.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btNewLogPass.Location = new Point(78, 611);
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
            txNewPassword.Location = new Point(447, 311);
            txNewPassword.Name = "txNewPassword";
            txNewPassword.Size = new Size(490, 48);
            txNewPassword.TabIndex = 23;
            // 
            // lbNewPassword
            // 
            lbNewPassword.AutoSize = true;
            lbNewPassword.Font = new Font("Trebuchet MS", 22.2F);
            lbNewPassword.Location = new Point(78, 309);
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
            panel1.Controls.Add(txPhoneNumber);
            panel1.Controls.Add(txConfirmation);
            panel1.Location = new Point(373, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(1016, 813);
            panel1.TabIndex = 24;
            panel1.Paint += panel1_Paint;
            // 
            // NewLogPassForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1717, 943);
            Controls.Add(panel1);
            Name = "NewLogPassForm";
            Text = "NewLogPassForm";
            FormClosed += NewLogPassForm_FormClosed;
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
        private Label lb998;
        private Button btNewLogPass;
        private TextBox txNewPassword;
        private Label lbNewPassword;
        private Panel panel1;
    }
}