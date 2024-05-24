namespace DorixonaForm.Forms
{
    partial class DeleteSalesmanForma
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
            panel1 = new Panel();
            label4 = new Label();
            button2 = new Button();
            txTel = new TextBox();
            txFio = new TextBox();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            txId = new TextBox();
            label1 = new Label();
            cbSearch = new ComboBox();
            txPillInformation = new TextBox();
            btSearch = new Button();
            DGVdelete = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fIODataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            loginDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employeTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employeBindingSource = new BindingSource(components);
            btBack = new Button();
            lb998 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVdelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(lb998);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(txTel);
            panel1.Controls.Add(txFio);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txId);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(869, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(792, 764);
            panel1.TabIndex = 64;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 24F);
            label4.Location = new Point(240, 15);
            label4.Name = "label4";
            label4.Size = new Size(330, 49);
            label4.TabIndex = 93;
            label4.Text = "Sotuvchi o'chirish";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.Font = new Font("Trebuchet MS", 20F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(30, 592);
            button2.Name = "button2";
            button2.Size = new Size(735, 60);
            button2.TabIndex = 75;
            button2.Text = "O'chirish";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txTel
            // 
            txTel.BackColor = Color.FromArgb(255, 255, 192);
            txTel.Font = new Font("Calibri Light", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            txTel.Location = new Point(407, 351);
            txTel.Name = "txTel";
            txTel.Size = new Size(358, 48);
            txTel.TabIndex = 72;
            // 
            // txFio
            // 
            txFio.BackColor = Color.FromArgb(255, 255, 192);
            txFio.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 204);
            txFio.Location = new Point(345, 275);
            txFio.Name = "txFio";
            txFio.Size = new Size(420, 51);
            txFio.TabIndex = 71;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 22.2F);
            label3.Location = new Point(30, 349);
            label3.Name = "label3";
            label3.Size = new Size(270, 46);
            label3.TabIndex = 68;
            label3.Text = "Telefon raqam:\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 22.2F);
            label2.Location = new Point(30, 278);
            label2.Name = "label2";
            label2.Size = new Size(88, 46);
            label2.TabIndex = 67;
            label2.Text = "FIO:";
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(618, 208);
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
            txId.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 204);
            txId.Location = new Point(406, 206);
            txId.Name = "txId";
            txId.Size = new Size(191, 48);
            txId.TabIndex = 65;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 22.2F);
            label1.Location = new Point(30, 208);
            label1.Name = "label1";
            label1.Size = new Size(370, 46);
            label1.TabIndex = 64;
            label1.Text = "Ishchi id sini kiriting:\r\n";
            // 
            // cbSearch
            // 
            cbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearch.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cbSearch.FormattingEnabled = true;
            cbSearch.Items.AddRange(new object[] { "Id", "FIO", "Login", "Password", "PhoneNumber", "EmployeType" });
            cbSearch.Location = new Point(62, 150);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(315, 49);
            cbSearch.TabIndex = 66;
            // 
            // txPillInformation
            // 
            txPillInformation.BackColor = Color.FromArgb(255, 255, 192);
            txPillInformation.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txPillInformation.Location = new Point(383, 152);
            txPillInformation.Name = "txPillInformation";
            txPillInformation.Size = new Size(262, 48);
            txPillInformation.TabIndex = 65;
            // 
            // btSearch
            // 
            btSearch.BackColor = Color.LightSkyBlue;
            btSearch.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btSearch.Location = new Point(651, 152);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(138, 49);
            btSearch.TabIndex = 64;
            btSearch.Text = "Qidirish";
            btSearch.UseVisualStyleBackColor = false;
            btSearch.Click += btSearch_Click;
            // 
            // DGVdelete
            // 
            DGVdelete.AutoGenerateColumns = false;
            DGVdelete.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVdelete.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, fIODataGridViewTextBoxColumn, loginDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, employeTypeDataGridViewTextBoxColumn });
            DGVdelete.DataSource = employeBindingSource;
            DGVdelete.Location = new Point(32, 206);
            DGVdelete.Name = "DGVdelete";
            DGVdelete.RowHeadersWidth = 51;
            DGVdelete.Size = new Size(805, 434);
            DGVdelete.TabIndex = 63;
            DGVdelete.CellContentClick += DGVdelete_CellContentClick;
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
            // btBack
            // 
            btBack.BackColor = Color.Silver;
            btBack.Font = new Font("Trebuchet MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btBack.Location = new Point(1393, 963);
            btBack.Name = "btBack";
            btBack.Size = new Size(193, 44);
            btBack.TabIndex = 67;
            btBack.Text = "Orqaga qaytish";
            btBack.UseVisualStyleBackColor = false;
            btBack.Click += btBack_Click;
            // 
            // lb998
            // 
            lb998.AutoSize = true;
            lb998.Font = new Font("Calibri Light", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lb998.Location = new Point(306, 351);
            lb998.Name = "lb998";
            lb998.Size = new Size(95, 45);
            lb998.TabIndex = 94;
            lb998.Text = "+998";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 24F);
            label5.Location = new Point(289, 88);
            label5.Name = "label5";
            label5.Size = new Size(316, 49);
            label5.TabIndex = 94;
            label5.Text = "Ishchilar ro'yxati";
            // 
            // DeleteSalesmanForma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1717, 943);
            Controls.Add(label5);
            Controls.Add(cbSearch);
            Controls.Add(btBack);
            Controls.Add(panel1);
            Controls.Add(txPillInformation);
            Controls.Add(btSearch);
            Controls.Add(DGVdelete);
            Name = "DeleteSalesmanForma";
            Text = "DeleteSalesmanForma";
            FormClosed += DeleteSalesmanForma_FormClosed;
            Load += DeleteSalesmanForma_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVdelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private ComboBox cbSearch;
        private Button button2;
        private TextBox txPillInformation;
        private Button btSearch;
        private TextBox txTel;
        private TextBox txFio;
        private Label label3;
        private Label label2;
        private Button button1;
        private TextBox txId;
        private Label label1;
        private DataGridView DGVdelete;
        private Button btBack;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employeTypeDataGridViewTextBoxColumn;
        private BindingSource employeBindingSource;
        private Label label4;
        private Label lb998;
        private Label label5;
    }
}