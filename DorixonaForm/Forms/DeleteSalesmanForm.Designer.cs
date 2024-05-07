namespace DorixonaForm.Forms
{
    partial class txDeleteSalesmanForm
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
            txSendPassword = new Button();
            txDeletePhoneNumber = new TextBox();
            txDeleteSmsPassword = new TextBox();
            lbSmsPassword = new Label();
            lbPhoneNumber = new Label();
            btDeleteSalesman = new Button();
            btBack = new Button();
            SuspendLayout();
            // 
            // lb998
            // 
            lb998.AutoSize = true;
            lb998.Font = new Font("Calibri Light", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lb998.Location = new Point(718, 224);
            lb998.Name = "lb998";
            lb998.Size = new Size(95, 45);
            lb998.TabIndex = 38;
            lb998.Text = "+998";
            // 
            // txSendPassword
            // 
            txSendPassword.BackColor = Color.LightSkyBlue;
            txSendPassword.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txSendPassword.Location = new Point(819, 279);
            txSendPassword.Name = "txSendPassword";
            txSendPassword.Size = new Size(213, 53);
            txSendPassword.TabIndex = 37;
            txSendPassword.Text = "Kod yuborish";
            txSendPassword.UseVisualStyleBackColor = false;
            txSendPassword.Click += txSendPassword_Click;
            // 
            // txDeletePhoneNumber
            // 
            txDeletePhoneNumber.BackColor = Color.FromArgb(255, 255, 192);
            txDeletePhoneNumber.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txDeletePhoneNumber.Location = new Point(819, 219);
            txDeletePhoneNumber.Name = "txDeletePhoneNumber";
            txDeletePhoneNumber.Size = new Size(213, 48);
            txDeletePhoneNumber.TabIndex = 36;
            txDeletePhoneNumber.Tag = "";
            // 
            // txDeleteSmsPassword
            // 
            txDeleteSmsPassword.BackColor = Color.FromArgb(255, 255, 192);
            txDeleteSmsPassword.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txDeleteSmsPassword.Location = new Point(819, 338);
            txDeleteSmsPassword.Name = "txDeleteSmsPassword";
            txDeleteSmsPassword.Size = new Size(213, 48);
            txDeleteSmsPassword.TabIndex = 35;
            txDeleteSmsPassword.Tag = "";
            // 
            // lbSmsPassword
            // 
            lbSmsPassword.AutoSize = true;
            lbSmsPassword.Font = new Font("Trebuchet MS", 22.2F);
            lbSmsPassword.Location = new Point(444, 336);
            lbSmsPassword.Name = "lbSmsPassword";
            lbSmsPassword.Size = new Size(331, 46);
            lbSmsPassword.TabIndex = 34;
            lbSmsPassword.Text = "Sms kodni kiriting:";
            // 
            // lbPhoneNumber
            // 
            lbPhoneNumber.AutoSize = true;
            lbPhoneNumber.Font = new Font("Trebuchet MS", 22.2F);
            lbPhoneNumber.Location = new Point(444, 223);
            lbPhoneNumber.Name = "lbPhoneNumber";
            lbPhoneNumber.Size = new Size(270, 46);
            lbPhoneNumber.TabIndex = 33;
            lbPhoneNumber.Text = "Telefon raqam:";
            // 
            // btDeleteSalesman
            // 
            btDeleteSalesman.BackColor = Color.LightSkyBlue;
            btDeleteSalesman.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btDeleteSalesman.Location = new Point(444, 409);
            btDeleteSalesman.Name = "btDeleteSalesman";
            btDeleteSalesman.Size = new Size(588, 60);
            btDeleteSalesman.TabIndex = 41;
            btDeleteSalesman.Text = "O'chirish";
            btDeleteSalesman.UseVisualStyleBackColor = false;
            btDeleteSalesman.Click += btDeleteSalesman_Click;
            // 
            // btBack
            // 
            btBack.BackColor = Color.Silver;
            btBack.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btBack.Location = new Point(783, 489);
            btBack.Name = "btBack";
            btBack.Size = new Size(249, 53);
            btBack.TabIndex = 40;
            btBack.Text = "Orqaga qaytish";
            btBack.UseVisualStyleBackColor = false;
            btBack.Click += btBack_Click;
            // 
            // txDeleteSalesmanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1482, 903);
            Controls.Add(btDeleteSalesman);
            Controls.Add(btBack);
            Controls.Add(lb998);
            Controls.Add(txSendPassword);
            Controls.Add(txDeletePhoneNumber);
            Controls.Add(txDeleteSmsPassword);
            Controls.Add(lbSmsPassword);
            Controls.Add(lbPhoneNumber);
            Name = "txDeleteSalesmanForm";
            Text = "DeleteSalesmanForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb998;
        private Button txSendPassword;
        private TextBox txDeletePhoneNumber;
        private TextBox txDeleteSmsPassword;
        private Label lbSmsPassword;
        private Label lbPhoneNumber;
        private Button btDeleteSalesman;
        private Button btBack;
    }
}