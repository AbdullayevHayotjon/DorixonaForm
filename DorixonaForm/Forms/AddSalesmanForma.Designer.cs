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
            btOsish = new Button();
            btKamayish = new Button();
            btQaytarish = new Button();
            cbSort = new ComboBox();
            cbSearch = new ComboBox();
            btSearch = new Button();
            txPillInformation = new TextBox();
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
            dGVAddEmploye.Location = new Point(729, 182);
            dGVAddEmploye.Name = "dGVAddEmploye";
            dGVAddEmploye.RowHeadersWidth = 51;
            dGVAddEmploye.Size = new Size(804, 544);
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
            lbAddPhoneNumber.Location = new Point(12, 125);
            lbAddPhoneNumber.Name = "lbAddPhoneNumber";
            lbAddPhoneNumber.Size = new Size(224, 41);
            lbAddPhoneNumber.TabIndex = 1;
            lbAddPhoneNumber.Text = "Telefon nomer:";
            // 
            // lbAddSmsPassword
            // 
            lbAddSmsPassword.AutoSize = true;
            lbAddSmsPassword.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbAddSmsPassword.Location = new Point(12, 195);
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
            lbAddFIO.Location = new Point(12, 270);
            lbAddFIO.Name = "lbAddFIO";
            lbAddFIO.Size = new Size(72, 41);
            lbAddFIO.TabIndex = 3;
            lbAddFIO.Text = "FIO:";
            // 
            // lbAddLogin
            // 
            lbAddLogin.AutoSize = true;
            lbAddLogin.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbAddLogin.Location = new Point(12, 338);
            lbAddLogin.Name = "lbAddLogin";
            lbAddLogin.Size = new Size(102, 41);
            lbAddLogin.TabIndex = 4;
            lbAddLogin.Text = "Login:";
            // 
            // lbAddPassword
            // 
            lbAddPassword.AutoSize = true;
            lbAddPassword.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbAddPassword.Location = new Point(12, 409);
            lbAddPassword.Name = "lbAddPassword";
            lbAddPassword.Size = new Size(95, 41);
            lbAddPassword.TabIndex = 5;
            lbAddPassword.Text = "Parol:";
            // 
            // txAddPhoneNumber
            // 
            txAddPhoneNumber.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txAddPhoneNumber.Location = new Point(250, 119);
            txAddPhoneNumber.Name = "txAddPhoneNumber";
            txAddPhoneNumber.Size = new Size(460, 47);
            txAddPhoneNumber.TabIndex = 6;
            // 
            // txAddSmsPassword
            // 
            txAddSmsPassword.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txAddSmsPassword.Location = new Point(250, 195);
            txAddSmsPassword.Name = "txAddSmsPassword";
            txAddSmsPassword.Size = new Size(178, 47);
            txAddSmsPassword.TabIndex = 7;
            // 
            // txAddFIO
            // 
            txAddFIO.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txAddFIO.Location = new Point(250, 270);
            txAddFIO.Name = "txAddFIO";
            txAddFIO.Size = new Size(460, 47);
            txAddFIO.TabIndex = 8;
            // 
            // txAddLogin
            // 
            txAddLogin.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txAddLogin.Location = new Point(250, 338);
            txAddLogin.Name = "txAddLogin";
            txAddLogin.Size = new Size(460, 47);
            txAddLogin.TabIndex = 9;
            // 
            // txAddPassword
            // 
            txAddPassword.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txAddPassword.Location = new Point(250, 409);
            txAddPassword.Name = "txAddPassword";
            txAddPassword.Size = new Size(460, 47);
            txAddPassword.TabIndex = 10;
            // 
            // btAddSmsPassword
            // 
            btAddSmsPassword.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btAddSmsPassword.Location = new Point(460, 195);
            btAddSmsPassword.Name = "btAddSmsPassword";
            btAddSmsPassword.Size = new Size(250, 47);
            btAddSmsPassword.TabIndex = 11;
            btAddSmsPassword.Text = "SMS ni jo'natish";
            btAddSmsPassword.UseVisualStyleBackColor = true;
            btAddSmsPassword.Click += btAddSmsPassword_Click;
            // 
            // btSaqlash
            // 
            btSaqlash.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btSaqlash.Location = new Point(12, 493);
            btSaqlash.Name = "btSaqlash";
            btSaqlash.Size = new Size(698, 54);
            btSaqlash.TabIndex = 12;
            btSaqlash.Text = "SAQLASH";
            btSaqlash.UseVisualStyleBackColor = true;
            btSaqlash.Click += btSaqlash_Click;
            // 
            // btOsish
            // 
            btOsish.BackColor = Color.LightSkyBlue;
            btOsish.Font = new Font("Trebuchet MS", 18F);
            btOsish.Location = new Point(1037, 123);
            btOsish.Name = "btOsish";
            btOsish.Size = new Size(160, 49);
            btOsish.TabIndex = 88;
            btOsish.Text = "O'sish";
            btOsish.UseVisualStyleBackColor = false;
            btOsish.Click += btOsish_Click;
            // 
            // btKamayish
            // 
            btKamayish.BackColor = Color.LightSkyBlue;
            btKamayish.Font = new Font("Trebuchet MS", 18F);
            btKamayish.Location = new Point(1203, 125);
            btKamayish.Name = "btKamayish";
            btKamayish.Size = new Size(160, 47);
            btKamayish.TabIndex = 87;
            btKamayish.Text = "Kamayish";
            btKamayish.UseVisualStyleBackColor = false;
            btKamayish.Click += btKamayish_Click;
            // 
            // btQaytarish
            // 
            btQaytarish.BackColor = Color.LightSkyBlue;
            btQaytarish.Font = new Font("Trebuchet MS", 18F);
            btQaytarish.Location = new Point(1369, 127);
            btQaytarish.Name = "btQaytarish";
            btQaytarish.Size = new Size(164, 49);
            btQaytarish.TabIndex = 86;
            btQaytarish.Text = "Qaytarish";
            btQaytarish.UseVisualStyleBackColor = false;
            btQaytarish.Click += btQaytarish_Click;
            // 
            // cbSort
            // 
            cbSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSort.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cbSort.FormattingEnabled = true;
            cbSort.Location = new Point(729, 126);
            cbSort.Name = "cbSort";
            cbSort.Size = new Size(302, 49);
            cbSort.TabIndex = 85;
            // 
            // cbSearch
            // 
            cbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearch.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cbSearch.FormattingEnabled = true;
            cbSearch.Items.AddRange(new object[] { "Nomi", "Id", "Soni", "Muddati", "Narxi" });
            cbSearch.Location = new Point(729, 71);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(302, 49);
            cbSearch.TabIndex = 84;
            // 
            // btSearch
            // 
            btSearch.BackColor = Color.LightSkyBlue;
            btSearch.Font = new Font("Trebuchet MS", 18F);
            btSearch.Location = new Point(1369, 71);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(164, 49);
            btSearch.TabIndex = 82;
            btSearch.Text = "Qidirish";
            btSearch.UseVisualStyleBackColor = false;
            btSearch.Click += btSearch_Click;
            // 
            // txPillInformation
            // 
            txPillInformation.BackColor = Color.FromArgb(255, 255, 192);
            txPillInformation.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txPillInformation.Location = new Point(1037, 71);
            txPillInformation.Name = "txPillInformation";
            txPillInformation.Size = new Size(326, 48);
            txPillInformation.TabIndex = 83;
            // 
            // AddSalesmanForma
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1837, 995);
            Controls.Add(btOsish);
            Controls.Add(btKamayish);
            Controls.Add(btQaytarish);
            Controls.Add(cbSort);
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
        private Button btOsish;
        private Button btKamayish;
        private Button btQaytarish;
        private ComboBox cbSort;
        private ComboBox cbSearch;
        private Button btSearch;
        private TextBox txPillInformation;
    }
}