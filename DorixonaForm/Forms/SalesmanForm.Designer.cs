namespace DorixonaForm
{
    partial class SalesmanForm
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
            btExit = new Button();
            btSellPill = new Button();
            btSearch = new Button();
            label1 = new Label();
            txPillName = new TextBox();
            dGWPills = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soniDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Muddati = new DataGridViewTextBoxColumn();
            narxiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            QoshilganSana = new DataGridViewTextBoxColumn();
            pillBindingSource2 = new BindingSource(components);
            pillBindingSource1 = new BindingSource(components);
            pillBindingSource = new BindingSource(components);
            txPillCount = new TextBox();
            lbPillCount = new Label();
            btAddBox = new Button();
            lbFIO = new Label();
            lnklSettings = new LinkLabel();
            lbPillsList = new Label();
            panel1 = new Panel();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            txId = new TextBox();
            label2 = new Label();
            cbSearch = new ComboBox();
            btAddPill = new Button();
            btUpdatePill = new Button();
            btDeletePill = new Button();
            lkSalesmanReports = new LinkLabel();
            pillBindingSource3 = new BindingSource(components);
            comboBox1 = new ComboBox();
            button3 = new Button();
            button7 = new Button();
            button9 = new Button();
            ((System.ComponentModel.ISupportInitialize)dGWPills).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource3).BeginInit();
            SuspendLayout();
            // 
            // btExit
            // 
            btExit.BackColor = Color.Silver;
            btExit.Font = new Font("Trebuchet MS", 14F);
            btExit.Location = new Point(1760, 3);
            btExit.Name = "btExit";
            btExit.Size = new Size(124, 44);
            btExit.TabIndex = 17;
            btExit.Text = "Chiqish";
            btExit.UseVisualStyleBackColor = false;
            btExit.Click += btExit_Click;
            // 
            // btSellPill
            // 
            btSellPill.BackColor = Color.LightSkyBlue;
            btSellPill.Font = new Font("Trebuchet MS", 16.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btSellPill.Location = new Point(613, 705);
            btSellPill.Name = "btSellPill";
            btSellPill.Size = new Size(232, 50);
            btSellPill.TabIndex = 15;
            btSellPill.Text = "Sotish";
            btSellPill.UseVisualStyleBackColor = false;
            btSellPill.Click += btSellPill_Click;
            // 
            // btSearch
            // 
            btSearch.BackColor = Color.LightSkyBlue;
            btSearch.Font = new Font("Trebuchet MS", 18F);
            btSearch.Location = new Point(653, 50);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(142, 47);
            btSearch.TabIndex = 21;
            btSearch.Text = "Qidirish";
            btSearch.UseVisualStyleBackColor = false;
            btSearch.Click += btAddBox_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 22;
            // 
            // txPillName
            // 
            txPillName.BackColor = Color.FromArgb(255, 255, 192);
            txPillName.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txPillName.Location = new Point(379, 48);
            txPillName.Name = "txPillName";
            txPillName.Size = new Size(243, 48);
            txPillName.TabIndex = 23;
            // 
            // dGWPills
            // 
            dGWPills.AutoGenerateColumns = false;
            dGWPills.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGWPills.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomiDataGridViewTextBoxColumn, soniDataGridViewTextBoxColumn, Muddati, narxiDataGridViewTextBoxColumn, QoshilganSana });
            dGWPills.DataSource = pillBindingSource2;
            dGWPills.Location = new Point(999, 100);
            dGWPills.Name = "dGWPills";
            dGWPills.RowHeadersWidth = 80;
            dGWPills.Size = new Size(832, 793);
            dGWPills.TabIndex = 24;
            dGWPills.CellContentClick += dGWPills_CellContentClick;
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
            // Muddati
            // 
            Muddati.DataPropertyName = "Muddati";
            Muddati.HeaderText = "Muddati";
            Muddati.MinimumWidth = 6;
            Muddati.Name = "Muddati";
            Muddati.Width = 125;
            // 
            // narxiDataGridViewTextBoxColumn
            // 
            narxiDataGridViewTextBoxColumn.DataPropertyName = "Narxi";
            narxiDataGridViewTextBoxColumn.HeaderText = "Narxi";
            narxiDataGridViewTextBoxColumn.MinimumWidth = 6;
            narxiDataGridViewTextBoxColumn.Name = "narxiDataGridViewTextBoxColumn";
            narxiDataGridViewTextBoxColumn.Width = 125;
            // 
            // QoshilganSana
            // 
            QoshilganSana.DataPropertyName = "QoshilganSana";
            QoshilganSana.HeaderText = "QoshilganSana";
            QoshilganSana.MinimumWidth = 6;
            QoshilganSana.Name = "QoshilganSana";
            QoshilganSana.Width = 125;
            // 
            // pillBindingSource2
            // 
            pillBindingSource2.DataSource = typeof(Actions.Pill);
            // 
            // pillBindingSource1
            // 
            pillBindingSource1.DataSource = typeof(Actions.Pill);
            // 
            // pillBindingSource
            // 
            pillBindingSource.DataSource = typeof(Actions.Pill);
            // 
            // txPillCount
            // 
            txPillCount.BackColor = Color.FromArgb(255, 255, 192);
            txPillCount.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txPillCount.Location = new Point(379, 192);
            txPillCount.Name = "txPillCount";
            txPillCount.Size = new Size(117, 48);
            txPillCount.TabIndex = 25;
            // 
            // lbPillCount
            // 
            lbPillCount.AutoSize = true;
            lbPillCount.Font = new Font("Trebuchet MS", 22.2F);
            lbPillCount.Location = new Point(16, 190);
            lbPillCount.Name = "lbPillCount";
            lbPillCount.Size = new Size(341, 46);
            lbPillCount.TabIndex = 26;
            lbPillCount.Text = "Dori sonini kiriting:";
            // 
            // btAddBox
            // 
            btAddBox.BackColor = Color.FromArgb(128, 255, 128);
            btAddBox.Font = new Font("Trebuchet MS", 18F);
            btAddBox.Location = new Point(526, 190);
            btAddBox.Name = "btAddBox";
            btAddBox.Size = new Size(269, 50);
            btAddBox.TabIndex = 27;
            btAddBox.Text = "Savatga qo'shish";
            btAddBox.UseVisualStyleBackColor = false;
            btAddBox.Click += btAddBox_Click_1;
            // 
            // lbFIO
            // 
            lbFIO.AutoSize = true;
            lbFIO.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbFIO.Location = new Point(12, 9);
            lbFIO.Name = "lbFIO";
            lbFIO.Size = new Size(61, 38);
            lbFIO.TabIndex = 28;
            lbFIO.Text = "FIO";
            // 
            // lnklSettings
            // 
            lnklSettings.AutoSize = true;
            lnklSettings.Font = new Font("Segoe UI", 14F);
            lnklSettings.Location = new Point(12, 47);
            lnklSettings.Name = "lnklSettings";
            lnklSettings.Size = new Size(129, 32);
            lnklSettings.TabIndex = 29;
            lnklSettings.TabStop = true;
            lnklSettings.Text = "Sozlamalar";
            lnklSettings.LinkClicked += lnklSettings_LinkClicked;
            // 
            // lbPillsList
            // 
            lbPillsList.AutoSize = true;
            lbPillsList.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbPillsList.Location = new Point(495, 26);
            lbPillsList.Name = "lbPillsList";
            lbPillsList.Size = new Size(218, 38);
            lbPillsList.TabIndex = 30;
            lbPillsList.Text = "Dorilar ro'yxati";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(txId);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cbSearch);
            panel1.Controls.Add(btSellPill);
            panel1.Controls.Add(btSearch);
            panel1.Controls.Add(txPillName);
            panel1.Controls.Add(txPillCount);
            panel1.Controls.Add(btAddBox);
            panel1.Controls.Add(lbPillCount);
            panel1.Location = new Point(91, 125);
            panel1.Name = "panel1";
            panel1.Size = new Size(876, 793);
            panel1.TabIndex = 32;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(368, 266);
            label4.Name = "label4";
            label4.Size = new Size(90, 38);
            label4.TabIndex = 83;
            label4.Text = "Savat";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 307);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(813, 263);
            dataGridView1.TabIndex = 82;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(255, 255, 192);
            label7.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label7.Location = new Point(245, 622);
            label7.Name = "label7";
            label7.Size = new Size(97, 38);
            label7.TabIndex = 81;
            label7.Text = "          ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 22.2F);
            label3.Location = new Point(32, 614);
            label3.Name = "label3";
            label3.Size = new Size(207, 46);
            label3.TabIndex = 80;
            label3.Text = "Jami narxi:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Font = new Font("Trebuchet MS", 17F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(302, 705);
            button1.Name = "button1";
            button1.Size = new Size(232, 50);
            button1.TabIndex = 79;
            button1.Text = "O'chirish";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 255, 128);
            button2.Font = new Font("Trebuchet MS", 17F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(32, 705);
            button2.Name = "button2";
            button2.Size = new Size(232, 50);
            button2.TabIndex = 78;
            button2.Text = "Yangilash";
            button2.UseVisualStyleBackColor = false;
            // 
            // txId
            // 
            txId.BackColor = Color.FromArgb(255, 255, 192);
            txId.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txId.Location = new Point(379, 115);
            txId.Name = "txId";
            txId.Size = new Size(243, 48);
            txId.TabIndex = 75;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 22.2F);
            label2.Location = new Point(16, 117);
            label2.Name = "label2";
            label2.Size = new Size(343, 46);
            label2.TabIndex = 74;
            label2.Text = "Dori Id sini kiriting:";
            // 
            // cbSearch
            // 
            cbSearch.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cbSearch.FormattingEnabled = true;
            cbSearch.Items.AddRange(new object[] { "Nomi", "Id", "Soni", "Muddati", "Narxi" });
            cbSearch.Location = new Point(155, 48);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(174, 49);
            cbSearch.TabIndex = 28;
            cbSearch.Text = "Nomi";
            cbSearch.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btAddPill
            // 
            btAddPill.BackColor = Color.FromArgb(128, 255, 128);
            btAddPill.Font = new Font("Trebuchet MS", 17F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btAddPill.Location = new Point(999, 915);
            btAddPill.Name = "btAddPill";
            btAddPill.Size = new Size(232, 50);
            btAddPill.TabIndex = 32;
            btAddPill.Text = "Dori qo'shish";
            btAddPill.UseVisualStyleBackColor = false;
            btAddPill.Click += button1_Click;
            // 
            // btUpdatePill
            // 
            btUpdatePill.BackColor = Color.FromArgb(255, 255, 128);
            btUpdatePill.Font = new Font("Trebuchet MS", 17F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btUpdatePill.Location = new Point(1299, 915);
            btUpdatePill.Name = "btUpdatePill";
            btUpdatePill.Size = new Size(232, 50);
            btUpdatePill.TabIndex = 33;
            btUpdatePill.Text = "Dori yangilash";
            btUpdatePill.UseVisualStyleBackColor = false;
            btUpdatePill.Click += btUpdatePill_Click_1;
            // 
            // btDeletePill
            // 
            btDeletePill.BackColor = Color.FromArgb(255, 128, 128);
            btDeletePill.Font = new Font("Trebuchet MS", 17F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btDeletePill.Location = new Point(1599, 915);
            btDeletePill.Name = "btDeletePill";
            btDeletePill.Size = new Size(232, 50);
            btDeletePill.TabIndex = 34;
            btDeletePill.Text = "Dori o'chirish";
            btDeletePill.UseVisualStyleBackColor = false;
            btDeletePill.Click += btDeletePill_Click_1;
            // 
            // lkSalesmanReports
            // 
            lkSalesmanReports.AutoSize = true;
            lkSalesmanReports.Font = new Font("Segoe UI", 14F);
            lkSalesmanReports.Location = new Point(12, 79);
            lkSalesmanReports.Name = "lkSalesmanReports";
            lkSalesmanReports.Size = new Size(150, 32);
            lkSalesmanReports.TabIndex = 35;
            lkSalesmanReports.TabStop = true;
            lkSalesmanReports.Text = "Hisobotlarim";
            lkSalesmanReports.LinkClicked += lkSalesmanReports_LinkClicked;
            // 
            // pillBindingSource3
            // 
            pillBindingSource3.DataSource = typeof(Actions.Pill);
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "O'sish", "Kamayish" });
            comboBox1.Location = new Point(903, 45);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(174, 49);
            comboBox1.TabIndex = 36;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSkyBlue;
            button3.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.Location = new Point(1083, 53);
            button3.Name = "button3";
            button3.Size = new Size(113, 41);
            button3.TabIndex = 37;
            button3.Text = "O'sish";
            button3.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.LightSkyBlue;
            button7.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button7.Location = new Point(1202, 53);
            button7.Name = "button7";
            button7.Size = new Size(129, 41);
            button7.TabIndex = 41;
            button7.Text = "Kamayish";
            button7.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.LightSkyBlue;
            button9.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button9.Location = new Point(1616, 9);
            button9.Name = "button9";
            button9.Size = new Size(138, 41);
            button9.TabIndex = 43;
            button9.Text = "Qaytarish";
            button9.UseVisualStyleBackColor = false;
            // 
            // SalesmanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1917, 1033);
            Controls.Add(button9);
            Controls.Add(button7);
            Controls.Add(button3);
            Controls.Add(comboBox1);
            Controls.Add(lkSalesmanReports);
            Controls.Add(btDeletePill);
            Controls.Add(btUpdatePill);
            Controls.Add(btAddPill);
            Controls.Add(panel1);
            Controls.Add(lbPillsList);
            Controls.Add(lnklSettings);
            Controls.Add(lbFIO);
            Controls.Add(btExit);
            Controls.Add(dGWPills);
            Controls.Add(label1);
            Name = "SalesmanForm";
            Text = "SalesmanForm";
            Load += SalesmanForm_Load;
            ((System.ComponentModel.ISupportInitialize)dGWPills).EndInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btSettings;
        private Button btExit;
        private Button btSellPill;
        private Button btSearch;
        private Label label1;
        private TextBox txPillName;
        private DataGridView dGWPills;
        private BindingSource pillBindingSource1;
        private BindingSource pillBindingSource;
        private TextBox txPillCount;
        private Label lbPillCount;
        private Button btAddBox;
        private BindingSource pillBindingSource2;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Muddati;
        private DataGridViewTextBoxColumn narxiDataGridViewTextBoxColumn;
        private Label lbFIO;
        private LinkLabel lnklSettings;
        private Label lbPillsList;
        private Panel panel1;
        private Button btAddPill;
        private DataGridViewTextBoxColumn QoshilganSana;
        private Button btUpdatePill;
        private Button btDeletePill;
        private LinkLabel lkSalesmanReports;
        private ComboBox cbSearch;
        private BindingSource pillBindingSource3;
        private Label label3;
        private Button button1;
        private Button button2;
        private TextBox txId;
        private Label label2;
        private Label label4;
        private DataGridView dataGridView1;
        private Label label7;
        private ComboBox comboBox1;
        private Button button3;
        private Button button7;
        private Button button9;
    }
}