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
            dGVEmploye = new DataGridView();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            employeBindingSource2 = new BindingSource(components);
            employeBindingSource1 = new BindingSource(components);
            employeBindingSource = new BindingSource(components);
            lbFIO = new Label();
            lnklSettings = new LinkLabel();
            lbPillsList = new Label();
            allInformationsBindingSource = new BindingSource(components);
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
            pillBindingSource = new BindingSource(components);
            dgwLess = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            salesmanReportBindingSource = new BindingSource(components);
            salesmanReportBindingSource1 = new BindingSource(components);
            salesmanReportBindingSource2 = new BindingSource(components);
            dgwMany = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soniDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sotilganVaqtiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            narxiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dGVEmploye).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)allInformationsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwLess).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salesmanReportBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salesmanReportBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salesmanReportBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwMany).BeginInit();
            SuspendLayout();
            // 
            // dGVEmploye
            // 
            dGVEmploye.AutoGenerateColumns = false;
            dGVEmploye.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVEmploye.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11 });
            dGVEmploye.DataSource = employeBindingSource2;
            dGVEmploye.Location = new Point(875, 261);
            dGVEmploye.Name = "dGVEmploye";
            dGVEmploye.RowHeadersWidth = 51;
            dGVEmploye.Size = new Size(804, 532);
            dGVEmploye.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Id";
            dataGridViewTextBoxColumn6.HeaderText = "Id";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "FIO";
            dataGridViewTextBoxColumn7.HeaderText = "FIO";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "Login";
            dataGridViewTextBoxColumn8.HeaderText = "Login";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "Password";
            dataGridViewTextBoxColumn9.HeaderText = "Password";
            dataGridViewTextBoxColumn9.MinimumWidth = 6;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.DataPropertyName = "PhoneNumber";
            dataGridViewTextBoxColumn10.HeaderText = "PhoneNumber";
            dataGridViewTextBoxColumn10.MinimumWidth = 6;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.DataPropertyName = "EmployeType";
            dataGridViewTextBoxColumn11.HeaderText = "EmployeType";
            dataGridViewTextBoxColumn11.MinimumWidth = 6;
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.Width = 125;
            // 
            // employeBindingSource2
            // 
            employeBindingSource2.DataSource = typeof(Actions.Employe);
            // 
            // lbFIO
            // 
            lbFIO.AutoSize = true;
            lbFIO.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbFIO.Location = new Point(12, 9);
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
            lnklSettings.Location = new Point(12, 47);
            lnklSettings.Name = "lnklSettings";
            lnklSettings.Size = new Size(129, 32);
            lnklSettings.TabIndex = 30;
            lnklSettings.TabStop = true;
            lnklSettings.Text = "Sozlamalar";
            lnklSettings.LinkClicked += lnklSettings_LinkClicked;
            // 
            // lbPillsList
            // 
            lbPillsList.AutoSize = true;
            lbPillsList.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbPillsList.Location = new Point(1142, 99);
            lbPillsList.Name = "lbPillsList";
            lbPillsList.Size = new Size(276, 38);
            lbPillsList.TabIndex = 31;
            lbPillsList.Text = "Sotuvchilar ro'yxati";
            // 
            // btDeleteSalesman
            // 
            btDeleteSalesman.BackColor = Color.FromArgb(255, 128, 128);
            btDeleteSalesman.Font = new Font("Trebuchet MS", 13.8F);
            btDeleteSalesman.Location = new Point(1472, 799);
            btDeleteSalesman.Name = "btDeleteSalesman";
            btDeleteSalesman.Size = new Size(207, 44);
            btDeleteSalesman.TabIndex = 39;
            btDeleteSalesman.Text = "Sotuvchi o'chirish";
            btDeleteSalesman.UseVisualStyleBackColor = false;
            btDeleteSalesman.Click += btDeleteSalesman_Click_1;
            // 
            // btUpdateSalesman
            // 
            btUpdateSalesman.BackColor = Color.FromArgb(255, 255, 128);
            btUpdateSalesman.Font = new Font("Trebuchet MS", 13.8F);
            btUpdateSalesman.Location = new Point(1174, 799);
            btUpdateSalesman.Name = "btUpdateSalesman";
            btUpdateSalesman.Size = new Size(225, 44);
            btUpdateSalesman.TabIndex = 38;
            btUpdateSalesman.Text = "Sotuvchi yangilash";
            btUpdateSalesman.UseVisualStyleBackColor = false;
            btUpdateSalesman.Click += btUpdateSalesman_Click;
            // 
            // btAddSalesman
            // 
            btAddSalesman.BackColor = Color.FromArgb(128, 255, 128);
            btAddSalesman.Font = new Font("Trebuchet MS", 13.8F);
            btAddSalesman.Location = new Point(875, 801);
            btAddSalesman.Name = "btAddSalesman";
            btAddSalesman.Size = new Size(207, 44);
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
            cbSearch.Items.AddRange(new object[] { "Id", "FIO", "Login", "Password", "PhoneNumber", "EmployeType" });
            cbSearch.Location = new Point(911, 152);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(269, 49);
            cbSearch.TabIndex = 77;
            // 
            // btSearch
            // 
            btSearch.BackColor = Color.LightSkyBlue;
            btSearch.Font = new Font("Trebuchet MS", 14F);
            btSearch.Location = new Point(1480, 158);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(146, 44);
            btSearch.TabIndex = 75;
            btSearch.Text = "Qidirish";
            btSearch.UseVisualStyleBackColor = false;
            btSearch.Click += btSearch_Click;
            // 
            // txPillInformation
            // 
            txPillInformation.BackColor = Color.FromArgb(255, 255, 192);
            txPillInformation.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txPillInformation.Location = new Point(1185, 152);
            txPillInformation.Name = "txPillInformation";
            txPillInformation.Size = new Size(290, 48);
            txPillInformation.TabIndex = 76;
            // 
            // cbSort
            // 
            cbSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSort.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cbSort.FormattingEnabled = true;
            cbSort.Items.AddRange(new object[] { "Id", "FIO", "Login", "Password", "PhoneNumber", "EmployeType" });
            cbSort.Location = new Point(912, 206);
            cbSort.Name = "cbSort";
            cbSort.Size = new Size(269, 49);
            cbSort.TabIndex = 78;
            // 
            // btQaytarish
            // 
            btQaytarish.BackColor = Color.LightSkyBlue;
            btQaytarish.Font = new Font("Trebuchet MS", 14F);
            btQaytarish.Location = new Point(1480, 212);
            btQaytarish.Name = "btQaytarish";
            btQaytarish.Size = new Size(147, 44);
            btQaytarish.TabIndex = 79;
            btQaytarish.Text = "Qaytarish";
            btQaytarish.UseVisualStyleBackColor = false;
            btQaytarish.Click += btQaytarish_Click;
            // 
            // btKamayish
            // 
            btKamayish.BackColor = Color.LightSkyBlue;
            btKamayish.Font = new Font("Trebuchet MS", 14F);
            btKamayish.Location = new Point(1332, 212);
            btKamayish.Name = "btKamayish";
            btKamayish.Size = new Size(142, 44);
            btKamayish.TabIndex = 80;
            btKamayish.Text = "Kamayish";
            btKamayish.UseVisualStyleBackColor = false;
            btKamayish.Click += btKamayish_Click;
            // 
            // btOsish
            // 
            btOsish.BackColor = Color.LightSkyBlue;
            btOsish.Font = new Font("Trebuchet MS", 14F);
            btOsish.Location = new Point(1185, 212);
            btOsish.Name = "btOsish";
            btOsish.Size = new Size(142, 44);
            btOsish.TabIndex = 81;
            btOsish.Text = "O'sish";
            btOsish.UseVisualStyleBackColor = false;
            btOsish.Click += btOsish_Click;
            // 
            // pillBindingSource
            // 
            pillBindingSource.DataSource = typeof(Actions.Pill);
            // 
            // dgwLess
            // 
            dgwLess.AutoGenerateColumns = false;
            dgwLess.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwLess.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn13 });
            dgwLess.DataSource = pillBindingSource;
            dgwLess.Location = new Point(32, 486);
            dgwLess.Name = "dgwLess";
            dgwLess.RowHeadersWidth = 51;
            dgwLess.Size = new Size(805, 307);
            dgwLess.TabIndex = 84;
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
            dataGridViewTextBoxColumn2.DataPropertyName = "Nomi";
            dataGridViewTextBoxColumn2.HeaderText = "Nomi";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Soni";
            dataGridViewTextBoxColumn3.HeaderText = "Soni";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Muddati";
            dataGridViewTextBoxColumn4.HeaderText = "Muddati";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Narxi";
            dataGridViewTextBoxColumn5.HeaderText = "Narxi";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.DataPropertyName = "QoshilganSana";
            dataGridViewTextBoxColumn13.HeaderText = "QoshilganSana";
            dataGridViewTextBoxColumn13.MinimumWidth = 6;
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            dataGridViewTextBoxColumn13.Width = 125;
            // 
            // salesmanReportBindingSource
            // 
            salesmanReportBindingSource.DataSource = typeof(Actions.SalesmanReport);
            // 
            // salesmanReportBindingSource1
            // 
            salesmanReportBindingSource1.DataSource = typeof(Actions.SalesmanReport);
            // 
            // salesmanReportBindingSource2
            // 
            salesmanReportBindingSource2.DataSource = typeof(Actions.SalesmanReport);
            // 
            // dgwMany
            // 
            dgwMany.AutoGenerateColumns = false;
            dgwMany.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwMany.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomiDataGridViewTextBoxColumn, soniDataGridViewTextBoxColumn, sotilganVaqtiDataGridViewTextBoxColumn, narxiDataGridViewTextBoxColumn });
            dgwMany.DataSource = salesmanReportBindingSource2;
            dgwMany.Location = new Point(96, 241);
            dgwMany.Name = "dgwMany";
            dgwMany.RowHeadersWidth = 51;
            dgwMany.Size = new Size(680, 187);
            dgwMany.TabIndex = 85;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomiDataGridViewTextBoxColumn
            // 
            nomiDataGridViewTextBoxColumn.DataPropertyName = "Nomi";
            nomiDataGridViewTextBoxColumn.HeaderText = "Nomi";
            nomiDataGridViewTextBoxColumn.MinimumWidth = 6;
            nomiDataGridViewTextBoxColumn.Name = "nomiDataGridViewTextBoxColumn";
            nomiDataGridViewTextBoxColumn.Width = 125;
            // 
            // soniDataGridViewTextBoxColumn
            // 
            soniDataGridViewTextBoxColumn.DataPropertyName = "Soni";
            soniDataGridViewTextBoxColumn.HeaderText = "Soni";
            soniDataGridViewTextBoxColumn.MinimumWidth = 6;
            soniDataGridViewTextBoxColumn.Name = "soniDataGridViewTextBoxColumn";
            soniDataGridViewTextBoxColumn.Width = 125;
            // 
            // sotilganVaqtiDataGridViewTextBoxColumn
            // 
            sotilganVaqtiDataGridViewTextBoxColumn.DataPropertyName = "SotilganVaqti";
            sotilganVaqtiDataGridViewTextBoxColumn.HeaderText = "SotilganVaqti";
            sotilganVaqtiDataGridViewTextBoxColumn.MinimumWidth = 6;
            sotilganVaqtiDataGridViewTextBoxColumn.Name = "sotilganVaqtiDataGridViewTextBoxColumn";
            sotilganVaqtiDataGridViewTextBoxColumn.Width = 125;
            // 
            // narxiDataGridViewTextBoxColumn
            // 
            narxiDataGridViewTextBoxColumn.DataPropertyName = "Narxi";
            narxiDataGridViewTextBoxColumn.HeaderText = "Narxi";
            narxiDataGridViewTextBoxColumn.MinimumWidth = 6;
            narxiDataGridViewTextBoxColumn.Name = "narxiDataGridViewTextBoxColumn";
            narxiDataGridViewTextBoxColumn.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(272, 193);
            label1.Name = "label1";
            label1.Size = new Size(365, 38);
            label1.TabIndex = 86;
            label1.Text = "Eng ko'p sotilgan 5 ta dori";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(230, 445);
            label2.Name = "label2";
            label2.Size = new Size(398, 38);
            label2.TabIndex = 87;
            label2.Text = "10 tadan kam qolgan dorilar";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 14F);
            linkLabel1.Location = new Point(347, 47);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(253, 32);
            linkLabel1.TabIndex = 88;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Qo'shimcha hisobotlar";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 14F);
            linkLabel2.Location = new Point(147, 47);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(194, 32);
            linkLabel2.TabIndex = 89;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Asosiy hisobotlar";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1717, 943);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgwMany);
            Controls.Add(dgwLess);
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
            Controls.Add(lbPillsList);
            Controls.Add(lnklSettings);
            Controls.Add(lbFIO);
            Controls.Add(dGVEmploye);
            Name = "ManagerForm";
            Text = "ManagerForm";
            FormClosed += ManagerForm_FormClosed;
            Load += ManagerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dGVEmploye).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)allInformationsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwLess).EndInit();
            ((System.ComponentModel.ISupportInitialize)salesmanReportBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)salesmanReportBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)salesmanReportBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwMany).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dGVEmploye;
        private BindingSource employeBindingSource;
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
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private BindingSource employeBindingSource2;
        private BindingSource pillBindingSource;
        private DataGridView dgwLess;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private BindingSource salesmanReportBindingSource;
        private BindingSource salesmanReportBindingSource1;
        private BindingSource salesmanReportBindingSource2;
        private DataGridView dgwMany;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sotilganVaqtiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn narxiDataGridViewTextBoxColumn;
        private Label label1;
        private Label label2;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
    }
}