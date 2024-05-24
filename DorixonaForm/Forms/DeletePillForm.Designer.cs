namespace DorixonaForm.Forms
{
    partial class DeletePillForm
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
            label4 = new Label();
            panel3 = new Panel();
            txDeletePillLifeTime = new TextBox();
            label1 = new Label();
            btDeletePill = new Button();
            lbUpdatePillCount = new Label();
            txDeletePillPrice = new TextBox();
            txDeletePillCount = new TextBox();
            lbUpdatePillName = new Label();
            lbUpdatePillPrice = new Label();
            txDeletePillName = new TextBox();
            btBack = new Button();
            btPlacement = new Button();
            txId = new TextBox();
            label2 = new Label();
            btSearch = new Button();
            txPillInformation = new TextBox();
            pillBindingSource = new BindingSource(components);
            button9 = new Button();
            cbSort = new ComboBox();
            btExit = new Button();
            cbSearch = new ComboBox();
            button7 = new Button();
            button3 = new Button();
            dataGridViewPills = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            pillBindingSource2 = new BindingSource(components);
            pillBindingSource1 = new BindingSource(components);
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPills).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 24F);
            label4.Location = new Point(260, 23);
            label4.Name = "label4";
            label4.Size = new Size(252, 49);
            label4.TabIndex = 61;
            label4.Text = "Dori o'chirish";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightCyan;
            panel3.Controls.Add(txDeletePillLifeTime);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(btDeletePill);
            panel3.Controls.Add(lbUpdatePillCount);
            panel3.Controls.Add(txDeletePillPrice);
            panel3.Controls.Add(txDeletePillCount);
            panel3.Controls.Add(lbUpdatePillName);
            panel3.Controls.Add(lbUpdatePillPrice);
            panel3.Controls.Add(txDeletePillName);
            panel3.Location = new Point(35, 237);
            panel3.Name = "panel3";
            panel3.Size = new Size(741, 587);
            panel3.TabIndex = 60;
            // 
            // txDeletePillLifeTime
            // 
            txDeletePillLifeTime.BackColor = Color.FromArgb(255, 255, 192);
            txDeletePillLifeTime.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txDeletePillLifeTime.Location = new Point(398, 302);
            txDeletePillLifeTime.Name = "txDeletePillLifeTime";
            txDeletePillLifeTime.Size = new Size(258, 48);
            txDeletePillLifeTime.TabIndex = 75;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 22.2F);
            label1.Location = new Point(103, 300);
            label1.Name = "label1";
            label1.Size = new Size(251, 46);
            label1.TabIndex = 74;
            label1.Text = "Dori muddati:";
            // 
            // btDeletePill
            // 
            btDeletePill.BackColor = Color.Tomato;
            btDeletePill.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btDeletePill.Location = new Point(103, 471);
            btDeletePill.Name = "btDeletePill";
            btDeletePill.Size = new Size(554, 60);
            btDeletePill.TabIndex = 59;
            btDeletePill.Text = "O'chirish";
            btDeletePill.UseVisualStyleBackColor = false;
            btDeletePill.Click += btDeletePill_Click;
            // 
            // lbUpdatePillCount
            // 
            lbUpdatePillCount.AutoSize = true;
            lbUpdatePillCount.Font = new Font("Trebuchet MS", 22.2F);
            lbUpdatePillCount.Location = new Point(103, 234);
            lbUpdatePillCount.Name = "lbUpdatePillCount";
            lbUpdatePillCount.Size = new Size(179, 46);
            lbUpdatePillCount.TabIndex = 69;
            lbUpdatePillCount.Text = "Dori soni:";
            // 
            // txDeletePillPrice
            // 
            txDeletePillPrice.BackColor = Color.FromArgb(255, 255, 192);
            txDeletePillPrice.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txDeletePillPrice.Location = new Point(397, 371);
            txDeletePillPrice.Name = "txDeletePillPrice";
            txDeletePillPrice.Size = new Size(259, 48);
            txDeletePillPrice.TabIndex = 73;
            // 
            // txDeletePillCount
            // 
            txDeletePillCount.BackColor = Color.FromArgb(255, 255, 192);
            txDeletePillCount.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txDeletePillCount.Location = new Point(398, 236);
            txDeletePillCount.Name = "txDeletePillCount";
            txDeletePillCount.Size = new Size(259, 48);
            txDeletePillCount.TabIndex = 70;
            // 
            // lbUpdatePillName
            // 
            lbUpdatePillName.AutoSize = true;
            lbUpdatePillName.Font = new Font("Trebuchet MS", 22.2F);
            lbUpdatePillName.Location = new Point(103, 164);
            lbUpdatePillName.Name = "lbUpdatePillName";
            lbUpdatePillName.Size = new Size(195, 46);
            lbUpdatePillName.TabIndex = 68;
            lbUpdatePillName.Text = "Dori nomi:";
            // 
            // lbUpdatePillPrice
            // 
            lbUpdatePillPrice.AutoSize = true;
            lbUpdatePillPrice.Font = new Font("Trebuchet MS", 22.2F);
            lbUpdatePillPrice.Location = new Point(103, 369);
            lbUpdatePillPrice.Name = "lbUpdatePillPrice";
            lbUpdatePillPrice.Size = new Size(196, 46);
            lbUpdatePillPrice.TabIndex = 72;
            lbUpdatePillPrice.Text = "Dori narxi:";
            // 
            // txDeletePillName
            // 
            txDeletePillName.BackColor = Color.FromArgb(255, 255, 192);
            txDeletePillName.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txDeletePillName.Location = new Point(397, 166);
            txDeletePillName.Name = "txDeletePillName";
            txDeletePillName.Size = new Size(259, 48);
            txDeletePillName.TabIndex = 71;
            // 
            // btBack
            // 
            btBack.BackColor = Color.Silver;
            btBack.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btBack.Location = new Point(1373, 842);
            btBack.Name = "btBack";
            btBack.Size = new Size(249, 53);
            btBack.TabIndex = 61;
            btBack.Text = "Orqaga qaytish";
            btBack.UseVisualStyleBackColor = false;
            btBack.Click += btBack_Click;
            // 
            // btPlacement
            // 
            btPlacement.BackColor = Color.LightSkyBlue;
            btPlacement.Font = new Font("Trebuchet MS", 18F);
            btPlacement.Location = new Point(634, 184);
            btPlacement.Name = "btPlacement";
            btPlacement.Size = new Size(142, 47);
            btPlacement.TabIndex = 79;
            btPlacement.Text = "Joylash";
            btPlacement.UseVisualStyleBackColor = false;
            btPlacement.Click += btPlacement_Click;
            // 
            // txId
            // 
            txId.BackColor = Color.FromArgb(255, 255, 192);
            txId.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txId.Location = new Point(345, 185);
            txId.Name = "txId";
            txId.Size = new Size(243, 48);
            txId.TabIndex = 78;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 22.2F);
            label2.Location = new Point(35, 183);
            label2.Name = "label2";
            label2.Size = new Size(343, 46);
            label2.TabIndex = 77;
            label2.Text = "Dori Id sini kiriting:";
            // 
            // btSearch
            // 
            btSearch.BackColor = Color.LightSkyBlue;
            btSearch.Font = new Font("Trebuchet MS", 18F);
            btSearch.Location = new Point(1479, 187);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(142, 48);
            btSearch.TabIndex = 74;
            btSearch.Text = "Qidirish";
            btSearch.UseVisualStyleBackColor = false;
            btSearch.Click += btSearch_Click;
            // 
            // txPillInformation
            // 
            txPillInformation.BackColor = Color.FromArgb(255, 255, 192);
            txPillInformation.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txPillInformation.Location = new Point(1192, 187);
            txPillInformation.Name = "txPillInformation";
            txPillInformation.Size = new Size(281, 48);
            txPillInformation.TabIndex = 75;
            // 
            // button9
            // 
            button9.BackColor = Color.LightSkyBlue;
            button9.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button9.Location = new Point(1484, 241);
            button9.Name = "button9";
            button9.Size = new Size(138, 48);
            button9.TabIndex = 89;
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
            cbSort.Location = new Point(815, 240);
            cbSort.Name = "cbSort";
            cbSort.Size = new Size(361, 49);
            cbSort.TabIndex = 82;
            // 
            // btExit
            // 
            btExit.BackColor = Color.Silver;
            btExit.Font = new Font("Trebuchet MS", 14F);
            btExit.Location = new Point(1497, 47);
            btExit.Name = "btExit";
            btExit.Size = new Size(124, 44);
            btExit.TabIndex = 81;
            btExit.Text = "Chiqish";
            btExit.UseVisualStyleBackColor = false;
            btExit.Click += btExit_Click;
            // 
            // cbSearch
            // 
            cbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearch.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cbSearch.FormattingEnabled = true;
            cbSearch.Items.AddRange(new object[] { "Id", "Nomi", "Soni", "Muddati", "Narxi", "Qo'shilgan sanasi" });
            cbSearch.Location = new Point(815, 185);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(361, 49);
            cbSearch.TabIndex = 90;
            // 
            // button7
            // 
            button7.BackColor = Color.LightSkyBlue;
            button7.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button7.Location = new Point(1335, 241);
            button7.Name = "button7";
            button7.Size = new Size(138, 48);
            button7.TabIndex = 92;
            button7.Text = "Kamayish";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSkyBlue;
            button3.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.Location = new Point(1192, 241);
            button3.Name = "button3";
            button3.Size = new Size(138, 48);
            button3.TabIndex = 91;
            button3.Text = "O'sish";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridViewPills
            // 
            dataGridViewPills.AutoGenerateColumns = false;
            dataGridViewPills.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPills.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dataGridViewPills.DataSource = pillBindingSource2;
            dataGridViewPills.Location = new Point(815, 295);
            dataGridViewPills.Name = "dataGridViewPills";
            dataGridViewPills.RowHeadersWidth = 51;
            dataGridViewPills.Size = new Size(806, 529);
            dataGridViewPills.TabIndex = 93;
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
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "QoshilganSana";
            dataGridViewTextBoxColumn6.HeaderText = "QoshilganSana";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 125;
            // 
            // pillBindingSource2
            // 
            pillBindingSource2.DataSource = typeof(Actions.Pill);
            // 
            // DeletePillForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1653, 1033);
            Controls.Add(dataGridViewPills);
            Controls.Add(button7);
            Controls.Add(button3);
            Controls.Add(cbSearch);
            Controls.Add(button9);
            Controls.Add(cbSort);
            Controls.Add(btExit);
            Controls.Add(btPlacement);
            Controls.Add(txId);
            Controls.Add(label2);
            Controls.Add(btSearch);
            Controls.Add(txPillInformation);
            Controls.Add(btBack);
            Controls.Add(panel3);
            Name = "DeletePillForm";
            Text = "DeletePillForm";
            Load += DeletePillForm_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPills).EndInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Panel panel3;
        private Button btDeletePill;
        private Button btBack;
        private TextBox txDeletePillLifeTime;
        private Label label1;
        private Label lbUpdatePillCount;
        private TextBox txDeletePillPrice;
        private TextBox txDeletePillCount;
        private Label lbUpdatePillName;
        private Label lbUpdatePillPrice;
        private TextBox txDeletePillName;
        private Button btPlacement;
        private TextBox txId;
        private Label label2;
        private Button btSearch;
        private TextBox txPillInformation;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn muddatiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn narxiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn qoshilganSanaDataGridViewTextBoxColumn;
        private BindingSource pillBindingSource;
        private Button button9;
        private ComboBox cbSort;
        private Button btExit;
        private ComboBox cbSearch;
        private Button button7;
        private Button button3;
        private DataGridView dataGridViewPills;
        private BindingSource pillBindingSource1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private BindingSource pillBindingSource2;
    }
}