namespace DorixonaForm.Forms
{
    partial class UpdatePillForm
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
            label3 = new Label();
            panel2 = new Panel();
            txUpdatePillLifeTime = new TextBox();
            label1 = new Label();
            btUpdatePill = new Button();
            txUpdatePillPrice = new TextBox();
            lbUpdatePillPrice = new Label();
            txUpdatePillName = new TextBox();
            txUpdatePillCount = new TextBox();
            lbUpdatePillCount = new Label();
            lbUpdatePillName = new Label();
            btBack = new Button();
            lbFIO = new Label();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soniDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            muddatiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            narxiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            qoshilganSanaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pillBindingSource = new BindingSource(components);
            btSearch = new Button();
            txPillName = new TextBox();
            txId = new TextBox();
            label2 = new Label();
            btPlacement = new Button();
            cbSearch = new ComboBox();
            button9 = new Button();
            comboBox1 = new ComboBox();
            btExit = new Button();
            button7 = new Button();
            button3 = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 24F);
            label3.Location = new Point(179, 43);
            label3.Name = "label3";
            label3.Size = new Size(272, 49);
            label3.TabIndex = 60;
            label3.Text = "Dori yangilash";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCyan;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txUpdatePillLifeTime);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btUpdatePill);
            panel2.Controls.Add(txUpdatePillPrice);
            panel2.Controls.Add(lbUpdatePillPrice);
            panel2.Controls.Add(txUpdatePillName);
            panel2.Controls.Add(txUpdatePillCount);
            panel2.Controls.Add(lbUpdatePillCount);
            panel2.Controls.Add(lbUpdatePillName);
            panel2.Location = new Point(1166, 268);
            panel2.Name = "panel2";
            panel2.Size = new Size(634, 622);
            panel2.TabIndex = 59;
            // 
            // txUpdatePillLifeTime
            // 
            txUpdatePillLifeTime.BackColor = Color.FromArgb(255, 255, 192);
            txUpdatePillLifeTime.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txUpdatePillLifeTime.Location = new Point(331, 305);
            txUpdatePillLifeTime.Name = "txUpdatePillLifeTime";
            txUpdatePillLifeTime.Size = new Size(258, 48);
            txUpdatePillLifeTime.TabIndex = 67;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 22.2F);
            label1.Location = new Point(36, 303);
            label1.Name = "label1";
            label1.Size = new Size(251, 46);
            label1.TabIndex = 66;
            label1.Text = "Dori muddati:";
            // 
            // btUpdatePill
            // 
            btUpdatePill.BackColor = Color.FromArgb(255, 255, 128);
            btUpdatePill.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btUpdatePill.Location = new Point(34, 515);
            btUpdatePill.Name = "btUpdatePill";
            btUpdatePill.Size = new Size(555, 60);
            btUpdatePill.TabIndex = 65;
            btUpdatePill.Text = "Yangilash";
            btUpdatePill.UseVisualStyleBackColor = false;
            btUpdatePill.Click += btUpdatePill_Click;
            // 
            // txUpdatePillPrice
            // 
            txUpdatePillPrice.BackColor = Color.FromArgb(255, 255, 192);
            txUpdatePillPrice.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txUpdatePillPrice.Location = new Point(330, 374);
            txUpdatePillPrice.Name = "txUpdatePillPrice";
            txUpdatePillPrice.Size = new Size(259, 48);
            txUpdatePillPrice.TabIndex = 64;
            // 
            // lbUpdatePillPrice
            // 
            lbUpdatePillPrice.AutoSize = true;
            lbUpdatePillPrice.Font = new Font("Trebuchet MS", 22.2F);
            lbUpdatePillPrice.Location = new Point(36, 372);
            lbUpdatePillPrice.Name = "lbUpdatePillPrice";
            lbUpdatePillPrice.Size = new Size(196, 46);
            lbUpdatePillPrice.TabIndex = 63;
            lbUpdatePillPrice.Text = "Dori narxi:";
            // 
            // txUpdatePillName
            // 
            txUpdatePillName.BackColor = Color.FromArgb(255, 255, 192);
            txUpdatePillName.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txUpdatePillName.Location = new Point(330, 169);
            txUpdatePillName.Name = "txUpdatePillName";
            txUpdatePillName.Size = new Size(259, 48);
            txUpdatePillName.TabIndex = 62;
            // 
            // txUpdatePillCount
            // 
            txUpdatePillCount.BackColor = Color.FromArgb(255, 255, 192);
            txUpdatePillCount.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txUpdatePillCount.Location = new Point(331, 239);
            txUpdatePillCount.Name = "txUpdatePillCount";
            txUpdatePillCount.Size = new Size(259, 48);
            txUpdatePillCount.TabIndex = 61;
            // 
            // lbUpdatePillCount
            // 
            lbUpdatePillCount.AutoSize = true;
            lbUpdatePillCount.Font = new Font("Trebuchet MS", 22.2F);
            lbUpdatePillCount.Location = new Point(36, 237);
            lbUpdatePillCount.Name = "lbUpdatePillCount";
            lbUpdatePillCount.Size = new Size(179, 46);
            lbUpdatePillCount.TabIndex = 60;
            lbUpdatePillCount.Text = "Dori soni:";
            // 
            // lbUpdatePillName
            // 
            lbUpdatePillName.AutoSize = true;
            lbUpdatePillName.Font = new Font("Trebuchet MS", 22.2F);
            lbUpdatePillName.Location = new Point(36, 167);
            lbUpdatePillName.Name = "lbUpdatePillName";
            lbUpdatePillName.Size = new Size(195, 46);
            lbUpdatePillName.TabIndex = 59;
            lbUpdatePillName.Text = "Dori nomi:";
            // 
            // btBack
            // 
            btBack.BackColor = Color.Silver;
            btBack.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btBack.Location = new Point(1551, 917);
            btBack.Name = "btBack";
            btBack.Size = new Size(249, 53);
            btBack.TabIndex = 61;
            btBack.Text = "Orqaga qaytish";
            btBack.UseVisualStyleBackColor = false;
            btBack.Click += btBack_Click;
            // 
            // lbFIO
            // 
            lbFIO.AutoSize = true;
            lbFIO.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbFIO.Location = new Point(12, 9);
            lbFIO.Name = "lbFIO";
            lbFIO.Size = new Size(61, 38);
            lbFIO.TabIndex = 62;
            lbFIO.Text = "FIO";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomiDataGridViewTextBoxColumn, soniDataGridViewTextBoxColumn, muddatiDataGridViewTextBoxColumn, narxiDataGridViewTextBoxColumn, qoshilganSanaDataGridViewTextBoxColumn });
            dataGridView1.DataSource = pillBindingSource;
            dataGridView1.Location = new Point(91, 147);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(803, 743);
            dataGridView1.TabIndex = 63;
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
            // muddatiDataGridViewTextBoxColumn
            // 
            muddatiDataGridViewTextBoxColumn.DataPropertyName = "Muddati";
            muddatiDataGridViewTextBoxColumn.HeaderText = "Muddati";
            muddatiDataGridViewTextBoxColumn.MinimumWidth = 6;
            muddatiDataGridViewTextBoxColumn.Name = "muddatiDataGridViewTextBoxColumn";
            muddatiDataGridViewTextBoxColumn.Width = 125;
            // 
            // narxiDataGridViewTextBoxColumn
            // 
            narxiDataGridViewTextBoxColumn.DataPropertyName = "Narxi";
            narxiDataGridViewTextBoxColumn.HeaderText = "Narxi";
            narxiDataGridViewTextBoxColumn.MinimumWidth = 6;
            narxiDataGridViewTextBoxColumn.Name = "narxiDataGridViewTextBoxColumn";
            narxiDataGridViewTextBoxColumn.Width = 125;
            // 
            // qoshilganSanaDataGridViewTextBoxColumn
            // 
            qoshilganSanaDataGridViewTextBoxColumn.DataPropertyName = "QoshilganSana";
            qoshilganSanaDataGridViewTextBoxColumn.HeaderText = "QoshilganSana";
            qoshilganSanaDataGridViewTextBoxColumn.MinimumWidth = 6;
            qoshilganSanaDataGridViewTextBoxColumn.Name = "qoshilganSanaDataGridViewTextBoxColumn";
            qoshilganSanaDataGridViewTextBoxColumn.Width = 125;
            // 
            // pillBindingSource
            // 
            pillBindingSource.DataSource = typeof(Actions.Pill);
            // 
            // btSearch
            // 
            btSearch.BackColor = Color.LightSkyBlue;
            btSearch.Font = new Font("Trebuchet MS", 18F);
            btSearch.Location = new Point(1714, 133);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(142, 47);
            btSearch.TabIndex = 68;
            btSearch.Text = "Qidirish";
            btSearch.UseVisualStyleBackColor = false;
            btSearch.Click += btSearch_Click;
            // 
            // txPillName
            // 
            txPillName.BackColor = Color.FromArgb(255, 255, 192);
            txPillName.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txPillName.Location = new Point(1440, 131);
            txPillName.Name = "txPillName";
            txPillName.Size = new Size(243, 48);
            txPillName.TabIndex = 69;
            // 
            // txId
            // 
            txId.BackColor = Color.FromArgb(255, 255, 192);
            txId.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txId.Location = new Point(1440, 215);
            txId.Name = "txId";
            txId.Size = new Size(243, 48);
            txId.TabIndex = 72;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 22.2F);
            label2.Location = new Point(1077, 217);
            label2.Name = "label2";
            label2.Size = new Size(343, 46);
            label2.TabIndex = 71;
            label2.Text = "Dori Id sini kiriting:";
            // 
            // btPlacement
            // 
            btPlacement.BackColor = Color.LightSkyBlue;
            btPlacement.Font = new Font("Trebuchet MS", 18F);
            btPlacement.Location = new Point(1714, 215);
            btPlacement.Name = "btPlacement";
            btPlacement.Size = new Size(142, 47);
            btPlacement.TabIndex = 73;
            btPlacement.Text = "Joylash";
            btPlacement.UseVisualStyleBackColor = false;
            btPlacement.Click += btPlacement_Click;
            // 
            // cbSearch
            // 
            cbSearch.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cbSearch.FormattingEnabled = true;
            cbSearch.Items.AddRange(new object[] { "Nomi", "Id", "Soni", "Muddati", "Narxi" });
            cbSearch.Location = new Point(1246, 129);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(174, 49);
            cbSearch.TabIndex = 74;
            cbSearch.Text = "Nomi";
            // 
            // button9
            // 
            button9.BackColor = Color.LightSkyBlue;
            button9.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button9.Location = new Point(727, 56);
            button9.Name = "button9";
            button9.Size = new Size(138, 41);
            button9.TabIndex = 83;
            button9.Text = "Qaytarish";
            button9.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "O'sish", "Kamayish" });
            comboBox1.Location = new Point(14, 92);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(174, 49);
            comboBox1.TabIndex = 76;
            // 
            // btExit
            // 
            btExit.BackColor = Color.Silver;
            btExit.Font = new Font("Trebuchet MS", 14F);
            btExit.Location = new Point(1768, 21);
            btExit.Name = "btExit";
            btExit.Size = new Size(124, 44);
            btExit.TabIndex = 75;
            btExit.Text = "Chiqish";
            btExit.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.LightSkyBlue;
            button7.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button7.Location = new Point(366, 100);
            button7.Name = "button7";
            button7.Size = new Size(129, 41);
            button7.TabIndex = 85;
            button7.Text = "Kamayish";
            button7.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSkyBlue;
            button3.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.Location = new Point(247, 100);
            button3.Name = "button3";
            button3.Size = new Size(113, 41);
            button3.TabIndex = 84;
            button3.Text = "O'sish";
            button3.UseVisualStyleBackColor = false;
            // 
            // UpdatePillForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1917, 1033);
            Controls.Add(button7);
            Controls.Add(button3);
            Controls.Add(button9);
            Controls.Add(comboBox1);
            Controls.Add(btExit);
            Controls.Add(cbSearch);
            Controls.Add(btPlacement);
            Controls.Add(txId);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(btSearch);
            Controls.Add(lbFIO);
            Controls.Add(txPillName);
            Controls.Add(btBack);
            Controls.Add(panel2);
            Name = "UpdatePillForm";
            Text = "UpdatePillForm";
            Load += UpdatePillForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Panel panel2;
        private TextBox txUpdatePillLifeTime;
        private Label label1;
        private Button btUpdatePill;
        private TextBox txUpdatePillPrice;
        private Label lbUpdatePillPrice;
        private TextBox txUpdatePillName;
        private TextBox txUpdatePillCount;
        private Label lbUpdatePillCount;
        private Label lbUpdatePillName;
        private Button btBack;
        private Label lbFIO;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn muddatiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn narxiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn qoshilganSanaDataGridViewTextBoxColumn;
        private BindingSource pillBindingSource;
        private Button btSearch;
        private TextBox txPillName;
        private TextBox txId;
        private Label label2;
        private Button btPlacement;
        private ComboBox cbSearch;
        private Button button9;
        private ComboBox comboBox1;
        private Button btExit;
        private Button button7;
        private Button button3;
    }
}