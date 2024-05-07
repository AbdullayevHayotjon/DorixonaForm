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
            btAddPill = new Button();
            btSettings = new Button();
            btExit = new Button();
            btDeletePill = new Button();
            btSellPill = new Button();
            btUpdatePill = new Button();
            btSearch = new Button();
            label1 = new Label();
            txPillName = new TextBox();
            dGWPills = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soniDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            narxiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pillBindingSource1 = new BindingSource(components);
            pillBindingSource = new BindingSource(components);
            txPillCount = new TextBox();
            lbPillCount = new Label();
            btAddBox = new Button();
            ((System.ComponentModel.ISupportInitialize)dGWPills).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btAddPill
            // 
            btAddPill.BackColor = Color.LightSkyBlue;
            btAddPill.Font = new Font("Trebuchet MS", 13.8F);
            btAddPill.Location = new Point(23, 787);
            btAddPill.Name = "btAddPill";
            btAddPill.Size = new Size(160, 45);
            btAddPill.TabIndex = 19;
            btAddPill.Text = "Dori qo'shish";
            btAddPill.UseVisualStyleBackColor = false;
            btAddPill.Click += btAddPill_Click;
            // 
            // btSettings
            // 
            btSettings.BackColor = Color.LightSkyBlue;
            btSettings.Font = new Font("Trebuchet MS", 18F);
            btSettings.Location = new Point(1235, 28);
            btSettings.Name = "btSettings";
            btSettings.Size = new Size(213, 50);
            btSettings.TabIndex = 18;
            btSettings.Text = "Sozlamalar";
            btSettings.UseVisualStyleBackColor = false;
            btSettings.Click += btChangePassword_Click;
            // 
            // btExit
            // 
            btExit.BackColor = Color.LightSkyBlue;
            btExit.Font = new Font("Trebuchet MS", 18F);
            btExit.Location = new Point(1284, 787);
            btExit.Name = "btExit";
            btExit.Size = new Size(164, 50);
            btExit.TabIndex = 17;
            btExit.Text = "Chiqish";
            btExit.UseVisualStyleBackColor = false;
            btExit.Click += btExit_Click;
            // 
            // btDeletePill
            // 
            btDeletePill.BackColor = Color.LightSkyBlue;
            btDeletePill.Font = new Font("Trebuchet MS", 13.8F);
            btDeletePill.Location = new Point(223, 787);
            btDeletePill.Name = "btDeletePill";
            btDeletePill.Size = new Size(172, 45);
            btDeletePill.TabIndex = 16;
            btDeletePill.Text = "Dori o'chirish";
            btDeletePill.UseVisualStyleBackColor = false;
            btDeletePill.Click += btDeletePill_Click;
            // 
            // btSellPill
            // 
            btSellPill.BackColor = Color.LightSkyBlue;
            btSellPill.Font = new Font("Trebuchet MS", 18F);
            btSellPill.Location = new Point(683, 438);
            btSellPill.Name = "btSellPill";
            btSellPill.Size = new Size(765, 50);
            btSellPill.TabIndex = 15;
            btSellPill.Text = "Tasdiqlash";
            btSellPill.UseVisualStyleBackColor = false;
            btSellPill.Click += btSellPill_Click;
            // 
            // btUpdatePill
            // 
            btUpdatePill.BackColor = Color.LightSkyBlue;
            btUpdatePill.Font = new Font("Trebuchet MS", 13.8F);
            btUpdatePill.Location = new Point(436, 787);
            btUpdatePill.Name = "btUpdatePill";
            btUpdatePill.Size = new Size(192, 45);
            btUpdatePill.TabIndex = 20;
            btUpdatePill.Text = "Dori yangilash";
            btUpdatePill.UseVisualStyleBackColor = false;
            btUpdatePill.Click += btUpdatePill_Click;
            // 
            // btSearch
            // 
            btSearch.BackColor = Color.LightSkyBlue;
            btSearch.Font = new Font("Trebuchet MS", 18F);
            btSearch.Location = new Point(951, 284);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(142, 50);
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
            txPillName.Location = new Point(683, 286);
            txPillName.Name = "txPillName";
            txPillName.Size = new Size(243, 48);
            txPillName.TabIndex = 23;
            // 
            // dGWPills
            // 
            dGWPills.AutoGenerateColumns = false;
            dGWPills.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGWPills.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomiDataGridViewTextBoxColumn, soniDataGridViewTextBoxColumn, narxiDataGridViewTextBoxColumn });
            dGWPills.DataSource = pillBindingSource1;
            dGWPills.Location = new Point(23, 43);
            dGWPills.Name = "dGWPills";
            dGWPills.ReadOnly = true;
            dGWPills.RowHeadersWidth = 80;
            dGWPills.Size = new Size(605, 725);
            dGWPills.TabIndex = 24;
            dGWPills.CellContentClick += dGWPills_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomiDataGridViewTextBoxColumn
            // 
            nomiDataGridViewTextBoxColumn.DataPropertyName = "Nomi";
            nomiDataGridViewTextBoxColumn.HeaderText = "Nomi";
            nomiDataGridViewTextBoxColumn.MinimumWidth = 6;
            nomiDataGridViewTextBoxColumn.Name = "nomiDataGridViewTextBoxColumn";
            nomiDataGridViewTextBoxColumn.ReadOnly = true;
            nomiDataGridViewTextBoxColumn.Width = 125;
            // 
            // soniDataGridViewTextBoxColumn
            // 
            soniDataGridViewTextBoxColumn.DataPropertyName = "Soni";
            soniDataGridViewTextBoxColumn.HeaderText = "Soni";
            soniDataGridViewTextBoxColumn.MinimumWidth = 6;
            soniDataGridViewTextBoxColumn.Name = "soniDataGridViewTextBoxColumn";
            soniDataGridViewTextBoxColumn.ReadOnly = true;
            soniDataGridViewTextBoxColumn.Width = 125;
            // 
            // narxiDataGridViewTextBoxColumn
            // 
            narxiDataGridViewTextBoxColumn.DataPropertyName = "Narxi";
            narxiDataGridViewTextBoxColumn.HeaderText = "Narxi";
            narxiDataGridViewTextBoxColumn.MinimumWidth = 6;
            narxiDataGridViewTextBoxColumn.Name = "narxiDataGridViewTextBoxColumn";
            narxiDataGridViewTextBoxColumn.ReadOnly = true;
            narxiDataGridViewTextBoxColumn.Width = 125;
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
            txPillCount.Location = new Point(1025, 359);
            txPillCount.Name = "txPillCount";
            txPillCount.Size = new Size(131, 48);
            txPillCount.TabIndex = 25;
            // 
            // lbPillCount
            // 
            lbPillCount.AutoSize = true;
            lbPillCount.Font = new Font("Trebuchet MS", 22.2F);
            lbPillCount.Location = new Point(674, 357);
            lbPillCount.Name = "lbPillCount";
            lbPillCount.Size = new Size(341, 46);
            lbPillCount.TabIndex = 26;
            lbPillCount.Text = "Dori sonini kiriting:";
            // 
            // btAddBox
            // 
            btAddBox.BackColor = Color.LightSkyBlue;
            btAddBox.Font = new Font("Trebuchet MS", 18F);
            btAddBox.Location = new Point(1179, 357);
            btAddBox.Name = "btAddBox";
            btAddBox.Size = new Size(269, 50);
            btAddBox.TabIndex = 27;
            btAddBox.Text = "Savatga qo'shish";
            btAddBox.UseVisualStyleBackColor = false;
            btAddBox.Click += btAddBox_Click_1;
            // 
            // SalesmanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1482, 903);
            Controls.Add(btAddBox);
            Controls.Add(lbPillCount);
            Controls.Add(txPillCount);
            Controls.Add(dGWPills);
            Controls.Add(txPillName);
            Controls.Add(label1);
            Controls.Add(btSearch);
            Controls.Add(btUpdatePill);
            Controls.Add(btAddPill);
            Controls.Add(btSettings);
            Controls.Add(btExit);
            Controls.Add(btDeletePill);
            Controls.Add(btSellPill);
            Name = "SalesmanForm";
            Text = "SalesmanForm";
            Load += SalesmanForm_Load;
            ((System.ComponentModel.ISupportInitialize)dGWPills).EndInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btAddPill;
        private Button btSettings;
        private Button btExit;
        private Button btDeletePill;
        private Button btSellPill;
        private Button btUpdatePill;
        private Button btSearch;
        private Label label1;
        private TextBox txPillName;
        private DataGridView dGWPills;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn narxiDataGridViewTextBoxColumn;
        private BindingSource pillBindingSource1;
        private BindingSource pillBindingSource;
        private TextBox txPillCount;
        private Label lbPillCount;
        private Button btAddBox;
    }
}