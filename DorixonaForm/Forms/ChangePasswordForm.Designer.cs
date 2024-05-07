namespace DorixonaForm.Forms
{
    partial class ChangePasswordForm
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
            btSaveNewPassword = new Button();
            txNewPassword2 = new TextBox();
            lbNewPassword2 = new Label();
            txOldPassword = new TextBox();
            txNewPassword = new TextBox();
            lbNewPassword = new Label();
            lbNewLogin = new Label();
            btBack = new Button();
            SuspendLayout();
            // 
            // btSaveNewPassword
            // 
            btSaveNewPassword.BackColor = Color.LightSkyBlue;
            btSaveNewPassword.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btSaveNewPassword.Location = new Point(392, 489);
            btSaveNewPassword.Name = "btSaveNewPassword";
            btSaveNewPassword.Size = new Size(426, 60);
            btSaveNewPassword.TabIndex = 47;
            btSaveNewPassword.Text = "Saqlash";
            btSaveNewPassword.UseVisualStyleBackColor = false;
            btSaveNewPassword.Click += btSaveNewPassword_Click;
            // 
            // txNewPassword2
            // 
            txNewPassword2.BackColor = Color.FromArgb(255, 255, 192);
            txNewPassword2.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txNewPassword2.Location = new Point(887, 421);
            txNewPassword2.Name = "txNewPassword2";
            txNewPassword2.Size = new Size(188, 48);
            txNewPassword2.TabIndex = 46;
            // 
            // lbNewPassword2
            // 
            lbNewPassword2.AutoSize = true;
            lbNewPassword2.Font = new Font("Trebuchet MS", 22.2F);
            lbNewPassword2.Location = new Point(392, 419);
            lbNewPassword2.Name = "lbNewPassword2";
            lbNewPassword2.Size = new Size(261, 46);
            lbNewPassword2.TabIndex = 45;
            lbNewPassword2.Text = "Qayta kiriting:";
            // 
            // txOldPassword
            // 
            txOldPassword.BackColor = Color.FromArgb(255, 255, 192);
            txOldPassword.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txOldPassword.Location = new Point(887, 279);
            txOldPassword.Name = "txOldPassword";
            txOldPassword.Size = new Size(188, 48);
            txOldPassword.TabIndex = 44;
            // 
            // txNewPassword
            // 
            txNewPassword.BackColor = Color.FromArgb(255, 255, 192);
            txNewPassword.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txNewPassword.Location = new Point(887, 346);
            txNewPassword.Name = "txNewPassword";
            txNewPassword.Size = new Size(188, 48);
            txNewPassword.TabIndex = 43;
            // 
            // lbNewPassword
            // 
            lbNewPassword.AutoSize = true;
            lbNewPassword.Font = new Font("Trebuchet MS", 22.2F);
            lbNewPassword.Location = new Point(392, 344);
            lbNewPassword.Name = "lbNewPassword";
            lbNewPassword.Size = new Size(379, 46);
            lbNewPassword.TabIndex = 42;
            lbNewPassword.Text = "Yangi parolni kiriting:";
            // 
            // lbNewLogin
            // 
            lbNewLogin.AutoSize = true;
            lbNewLogin.Font = new Font("Trebuchet MS", 22.2F);
            lbNewLogin.Location = new Point(392, 277);
            lbNewLogin.Name = "lbNewLogin";
            lbNewLogin.Size = new Size(489, 46);
            lbNewLogin.TabIndex = 41;
            lbNewLogin.Text = "Oldingi parolingizni kiriting:";
            // 
            // btBack
            // 
            btBack.BackColor = Color.Silver;
            btBack.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btBack.Location = new Point(826, 495);
            btBack.Name = "btBack";
            btBack.Size = new Size(249, 53);
            btBack.TabIndex = 40;
            btBack.Text = "Orqaga qaytish";
            btBack.UseVisualStyleBackColor = false;
            btBack.Click += btBack_Click;
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1482, 903);
            Controls.Add(btSaveNewPassword);
            Controls.Add(txNewPassword2);
            Controls.Add(lbNewPassword2);
            Controls.Add(txOldPassword);
            Controls.Add(txNewPassword);
            Controls.Add(lbNewPassword);
            Controls.Add(lbNewLogin);
            Controls.Add(btBack);
            Name = "ChangePasswordForm";
            Text = "ChangePasswordForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSaveNewPassword;
        private TextBox txNewPassword2;
        private Label lbNewPassword2;
        private TextBox txOldPassword;
        private TextBox txNewPassword;
        private Label lbNewPassword;
        private Label lbNewLogin;
        private Button btBack;
    }
}