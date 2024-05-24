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
            label3 = new Label();
            label4 = new Label();
            label8 = new Label();
            label1 = new Label();
            lbCount = new Label();
            dtDay1 = new DateTimePicker();
            dtDay2 = new DateTimePicker();
            button1 = new Button();
            lbPrice = new Label();
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
            btOsish.Font = new Font("Trebuchet MS", 14F);
            btOsish.Location = new Point(412, 143);
            btOsish.Name = "btOsish";
            btOsish.Size = new Size(142, 44);
            btOsish.TabIndex = 159;
            btOsish.Text = "O'sish";
            btOsish.UseVisualStyleBackColor = false;
            btOsish.Click += btOsish_Click;
            // 
            // btKamayish
            // 
            btKamayish.BackColor = Color.LightSkyBlue;
            btKamayish.Font = new Font("Trebuchet MS", 14F);
            btKamayish.Location = new Point(560, 143);
            btKamayish.Name = "btKamayish";
            btKamayish.Size = new Size(142, 44);
            btKamayish.TabIndex = 158;
            btKamayish.Text = "Kamayish";
            btKamayish.UseVisualStyleBackColor = false;
            btKamayish.Click += btKamayish_Click;
            // 
            // btQaytarish
            // 
            btQaytarish.BackColor = Color.LightSkyBlue;
            btQaytarish.Font = new Font("Trebuchet MS", 14F);
            btQaytarish.Location = new Point(708, 143);
            btQaytarish.Name = "btQaytarish";
            btQaytarish.Size = new Size(149, 44);
            btQaytarish.TabIndex = 157;
            btQaytarish.Text = "Qaytarish";
            btQaytarish.UseVisualStyleBackColor = false;
            btQaytarish.Click += btQaytarish_Click;
            // 
            // cbSort
            // 
            cbSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSort.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cbSort.FormattingEnabled = true;
            cbSort.Items.AddRange(new object[] { "Sotuvchi Id", "FIO", "Dori Id", "Nomi", "Soni", "Sotilgan vaqti", "Narxi" });
            cbSort.Location = new Point(138, 142);
            cbSort.Name = "cbSort";
            cbSort.Size = new Size(269, 49);
            cbSort.TabIndex = 156;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label10.Location = new Point(37, 75);
            label10.Name = "label10";
            label10.Size = new Size(337, 38);
            label10.TabIndex = 155;
            label10.Text = "Sotuvchi id sini kiriting:";
            label10.Click += label10_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(37, 144);
            label7.Name = "label7";
            label7.Size = new Size(279, 38);
            label7.TabIndex = 154;
            label7.Text = "Dori id sini kiriting:";
            // 
            // txSalesmanId
            // 
            txSalesmanId.BackColor = Color.FromArgb(255, 255, 192);
            txSalesmanId.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txSalesmanId.Location = new Point(389, 71);
            txSalesmanId.Name = "txSalesmanId";
            txSalesmanId.Size = new Size(250, 48);
            txSalesmanId.TabIndex = 153;
            // 
            // txPillId
            // 
            txPillId.BackColor = Color.FromArgb(255, 255, 192);
            txPillId.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txPillId.Location = new Point(389, 140);
            txPillId.Name = "txPillId";
            txPillId.Size = new Size(250, 48);
            txPillId.TabIndex = 152;
            // 
            // dGVEmploye
            // 
            dGVEmploye.AutoGenerateColumns = false;
            dGVEmploye.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVEmploye.Columns.AddRange(new DataGridViewColumn[] { sotuvchiIdDataGridViewTextBoxColumn, dataGridViewTextBoxColumn1, doriIdDataGridViewTextBoxColumn, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dGVEmploye.DataSource = reportSelesPillBindingSource1;
            dGVEmploye.Location = new Point(35, 195);
            dGVEmploye.Name = "dGVEmploye";
            dGVEmploye.RowHeadersWidth = 51;
            dGVEmploye.Size = new Size(930, 637);
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
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lbCount);
            panel2.Controls.Add(dtDay1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txPillId);
            panel2.Controls.Add(dtDay2);
            panel2.Controls.Add(txSalesmanId);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(lbPrice);
            panel2.Location = new Point(992, 195);
            panel2.Name = "panel2";
            panel2.Size = new Size(673, 637);
            panel2.TabIndex = 150;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(37, 510);
            label3.Name = "label3";
            label3.Size = new Size(288, 38);
            label3.TabIndex = 172;
            label3.Text = "Sotgan dorilari soni:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(37, 447);
            label4.Name = "label4";
            label4.Size = new Size(196, 38);
            label4.TabIndex = 173;
            label4.Text = "Ishlagan puli:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(37, 219);
            label8.Name = "label8";
            label8.Size = new Size(259, 38);
            label8.TabIndex = 173;
            label8.Text = "Boshlang'ich sana:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(37, 288);
            label1.Name = "label1";
            label1.Size = new Size(185, 38);
            label1.TabIndex = 172;
            label1.Text = "Tugash sana:";
            // 
            // lbCount
            // 
            lbCount.AutoSize = true;
            lbCount.BackColor = Color.FromArgb(255, 255, 192);
            lbCount.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lbCount.Location = new Point(389, 511);
            lbCount.Name = "lbCount";
            lbCount.Size = new Size(97, 38);
            lbCount.TabIndex = 143;
            lbCount.Text = "          ";
            // 
            // dtDay1
            // 
            dtDay1.Font = new Font("Segoe UI", 15F);
            dtDay1.Location = new Point(389, 216);
            dtDay1.Name = "dtDay1";
            dtDay1.Size = new Size(250, 41);
            dtDay1.TabIndex = 139;
            // 
            // dtDay2
            // 
            dtDay2.Font = new Font("Segoe UI", 15F);
            dtDay2.Location = new Point(389, 286);
            dtDay2.Name = "dtDay2";
            dtDay2.Size = new Size(250, 41);
            dtDay2.TabIndex = 137;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Font = new Font("Trebuchet MS", 20F);
            button1.Location = new Point(37, 364);
            button1.Name = "button1";
            button1.Size = new Size(602, 60);
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
            lbPrice.Location = new Point(389, 447);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(97, 38);
            lbPrice.TabIndex = 131;
            lbPrice.Text = "          ";
            // 
            // cbSearch
            // 
            cbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearch.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cbSearch.FormattingEnabled = true;
            cbSearch.Items.AddRange(new object[] { "SotuvchiId", "FIO", "DoriId", "Nomi", "Soni", "SotilganVaqti", "Narxi" });
            cbSearch.Location = new Point(138, 87);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(269, 49);
            cbSearch.TabIndex = 149;
            // 
            // btSearch
            // 
            btSearch.BackColor = Color.LightSkyBlue;
            btSearch.Font = new Font("Trebuchet MS", 14F);
            btSearch.Location = new Point(708, 90);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(149, 44);
            btSearch.TabIndex = 147;
            btSearch.Text = "Qidirish";
            btSearch.UseVisualStyleBackColor = false;
            btSearch.Click += btSearch_Click_1;
            // 
            // txPillInformation
            // 
            txPillInformation.BackColor = Color.FromArgb(255, 255, 192);
            txPillInformation.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txPillInformation.Location = new Point(413, 89);
            txPillInformation.Name = "txPillInformation";
            txPillInformation.Size = new Size(289, 48);
            txPillInformation.TabIndex = 148;
            // 
            // lbFIO
            // 
            lbFIO.AutoSize = true;
            lbFIO.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbFIO.Location = new Point(335, 36);
            lbFIO.Name = "lbFIO";
            lbFIO.Size = new Size(383, 38);
            lbFIO.TabIndex = 145;
            lbFIO.Text = "Umumiy jarayonlar ro'yxati";
            // 
            // btBack
            // 
            btBack.BackColor = Color.Silver;
            btBack.Font = new Font("Trebuchet MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btBack.Location = new Point(1470, 852);
            btBack.Name = "btBack";
            btBack.Size = new Size(195, 44);
            btBack.TabIndex = 144;
            btBack.Text = "Orqaga qaytish";
            btBack.UseVisualStyleBackColor = false;
            btBack.Click += btBack_Click_1;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1717, 943);
            Controls.Add(btOsish);
            Controls.Add(btKamayish);
            Controls.Add(btQaytarish);
            Controls.Add(cbSort);
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
        private Label lbCount;
        private DateTimePicker dtDay1;
        private DateTimePicker dtDay2;
        private Button button1;
        private Label lbPrice;
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
        private Label label8;
        private Label label1;
        private Label label3;
        private Label label4;
    }
}