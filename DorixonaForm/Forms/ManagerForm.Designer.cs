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
            txPillName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dGVEmploye).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)allInformationsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btReports
            // 
            btReports.BackColor = Color.LightSkyBlue;
            btReports.Font = new Font("Trebuchet MS", 17F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btReports.Location = new Point(1166, 447);
            btReports.Name = "btReports";
            btReports.Size = new Size(728, 54);
            btReports.TabIndex = 10;
            btReports.Text = "Hisobotlar";
            btReports.UseVisualStyleBackColor = false;
            btReports.Click += btReports_Click;
            // 
            // dGVEmploye
            // 
            dGVEmploye.AutoGenerateColumns = false;
            dGVEmploye.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVEmploye.DataSource = employeBindingSource;
            dGVEmploye.Location = new Point(461, 127);
            dGVEmploye.Name = "dGVEmploye";
            dGVEmploye.RowHeadersWidth = 51;
            dGVEmploye.Size = new Size(679, 701);
            dGVEmploye.TabIndex = 19;
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
            lbPillsList.Location = new Point(665, 76);
            lbPillsList.Name = "lbPillsList";
            lbPillsList.Size = new Size(276, 38);
            lbPillsList.TabIndex = 31;
            lbPillsList.Text = "Sotuvchilar ro'yxati";
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.Font = new Font("Trebuchet MS", 18F);
            button2.Location = new Point(1741, 12);
            button2.Name = "button2";
            button2.Size = new Size(164, 50);
            button2.TabIndex = 35;
            button2.Text = "Chiqish";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btDeleteSalesman
            // 
            btDeleteSalesman.BackColor = Color.FromArgb(255, 128, 128);
            btDeleteSalesman.Font = new Font("Trebuchet MS", 13.8F);
            btDeleteSalesman.Location = new Point(933, 848);
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
            btUpdateSalesman.Location = new Point(687, 848);
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
            btAddSalesman.Location = new Point(461, 848);
            btAddSalesman.Name = "btAddSalesman";
            btAddSalesman.Size = new Size(207, 44);
            btAddSalesman.TabIndex = 37;
            btAddSalesman.Text = "Sotuvchi qo'shish";
            btAddSalesman.UseVisualStyleBackColor = false;
            btAddSalesman.Click += btAddSalesman_Click_1;
            // 
            // cbSearch
            // 
            cbSearch.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cbSearch.FormattingEnabled = true;
            cbSearch.Items.AddRange(new object[] { "Nomi", "Id", "Soni", "Muddati", "Narxi" });
            cbSearch.Location = new Point(1223, 313);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(174, 49);
            cbSearch.TabIndex = 77;
            cbSearch.Text = "Nomi";
            // 
            // btSearch
            // 
            btSearch.BackColor = Color.LightSkyBlue;
            btSearch.Font = new Font("Trebuchet MS", 18F);
            btSearch.Location = new Point(1691, 317);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(142, 47);
            btSearch.TabIndex = 75;
            btSearch.Text = "Qidirish";
            btSearch.UseVisualStyleBackColor = false;
            // 
            // txPillName
            // 
            txPillName.BackColor = Color.FromArgb(255, 255, 192);
            txPillName.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txPillName.Location = new Point(1417, 315);
            txPillName.Name = "txPillName";
            txPillName.Size = new Size(243, 48);
            txPillName.TabIndex = 76;
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1917, 1033);
            Controls.Add(cbSearch);
            Controls.Add(btSearch);
            Controls.Add(txPillName);
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
        private TextBox txPillName;
    }
}