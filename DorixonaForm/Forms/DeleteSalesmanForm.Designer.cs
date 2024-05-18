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
            btDeleteSalesman = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txDeleteSmsPassword = new TextBox();
            txSendPassword = new Button();
            txDeletePhoneNumber = new TextBox();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 24F);
            label6.Location = new Point(796, 160);
            label6.Name = "label6";
            label6.Size = new Size(330, 49);
            label6.TabIndex = 61;
            label6.Text = "Sotuvchi o'chirish";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCyan;
            panel2.Controls.Add(btDeleteSalesman);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txDeleteSmsPassword);
            panel2.Controls.Add(txSendPassword);
            panel2.Controls.Add(txDeletePhoneNumber);
            panel2.Location = new Point(567, 212);
            panel2.Name = "panel2";
            panel2.Size = new Size(783, 661);
            panel2.TabIndex = 60;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 22.2F);
            label4.Location = new Point(34, 118);
            label4.Name = "label4";
            label4.Size = new Size(270, 46);
            label4.TabIndex = 42;
            label4.Text = "Telefon raqam:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 22.2F);
            label3.Location = new Point(34, 182);
            label3.Name = "label3";
            label3.Size = new Size(331, 46);
            label3.TabIndex = 43;
            label3.Text = "Sms kodni kiriting:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri Light", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(336, 119);
            label2.Name = "label2";
            label2.Size = new Size(95, 45);
            label2.TabIndex = 47;
            label2.Text = "+998";
            // 
            // txDeleteSmsPassword
            // 
            txDeleteSmsPassword.BackColor = Color.FromArgb(255, 255, 192);
            txDeleteSmsPassword.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txDeleteSmsPassword.Location = new Point(367, 184);
            txDeleteSmsPassword.Name = "txDeleteSmsPassword";
            txDeleteSmsPassword.Size = new Size(158, 48);
            txDeleteSmsPassword.TabIndex = 44;
            txDeleteSmsPassword.Tag = "";
            // 
            // txSendPassword
            // 
            txSendPassword.BackColor = Color.LightSkyBlue;
            txSendPassword.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txSendPassword.Location = new Point(543, 181);
            txSendPassword.Name = "txSendPassword";
            txSendPassword.Size = new Size(213, 53);
            txSendPassword.TabIndex = 46;
            txSendPassword.Text = "Kod yuborish";
            txSendPassword.UseVisualStyleBackColor = false;
            txSendPassword.Click += txSendPassword_Click;
            // 
            // txDeletePhoneNumber
            // 
            txDeletePhoneNumber.BackColor = Color.FromArgb(255, 255, 192);
            txDeletePhoneNumber.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txDeletePhoneNumber.Location = new Point(437, 116);
            txDeletePhoneNumber.Name = "txDeletePhoneNumber";
            txDeletePhoneNumber.Size = new Size(319, 48);
            txDeletePhoneNumber.TabIndex = 45;
            txDeletePhoneNumber.Tag = "";
            // 
            // DeleteSalesmanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1917, 1033);
            Controls.Add(label6);
            Controls.Add(panel2);
            Name = "DeleteSalesmanForm";
            Text = "DeleteSalesmanForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Panel panel2;
        private Button btDeleteSalesman;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txDeleteSmsPassword;
        private Button txSendPassword;
        private TextBox txDeletePhoneNumber;
    }
}