namespace DorixonaForm.Forms
{
    partial class ChangePhoneNumberForm
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
            btChangePhoneNumber = new Button();
            btBack = new Button();
            lb998 = new Label();
            txSendPassword = new Button();
            txNewPhoneNumber = new TextBox();
            txSmsPassword = new TextBox();
            lbSmsPassword = new Label();
            lbNewPhoneNumber = new Label();
            SuspendLayout();
            // 
            // btChangePhoneNumber
            // 
            btChangePhoneNumber.BackColor = Color.LightSkyBlue;
            btChangePhoneNumber.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btChangePhoneNumber.Location = new Point(584, 459);
            btChangePhoneNumber.Name = "btChangePhoneNumber";
            btChangePhoneNumber.Size = new Size(588, 60);
            btChangePhoneNumber.TabIndex = 49;
            btChangePhoneNumber.Text = "Saqlash";
            btChangePhoneNumber.UseVisualStyleBackColor = false;
            btChangePhoneNumber.Click += btChangePhoneNumber_Click;
            // 
            // btBack
            // 
            btBack.BackColor = Color.Silver;
            btBack.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btBack.Location = new Point(923, 539);
            btBack.Name = "btBack";
            btBack.Size = new Size(249, 53);
            btBack.TabIndex = 48;
            btBack.Text = "Orqaga qaytish";
            btBack.UseVisualStyleBackColor = false;
            btBack.Click += btBack_Click;
            // 
            // lb998
            // 
            lb998.AutoSize = true;
            lb998.Font = new Font("Calibri Light", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lb998.Location = new Point(858, 274);
            lb998.Name = "lb998";
            lb998.Size = new Size(95, 45);
            lb998.TabIndex = 47;
            lb998.Text = "+998";
            // 
            // txSendPassword
            // 
            txSendPassword.BackColor = Color.LightSkyBlue;
            txSendPassword.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txSendPassword.Location = new Point(959, 329);
            txSendPassword.Name = "txSendPassword";
            txSendPassword.Size = new Size(213, 53);
            txSendPassword.TabIndex = 46;
            txSendPassword.Text = "Kod yuborish";
            txSendPassword.UseVisualStyleBackColor = false;
            txSendPassword.Click += txSendPassword_Click;
            // 
            // txNewPhoneNumber
            // 
            txNewPhoneNumber.BackColor = Color.FromArgb(255, 255, 192);
            txNewPhoneNumber.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txNewPhoneNumber.Location = new Point(959, 269);
            txNewPhoneNumber.Name = "txNewPhoneNumber";
            txNewPhoneNumber.Size = new Size(213, 48);
            txNewPhoneNumber.TabIndex = 45;
            txNewPhoneNumber.Tag = "";
            // 
            // txSmsPassword
            // 
            txSmsPassword.BackColor = Color.FromArgb(255, 255, 192);
            txSmsPassword.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txSmsPassword.Location = new Point(959, 388);
            txSmsPassword.Name = "txSmsPassword";
            txSmsPassword.Size = new Size(213, 48);
            txSmsPassword.TabIndex = 44;
            txSmsPassword.Tag = "";
            // 
            // lbSmsPassword
            // 
            lbSmsPassword.AutoSize = true;
            lbSmsPassword.Font = new Font("Trebuchet MS", 22.2F);
            lbSmsPassword.Location = new Point(584, 386);
            lbSmsPassword.Name = "lbSmsPassword";
            lbSmsPassword.Size = new Size(331, 46);
            lbSmsPassword.TabIndex = 43;
            lbSmsPassword.Text = "Sms kodni kiriting:";
            // 
            // lbNewPhoneNumber
            // 
            lbNewPhoneNumber.AutoSize = true;
            lbNewPhoneNumber.Font = new Font("Trebuchet MS", 22.2F);
            lbNewPhoneNumber.Location = new Point(255, 273);
            lbNewPhoneNumber.Name = "lbNewPhoneNumber";
            lbNewPhoneNumber.Size = new Size(608, 46);
            lbNewPhoneNumber.TabIndex = 42;
            lbNewPhoneNumber.Text = "Yangi telefon raqamingizni kiriting:";
            // 
            // ChangePhoneNumberForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1482, 903);
            Controls.Add(btChangePhoneNumber);
            Controls.Add(btBack);
            Controls.Add(lb998);
            Controls.Add(txSendPassword);
            Controls.Add(txNewPhoneNumber);
            Controls.Add(txSmsPassword);
            Controls.Add(lbSmsPassword);
            Controls.Add(lbNewPhoneNumber);
            Name = "ChangePhoneNumberForm";
            Text = "ChangePhoneNumberForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btChangePhoneNumber;
        private Button btBack;
        private Label lb998;
        private Button txSendPassword;
        private TextBox txNewPhoneNumber;
        private TextBox txSmsPassword;
        private Label lbSmsPassword;
        private Label lbNewPhoneNumber;
    }
}