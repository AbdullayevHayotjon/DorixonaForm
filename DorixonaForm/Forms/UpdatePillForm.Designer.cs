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
            btPlacement = new Button();
            lbUpdatePillCount = new Label();
            txId = new TextBox();
            label2 = new Label();
            lbUpdatePillName = new Label();
            btBack = new Button();
            pillBindingSource = new BindingSource(components);
            btSearch = new Button();
            txPillInformation = new TextBox();
            cbSearch = new ComboBox();
            button9 = new Button();
            cbSort = new ComboBox();
            button7 = new Button();
            button3 = new Button();
            dbPills = new DataGridView();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            pillBindingSource2 = new BindingSource(components);
            pillBindingSource1 = new BindingSource(components);
            label5 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dbPills).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 24F);
            label3.Location = new Point(216, 26);
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
            panel2.Controls.Add(btPlacement);
            panel2.Controls.Add(lbUpdatePillCount);
            panel2.Controls.Add(txId);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lbUpdatePillName);
            panel2.Location = new Point(946, 117);
            panel2.Name = "panel2";
            panel2.Size = new Size(698, 722);
            panel2.TabIndex = 59;
            // 
            // txUpdatePillLifeTime
            // 
            txUpdatePillLifeTime.BackColor = Color.FromArgb(255, 255, 192);
            txUpdatePillLifeTime.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txUpdatePillLifeTime.Location = new Point(396, 368);
            txUpdatePillLifeTime.Name = "txUpdatePillLifeTime";
            txUpdatePillLifeTime.Size = new Size(244, 48);
            txUpdatePillLifeTime.TabIndex = 67;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 22.2F);
            label1.Location = new Point(47, 366);
            label1.Name = "label1";
            label1.Size = new Size(251, 46);
            label1.TabIndex = 66;
            label1.Text = "Dori muddati:";
            // 
            // btUpdatePill
            // 
            btUpdatePill.BackColor = Color.FromArgb(255, 255, 128);
            btUpdatePill.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btUpdatePill.Location = new Point(47, 589);
            btUpdatePill.Name = "btUpdatePill";
            btUpdatePill.Size = new Size(593, 60);
            btUpdatePill.TabIndex = 65;
            btUpdatePill.Text = "Yangilash";
            btUpdatePill.UseVisualStyleBackColor = false;
            btUpdatePill.Click += btUpdatePill_Click;
            // 
            // txUpdatePillPrice
            // 
            txUpdatePillPrice.BackColor = Color.FromArgb(255, 255, 192);
            txUpdatePillPrice.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txUpdatePillPrice.Location = new Point(396, 447);
            txUpdatePillPrice.Name = "txUpdatePillPrice";
            txUpdatePillPrice.Size = new Size(244, 48);
            txUpdatePillPrice.TabIndex = 64;
            // 
            // lbUpdatePillPrice
            // 
            lbUpdatePillPrice.AutoSize = true;
            lbUpdatePillPrice.Font = new Font("Trebuchet MS", 22.2F);
            lbUpdatePillPrice.Location = new Point(47, 445);
            lbUpdatePillPrice.Name = "lbUpdatePillPrice";
            lbUpdatePillPrice.Size = new Size(196, 46);
            lbUpdatePillPrice.TabIndex = 63;
            lbUpdatePillPrice.Text = "Dori narxi:";
            // 
            // txUpdatePillName
            // 
            txUpdatePillName.BackColor = Color.FromArgb(255, 255, 192);
            txUpdatePillName.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txUpdatePillName.Location = new Point(396, 208);
            txUpdatePillName.Name = "txUpdatePillName";
            txUpdatePillName.Size = new Size(244, 48);
            txUpdatePillName.TabIndex = 62;
            // 
            // txUpdatePillCount
            // 
            txUpdatePillCount.BackColor = Color.FromArgb(255, 255, 192);
            txUpdatePillCount.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txUpdatePillCount.Location = new Point(396, 287);
            txUpdatePillCount.Name = "txUpdatePillCount";
            txUpdatePillCount.Size = new Size(244, 48);
            txUpdatePillCount.TabIndex = 61;
            // 
            // btPlacement
            // 
            btPlacement.BackColor = Color.LightSkyBlue;
            btPlacement.Font = new Font("Trebuchet MS", 18F);
            btPlacement.Location = new Point(508, 131);
            btPlacement.Name = "btPlacement";
            btPlacement.Size = new Size(132, 50);
            btPlacement.TabIndex = 73;
            btPlacement.Text = "Joylash";
            btPlacement.UseVisualStyleBackColor = false;
            btPlacement.Click += btPlacement_Click;
            // 
            // lbUpdatePillCount
            // 
            lbUpdatePillCount.AutoSize = true;
            lbUpdatePillCount.Font = new Font("Trebuchet MS", 22.2F);
            lbUpdatePillCount.Location = new Point(47, 285);
            lbUpdatePillCount.Name = "lbUpdatePillCount";
            lbUpdatePillCount.Size = new Size(179, 46);
            lbUpdatePillCount.TabIndex = 60;
            lbUpdatePillCount.Text = "Dori soni:";
            // 
            // txId
            // 
            txId.BackColor = Color.FromArgb(255, 255, 192);
            txId.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txId.Location = new Point(396, 131);
            txId.Name = "txId";
            txId.Size = new Size(92, 48);
            txId.TabIndex = 72;
            txId.TextChanged += txId_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 22.2F);
            label2.Location = new Point(47, 129);
            label2.Name = "label2";
            label2.Size = new Size(343, 46);
            label2.TabIndex = 71;
            label2.Text = "Dori Id sini kiriting:";
            // 
            // lbUpdatePillName
            // 
            lbUpdatePillName.AutoSize = true;
            lbUpdatePillName.Font = new Font("Trebuchet MS", 22.2F);
            lbUpdatePillName.Location = new Point(47, 206);
            lbUpdatePillName.Name = "lbUpdatePillName";
            lbUpdatePillName.Size = new Size(195, 46);
            lbUpdatePillName.TabIndex = 59;
            lbUpdatePillName.Text = "Dori nomi:";
            // 
            // btBack
            // 
            btBack.BackColor = Color.Silver;
            btBack.Font = new Font("Trebuchet MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btBack.Location = new Point(1455, 857);
            btBack.Name = "btBack";
            btBack.Size = new Size(189, 44);
            btBack.TabIndex = 61;
            btBack.Text = "Orqaga qaytish";
            btBack.UseVisualStyleBackColor = false;
            btBack.Click += btBack_Click;
            // 
            // btSearch
            // 
            btSearch.BackColor = Color.LightSkyBlue;
            btSearch.Font = new Font("Trebuchet MS", 14F);
            btSearch.Location = new Point(714, 123);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(161, 44);
            btSearch.TabIndex = 68;
            btSearch.Text = "Qidirish";
            btSearch.UseVisualStyleBackColor = false;
            btSearch.Click += btSearch_Click;
            // 
            // txPillInformation
            // 
            txPillInformation.BackColor = Color.FromArgb(255, 255, 192);
            txPillInformation.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txPillInformation.Location = new Point(350, 117);
            txPillInformation.Name = "txPillInformation";
            txPillInformation.Size = new Size(358, 48);
            txPillInformation.TabIndex = 69;
            txPillInformation.TextChanged += txPillInformation_TextChanged;
            // 
            // cbSearch
            // 
            cbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearch.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cbSearch.FormattingEnabled = true;
            cbSearch.Items.AddRange(new object[] { "Id", "Nomi", "Soni", "Muddati", "Narxi", "Qo'shilgan sanasi" });
            cbSearch.Location = new Point(70, 117);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(274, 49);
            cbSearch.TabIndex = 74;
            // 
            // button9
            // 
            button9.BackColor = Color.LightSkyBlue;
            button9.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button9.Location = new Point(714, 173);
            button9.Name = "button9";
            button9.Size = new Size(161, 48);
            button9.TabIndex = 83;
            button9.Text = "Qaytarish";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // cbSort
            // 
            cbSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSort.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cbSort.FormattingEnabled = true;
            cbSort.Items.AddRange(new object[] { "Id", "Nomi", "Soni", "Muddati", "Narxi", "Qo'shilgan sanasi" });
            cbSort.Location = new Point(70, 172);
            cbSort.Name = "cbSort";
            cbSort.Size = new Size(274, 49);
            cbSort.TabIndex = 76;
            cbSort.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button7
            // 
            button7.BackColor = Color.LightSkyBlue;
            button7.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button7.Location = new Point(548, 172);
            button7.Name = "button7";
            button7.Size = new Size(161, 48);
            button7.TabIndex = 85;
            button7.Text = "Kamayish";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSkyBlue;
            button3.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.Location = new Point(350, 172);
            button3.Name = "button3";
            button3.Size = new Size(193, 48);
            button3.TabIndex = 84;
            button3.Text = "O'sish";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dbPills
            // 
            dbPills.AutoGenerateColumns = false;
            dbPills.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dbPills.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12 });
            dbPills.DataSource = pillBindingSource2;
            dbPills.Location = new Point(70, 227);
            dbPills.Name = "dbPills";
            dbPills.RowHeadersWidth = 51;
            dbPills.Size = new Size(805, 612);
            dbPills.TabIndex = 86;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "Id";
            dataGridViewTextBoxColumn7.HeaderText = "Id";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "Nomi";
            dataGridViewTextBoxColumn8.HeaderText = "Nomi";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "Soni";
            dataGridViewTextBoxColumn9.HeaderText = "Soni";
            dataGridViewTextBoxColumn9.MinimumWidth = 6;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.DataPropertyName = "Muddati";
            dataGridViewTextBoxColumn10.HeaderText = "Muddati";
            dataGridViewTextBoxColumn10.MinimumWidth = 6;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.DataPropertyName = "Narxi";
            dataGridViewTextBoxColumn11.HeaderText = "Narxi";
            dataGridViewTextBoxColumn11.MinimumWidth = 6;
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.DataPropertyName = "QoshilganSana";
            dataGridViewTextBoxColumn12.HeaderText = "QoshilganSana";
            dataGridViewTextBoxColumn12.MinimumWidth = 6;
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.Width = 125;
            // 
            // pillBindingSource2
            // 
            pillBindingSource2.DataSource = typeof(Actions.Pill);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 24F);
            label5.Location = new Point(338, 55);
            label5.Name = "label5";
            label5.Size = new Size(287, 49);
            label5.TabIndex = 133;
            label5.Text = "Dorilar ro'yxati";
            // 
            // UpdatePillForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1717, 943);
            Controls.Add(label5);
            Controls.Add(dbPills);
            Controls.Add(button7);
            Controls.Add(button3);
            Controls.Add(button9);
            Controls.Add(cbSort);
            Controls.Add(cbSearch);
            Controls.Add(btSearch);
            Controls.Add(txPillInformation);
            Controls.Add(btBack);
            Controls.Add(panel2);
            Name = "UpdatePillForm";
            Text = "UpdatePillForm";
            FormClosed += UpdatePillForm_FormClosed;
            Load += UpdatePillForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dbPills).EndInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource1).EndInit();
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
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn muddatiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn narxiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn qoshilganSanaDataGridViewTextBoxColumn;
        private BindingSource pillBindingSource;
        private Button btSearch;
        private TextBox txPillInformation;
        private TextBox txId;
        private Label label2;
        private Button btPlacement;
        private ComboBox cbSearch;
        private Button button9;
        private ComboBox cbSort;
        private Button button7;
        private Button button3;
        private DataGridView dbPills;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private BindingSource pillBindingSource1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private BindingSource pillBindingSource2;
        private Label label5;
    }
}