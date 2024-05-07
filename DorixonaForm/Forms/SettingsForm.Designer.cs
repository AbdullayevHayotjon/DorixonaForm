namespace DorixonaForm.Forms
{
    partial class SettingsForm
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
            btChangePassword = new Button();
            btChangePhoneNumber = new Button();
            btBack = new Button();
            SuspendLayout();
            // 
            // btChangePassword
            // 
            btChangePassword.BackColor = Color.LightSkyBlue;
            btChangePassword.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btChangePassword.Location = new Point(440, 310);
            btChangePassword.Name = "btChangePassword";
            btChangePassword.Size = new Size(600, 60);
            btChangePassword.TabIndex = 19;
            btChangePassword.Text = "Parolni o'zgartirish";
            btChangePassword.UseVisualStyleBackColor = false;
            btChangePassword.Click += btChangePassword_Click;
            // 
            // btChangePhoneNumber
            // 
            btChangePhoneNumber.BackColor = Color.LightSkyBlue;
            btChangePhoneNumber.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btChangePhoneNumber.Location = new Point(440, 393);
            btChangePhoneNumber.Name = "btChangePhoneNumber";
            btChangePhoneNumber.Size = new Size(600, 60);
            btChangePhoneNumber.TabIndex = 21;
            btChangePhoneNumber.Text = "Telefon raqamni o'zgartirish";
            btChangePhoneNumber.UseVisualStyleBackColor = false;
            btChangePhoneNumber.Click += btChangePhoneNumber_Click;
            // 
            // btBack
            // 
            btBack.BackColor = Color.Silver;
            btBack.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btBack.Location = new Point(791, 477);
            btBack.Name = "btBack";
            btBack.Size = new Size(249, 53);
            btBack.TabIndex = 41;
            btBack.Text = "Orqaga qaytish";
            btBack.UseVisualStyleBackColor = false;
            btBack.Click += btBack_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1482, 903);
            Controls.Add(btBack);
            Controls.Add(btChangePhoneNumber);
            Controls.Add(btChangePassword);
            Name = "SettingsForm";
            RightToLeft = RightToLeft.No;
            Text = "SettingsForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btChangePassword;
        private Button btChangePhoneNumber;
        private Button btBack;
    }
}