namespace DorixonaForm.Forms
{
    partial class DeleteSalesmanForm
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
            label6 = new Label();
            panel2 = new Panel();
            txAddLogin = new TextBox();
            btDeleteSalesman = new Button();
            btPlacement = new Button();
            lbNewLogin = new Label();
            txId = new TextBox();
            txAddFIO = new TextBox();
            label1 = new Label();
            lbNewPassword = new Label();
            dGVDeleteEmploye = new DataGridView();
            btExit = new Button();
            btBack = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGVDeleteEmploye).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 24F);
            label6.Location = new Point(346, 58);
            label6.Name = "label6";
            label6.Size = new Size(359, 49);
            label6.TabIndex = 61;
            label6.Text = "Sotuvchilar royxati";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCyan;
            panel2.Controls.Add(txAddLogin);
            panel2.Controls.Add(btDeleteSalesman);
            panel2.Controls.Add(btPlacement);
            panel2.Controls.Add(lbNewLogin);
            panel2.Controls.Add(txId);
            panel2.Controls.Add(txAddFIO);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lbNewPassword);
            panel2.Location = new Point(1046, 189);
            panel2.Name = "panel2";
            panel2.Size = new Size(783, 661);
            panel2.TabIndex = 60;
            // 
            // txAddLogin
            // 
            txAddLogin.BackColor = Color.FromArgb(255, 255, 192);
            txAddLogin.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txAddLogin.Location = new Point(318, 313);
            txAddLogin.Name = "txAddLogin";
            txAddLogin.Size = new Size(438, 48);
            txAddLogin.TabIndex = 86;
            // 
            // btDeleteSalesman
            // 
            btDeleteSalesman.BackColor = Color.LightSkyBlue;
            btDeleteSalesman.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btDeleteSalesman.Location = new Point(34, 482);
            btDeleteSalesman.Name = "btDeleteSalesman";
            btDeleteSalesman.Size = new Size(722, 60);
            btDeleteSalesman.TabIndex = 49;
            btDeleteSalesman.Text = "O'chirish";
            btDeleteSalesman.UseVisualStyleBackColor = false;
            btDeleteSalesman.Click += btDeleteSalesman_Click;
            // 
            // btPlacement
            // 
            btPlacement.BackColor = Color.LightSkyBlue;
            btPlacement.Font = new Font("Trebuchet MS", 18F);
            btPlacement.Location = new Point(614, 57);
            btPlacement.Name = "btPlacement";
            btPlacement.Size = new Size(142, 47);
            btPlacement.TabIndex = 83;
            btPlacement.Text = "Joylash";
            btPlacement.UseVisualStyleBackColor = false;
            // 
            // lbNewLogin
            // 
            lbNewLogin.AutoSize = true;
            lbNewLogin.Font = new Font("Trebuchet MS", 22.2F);
            lbNewLogin.Location = new Point(34, 206);
            lbNewLogin.Name = "lbNewLogin";
            lbNewLogin.Size = new Size(88, 46);
            lbNewLogin.TabIndex = 84;
            lbNewLogin.Text = "FIO:";
            // 
            // txId
            // 
            txId.BackColor = Color.FromArgb(255, 255, 192);
            txId.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txId.Location = new Point(446, 56);
            txId.Name = "txId";
            txId.Size = new Size(135, 48);
            txId.TabIndex = 82;
            // 
            // txAddFIO
            // 
            txAddFIO.BackColor = Color.FromArgb(255, 255, 192);
            txAddFIO.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txAddFIO.Location = new Point(137, 204);
            txAddFIO.Name = "txAddFIO";
            txAddFIO.Size = new Size(619, 48);
            txAddFIO.TabIndex = 87;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 22.2F);
            label1.Location = new Point(34, 58);
            label1.Name = "label1";
            label1.Size = new Size(415, 46);
            label1.TabIndex = 81;
            label1.Text = "Sotuvchi Id sini kiriting:";
            // 
            // lbNewPassword
            // 
            lbNewPassword.AutoSize = true;
            lbNewPassword.Font = new Font("Trebuchet MS", 22.2F);
            lbNewPassword.Location = new Point(34, 315);
            lbNewPassword.Name = "lbNewPassword";
            lbNewPassword.Size = new Size(196, 46);
            lbNewPassword.TabIndex = 85;
            lbNewPassword.Text = "Tel raqam:";
            // 
            // dGVDeleteEmploye
            // 
            dGVDeleteEmploye.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVDeleteEmploye.Location = new Point(205, 110);
            dGVDeleteEmploye.Name = "dGVDeleteEmploye";
            dGVDeleteEmploye.RowHeadersWidth = 51;
            dGVDeleteEmploye.Size = new Size(679, 701);
            dGVDeleteEmploye.TabIndex = 62;
            dGVDeleteEmploye.CellContentClick += dGVEmploye_CellContentClick;
            // 
            // btExit
            // 
            btExit.BackColor = Color.Silver;
            btExit.Font = new Font("Trebuchet MS", 14F);
            btExit.Location = new Point(1767, 36);
            btExit.Name = "btExit";
            btExit.Size = new Size(124, 44);
            btExit.TabIndex = 84;
            btExit.Text = "Chiqish";
            btExit.UseVisualStyleBackColor = false;
            // 
            // btBack
            // 
            btBack.BackColor = Color.Silver;
            btBack.Font = new Font("Trebuchet MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btBack.Location = new Point(1698, 937);
            btBack.Name = "btBack";
            btBack.Size = new Size(193, 44);
            btBack.TabIndex = 85;
            btBack.Text = "Orqaga qaytish";
            btBack.UseVisualStyleBackColor = false;
            btBack.Click += btBack_Click;
            // 
            // DeleteSalesmanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1917, 1033);
            Controls.Add(btBack);
            Controls.Add(btExit);
            Controls.Add(dGVDeleteEmploye);
            Controls.Add(label6);
            Controls.Add(panel2);
            Name = "DeleteSalesmanForm";
            Text = "DeleteSalesmanForm";
            Load += DeleteSalesmanForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dGVDeleteEmploye).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Panel panel2;
        private Button btDeleteSalesman;
        private DataGridView dGVDeleteEmploye;
        private Button btPlacement;
        private TextBox txId;
        private Label label1;
        private TextBox txAddLogin;
        private Label lbNewLogin;
        private TextBox txAddFIO;
        private Label lbNewPassword;
        private Button btExit;
        private Button btBack;
    }
}