namespace DorixonaForm
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LkUpdateLogPass = new LinkLabel();
            txLogin = new TextBox();
            txPassword = new TextBox();
            btEnter = new Button();
            lbPassword = new Label();
            lbLogin = new Label();
            SuspendLayout();
            // 
            // LkUpdateLogPass
            // 
            LkUpdateLogPass.AutoSize = true;
            LkUpdateLogPass.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LkUpdateLogPass.Location = new Point(574, 514);
            LkUpdateLogPass.Name = "LkUpdateLogPass";
            LkUpdateLogPass.Size = new Size(350, 31);
            LkUpdateLogPass.TabIndex = 12;
            LkUpdateLogPass.TabStop = true;
            LkUpdateLogPass.Text = "Login yoki parol esdan chiqdimi?";
            LkUpdateLogPass.LinkClicked += LkRegister_LinkClicked;
            // 
            // txLogin
            // 
            txLogin.BackColor = Color.FromArgb(255, 255, 192);
            txLogin.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txLogin.Location = new Point(735, 291);
            txLogin.Name = "txLogin";
            txLogin.Size = new Size(314, 48);
            txLogin.TabIndex = 11;
            // 
            // txPassword
            // 
            txPassword.BackColor = Color.FromArgb(255, 255, 192);
            txPassword.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txPassword.Location = new Point(735, 364);
            txPassword.Name = "txPassword";
            txPassword.PasswordChar = '*';
            txPassword.Size = new Size(314, 48);
            txPassword.TabIndex = 10;
            // 
            // btEnter
            // 
            btEnter.BackColor = Color.LightSkyBlue;
            btEnter.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btEnter.Location = new Point(449, 442);
            btEnter.Name = "btEnter";
            btEnter.Size = new Size(600, 60);
            btEnter.TabIndex = 9;
            btEnter.Text = "Kirish";
            btEnter.UseVisualStyleBackColor = false;
            btEnter.Click += btEnter_Click;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Trebuchet MS", 22.2F);
            lbPassword.Location = new Point(449, 364);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(279, 46);
            lbPassword.TabIndex = 8;
            lbPassword.Text = "Parolni kiriting:";
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Trebuchet MS", 22.2F);
            lbLogin.Location = new Point(449, 291);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(285, 46);
            lbLogin.TabIndex = 7;
            lbLogin.Text = "Loginni kiriting:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1482, 903);
            Controls.Add(LkUpdateLogPass);
            Controls.Add(txLogin);
            Controls.Add(txPassword);
            Controls.Add(btEnter);
            Controls.Add(lbPassword);
            Controls.Add(lbLogin);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel LkUpdateLogPass;
        private TextBox txLogin;
        private TextBox txPassword;
        private Button btEnter;
        private Label lbPassword;
        private Label lbLogin;
    }
}
