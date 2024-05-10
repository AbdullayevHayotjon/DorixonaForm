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
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LkUpdateLogPass
            // 
            LkUpdateLogPass.AutoSize = true;
            LkUpdateLogPass.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LkUpdateLogPass.Location = new Point(145, 521);
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
            txLogin.Location = new Point(73, 229);
            txLogin.Name = "txLogin";
            txLogin.Size = new Size(497, 48);
            txLogin.TabIndex = 11;
            // 
            // txPassword
            // 
            txPassword.BackColor = Color.FromArgb(255, 255, 192);
            txPassword.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txPassword.Location = new Point(73, 359);
            txPassword.Name = "txPassword";
            txPassword.Size = new Size(497, 48);
            txPassword.TabIndex = 10;
            // 
            // btEnter
            // 
            btEnter.BackColor = Color.LightSkyBlue;
            btEnter.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btEnter.Location = new Point(73, 449);
            btEnter.Name = "btEnter";
            btEnter.Size = new Size(497, 60);
            btEnter.TabIndex = 9;
            btEnter.Text = "Kirish";
            btEnter.UseVisualStyleBackColor = false;
            btEnter.Click += btEnter_Click;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Trebuchet MS", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbPassword.Location = new Point(73, 313);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(95, 43);
            lbPassword.TabIndex = 8;
            lbPassword.Text = "Parol";
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Trebuchet MS", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbLogin.Location = new Point(73, 183);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(100, 43);
            lbLogin.TabIndex = 7;
            lbLogin.Text = "Login";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(lbLogin);
            panel1.Controls.Add(LkUpdateLogPass);
            panel1.Controls.Add(txLogin);
            panel1.Controls.Add(btEnter);
            panel1.Controls.Add(txPassword);
            panel1.Controls.Add(lbPassword);
            panel1.Location = new Point(629, 178);
            panel1.Name = "panel1";
            panel1.Size = new Size(640, 800);
            panel1.TabIndex = 13;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1917, 1158);
            Controls.Add(panel1);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private LinkLabel LkUpdateLogPass;
        private TextBox txLogin;
        private TextBox txPassword;
        private Button btEnter;
        private Label lbPassword;
        private Label lbLogin;
        private Panel panel1;
    }
}
