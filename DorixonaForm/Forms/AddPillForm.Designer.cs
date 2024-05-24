namespace DorixonaForm.Forms
{
    partial class AddPillForm
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
            label2 = new Label();
            panel1 = new Panel();
            txLifeTime = new TextBox();
            lbAddPillName = new Label();
            lbLifeTime = new Label();
            lbAddPillCount = new Label();
            btAddPill = new Button();
            txAddPillCount = new TextBox();
            txAddPillPrice = new TextBox();
            txAddPillName = new TextBox();
            lbAddPillPrice = new Label();
            btBack = new Button();
            btExit = new Button();
            button9 = new Button();
            cbSearch = new ComboBox();
            cbSort = new ComboBox();
            btSearch = new Button();
            txPillInformation = new TextBox();
            button7 = new Button();
            button3 = new Button();
            sellingPillBindingSource = new BindingSource(components);
            sellingPillBindingSource1 = new BindingSource(components);
            sellingPillBindingSource2 = new BindingSource(components);
            sellingPillBindingSource3 = new BindingSource(components);
            dgPills = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            pillBindingSource1 = new BindingSource(components);
            pillBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sellingPillBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sellingPillBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sellingPillBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sellingPillBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgPills).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 24F);
            label2.Location = new Point(228, 34);
            label2.Name = "label2";
            label2.Size = new Size(243, 49);
            label2.TabIndex = 59;
            label2.Text = "Dori qo'shish";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txLifeTime);
            panel1.Controls.Add(lbAddPillName);
            panel1.Controls.Add(lbLifeTime);
            panel1.Controls.Add(lbAddPillCount);
            panel1.Controls.Add(btAddPill);
            panel1.Controls.Add(txAddPillCount);
            panel1.Controls.Add(txAddPillPrice);
            panel1.Controls.Add(txAddPillName);
            panel1.Controls.Add(lbAddPillPrice);
            panel1.Location = new Point(193, 106);
            panel1.Name = "panel1";
            panel1.Size = new Size(660, 771);
            panel1.TabIndex = 58;
            // 
            // txLifeTime
            // 
            txLifeTime.BackColor = Color.FromArgb(255, 255, 192);
            txLifeTime.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txLifeTime.Location = new Point(330, 297);
            txLifeTime.Name = "txLifeTime";
            txLifeTime.Size = new Size(291, 48);
            txLifeTime.TabIndex = 49;
            // 
            // lbAddPillName
            // 
            lbAddPillName.AutoSize = true;
            lbAddPillName.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbAddPillName.Location = new Point(15, 159);
            lbAddPillName.Name = "lbAddPillName";
            lbAddPillName.Size = new Size(289, 38);
            lbAddPillName.TabIndex = 41;
            lbAddPillName.Text = "Dori nomini kiriting:";
            // 
            // lbLifeTime
            // 
            lbLifeTime.AutoSize = true;
            lbLifeTime.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbLifeTime.Location = new Point(15, 295);
            lbLifeTime.Name = "lbLifeTime";
            lbLifeTime.Size = new Size(335, 38);
            lbLifeTime.TabIndex = 48;
            lbLifeTime.Text = "Dori muddatini kiriting:";
            // 
            // lbAddPillCount
            // 
            lbAddPillCount.AutoSize = true;
            lbAddPillCount.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbAddPillCount.Location = new Point(15, 229);
            lbAddPillCount.Name = "lbAddPillCount";
            lbAddPillCount.Size = new Size(276, 38);
            lbAddPillCount.TabIndex = 42;
            lbAddPillCount.Text = "Dori sonini kiriting:";
            // 
            // btAddPill
            // 
            btAddPill.BackColor = Color.FromArgb(128, 255, 128);
            btAddPill.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btAddPill.Location = new Point(15, 548);
            btAddPill.Name = "btAddPill";
            btAddPill.Size = new Size(606, 60);
            btAddPill.TabIndex = 47;
            btAddPill.Text = "Qo'shish";
            btAddPill.UseVisualStyleBackColor = false;
            btAddPill.Click += btAddPill_Click;
            // 
            // txAddPillCount
            // 
            txAddPillCount.BackColor = Color.FromArgb(255, 255, 192);
            txAddPillCount.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txAddPillCount.Location = new Point(330, 231);
            txAddPillCount.Name = "txAddPillCount";
            txAddPillCount.Size = new Size(291, 48);
            txAddPillCount.TabIndex = 43;
            // 
            // txAddPillPrice
            // 
            txAddPillPrice.BackColor = Color.FromArgb(255, 255, 192);
            txAddPillPrice.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txAddPillPrice.Location = new Point(330, 366);
            txAddPillPrice.Name = "txAddPillPrice";
            txAddPillPrice.Size = new Size(291, 48);
            txAddPillPrice.TabIndex = 46;
            // 
            // txAddPillName
            // 
            txAddPillName.BackColor = Color.FromArgb(255, 255, 192);
            txAddPillName.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txAddPillName.Location = new Point(330, 161);
            txAddPillName.Name = "txAddPillName";
            txAddPillName.Size = new Size(291, 48);
            txAddPillName.TabIndex = 44;
            // 
            // lbAddPillPrice
            // 
            lbAddPillPrice.AutoSize = true;
            lbAddPillPrice.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbAddPillPrice.Location = new Point(15, 364);
            lbAddPillPrice.Name = "lbAddPillPrice";
            lbAddPillPrice.Size = new Size(291, 38);
            lbAddPillPrice.TabIndex = 45;
            lbAddPillPrice.Text = "Dori narxini kiriting:";
            // 
            // btBack
            // 
            btBack.BackColor = Color.Silver;
            btBack.Font = new Font("Trebuchet MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btBack.Location = new Point(1484, 894);
            btBack.Name = "btBack";
            btBack.Size = new Size(193, 44);
            btBack.TabIndex = 60;
            btBack.Text = "Orqaga qaytish";
            btBack.UseVisualStyleBackColor = false;
            btBack.Click += btBack_Click;
            // 
            // btExit
            // 
            btExit.BackColor = Color.Silver;
            btExit.Font = new Font("Trebuchet MS", 14F);
            btExit.Location = new Point(1539, 35);
            btExit.Name = "btExit";
            btExit.Size = new Size(124, 44);
            btExit.TabIndex = 61;
            btExit.Text = "Chiqish";
            btExit.UseVisualStyleBackColor = false;
            btExit.Click += btExit_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.LightSkyBlue;
            button9.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button9.Location = new Point(1539, 159);
            button9.Name = "button9";
            button9.Size = new Size(138, 51);
            button9.TabIndex = 98;
            button9.Text = "Qaytarish";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // cbSearch
            // 
            cbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearch.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cbSearch.FormattingEnabled = true;
            cbSearch.Items.AddRange(new object[] { "Id", "Nomi", "Soni", "Muddati", "Narxi", "Qo'shilgan sanasi" });
            cbSearch.Location = new Point(877, 106);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(320, 49);
            cbSearch.TabIndex = 91;
            // 
            // cbSort
            // 
            cbSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSort.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cbSort.FormattingEnabled = true;
            cbSort.Items.AddRange(new object[] { "Id", "Nomi", "Soni", "Muddati", "Narxi", "Qo'shilgan sanasi" });
            cbSort.Location = new Point(877, 161);
            cbSort.Name = "cbSort";
            cbSort.Size = new Size(320, 49);
            cbSort.TabIndex = 101;
            // 
            // btSearch
            // 
            btSearch.BackColor = Color.LightSkyBlue;
            btSearch.Font = new Font("Trebuchet MS", 18F);
            btSearch.Location = new Point(1539, 106);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(138, 47);
            btSearch.TabIndex = 99;
            btSearch.Text = "Qidirish";
            btSearch.UseVisualStyleBackColor = false;
            btSearch.Click += btSearch_Click;
            // 
            // txPillInformation
            // 
            txPillInformation.BackColor = Color.FromArgb(255, 255, 192);
            txPillInformation.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txPillInformation.Location = new Point(1222, 106);
            txPillInformation.Name = "txPillInformation";
            txPillInformation.Size = new Size(297, 48);
            txPillInformation.TabIndex = 100;
            // 
            // button7
            // 
            button7.BackColor = Color.LightSkyBlue;
            button7.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button7.Location = new Point(1381, 159);
            button7.Name = "button7";
            button7.Size = new Size(138, 49);
            button7.TabIndex = 103;
            button7.Text = "Kamayish";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSkyBlue;
            button3.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.Location = new Point(1222, 159);
            button3.Name = "button3";
            button3.Size = new Size(138, 49);
            button3.TabIndex = 102;
            button3.Text = "O'sish";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dgPills
            // 
            dgPills.AutoGenerateColumns = false;
            dgPills.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPills.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dgPills.DataSource = pillBindingSource1;
            dgPills.Location = new Point(877, 216);
            dgPills.Name = "dgPills";
            dgPills.RowHeadersWidth = 51;
            dgPills.Size = new Size(799, 661);
            dgPills.TabIndex = 104;
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
            // pillBindingSource1
            // 
            pillBindingSource1.DataSource = typeof(Actions.Pill);
            // 
            // AddPillForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1700, 1033);
            Controls.Add(dgPills);
            Controls.Add(button7);
            Controls.Add(button3);
            Controls.Add(cbSort);
            Controls.Add(btSearch);
            Controls.Add(txPillInformation);
            Controls.Add(button9);
            Controls.Add(cbSearch);
            Controls.Add(btExit);
            Controls.Add(btBack);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddPillForm";
            Text = "AddPillForm";
            FormClosed += AddPillForm_FormClosed;
            Load += AddPillForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sellingPillBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)sellingPillBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)sellingPillBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)sellingPillBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgPills).EndInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Panel panel1;
        private TextBox txLifeTime;
        private Label lbAddPillName;
        private Label lbLifeTime;
        private Label lbAddPillCount;
        private Button btAddPill;
        private TextBox txAddPillCount;
        private TextBox txAddPillPrice;
        private TextBox txAddPillName;
        private Label lbAddPillPrice;
        private Button btBack;
        private Button btExit;
        private Button button9;
        private ComboBox cbSearch;
        private ComboBox cbSort;
        private Button btSearch;
        private TextBox txPillInformation;
        private Button button7;
        private Button button3;
        private BindingSource sellingPillBindingSource;
        private BindingSource sellingPillBindingSource1;
        private BindingSource sellingPillBindingSource2;
        private BindingSource sellingPillBindingSource3;
        private DataGridView dgPills;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn muddatiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn narxiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn qoshilganSanaDataGridViewTextBoxColumn;
        private BindingSource pillBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private BindingSource pillBindingSource1;
    }
}