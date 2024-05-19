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
            txPillInformation = new TextBox();
            dGWPills = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            muddatiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            qoshilganSanaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pillBindingSource4 = new BindingSource(components);
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
            button4 = new Button();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            sellingPillBindingSource = new BindingSource(components);
            lbAllPrice = new Label();
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
            cbSort = new ComboBox();
            btOsish = new Button();
            btKamayish = new Button();
            btQaytarish = new Button();
            sellingPillBindingSource1 = new BindingSource(components);
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dGWPills).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sellingPillBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sellingPillBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // btExit
            // 
            btExit.BackColor = Color.Silver;
            btExit.Font = new Font("Trebuchet MS", 14F);
            btExit.Location = new Point(1497, 47);
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
            btSellPill.Location = new Point(564, 705);
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
            btSearch.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btSearch.Location = new Point(1483, 124);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(138, 49);
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
            // txPillInformation
            // 
            txPillInformation.BackColor = Color.FromArgb(255, 255, 192);
            txPillInformation.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txPillInformation.Location = new Point(1216, 124);
            txPillInformation.Name = "txPillInformation";
            txPillInformation.Size = new Size(262, 48);
            txPillInformation.TabIndex = 23;
            // 
            // dGWPills
            // 
            dGWPills.AutoGenerateColumns = false;
            dGWPills.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGWPills.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, muddatiDataGridViewTextBoxColumn, dataGridViewTextBoxColumn4, qoshilganSanaDataGridViewTextBoxColumn });
            dGWPills.DataSource = pillBindingSource4;
            dGWPills.Location = new Point(881, 241);
            dGWPills.Name = "dGWPills";
            dGWPills.RowHeadersWidth = 80;
            dGWPills.Size = new Size(832, 668);
            dGWPills.TabIndex = 24;
            dGWPills.CellContentClick += dGWPills_CellContentClick;
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
            // muddatiDataGridViewTextBoxColumn
            // 
            muddatiDataGridViewTextBoxColumn.DataPropertyName = "Muddati";
            muddatiDataGridViewTextBoxColumn.HeaderText = "Muddati";
            muddatiDataGridViewTextBoxColumn.MinimumWidth = 6;
            muddatiDataGridViewTextBoxColumn.Name = "muddatiDataGridViewTextBoxColumn";
            muddatiDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Narxi";
            dataGridViewTextBoxColumn4.HeaderText = "Narxi";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // qoshilganSanaDataGridViewTextBoxColumn
            // 
            qoshilganSanaDataGridViewTextBoxColumn.DataPropertyName = "QoshilganSana";
            qoshilganSanaDataGridViewTextBoxColumn.HeaderText = "QoshilganSana";
            qoshilganSanaDataGridViewTextBoxColumn.MinimumWidth = 6;
            qoshilganSanaDataGridViewTextBoxColumn.Name = "qoshilganSanaDataGridViewTextBoxColumn";
            qoshilganSanaDataGridViewTextBoxColumn.Width = 125;
            // 
            // pillBindingSource4
            // 
            pillBindingSource4.DataSource = typeof(Actions.Pill);
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
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(lbAllPrice);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(txId);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btSellPill);
            panel1.Controls.Add(txPillCount);
            panel1.Controls.Add(btAddBox);
            panel1.Controls.Add(lbPillCount);
            panel1.Location = new Point(12, 124);
            panel1.Name = "panel1";
            panel1.Size = new Size(851, 841);
            panel1.TabIndex = 32;
            panel1.Paint += panel1_Paint;
            // 
            // button4
            // 
            button4.BackColor = Color.LightSkyBlue;
            button4.Font = new Font("Trebuchet MS", 16.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button4.Location = new Point(564, 610);
            button4.Name = "button4";
            button4.Size = new Size(232, 50);
            button4.TabIndex = 84;
            button4.Text = "Tozalash";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(404, 267);
            label4.Name = "label4";
            label4.Size = new Size(90, 38);
            label4.TabIndex = 83;
            label4.Text = "Savat";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            dataGridView1.DataSource = sellingPillBindingSource1;
            dataGridView1.Location = new Point(148, 308);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(553, 263);
            dataGridView1.TabIndex = 82;
            // 
            // lbAllPrice
            // 
            lbAllPrice.AutoSize = true;
            lbAllPrice.BackColor = Color.FromArgb(255, 255, 192);
            lbAllPrice.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lbAllPrice.Location = new Point(245, 622);
            lbAllPrice.Name = "lbAllPrice";
            lbAllPrice.Size = new Size(97, 38);
            lbAllPrice.TabIndex = 81;
            lbAllPrice.Text = "          ";
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
            button1.Click += button1_Click_1;
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
            button2.Click += button2_Click;
            // 
            // txId
            // 
            txId.BackColor = Color.FromArgb(255, 255, 192);
            txId.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txId.Location = new Point(379, 115);
            txId.Name = "txId";
            txId.Size = new Size(117, 48);
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
            cbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearch.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cbSearch.FormattingEnabled = true;
            cbSearch.Items.AddRange(new object[] { "Id", "Nomi", "Soni", "Muddati", "Narxi", "Qo'shilgan Sanasi" });
            cbSearch.Location = new Point(881, 124);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(328, 49);
            cbSearch.TabIndex = 28;
            cbSearch.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btAddPill
            // 
            btAddPill.BackColor = Color.FromArgb(128, 255, 128);
            btAddPill.Font = new Font("Trebuchet MS", 17F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btAddPill.Location = new Point(881, 915);
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
            btUpdatePill.Location = new Point(1139, 915);
            btUpdatePill.Name = "btUpdatePill";
            btUpdatePill.Size = new Size(227, 50);
            btUpdatePill.TabIndex = 33;
            btUpdatePill.Text = "Dori yangilash";
            btUpdatePill.UseVisualStyleBackColor = false;
            btUpdatePill.Click += btUpdatePill_Click_1;
            // 
            // btDeletePill
            // 
            btDeletePill.BackColor = Color.FromArgb(255, 128, 128);
            btDeletePill.Font = new Font("Trebuchet MS", 17F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btDeletePill.Location = new Point(1388, 915);
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
            // cbSort
            // 
            cbSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSort.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cbSort.FormattingEnabled = true;
            cbSort.Items.AddRange(new object[] { "Id", "Nomi", "Soni", "Muddati", "Narxi", "Qo'shilgan sanasi" });
            cbSort.Location = new Point(881, 185);
            cbSort.Name = "cbSort";
            cbSort.Size = new Size(330, 49);
            cbSort.TabIndex = 36;
            // 
            // btOsish
            // 
            btOsish.BackColor = Color.LightSkyBlue;
            btOsish.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btOsish.Location = new Point(1216, 179);
            btOsish.Name = "btOsish";
            btOsish.Size = new Size(127, 55);
            btOsish.TabIndex = 37;
            btOsish.Text = "O'sish";
            btOsish.UseVisualStyleBackColor = false;
            btOsish.Click += button3_Click;
            // 
            // btKamayish
            // 
            btKamayish.BackColor = Color.LightSkyBlue;
            btKamayish.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btKamayish.Location = new Point(1346, 179);
            btKamayish.Name = "btKamayish";
            btKamayish.Size = new Size(129, 55);
            btKamayish.TabIndex = 41;
            btKamayish.Text = "Kamayish";
            btKamayish.UseVisualStyleBackColor = false;
            btKamayish.Click += btKamayish_Click;
            // 
            // btQaytarish
            // 
            btQaytarish.BackColor = Color.LightSkyBlue;
            btQaytarish.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btQaytarish.Location = new Point(1483, 179);
            btQaytarish.Name = "btQaytarish";
            btQaytarish.Size = new Size(138, 55);
            btQaytarish.TabIndex = 43;
            btQaytarish.Text = "Qaytarish";
            btQaytarish.UseVisualStyleBackColor = false;
            btQaytarish.Click += btQaytarish_Click;
            // 
            // sellingPillBindingSource1
            // 
            sellingPillBindingSource1.DataSource = typeof(Actions.SellingPill);
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Id";
            dataGridViewTextBoxColumn5.HeaderText = "Id";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Nomi";
            dataGridViewTextBoxColumn6.HeaderText = "Nomi";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "Soni";
            dataGridViewTextBoxColumn7.HeaderText = "Soni";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "Narxi";
            dataGridViewTextBoxColumn8.HeaderText = "Narxi";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Width = 125;
            // 
            // SalesmanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1720, 1033);
            Controls.Add(btQaytarish);
            Controls.Add(btKamayish);
            Controls.Add(btOsish);
            Controls.Add(cbSort);
            Controls.Add(lkSalesmanReports);
            Controls.Add(btDeletePill);
            Controls.Add(btUpdatePill);
            Controls.Add(btAddPill);
            Controls.Add(panel1);
            Controls.Add(cbSearch);
            Controls.Add(lbPillsList);
            Controls.Add(lnklSettings);
            Controls.Add(txPillInformation);
            Controls.Add(btSearch);
            Controls.Add(lbFIO);
            Controls.Add(btExit);
            Controls.Add(dGWPills);
            Controls.Add(label1);
            Name = "SalesmanForm";
            Text = "SalesmanForm";
            Load += SalesmanForm_Load;
            ((System.ComponentModel.ISupportInitialize)dGWPills).EndInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)sellingPillBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)sellingPillBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btSettings;
        private Button btExit;
        private Button btSellPill;
        private Button btSearch;
        private Label label1;
        private TextBox txPillInformation;
        private DataGridView dGWPills;
        private BindingSource pillBindingSource1;
        private BindingSource pillBindingSource;
        private TextBox txPillCount;
        private Label lbPillCount;
        private Button btAddBox;
        private BindingSource pillBindingSource2;
        private Label lbFIO;
        private LinkLabel lnklSettings;
        private Label lbPillsList;
        private Panel panel1;
        private Button btAddPill;
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
        private Label lbAllPrice;
        private ComboBox cbSort;
        private Button btOsish;
        private Button btKamayish;
        private Button btQaytarish;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nomiDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn soniDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn narxiDataGridViewTextBoxColumn1;
        private BindingSource sellingPillBindingSource;
        private Button button4;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn narxiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn muddatiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn qoshilganSanaDataGridViewTextBoxColumn;
        private BindingSource pillBindingSource4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private BindingSource sellingPillBindingSource1;
    }
}