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
            btBack = new Button();
            label6 = new Label();
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
            DGVupdate.Location = new Point(38, 212);
            DGVupdate.Name = "DGVupdate";
            DGVupdate.RowHeadersWidth = 51;
            DGVupdate.Size = new Size(807, 642);
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
            panel1.Controls.Add(label6);
            panel1.Controls.Add(button2);
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
            panel1.Location = new Point(881, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 764);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // cbSearch
            // 
            cbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearch.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cbSearch.FormattingEnabled = true;
            cbSearch.Items.AddRange(new object[] { "Id", "FIO", "Login", "Password", "PhoneNumber", "EmployeType" });
            cbSearch.Location = new Point(38, 157);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(315, 49);
            cbSearch.TabIndex = 66;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSkyBlue;
            button2.Font = new Font("Trebuchet MS", 20F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(37, 628);
            button2.Name = "button2";
            button2.Size = new Size(737, 60);
            button2.TabIndex = 75;
            button2.Text = "Yangilash";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txPillInformation
            // 
            txPillInformation.BackColor = Color.FromArgb(255, 255, 192);
            txPillInformation.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txPillInformation.Location = new Point(359, 157);
            txPillInformation.Name = "txPillInformation";
            txPillInformation.Size = new Size(342, 48);
            txPillInformation.TabIndex = 65;
            // 
            // btSearch
            // 
            btSearch.BackColor = Color.LightSkyBlue;
            btSearch.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btSearch.Location = new Point(707, 156);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(138, 49);
            btSearch.TabIndex = 64;
            btSearch.Text = "Qidirish";
            btSearch.UseVisualStyleBackColor = false;
            btSearch.Click += btSearch_Click;
            // 
            // txParol
            // 
            txParol.BackColor = Color.FromArgb(255, 255, 192);
            txParol.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            txParol.Location = new Point(399, 458);
            txParol.Name = "txParol";
            txParol.Size = new Size(375, 47);
            txParol.TabIndex = 74;
            // 
            // txLogin
            // 
            txLogin.BackColor = Color.FromArgb(255, 255, 192);
            txLogin.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            txLogin.Location = new Point(399, 379);
            txLogin.Name = "txLogin";
            txLogin.Size = new Size(375, 47);
            txLogin.TabIndex = 73;
            // 
            // txTel
            // 
            txTel.BackColor = Color.FromArgb(255, 255, 192);
            txTel.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            txTel.Location = new Point(399, 298);
            txTel.Name = "txTel";
            txTel.Size = new Size(375, 47);
            txTel.TabIndex = 72;
            // 
            // txFio
            // 
            txFio.BackColor = Color.FromArgb(255, 255, 192);
            txFio.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            txFio.Location = new Point(399, 222);
            txFio.Name = "txFio";
            txFio.Size = new Size(375, 47);
            txFio.TabIndex = 71;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 22.2F);
            label5.Location = new Point(37, 458);
            label5.Name = "label5";
            label5.Size = new Size(117, 46);
            label5.TabIndex = 70;
            label5.Text = "Parol:\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 22.2F);
            label4.Location = new Point(37, 379);
            label4.Name = "label4";
            label4.Size = new Size(123, 46);
            label4.TabIndex = 69;
            label4.Text = "Login:\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 22.2F);
            label3.Location = new Point(37, 298);
            label3.Name = "label3";
            label3.Size = new Size(270, 46);
            label3.TabIndex = 68;
            label3.Text = "Telefon raqam:\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 22.2F);
            label2.Location = new Point(37, 222);
            label2.Name = "label2";
            label2.Size = new Size(88, 46);
            label2.TabIndex = 67;
            label2.Text = "FIO:";
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Font = new Font("Trebuchet MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(627, 149);
            button1.Name = "button1";
            button1.Size = new Size(147, 46);
            button1.TabIndex = 66;
            button1.Text = "Joylash";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txId
            // 
            txId.BackColor = Color.FromArgb(255, 255, 192);
            txId.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            txId.Location = new Point(399, 152);
            txId.Name = "txId";
            txId.Size = new Size(199, 47);
            txId.TabIndex = 65;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 22.2F);
            label1.Location = new Point(34, 147);
            label1.Name = "label1";
            label1.Size = new Size(370, 46);
            label1.TabIndex = 64;
            label1.Text = "Ishchi id sini kiriting:\r\n";
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Font = new Font("Trebuchet MS", 22.2F);
            Label.Location = new Point(297, 90);
            Label.Name = "Label";
            Label.Size = new Size(291, 46);
            Label.TabIndex = 14;
            Label.Text = "Ishchilar ro'yxati\r\n";
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 24F);
            label6.Location = new Point(212, 31);
            label6.Name = "label6";
            label6.Size = new Size(350, 49);
            label6.TabIndex = 76;
            label6.Text = "Sotuvchi yangilash";
            // 
            // UpdateSalaesmanForma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1717, 943);
            Controls.Add(cbSearch);
            Controls.Add(btBack);
            Controls.Add(Label);
            Controls.Add(txPillInformation);
            Controls.Add(btSearch);
            Controls.Add(panel1);
            Controls.Add(DGVupdate);
            Name = "UpdateSalaesmanForma";
            Text = "UpdateSalaesmanForma";
            FormClosed += UpdateSalaesmanForma_FormClosed;
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
        private Label label6;
    }
}