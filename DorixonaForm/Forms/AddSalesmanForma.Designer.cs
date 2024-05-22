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
            employeBindingSource = new BindingSource(components);
            lbAddPhoneNumber = new Label();
            lbAddSmsPassword = new Label();
            lbAddFIO = new Label();
            lbAddLogin = new Label();
            lbAddPassword = new Label();
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
            btExit = new Button();
            btBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dGVAddEmploye).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dGVAddEmploye
            // 
            dGVAddEmploye.AutoGenerateColumns = false;
            dGVAddEmploye.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVAddEmploye.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, fIODataGridViewTextBoxColumn, loginDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, employeTypeDataGridViewTextBoxColumn });
            dGVAddEmploye.DataSource = employeBindingSource;
            dGVAddEmploye.Location = new Point(648, 247);
            dGVAddEmploye.Name = "dGVAddEmploye";
            dGVAddEmploye.RowHeadersWidth = 51;
            dGVAddEmploye.Size = new Size(805, 544);
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
            // employeBindingSource
            // 
            employeBindingSource.DataSource = typeof(Actions.Employe);
            // 
            // lbAddPhoneNumber
            // 
            lbAddPhoneNumber.AutoSize = true;
            lbAddPhoneNumber.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbAddPhoneNumber.Location = new Point(6, 119);
            lbAddPhoneNumber.Name = "lbAddPhoneNumber";
            lbAddPhoneNumber.Size = new Size(224, 41);
            lbAddPhoneNumber.TabIndex = 1;
            lbAddPhoneNumber.Text = "Telefon nomer:";
            // 
            // lbAddSmsPassword
            // 
            lbAddSmsPassword.AutoSize = true;
            lbAddSmsPassword.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbAddSmsPassword.Location = new Point(11, 195);
            lbAddSmsPassword.Name = "lbAddSmsPassword";
            lbAddSmsPassword.Size = new Size(219, 41);
            lbAddSmsPassword.TabIndex = 2;
            lbAddSmsPassword.Text = "SMS ni kiritish:";
            lbAddSmsPassword.Click += lbAddSmsPassword_Click;
            // 
            // lbAddFIO
            // 
            lbAddFIO.AutoSize = true;
            lbAddFIO.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbAddFIO.Location = new Point(11, 270);
            lbAddFIO.Name = "lbAddFIO";
            lbAddFIO.Size = new Size(72, 41);
            lbAddFIO.TabIndex = 3;
            lbAddFIO.Text = "FIO:";
            // 
            // lbAddLogin
            // 
            lbAddLogin.AutoSize = true;
            lbAddLogin.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbAddLogin.Location = new Point(11, 338);
            lbAddLogin.Name = "lbAddLogin";
            lbAddLogin.Size = new Size(102, 41);
            lbAddLogin.TabIndex = 4;
            lbAddLogin.Text = "Login:";
            // 
            // lbAddPassword
            // 
            lbAddPassword.AutoSize = true;
            lbAddPassword.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbAddPassword.Location = new Point(11, 409);
            lbAddPassword.Name = "lbAddPassword";
            lbAddPassword.Size = new Size(95, 41);
            lbAddPassword.TabIndex = 5;
            lbAddPassword.Text = "Parol:";
            // 
            // txAddPhoneNumber
            // 
            txAddPhoneNumber.BackColor = SystemColors.Info;
            txAddPhoneNumber.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txAddPhoneNumber.Location = new Point(222, 119);
            txAddPhoneNumber.Name = "txAddPhoneNumber";
            txAddPhoneNumber.Size = new Size(409, 47);
            txAddPhoneNumber.TabIndex = 6;
            // 
            // txAddSmsPassword
            // 
            txAddSmsPassword.BackColor = SystemColors.Info;
            txAddSmsPassword.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txAddSmsPassword.Location = new Point(222, 195);
            txAddSmsPassword.Name = "txAddSmsPassword";
            txAddSmsPassword.Size = new Size(159, 47);
            txAddSmsPassword.TabIndex = 7;
            // 
            // txAddFIO
            // 
            txAddFIO.BackColor = SystemColors.Info;
            txAddFIO.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txAddFIO.Location = new Point(222, 270);
            txAddFIO.Name = "txAddFIO";
            txAddFIO.Size = new Size(409, 47);
            txAddFIO.TabIndex = 8;
            // 
            // txAddLogin
            // 
            txAddLogin.BackColor = SystemColors.Info;
            txAddLogin.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txAddLogin.Location = new Point(222, 338);
            txAddLogin.Name = "txAddLogin";
            txAddLogin.Size = new Size(409, 47);
            txAddLogin.TabIndex = 9;
            // 
            // txAddPassword
            // 
            txAddPassword.BackColor = SystemColors.Info;
            txAddPassword.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txAddPassword.Location = new Point(222, 409);
            txAddPassword.Name = "txAddPassword";
            txAddPassword.Size = new Size(409, 47);
            txAddPassword.TabIndex = 10;
            // 
            // btAddSmsPassword
            // 
            btAddSmsPassword.BackColor = Color.LightSkyBlue;
            btAddSmsPassword.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btAddSmsPassword.Location = new Point(409, 195);
            btAddSmsPassword.Name = "btAddSmsPassword";
            btAddSmsPassword.Size = new Size(222, 47);
            btAddSmsPassword.TabIndex = 11;
            btAddSmsPassword.Text = "SMS ni jo'natish";
            btAddSmsPassword.UseVisualStyleBackColor = false;
            btAddSmsPassword.Click += btAddSmsPassword_Click;
            // 
            // btSaqlash
            // 
            btSaqlash.BackColor = Color.LightSkyBlue;
            btSaqlash.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btSaqlash.Location = new Point(11, 493);
            btSaqlash.Name = "btSaqlash";
            btSaqlash.Size = new Size(620, 54);
            btSaqlash.TabIndex = 12;
            btSaqlash.Text = "SAQLASH";
            btSaqlash.UseVisualStyleBackColor = false;
            btSaqlash.Click += btSaqlash_Click;
            // 
            // cbSearch
            // 
            cbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearch.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cbSearch.FormattingEnabled = true;
            cbSearch.Items.AddRange(new object[] { "Id", "FIO", "Login", "Password", "PhoneNumber", "EmployeType" });
            cbSearch.Location = new Point(680, 163);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(269, 49);
            cbSearch.TabIndex = 84;
            // 
            // btSearch
            // 
            btSearch.BackColor = Color.LightSkyBlue;
            btSearch.Font = new Font("Trebuchet MS", 18F);
            btSearch.Location = new Point(1263, 163);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(146, 49);
            btSearch.TabIndex = 82;
            btSearch.Text = "Qidirish";
            btSearch.UseVisualStyleBackColor = false;
            btSearch.Click += btSearch_Click;
            // 
            // txPillInformation
            // 
            txPillInformation.BackColor = SystemColors.Info;
            txPillInformation.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txPillInformation.Location = new Point(954, 163);
            txPillInformation.Name = "txPillInformation";
            txPillInformation.Size = new Size(290, 48);
            txPillInformation.TabIndex = 83;
            // 
            // btExit
            // 
            btExit.BackColor = Color.Silver;
            btExit.Font = new Font("Trebuchet MS", 14F);
            btExit.Location = new Point(1426, 41);
            btExit.Name = "btExit";
            btExit.Size = new Size(124, 44);
            btExit.TabIndex = 89;
            btExit.Text = "Chiqish";
            btExit.UseVisualStyleBackColor = false;
            btExit.Click += btExit_Click;
            // 
            // btBack
            // 
            btBack.BackColor = Color.Silver;
            btBack.Font = new Font("Trebuchet MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btBack.Location = new Point(1357, 869);
            btBack.Name = "btBack";
            btBack.Size = new Size(193, 44);
            btBack.TabIndex = 90;
            btBack.Text = "Orqaga qaytish";
            btBack.UseVisualStyleBackColor = false;
            btBack.Click += btBack_Click;
            // 
            // AddSalesmanForma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1599, 1033);
            Controls.Add(btBack);
            Controls.Add(btExit);
            Controls.Add(cbSearch);
            Controls.Add(btSearch);
            Controls.Add(txPillInformation);
            Controls.Add(btSaqlash);
            Controls.Add(btAddSmsPassword);
            Controls.Add(txAddPassword);
            Controls.Add(txAddLogin);
            Controls.Add(txAddFIO);
            Controls.Add(txAddSmsPassword);
            Controls.Add(txAddPhoneNumber);
            Controls.Add(lbAddPassword);
            Controls.Add(lbAddLogin);
            Controls.Add(lbAddFIO);
            Controls.Add(lbAddSmsPassword);
            Controls.Add(lbAddPhoneNumber);
            Controls.Add(dGVAddEmploye);
            Name = "AddSalesmanForma";
            Text = "AddSalesmanForma";
            Load += AddSalesmanForma_Load;
            ((System.ComponentModel.ISupportInitialize)dGVAddEmploye).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeBindingSource).EndInit();
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
        private Label lbAddPhoneNumber;
        private Label lbAddSmsPassword;
        private Label lbAddFIO;
        private Label lbAddLogin;
        private Label lbAddPassword;
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
        private Button btExit;
        private Button btBack;
    }
}