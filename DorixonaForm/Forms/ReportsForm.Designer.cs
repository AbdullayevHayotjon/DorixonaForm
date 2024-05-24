namespace DorixonaForm.Forms
{
    partial class ReportsForm
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
            reportSelesPillBindingSource = new BindingSource(components);
            allInformationsBindingSource = new BindingSource(components);
            btOsish = new Button();
            btKamayish = new Button();
            btQaytarish = new Button();
            cbSort = new ComboBox();
            label10 = new Label();
            label7 = new Label();
            txSalesmanId = new TextBox();
            txPillId = new TextBox();
            dGVEmploye = new DataGridView();
            sotuvchiIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            doriIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            reportSelesPillBindingSource1 = new BindingSource(components);
            panel2 = new Panel();
            btBack1 = new Button();
            lbCount = new Label();
            label5 = new Label();
            dtDay1 = new DateTimePicker();
            label1 = new Label();
            dtDay2 = new DateTimePicker();
            button1 = new Button();
            lbPrice = new Label();
            label9 = new Label();
            label6 = new Label();
            cbSearch = new ComboBox();
            btSearch = new Button();
            txPillInformation = new TextBox();
            lbFIO = new Label();
            btBack = new Button();
            ((System.ComponentModel.ISupportInitialize)reportSelesPillBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)allInformationsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dGVEmploye).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reportSelesPillBindingSource1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btOsish
            // 
            btOsish.BackColor = Color.LightSkyBlue;
            btOsish.Font = new Font("Trebuchet MS", 18F);
            btOsish.Location = new Point(402, 166);
            btOsish.Name = "btOsish";
            btOsish.Size = new Size(160, 49);
            btOsish.TabIndex = 159;
            btOsish.Text = "O'sish";
            btOsish.UseVisualStyleBackColor = false;
            btOsish.Click += btOsish_Click;
            // 
            // btKamayish
            // 
            btKamayish.BackColor = Color.LightSkyBlue;
            btKamayish.Font = new Font("Trebuchet MS", 18F);
            btKamayish.Location = new Point(568, 166);
            btKamayish.Name = "btKamayish";
            btKamayish.Size = new Size(160, 49);
            btKamayish.TabIndex = 158;
            btKamayish.Text = "Kamayish";
            btKamayish.UseVisualStyleBackColor = false;
            btKamayish.Click += btKamayish_Click;
            // 
            // btQaytarish
            // 
            btQaytarish.BackColor = Color.LightSkyBlue;
            btQaytarish.Font = new Font("Trebuchet MS", 18F);
            btQaytarish.Location = new Point(734, 166);
            btQaytarish.Name = "btQaytarish";
            btQaytarish.Size = new Size(188, 49);
            btQaytarish.TabIndex = 157;
            btQaytarish.Text = "Qaytarish";
            btQaytarish.UseVisualStyleBackColor = false;
            btQaytarish.Click += btQaytarish_Click;
            // 
            // cbSort
            // 
            cbSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSort.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cbSort.FormattingEnabled = true;
            cbSort.Items.AddRange(new object[] { "Sotuvchi Id", "FIO", "Dori Id", "Nomi", "Soni", "Sotilgan vaqti", "Narxi" });
            cbSort.Location = new Point(93, 165);
            cbSort.Name = "cbSort";
            cbSort.Size = new Size(302, 49);
            cbSort.TabIndex = 156;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label10.Location = new Point(1238, 206);
            label10.Name = "label10";
            label10.Size = new Size(165, 38);
            label10.TabIndex = 155;
            label10.Text = "Sotuvchi id";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(1238, 270);
            label7.Name = "label7";
            label7.Size = new Size(107, 38);
            label7.TabIndex = 154;
            label7.Text = "Dori id";
            // 
            // txSalesmanId
            // 
            txSalesmanId.BackColor = Color.FromArgb(255, 255, 192);
            txSalesmanId.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txSalesmanId.Location = new Point(1475, 196);
            txSalesmanId.Name = "txSalesmanId";
            txSalesmanId.Size = new Size(273, 48);
            txSalesmanId.TabIndex = 153;
            // 
            // txPillId
            // 
            txPillId.BackColor = Color.FromArgb(255, 255, 192);
            txPillId.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txPillId.Location = new Point(1475, 260);
            txPillId.Name = "txPillId";
            txPillId.Size = new Size(273, 48);
            txPillId.TabIndex = 152;
            // 
            // dGVEmploye
            // 
            dGVEmploye.AutoGenerateColumns = false;
            dGVEmploye.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVEmploye.Columns.AddRange(new DataGridViewColumn[] { sotuvchiIdDataGridViewTextBoxColumn, dataGridViewTextBoxColumn1, doriIdDataGridViewTextBoxColumn, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dGVEmploye.DataSource = reportSelesPillBindingSource1;
            dGVEmploye.Location = new Point(48, 248);
            dGVEmploye.Name = "dGVEmploye";
            dGVEmploye.RowHeadersWidth = 51;
            dGVEmploye.Size = new Size(1046, 532);
            dGVEmploye.TabIndex = 151;
            // 
            // sotuvchiIdDataGridViewTextBoxColumn
            // 
            sotuvchiIdDataGridViewTextBoxColumn.DataPropertyName = "SotuvchiId";
            sotuvchiIdDataGridViewTextBoxColumn.HeaderText = "SotuvchiId";
            sotuvchiIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            sotuvchiIdDataGridViewTextBoxColumn.Name = "sotuvchiIdDataGridViewTextBoxColumn";
            sotuvchiIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "FIO";
            dataGridViewTextBoxColumn1.HeaderText = "FIO";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // doriIdDataGridViewTextBoxColumn
            // 
            doriIdDataGridViewTextBoxColumn.DataPropertyName = "DoriId";
            doriIdDataGridViewTextBoxColumn.HeaderText = "DoriId";
            doriIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            doriIdDataGridViewTextBoxColumn.Name = "doriIdDataGridViewTextBoxColumn";
            doriIdDataGridViewTextBoxColumn.Width = 125;
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
            dataGridViewTextBoxColumn4.DataPropertyName = "SotilganVaqti";
            dataGridViewTextBoxColumn4.HeaderText = "SotilganVaqti";
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
            // reportSelesPillBindingSource1
            // 
            reportSelesPillBindingSource1.DataSource = typeof(Actions.ReportSelesPill);
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCyan;
            panel2.Controls.Add(btBack1);
            panel2.Controls.Add(lbCount);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(dtDay1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dtDay2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(lbPrice);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(1153, 314);
            panel2.Name = "panel2";
            panel2.Size = new Size(794, 571);
            panel2.TabIndex = 150;
            // 
            // btBack1
            // 
            btBack1.BackColor = Color.LightSkyBlue;
            btBack1.Font = new Font("Trebuchet MS", 18F);
            btBack1.Location = new Point(565, 493);
            btBack1.Name = "btBack1";
            btBack1.Size = new Size(197, 47);
            btBack1.TabIndex = 147;
            btBack1.Text = "Qaytarish";
            btBack1.UseVisualStyleBackColor = false;
            btBack1.Click += btBack1_Click;
            // 
            // lbCount
            // 
            lbCount.AutoSize = true;
            lbCount.BackColor = Color.FromArgb(255, 255, 192);
            lbCount.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lbCount.Location = new Point(486, 371);
            lbCount.Name = "lbCount";
            lbCount.Size = new Size(97, 38);
            lbCount.TabIndex = 143;
            lbCount.Text = "          ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 22.2F);
            label5.Location = new Point(177, 363);
            label5.Name = "label5";
            label5.Size = new Size(103, 46);
            label5.TabIndex = 142;
            label5.Text = "Soni:";
            // 
            // dtDay1
            // 
            dtDay1.Location = new Point(302, 122);
            dtDay1.Name = "dtDay1";
            dtDay1.Size = new Size(281, 27);
            dtDay1.TabIndex = 139;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 22.2F);
            label1.Location = new Point(177, 107);
            label1.Name = "label1";
            label1.Size = new Size(113, 46);
            label1.TabIndex = 138;
            label1.Text = "Kun1:";
            // 
            // dtDay2
            // 
            dtDay2.Location = new Point(302, 180);
            dtDay2.Name = "dtDay2";
            dtDay2.Size = new Size(281, 27);
            dtDay2.TabIndex = 137;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Font = new Font("Trebuchet MS", 18F);
            button1.Location = new Point(177, 236);
            button1.Name = "button1";
            button1.Size = new Size(406, 47);
            button1.TabIndex = 129;
            button1.Text = "Ma'lumot";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.BackColor = Color.FromArgb(255, 255, 192);
            lbPrice.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lbPrice.Location = new Point(486, 308);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(97, 38);
            lbPrice.TabIndex = 131;
            lbPrice.Text = "          ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Trebuchet MS", 22.2F);
            label9.Location = new Point(177, 300);
            label9.Name = "label9";
            label9.Size = new Size(156, 46);
            label9.TabIndex = 130;
            label9.Text = "Tushum:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 22.2F);
            label6.Location = new Point(177, 165);
            label6.Name = "label6";
            label6.Size = new Size(113, 46);
            label6.TabIndex = 128;
            label6.Text = "Kun2:";
            // 
            // cbSearch
            // 
            cbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearch.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cbSearch.FormattingEnabled = true;
            cbSearch.Items.AddRange(new object[] { "SotuvchiId", "FIO", "DoriId", "Nomi", "Soni", "SotilganVaqti", "Narxi" });
            cbSearch.Location = new Point(1130, 139);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(216, 49);
            cbSearch.TabIndex = 149;
            // 
            // btSearch
            // 
            btSearch.BackColor = Color.LightSkyBlue;
            btSearch.Font = new Font("Trebuchet MS", 18F);
            btSearch.Location = new Point(1655, 143);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(160, 47);
            btSearch.TabIndex = 147;
            btSearch.Text = "Qidirish";
            btSearch.UseVisualStyleBackColor = false;
            btSearch.Click += btSearch_Click_1;
            // 
            // txPillInformation
            // 
            txPillInformation.BackColor = Color.FromArgb(255, 255, 192);
            txPillInformation.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txPillInformation.Location = new Point(1367, 140);
            txPillInformation.Name = "txPillInformation";
            txPillInformation.Size = new Size(273, 48);
            txPillInformation.TabIndex = 148;
            // 
            // lbFIO
            // 
            lbFIO.AutoSize = true;
            lbFIO.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbFIO.Location = new Point(819, 80);
            lbFIO.Name = "lbFIO";
            lbFIO.Size = new Size(383, 38);
            lbFIO.TabIndex = 145;
            lbFIO.Text = "Umumiy jarayonlar ro'yxati";
            // 
            // btBack
            // 
            btBack.BackColor = Color.Silver;
            btBack.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btBack.Location = new Point(1667, 912);
            btBack.Name = "btBack";
            btBack.Size = new Size(280, 53);
            btBack.TabIndex = 144;
            btBack.Text = "Orqaga qaytish";
            btBack.UseVisualStyleBackColor = false;
            btBack.Click += btBack_Click_1;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1924, 1033);
            Controls.Add(btOsish);
            Controls.Add(btKamayish);
            Controls.Add(btQaytarish);
            Controls.Add(cbSort);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(txSalesmanId);
            Controls.Add(txPillId);
            Controls.Add(dGVEmploye);
            Controls.Add(panel2);
            Controls.Add(cbSearch);
            Controls.Add(btSearch);
            Controls.Add(txPillInformation);
            Controls.Add(lbFIO);
            Controls.Add(btBack);
            Name = "ReportsForm";
            Text = "ReportsForm";
            FormClosing += ReportsForm_FormClosing;
            Load += ReportsForm_Load;
            ((System.ComponentModel.ISupportInitialize)reportSelesPillBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)allInformationsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dGVEmploye).EndInit();
            ((System.ComponentModel.ISupportInitialize)reportSelesPillBindingSource1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource allInformationsBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sotilganVaqtiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn narxiDataGridViewTextBoxColumn;
        private BindingSource reportSelesPillBindingSource;
        private Button btOsish;
        private Button btKamayish;
        private Button btQaytarish;
        private ComboBox cbSort;
        private Label label10;
        private Label label7;
        private TextBox txSalesmanId;
        private TextBox txPillId;
        private DataGridView dGVEmploye;
        private Panel panel2;
        private Button btBack1;
        private Label lbCount;
        private Label label5;
        private DateTimePicker dtDay1;
        private Label label1;
        private DateTimePicker dtDay2;
        private Button button1;
        private Label lbPrice;
        private Label label9;
        private Label label6;
        private ComboBox cbSearch;
        private Button btSearch;
        private TextBox txPillInformation;
        private Label lbFIO;
        private Button btBack;
        private DataGridViewTextBoxColumn sotuvchiIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn doriIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private BindingSource reportSelesPillBindingSource1;
    }
}