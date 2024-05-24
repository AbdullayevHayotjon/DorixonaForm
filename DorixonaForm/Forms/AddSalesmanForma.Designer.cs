namespace DorixonaForm.Forms
{
    partial class AddSalesmanForma
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
            components = new System.ComponentModel.Container();
            dGVAddEmploye = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fIODataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            loginDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employeTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employeBindingSource1 = new BindingSource(components);
            employeBindingSource = new BindingSource(components);
            txAddPhoneNumber = new TextBox();
            txAddSmsPassword = new TextBox();
            txAddFIO = new TextBox();
            txAddLogin = new TextBox();
            txAddPassword = new TextBox();
            btAddSmsPassword = new Button();
            btSaqlash = new Button();
            cbSearch = new ComboBox();
            btSearch = new Button();
            txPillInformation = new TextBox();
            btBack = new Button();
            panel1 = new Panel();
            label5 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            lbAddPillName = new Label();
            lb998 = new Label();
            label2 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dGVAddEmploye).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeBindingSource).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dGVAddEmploye
            // 
            dGVAddEmploye.AutoGenerateColumns = false;
            dGVAddEmploye.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVAddEmploye.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, fIODataGridViewTextBoxColumn, loginDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, employeTypeDataGridViewTextBoxColumn });
            dGVAddEmploye.DataSource = employeBindingSource1;
            dGVAddEmploye.Location = new Point(64, 228);
            dGVAddEmploye.Name = "dGVAddEmploye";
            dGVAddEmploye.RowHeadersWidth = 51;
            dGVAddEmploye.Size = new Size(805, 408);
            dGVAddEmploye.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            fIODataGridViewTextBoxColumn.HeaderText = "FIO";
            fIODataGridViewTextBoxColumn.MinimumWidth = 6;
            fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            fIODataGridViewTextBoxColumn.Width = 125;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            loginDataGridViewTextBoxColumn.HeaderText = "Login";
            loginDataGridViewTextBoxColumn.MinimumWidth = 6;
            loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            loginDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeTypeDataGridViewTextBoxColumn
            // 
            employeTypeDataGridViewTextBoxColumn.DataPropertyName = "EmployeType";
            employeTypeDataGridViewTextBoxColumn.HeaderText = "EmployeType";
            employeTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            employeTypeDataGridViewTextBoxColumn.Name = "employeTypeDataGridViewTextBoxColumn";
            employeTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeBindingSource1
            // 
            employeBindingSource1.DataSource = typeof(Actions.Employe);
            // 
            // txAddPhoneNumber
            // 
            txAddPhoneNumber.BackColor = Color.FromArgb(255, 255, 192);
            txAddPhoneNumber.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txAddPhoneNumber.Location = new Point(391, 141);
            txAddPhoneNumber.Name = "txAddPhoneNumber";
            txAddPhoneNumber.Size = new Size(289, 47);
            txAddPhoneNumber.TabIndex = 6;
            // 
            // txAddSmsPassword
            // 
            txAddSmsPassword.BackColor = Color.FromArgb(255, 255, 192);
            txAddSmsPassword.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txAddSmsPassword.Location = new Point(312, 206);
            txAddSmsPassword.Name = "txAddSmsPassword";
            txAddSmsPassword.Size = new Size(186, 47);
            txAddSmsPassword.TabIndex = 7;
            // 
            // txAddFIO
            // 
            txAddFIO.BackColor = Color.FromArgb(255, 255, 192);
            txAddFIO.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txAddFIO.Location = new Point(312, 272);
            txAddFIO.Name = "txAddFIO";
            txAddFIO.Size = new Size(368, 47);
            txAddFIO.TabIndex = 8;
            // 
            // txAddLogin
            // 
            txAddLogin.BackColor = Color.FromArgb(255, 255, 192);
            txAddLogin.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txAddLogin.Location = new Point(312, 343);
            txAddLogin.Name = "txAddLogin";
            txAddLogin.Size = new Size(368, 47);
            txAddLogin.TabIndex = 9;
            // 
            // txAddPassword
            // 
            txAddPassword.BackColor = Color.FromArgb(255, 255, 192);
            txAddPassword.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txAddPassword.Location = new Point(312, 416);
            txAddPassword.Name = "txAddPassword";
            txAddPassword.Size = new Size(368, 47);
            txAddPassword.TabIndex = 10;
            // 
            // btAddSmsPassword
            // 
            btAddSmsPassword.BackColor = Color.LightSkyBlue;
            btAddSmsPassword.Font = new Font("Trebuchet MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btAddSmsPassword.Location = new Point(514, 206);
            btAddSmsPassword.Name = "btAddSmsPassword";
            btAddSmsPassword.Size = new Size(166, 44);
            btAddSmsPassword.TabIndex = 11;
            btAddSmsPassword.Text = "Kod yuborish";
            btAddSmsPassword.UseVisualStyleBackColor = false;
            btAddSmsPassword.Click += btAddSmsPassword_Click;
            // 
            // btSaqlash
            // 
            btSaqlash.BackColor = Color.LightSkyBlue;
            btSaqlash.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btSaqlash.Location = new Point(39, 562);
            btSaqlash.Name = "btSaqlash";
            btSaqlash.Size = new Size(641, 54);
            btSaqlash.TabIndex = 12;
            btSaqlash.Text = "SAQLASH";
            btSaqlash.UseVisualStyleBackColor = false;
            btSaqlash.Click += btSaqlash_Click;
            // 
            // cbSearch
            // 
            cbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearch.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cbSearch.FormattingEnabled = true;
            cbSearch.Items.AddRange(new object[] { "Id", "FIO", "Login", "Password", "PhoneNumber", "EmployeType" });
            cbSearch.Location = new Point(108, 172);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(269, 49);
            cbSearch.TabIndex = 84;
            // 
            // btSearch
            // 
            btSearch.BackColor = Color.LightSkyBlue;
            btSearch.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btSearch.Location = new Point(679, 178);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(146, 44);
            btSearch.TabIndex = 82;
            btSearch.Text = "Qidirish";
            btSearch.UseVisualStyleBackColor = false;
            btSearch.Click += btSearch_Click;
            // 
            // txPillInformation
            // 
            txPillInformation.BackColor = Color.FromArgb(255, 255, 192);
            txPillInformation.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txPillInformation.Location = new Point(383, 174);
            txPillInformation.Name = "txPillInformation";
            txPillInformation.Size = new Size(290, 48);
            txPillInformation.TabIndex = 83;
            // 
            // btBack
            // 
            btBack.BackColor = Color.Silver;
            btBack.Font = new Font("Trebuchet MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btBack.Location = new Point(1463, 829);
            btBack.Name = "btBack";
            btBack.Size = new Size(193, 44);
            btBack.TabIndex = 90;
            btBack.Text = "Orqaga qaytish";
            btBack.UseVisualStyleBackColor = false;
            btBack.Click += btBack_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lbAddPillName);
            panel1.Controls.Add(lb998);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txAddFIO);
            panel1.Controls.Add(btSaqlash);
            panel1.Controls.Add(btAddSmsPassword);
            panel1.Controls.Add(txAddPhoneNumber);
            panel1.Controls.Add(txAddPassword);
            panel1.Controls.Add(txAddSmsPassword);
            panel1.Controls.Add(txAddLogin);
            panel1.Location = new Point(940, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(716, 712);
            panel1.TabIndex = 91;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(39, 422);
            label5.Name = "label5";
            label5.Size = new Size(217, 38);
            label5.TabIndex = 95;
            label5.Text = "Parol yarating:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(39, 212);
            label1.Name = "label1";
            label1.Size = new Size(267, 38);
            label1.TabIndex = 93;
            label1.Text = "Sms kodni kiriting:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(39, 349);
            label3.Name = "label3";
            label3.Size = new Size(219, 38);
            label3.TabIndex = 93;
            label3.Text = "Login yarating:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(39, 278);
            label4.Name = "label4";
            label4.Size = new Size(72, 38);
            label4.TabIndex = 94;
            label4.Text = "FIO:";
            // 
            // lbAddPillName
            // 
            lbAddPillName.AutoSize = true;
            lbAddPillName.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbAddPillName.Location = new Point(39, 147);
            lbAddPillName.Name = "lbAddPillName";
            lbAddPillName.Size = new Size(220, 38);
            lbAddPillName.TabIndex = 92;
            lbAddPillName.Text = "Telefon raqam:";
            // 
            // lb998
            // 
            lb998.AutoSize = true;
            lb998.Font = new Font("Calibri Light", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lb998.Location = new Point(290, 144);
            lb998.Name = "lb998";
            lb998.Size = new Size(95, 45);
            lb998.TabIndex = 92;
            lb998.Text = "+998";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 24F);
            label2.Location = new Point(210, 24);
            label2.Name = "label2";
            label2.Size = new Size(321, 49);
            label2.TabIndex = 92;
            label2.Text = "Sotuvchi qo'shish";
            label2.Click += label2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 24F);
            label6.Location = new Point(318, 111);
            label6.Name = "label6";
            label6.Size = new Size(316, 49);
            label6.TabIndex = 96;
            label6.Text = "Ishchilar ro'yxati";
            // 
            // AddSalesmanForma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1722, 943);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(btBack);
            Controls.Add(cbSearch);
            Controls.Add(btSearch);
            Controls.Add(txPillInformation);
            Controls.Add(dGVAddEmploye);
            Name = "AddSalesmanForma";
            Text = "AddSalesmanForma";
            FormClosed += AddSalesmanForma_FormClosed;
            Load += AddSalesmanForma_Load;
            ((System.ComponentModel.ISupportInitialize)dGVAddEmploye).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dGVAddEmploye;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employeTypeDataGridViewTextBoxColumn;
        private BindingSource employeBindingSource;
        private TextBox txAddPhoneNumber;
        private TextBox txAddSmsPassword;
        private TextBox txAddFIO;
        private TextBox txAddLogin;
        private TextBox txAddPassword;
        private Button btAddSmsPassword;
        private Button btSaqlash;
        private ComboBox cbSearch;
        private Button btSearch;
        private TextBox txPillInformation;
        private Button btBack;
        private Panel panel1;
        private Label label2;
        private Label lb998;
        private Label label1;
        private Label lbAddPillName;
        private Label label3;
        private Label label4;
        private Label label5;
        private BindingSource employeBindingSource1;
        private Label label6;
    }
}