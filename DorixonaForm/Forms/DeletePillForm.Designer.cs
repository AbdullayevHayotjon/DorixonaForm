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
            btPlacement = new Button();
            label1 = new Label();
            txId = new TextBox();
            btDeletePill = new Button();
            label2 = new Label();
            lbUpdatePillCount = new Label();
            txDeletePillPrice = new TextBox();
            txDeletePillCount = new TextBox();
            lbUpdatePillName = new Label();
            lbUpdatePillPrice = new Label();
            txDeletePillName = new TextBox();
            btBack = new Button();
            btSearch = new Button();
            txPillInformation = new TextBox();
            pillBindingSource = new BindingSource(components);
            button9 = new Button();
            cbSort = new ComboBox();
            cbSearch = new ComboBox();
            button7 = new Button();
            button3 = new Button();
            dataGridViewPills = new DataGridView();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            pillBindingSource3 = new BindingSource(components);
            pillBindingSource2 = new BindingSource(components);
            pillBindingSource1 = new BindingSource(components);
            label5 = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPills).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 24F);
            label4.Location = new Point(283, 18);
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
            panel3.Controls.Add(btPlacement);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txId);
            panel3.Controls.Add(btDeletePill);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(lbUpdatePillCount);
            panel3.Controls.Add(txDeletePillPrice);
            panel3.Controls.Add(txDeletePillCount);
            panel3.Controls.Add(lbUpdatePillName);
            panel3.Controls.Add(lbUpdatePillPrice);
            panel3.Controls.Add(txDeletePillName);
            panel3.Location = new Point(879, 90);
            panel3.Name = "panel3";
            panel3.Size = new Size(794, 728);
            panel3.TabIndex = 60;
            // 
            // txDeletePillLifeTime
            // 
            txDeletePillLifeTime.BackColor = Color.FromArgb(255, 255, 192);
            txDeletePillLifeTime.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txDeletePillLifeTime.Location = new Point(393, 380);
            txDeletePillLifeTime.Name = "txDeletePillLifeTime";
            txDeletePillLifeTime.Size = new Size(365, 48);
            txDeletePillLifeTime.TabIndex = 75;
            // 
            // btPlacement
            // 
            btPlacement.BackColor = Color.LightSkyBlue;
            btPlacement.Font = new Font("Trebuchet MS", 14F);
            btPlacement.Location = new Point(616, 164);
            btPlacement.Name = "btPlacement";
            btPlacement.Size = new Size(142, 44);
            btPlacement.TabIndex = 79;
            btPlacement.Text = "Joylash";
            btPlacement.UseVisualStyleBackColor = false;
            btPlacement.Click += btPlacement_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 22.2F);
            label1.Location = new Point(44, 378);
            label1.Name = "label1";
            label1.Size = new Size(251, 46);
            label1.TabIndex = 74;
            label1.Text = "Dori muddati:";
            // 
            // txId
            // 
            txId.BackColor = Color.FromArgb(255, 255, 192);
            txId.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txId.Location = new Point(393, 160);
            txId.Name = "txId";
            txId.Size = new Size(204, 48);
            txId.TabIndex = 78;
            // 
            // btDeletePill
            // 
            btDeletePill.BackColor = Color.FromArgb(255, 128, 128);
            btDeletePill.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btDeletePill.Location = new Point(44, 602);
            btDeletePill.Name = "btDeletePill";
            btDeletePill.Size = new Size(714, 60);
            btDeletePill.TabIndex = 59;
            btDeletePill.Text = "O'chirish";
            btDeletePill.UseVisualStyleBackColor = false;
            btDeletePill.Click += btDeletePill_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 22.2F);
            label2.Location = new Point(44, 158);
            label2.Name = "label2";
            label2.Size = new Size(343, 46);
            label2.TabIndex = 77;
            label2.Text = "Dori Id sini kiriting:";
            // 
            // lbUpdatePillCount
            // 
            lbUpdatePillCount.AutoSize = true;
            lbUpdatePillCount.Font = new Font("Trebuchet MS", 22.2F);
            lbUpdatePillCount.Location = new Point(44, 303);
            lbUpdatePillCount.Name = "lbUpdatePillCount";
            lbUpdatePillCount.Size = new Size(179, 46);
            lbUpdatePillCount.TabIndex = 69;
            lbUpdatePillCount.Text = "Dori soni:";
            // 
            // txDeletePillPrice
            // 
            txDeletePillPrice.BackColor = Color.FromArgb(255, 255, 192);
            txDeletePillPrice.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txDeletePillPrice.Location = new Point(393, 453);
            txDeletePillPrice.Name = "txDeletePillPrice";
            txDeletePillPrice.Size = new Size(365, 48);
            txDeletePillPrice.TabIndex = 73;
            // 
            // txDeletePillCount
            // 
            txDeletePillCount.BackColor = Color.FromArgb(255, 255, 192);
            txDeletePillCount.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txDeletePillCount.Location = new Point(393, 305);
            txDeletePillCount.Name = "txDeletePillCount";
            txDeletePillCount.Size = new Size(365, 48);
            txDeletePillCount.TabIndex = 70;
            // 
            // lbUpdatePillName
            // 
            lbUpdatePillName.AutoSize = true;
            lbUpdatePillName.Font = new Font("Trebuchet MS", 22.2F);
            lbUpdatePillName.Location = new Point(44, 228);
            lbUpdatePillName.Name = "lbUpdatePillName";
            lbUpdatePillName.Size = new Size(195, 46);
            lbUpdatePillName.TabIndex = 68;
            lbUpdatePillName.Text = "Dori nomi:";
            // 
            // lbUpdatePillPrice
            // 
            lbUpdatePillPrice.AutoSize = true;
            lbUpdatePillPrice.Font = new Font("Trebuchet MS", 22.2F);
            lbUpdatePillPrice.Location = new Point(44, 451);
            lbUpdatePillPrice.Name = "lbUpdatePillPrice";
            lbUpdatePillPrice.Size = new Size(196, 46);
            lbUpdatePillPrice.TabIndex = 72;
            lbUpdatePillPrice.Text = "Dori narxi:";
            // 
            // txDeletePillName
            // 
            txDeletePillName.BackColor = Color.FromArgb(255, 255, 192);
            txDeletePillName.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txDeletePillName.Location = new Point(393, 230);
            txDeletePillName.Name = "txDeletePillName";
            txDeletePillName.Size = new Size(365, 48);
            txDeletePillName.TabIndex = 71;
            // 
            // btBack
            // 
            btBack.BackColor = Color.Silver;
            btBack.Font = new Font("Trebuchet MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btBack.Location = new Point(1481, 836);
            btBack.Name = "btBack";
            btBack.Size = new Size(192, 44);
            btBack.TabIndex = 61;
            btBack.Text = "Orqaga qaytish";
            btBack.UseVisualStyleBackColor = false;
            btBack.Click += btBack_Click;
            // 
            // btSearch
            // 
            btSearch.BackColor = Color.LightSkyBlue;
            btSearch.Font = new Font("Trebuchet MS", 14F);
            btSearch.Location = new Point(705, 110);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(138, 44);
            btSearch.TabIndex = 74;
            btSearch.Text = "Qidirish";
            btSearch.UseVisualStyleBackColor = false;
            btSearch.Click += btSearch_Click;
            // 
            // txPillInformation
            // 
            txPillInformation.BackColor = Color.FromArgb(255, 255, 192);
            txPillInformation.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txPillInformation.Location = new Point(418, 110);
            txPillInformation.Name = "txPillInformation";
            txPillInformation.Size = new Size(281, 48);
            txPillInformation.TabIndex = 75;
            // 
            // button9
            // 
            button9.BackColor = Color.LightSkyBlue;
            button9.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button9.Location = new Point(705, 163);
            button9.Name = "button9";
            button9.Size = new Size(138, 44);
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
            cbSort.Location = new Point(51, 163);
            cbSort.Name = "cbSort";
            cbSort.Size = new Size(361, 49);
            cbSort.TabIndex = 82;
            // 
            // cbSearch
            // 
            cbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearch.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cbSearch.FormattingEnabled = true;
            cbSearch.Items.AddRange(new object[] { "Id", "Nomi", "Soni", "Muddati", "Narxi", "Qo'shilgan sanasi" });
            cbSearch.Location = new Point(51, 108);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(361, 49);
            cbSearch.TabIndex = 90;
            // 
            // button7
            // 
            button7.BackColor = Color.LightSkyBlue;
            button7.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button7.Location = new Point(561, 164);
            button7.Name = "button7";
            button7.Size = new Size(138, 44);
            button7.TabIndex = 92;
            button7.Text = "Kamayish";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSkyBlue;
            button3.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.Location = new Point(418, 164);
            button3.Name = "button3";
            button3.Size = new Size(138, 44);
            button3.TabIndex = 91;
            button3.Text = "O'sish";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridViewPills
            // 
            dataGridViewPills.AutoGenerateColumns = false;
            dataGridViewPills.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPills.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12 });
            dataGridViewPills.DataSource = pillBindingSource3;
            dataGridViewPills.Location = new Point(42, 223);
            dataGridViewPills.Name = "dataGridViewPills";
            dataGridViewPills.RowHeadersWidth = 51;
            dataGridViewPills.Size = new Size(806, 529);
            dataGridViewPills.TabIndex = 93;
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
            // pillBindingSource3
            // 
            pillBindingSource3.DataSource = typeof(Actions.Pill);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 24F);
            label5.Location = new Point(317, 56);
            label5.Name = "label5";
            label5.Size = new Size(287, 49);
            label5.TabIndex = 95;
            label5.Text = "Dorilar ro'yxati";
            // 
            // DeletePillForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1717, 943);
            Controls.Add(label5);
            Controls.Add(dataGridViewPills);
            Controls.Add(button7);
            Controls.Add(button3);
            Controls.Add(btBack);
            Controls.Add(cbSearch);
            Controls.Add(panel3);
            Controls.Add(txPillInformation);
            Controls.Add(button9);
            Controls.Add(btSearch);
            Controls.Add(cbSort);
            Name = "DeletePillForm";
            Text = "DeletePillForm";
            FormClosed += DeletePillForm_FormClosed;
            Load += DeletePillForm_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPills).EndInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource3).EndInit();
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
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private BindingSource pillBindingSource3;
        private Label label5;
    }
}