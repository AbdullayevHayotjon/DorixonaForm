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
            lbPillName = new Label();
            panel1 = new Panel();
            btAddPill = new Button();
            btUpdatePill = new Button();
            btDeletePill = new Button();
            ((System.ComponentModel.ISupportInitialize)dGWPills).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btExit
            // 
            btExit.BackColor = Color.Silver;
            btExit.Font = new Font("Trebuchet MS", 18F);
            btExit.Location = new Point(664, 694);
            btExit.Name = "btExit";
            btExit.Size = new Size(164, 50);
            btExit.TabIndex = 17;
            btExit.Text = "Chiqish";
            btExit.UseVisualStyleBackColor = false;
            btExit.Click += btExit_Click;
            // 
            // btSellPill
            // 
            btSellPill.BackColor = Color.LightSkyBlue;
            btSellPill.Font = new Font("Trebuchet MS", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btSellPill.Location = new Point(49, 411);
            btSellPill.Name = "btSellPill";
            btSellPill.Size = new Size(779, 54);
            btSellPill.TabIndex = 15;
            btSellPill.Text = "Tasdiqlash";
            btSellPill.UseVisualStyleBackColor = false;
            btSellPill.Click += btSellPill_Click;
            // 
            // btSearch
            // 
            btSearch.BackColor = Color.LightSkyBlue;
            btSearch.Font = new Font("Trebuchet MS", 18F);
            btSearch.Location = new Point(686, 258);
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
            txPillName.Location = new Point(412, 256);
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
            txPillCount.Location = new Point(412, 333);
            txPillCount.Name = "txPillCount";
            txPillCount.Size = new Size(117, 48);
            txPillCount.TabIndex = 25;
            // 
            // lbPillCount
            // 
            lbPillCount.AutoSize = true;
            lbPillCount.Font = new Font("Trebuchet MS", 22.2F);
            lbPillCount.Location = new Point(49, 331);
            lbPillCount.Name = "lbPillCount";
            lbPillCount.Size = new Size(341, 46);
            lbPillCount.TabIndex = 26;
            lbPillCount.Text = "Dori sonini kiriting:";
            // 
            // btAddBox
            // 
            btAddBox.BackColor = Color.FromArgb(128, 255, 128);
            btAddBox.Font = new Font("Trebuchet MS", 18F);
            btAddBox.Location = new Point(559, 331);
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
            lbPillsList.Location = new Point(1313, 47);
            lbPillsList.Name = "lbPillsList";
            lbPillsList.Size = new Size(218, 38);
            lbPillsList.TabIndex = 30;
            lbPillsList.Text = "Dorilar ro'yxati";
            // 
            // lbPillName
            // 
            lbPillName.AutoSize = true;
            lbPillName.Font = new Font("Trebuchet MS", 22.2F);
            lbPillName.Location = new Point(49, 256);
            lbPillName.Name = "lbPillName";
            lbPillName.Size = new Size(357, 46);
            lbPillName.TabIndex = 31;
            lbPillName.Text = "Dori nomini kiriting:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(lbPillName);
            panel1.Controls.Add(btSellPill);
            panel1.Controls.Add(btSearch);
            panel1.Controls.Add(txPillName);
            panel1.Controls.Add(txPillCount);
            panel1.Controls.Add(btAddBox);
            panel1.Controls.Add(lbPillCount);
            panel1.Controls.Add(btExit);
            panel1.Location = new Point(57, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(876, 793);
            panel1.TabIndex = 32;
            panel1.Paint += panel1_Paint;
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
            // SalesmanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1917, 1033);
            Controls.Add(btDeletePill);
            Controls.Add(btUpdatePill);
            Controls.Add(btAddPill);
            Controls.Add(panel1);
            Controls.Add(lbPillsList);
            Controls.Add(lnklSettings);
            Controls.Add(lbFIO);
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
        private Label lbPillName;
        private Panel panel1;
        private Button btAddPill;
        private DataGridViewTextBoxColumn QoshilganSana;
        private Button btUpdatePill;
        private Button btDeletePill;
    }
}