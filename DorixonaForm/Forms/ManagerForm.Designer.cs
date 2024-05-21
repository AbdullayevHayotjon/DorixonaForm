namespace DorixonaForm.Forms
{
    partial class ManagerForm
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
            btReports = new Button();
            dGVEmploye = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            employeTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employeBindingSource1 = new BindingSource(components);
            employeBindingSource = new BindingSource(components);
            lbFIO = new Label();
            lnklSettings = new LinkLabel();
            lbPillsList = new Label();
            allInformationsBindingSource = new BindingSource(components);
            button2 = new Button();
            btDeleteSalesman = new Button();
            btUpdateSalesman = new Button();
            btAddSalesman = new Button();
            cbSearch = new ComboBox();
            btSearch = new Button();
            txPillInformation = new TextBox();
            cbSort = new ComboBox();
            btQaytarish = new Button();
            btKamayish = new Button();
            btOsish = new Button();
            ((System.ComponentModel.ISupportInitialize)dGVEmploye).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)allInformationsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btReports
            // 
            btReports.BackColor = Color.LightSkyBlue;
            btReports.Font = new Font("Trebuchet MS", 17F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btReports.Location = new Point(363, 442);
            btReports.Name = "btReports";
            btReports.Size = new Size(407, 54);
            btReports.TabIndex = 10;
            btReports.Text = "Hisobotlar";
            btReports.UseVisualStyleBackColor = false;
            btReports.Click += btReports_Click;
            // 
            // dGVEmploye
            // 
            dGVEmploye.AutoGenerateColumns = false;
            dGVEmploye.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVEmploye.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, employeTypeDataGridViewTextBoxColumn });
            dGVEmploye.DataSource = employeBindingSource1;
            dGVEmploye.Location = new Point(880, 276);
            dGVEmploye.Name = "dGVEmploye";
            dGVEmploye.RowHeadersWidth = 51;
            dGVEmploye.Size = new Size(804, 532);
            dGVEmploye.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "FIO";
            dataGridViewTextBoxColumn2.HeaderText = "FIO";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Login";
            dataGridViewTextBoxColumn3.HeaderText = "Login";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Password";
            dataGridViewTextBoxColumn4.HeaderText = "Password";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "PhoneNumber";
            dataGridViewTextBoxColumn5.HeaderText = "PhoneNumber";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 125;
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
            // lbFIO
            // 
            lbFIO.AutoSize = true;
            lbFIO.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbFIO.Location = new Point(14, 9);
            lbFIO.Name = "lbFIO";
            lbFIO.Size = new Size(61, 38);
            lbFIO.TabIndex = 20;
            lbFIO.Text = "FIO";
            lbFIO.Click += lbFIO_Click;
            // 
            // lnklSettings
            // 
            lnklSettings.AutoSize = true;
            lnklSettings.Font = new Font("Segoe UI", 14F);
            lnklSettings.Location = new Point(14, 47);
            lnklSettings.Name = "lnklSettings";
            lnklSettings.Size = new Size(133, 32);
            lnklSettings.TabIndex = 30;
            lnklSettings.TabStop = true;
            lnklSettings.Text = "Sozlamalar";
            lnklSettings.LinkClicked += lnklSettings_LinkClicked;
            // 
            // lbPillsList
            // 
            lbPillsList.AutoSize = true;
            lbPillsList.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbPillsList.Location = new Point(1143, 112);
            lbPillsList.Name = "lbPillsList";
            lbPillsList.Size = new Size(276, 38);
            lbPillsList.TabIndex = 31;
            lbPillsList.Text = "Sotuvchilar ro'yxati";
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.Font = new Font("Trebuchet MS", 18F);
            button2.Location = new Point(1959, 12);
            button2.Name = "button2";
            button2.Size = new Size(184, 50);
            button2.TabIndex = 35;
            button2.Text = "Chiqish";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btDeleteSalesman
            // 
            btDeleteSalesman.BackColor = Color.FromArgb(255, 128, 128);
            btDeleteSalesman.Font = new Font("Trebuchet MS", 13.8F);
            btDeleteSalesman.Location = new Point(1451, 814);
            btDeleteSalesman.Name = "btDeleteSalesman";
            btDeleteSalesman.Size = new Size(233, 44);
            btDeleteSalesman.TabIndex = 39;
            btDeleteSalesman.Text = "Sotuvchi o'chirish";
            btDeleteSalesman.UseVisualStyleBackColor = false;
            btDeleteSalesman.Click += btDeleteSalesman_Click_1;
            // 
            // btUpdateSalesman
            // 
            btUpdateSalesman.BackColor = Color.FromArgb(255, 255, 128);
            btUpdateSalesman.Font = new Font("Trebuchet MS", 13.8F);
            btUpdateSalesman.Location = new Point(1166, 814);
            btUpdateSalesman.Name = "btUpdateSalesman";
            btUpdateSalesman.Size = new Size(253, 44);
            btUpdateSalesman.TabIndex = 38;
            btUpdateSalesman.Text = "Sotuvchi yangilash";
            btUpdateSalesman.UseVisualStyleBackColor = false;
            btUpdateSalesman.Click += btUpdateSalesman_Click;
            // 
            // btAddSalesman
            // 
            btAddSalesman.BackColor = Color.FromArgb(128, 255, 128);
            btAddSalesman.Font = new Font("Trebuchet MS", 13.8F);
            btAddSalesman.Location = new Point(881, 814);
            btAddSalesman.Name = "btAddSalesman";
            btAddSalesman.Size = new Size(233, 44);
            btAddSalesman.TabIndex = 37;
            btAddSalesman.Text = "Sotuvchi qo'shish";
            btAddSalesman.UseVisualStyleBackColor = false;
            btAddSalesman.Click += btAddSalesman_Click_1;
            // 
            // cbSearch
            // 
            cbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearch.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cbSearch.FormattingEnabled = true;
            cbSearch.Items.AddRange(new object[] { "Nomi", "Id", "Soni", "Muddati", "Narxi" });
            cbSearch.Location = new Point(880, 165);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(302, 49);
            cbSearch.TabIndex = 77;
            // 
            // btSearch
            // 
            btSearch.BackColor = Color.LightSkyBlue;
            btSearch.Font = new Font("Trebuchet MS", 18F);
            btSearch.Location = new Point(1520, 165);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(164, 49);
            btSearch.TabIndex = 75;
            btSearch.Text = "Qidirish";
            btSearch.UseVisualStyleBackColor = false;
            btSearch.Click += btSearch_Click;
            // 
            // txPillInformation
            // 
            txPillInformation.BackColor = Color.FromArgb(255, 255, 192);
            txPillInformation.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txPillInformation.Location = new Point(1188, 165);
            txPillInformation.Name = "txPillInformation";
            txPillInformation.Size = new Size(326, 48);
            txPillInformation.TabIndex = 76;
            // 
            // cbSort
            // 
            cbSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSort.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cbSort.FormattingEnabled = true;
            cbSort.Location = new Point(880, 220);
            cbSort.Name = "cbSort";
            cbSort.Size = new Size(302, 49);
            cbSort.TabIndex = 78;
            // 
            // btQaytarish
            // 
            btQaytarish.BackColor = Color.LightSkyBlue;
            btQaytarish.Font = new Font("Trebuchet MS", 18F);
            btQaytarish.Location = new Point(1520, 221);
            btQaytarish.Name = "btQaytarish";
            btQaytarish.Size = new Size(164, 49);
            btQaytarish.TabIndex = 79;
            btQaytarish.Text = "Qaytarish";
            btQaytarish.UseVisualStyleBackColor = false;
            btQaytarish.Click += btQaytarish_Click;
            // 
            // btKamayish
            // 
            btKamayish.BackColor = Color.LightSkyBlue;
            btKamayish.Font = new Font("Trebuchet MS", 18F);
            btKamayish.Location = new Point(1354, 221);
            btKamayish.Name = "btKamayish";
            btKamayish.Size = new Size(160, 49);
            btKamayish.TabIndex = 80;
            btKamayish.Text = "Kamayish";
            btKamayish.UseVisualStyleBackColor = false;
            btKamayish.Click += btKamayish_Click;
            // 
            // btOsish
            // 
            btOsish.BackColor = Color.LightSkyBlue;
            btOsish.Font = new Font("Trebuchet MS", 18F);
            btOsish.Location = new Point(1188, 221);
            btOsish.Name = "btOsish";
            btOsish.Size = new Size(160, 49);
            btOsish.TabIndex = 81;
            btOsish.Text = "O'sish";
            btOsish.UseVisualStyleBackColor = false;
            btOsish.Click += btOsish_Click;
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1924, 1033);
            Controls.Add(btOsish);
            Controls.Add(btKamayish);
            Controls.Add(btQaytarish);
            Controls.Add(cbSort);
            Controls.Add(cbSearch);
            Controls.Add(btSearch);
            Controls.Add(txPillInformation);
            Controls.Add(btDeleteSalesman);
            Controls.Add(btUpdateSalesman);
            Controls.Add(btAddSalesman);
            Controls.Add(button2);
            Controls.Add(lbPillsList);
            Controls.Add(lnklSettings);
            Controls.Add(lbFIO);
            Controls.Add(dGVEmploye);
            Controls.Add(btReports);
            Name = "ManagerForm";
            Text = "ManagerForm";
            Load += ManagerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dGVEmploye).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)allInformationsBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btReports;
        private DataGridView dGVEmploye;
        private BindingSource employeBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private Label lbFIO;
        private LinkLabel lnklSettings;
        private Label lbPillsList;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn processTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn informationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn processTimeDataGridViewTextBoxColumn;
        private BindingSource allInformationsBindingSource;
        private Button button2;
        private Button btDeleteSalesman;
        private Button btUpdateSalesman;
        private Button btAddSalesman;
        private ComboBox cbSearch;
        private Button btSearch;
        private TextBox txPillInformation;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn employeTypeDataGridViewTextBoxColumn;
        private BindingSource employeBindingSource1;
        private ComboBox cbSort;
        private Button btQaytarish;
        private Button btKamayish;
        private Button btOsish;
    }
}