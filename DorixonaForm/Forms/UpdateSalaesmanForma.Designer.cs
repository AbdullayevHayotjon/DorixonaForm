namespace DorixonaForm.Forms
{
    partial class UpdateSalaesmanForma
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
            DGVupdate = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fIODataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            loginDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employeTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employeBindingSource = new BindingSource(components);
            panel1 = new Panel();
            cbSearch = new ComboBox();
            button2 = new Button();
            txPillInformation = new TextBox();
            btSearch = new Button();
            txParol = new TextBox();
            txLogin = new TextBox();
            txTel = new TextBox();
            txFio = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            txId = new TextBox();
            label1 = new Label();
            Label = new Label();
            btExit = new Button();
            btBack = new Button();
            ((System.ComponentModel.ISupportInitialize)DGVupdate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeBindingSource).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // DGVupdate
            // 
            DGVupdate.AutoGenerateColumns = false;
            DGVupdate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVupdate.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, fIODataGridViewTextBoxColumn, loginDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, employeTypeDataGridViewTextBoxColumn });
            DGVupdate.DataSource = employeBindingSource;
            DGVupdate.Location = new Point(12, 110);
            DGVupdate.Name = "DGVupdate";
            DGVupdate.RowHeadersWidth = 51;
            DGVupdate.Size = new Size(777, 764);
            DGVupdate.TabIndex = 0;
            DGVupdate.CellContentClick += dataGridView1_CellContentClick;
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
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(cbSearch);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(txPillInformation);
            panel1.Controls.Add(btSearch);
            panel1.Controls.Add(txParol);
            panel1.Controls.Add(txLogin);
            panel1.Controls.Add(txTel);
            panel1.Controls.Add(txFio);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txId);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(795, 110);
            panel1.Name = "panel1";
            panel1.Size = new Size(792, 764);
            panel1.TabIndex = 1;
            // 
            // cbSearch
            // 
            cbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearch.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cbSearch.FormattingEnabled = true;
            cbSearch.Items.AddRange(new object[] { "Id", "FIO", "Login", "Password", "PhoneNumber", "EmployeType" });
            cbSearch.Location = new Point(24, 22);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(315, 49);
            cbSearch.TabIndex = 66;
            // 
            // button2
            // 
            button2.BackColor = Color.DeepSkyBlue;
            button2.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(219, 643);
            button2.Name = "button2";
            button2.Size = new Size(259, 46);
            button2.TabIndex = 75;
            button2.Text = "Yangilash";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txPillInformation
            // 
            txPillInformation.BackColor = Color.FromArgb(255, 255, 192);
            txPillInformation.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txPillInformation.Location = new Point(365, 22);
            txPillInformation.Name = "txPillInformation";
            txPillInformation.Size = new Size(262, 48);
            txPillInformation.TabIndex = 65;
            // 
            // btSearch
            // 
            btSearch.BackColor = Color.LightSkyBlue;
            btSearch.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btSearch.Location = new Point(632, 22);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(138, 49);
            btSearch.TabIndex = 64;
            btSearch.Text = "Qidirish";
            btSearch.UseVisualStyleBackColor = false;
            btSearch.Click += btSearch_Click;
            // 
            // txParol
            // 
            txParol.BackColor = SystemColors.Info;
            txParol.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            txParol.Location = new Point(268, 508);
            txParol.Name = "txParol";
            txParol.Size = new Size(407, 43);
            txParol.TabIndex = 74;
            // 
            // txLogin
            // 
            txLogin.BackColor = SystemColors.Info;
            txLogin.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            txLogin.Location = new Point(268, 401);
            txLogin.Name = "txLogin";
            txLogin.Size = new Size(407, 43);
            txLogin.TabIndex = 73;
            // 
            // txTel
            // 
            txTel.BackColor = SystemColors.Info;
            txTel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            txTel.Location = new Point(268, 300);
            txTel.Name = "txTel";
            txTel.Size = new Size(407, 43);
            txTel.TabIndex = 72;
            // 
            // txFio
            // 
            txFio.BackColor = SystemColors.Info;
            txFio.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            txFio.Location = new Point(268, 199);
            txFio.Name = "txFio";
            txFio.Size = new Size(472, 43);
            txFio.TabIndex = 71;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 22.2F);
            label5.Location = new Point(22, 505);
            label5.Name = "label5";
            label5.Size = new Size(117, 46);
            label5.TabIndex = 70;
            label5.Text = "Parol:\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 22.2F);
            label4.Location = new Point(22, 401);
            label4.Name = "label4";
            label4.Size = new Size(123, 46);
            label4.TabIndex = 69;
            label4.Text = "Login:\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 22.2F);
            label3.Location = new Point(22, 300);
            label3.Name = "label3";
            label3.Size = new Size(204, 46);
            label3.TabIndex = 68;
            label3.Text = "Tel Raqam:\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 22.2F);
            label2.Location = new Point(22, 199);
            label2.Name = "label2";
            label2.Size = new Size(88, 46);
            label2.TabIndex = 67;
            label2.Text = "FIO:";
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(632, 113);
            button1.Name = "button1";
            button1.Size = new Size(147, 46);
            button1.TabIndex = 66;
            button1.Text = "Joylash";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txId
            // 
            txId.BackColor = SystemColors.Info;
            txId.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            txId.Location = new Point(398, 116);
            txId.Name = "txId";
            txId.Size = new Size(229, 43);
            txId.TabIndex = 65;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 22.2F);
            label1.Location = new Point(22, 113);
            label1.Name = "label1";
            label1.Size = new Size(370, 46);
            label1.TabIndex = 64;
            label1.Text = "Ishchi id sini kiriting:\r\n";
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Font = new Font("Trebuchet MS", 22.2F);
            Label.Location = new Point(183, 49);
            Label.Name = "Label";
            Label.Size = new Size(285, 46);
            Label.TabIndex = 14;
            Label.Text = "Ishchilar royxati\r\n";
            // 
            // btExit
            // 
            btExit.BackColor = Color.Silver;
            btExit.Font = new Font("Trebuchet MS", 14F);
            btExit.Location = new Point(1441, 32);
            btExit.Name = "btExit";
            btExit.Size = new Size(124, 44);
            btExit.TabIndex = 62;
            btExit.Text = "Chiqish";
            btExit.UseVisualStyleBackColor = false;
            btExit.Click += btExit_Click;
            // 
            // btBack
            // 
            btBack.BackColor = Color.Silver;
            btBack.Font = new Font("Trebuchet MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btBack.Location = new Point(1372, 950);
            btBack.Name = "btBack";
            btBack.Size = new Size(193, 44);
            btBack.TabIndex = 63;
            btBack.Text = "Orqaga qaytish";
            btBack.UseVisualStyleBackColor = false;
            btBack.Click += btBack_Click;
            // 
            // UpdateSalaesmanForma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1599, 1033);
            Controls.Add(btBack);
            Controls.Add(btExit);
            Controls.Add(Label);
            Controls.Add(panel1);
            Controls.Add(DGVupdate);
            Name = "UpdateSalaesmanForma";
            Text = "UpdateSalaesmanForma";
            Load += UpdateSalaesmanForma_Load;
            ((System.ComponentModel.ISupportInitialize)DGVupdate).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGVupdate;
        private Panel panel1;
        private Label Label;
        private Button btExit;
        private Label label1;
        private Button btBack;
        private Button button1;
        private TextBox txId;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button2;
        private TextBox txParol;
        private TextBox txLogin;
        private TextBox txTel;
        private TextBox txFio;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employeTypeDataGridViewTextBoxColumn;
        private BindingSource employeBindingSource;
        private ComboBox cbSearch;
        private TextBox txPillInformation;
        private Button btSearch;
    }
}