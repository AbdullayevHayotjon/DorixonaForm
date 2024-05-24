namespace DorixonaForm.Forms
{
    partial class SalesmanReportsForm
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
            cbSearch = new ComboBox();
            btSearch = new Button();
            txPillInformation = new TextBox();
            btBack = new Button();
            button2 = new Button();
            lbPrice = new Label();
            panel2 = new Panel();
            label3 = new Label();
            label4 = new Label();
            label8 = new Label();
            label1 = new Label();
            txId = new TextBox();
            lbCount = new Label();
            dTKun1 = new DateTimePicker();
            dTKun2 = new DateTimePicker();
            button9 = new Button();
            button7 = new Button();
            button3 = new Button();
            cbSort = new ComboBox();
            dGWPills = new DataGridView();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            salesmanReportBindingSource6 = new BindingSource(components);
            salesmanReportBindingSource5 = new BindingSource(components);
            salesmanReportBindingSource4 = new BindingSource(components);
            salesmanReportBindingSource3 = new BindingSource(components);
            salesmanReportBindingSource2 = new BindingSource(components);
            salesmanReportBindingSource1 = new BindingSource(components);
            salesmanReportBindingSource = new BindingSource(components);
            label10 = new Label();
            label2 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGWPills).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salesmanReportBindingSource6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salesmanReportBindingSource5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salesmanReportBindingSource4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salesmanReportBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salesmanReportBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salesmanReportBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salesmanReportBindingSource).BeginInit();
            SuspendLayout();
            // 
            // cbSearch
            // 
            cbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearch.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cbSearch.FormattingEnabled = true;
            cbSearch.Items.AddRange(new object[] { "Id", "Nomi", "Soni", "Sotilgan vaqti", "Narxi" });
            cbSearch.Location = new Point(110, 244);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(248, 49);
            cbSearch.TabIndex = 86;
            // 
            // btSearch
            // 
            btSearch.BackColor = Color.LightSkyBlue;
            btSearch.Font = new Font("Microsoft Sans Serif", 13.8F);
            btSearch.Location = new Point(655, 248);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(134, 44);
            btSearch.TabIndex = 84;
            btSearch.Text = "Qidirish";
            btSearch.UseVisualStyleBackColor = false;
            btSearch.Click += btSearch_Click;
            // 
            // txPillInformation
            // 
            txPillInformation.BackColor = Color.FromArgb(255, 255, 192);
            txPillInformation.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txPillInformation.Location = new Point(364, 244);
            txPillInformation.Name = "txPillInformation";
            txPillInformation.Size = new Size(280, 48);
            txPillInformation.TabIndex = 85;
            // 
            // btBack
            // 
            btBack.BackColor = Color.Silver;
            btBack.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btBack.Location = new Point(1358, 777);
            btBack.Name = "btBack";
            btBack.Size = new Size(192, 44);
            btBack.TabIndex = 118;
            btBack.Text = "Orqaga qaytish";
            btBack.UseVisualStyleBackColor = false;
            btBack.Click += btBack_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSkyBlue;
            button2.Font = new Font("Trebuchet MS", 20F);
            button2.Location = new Point(46, 262);
            button2.Name = "button2";
            button2.Size = new Size(537, 60);
            button2.TabIndex = 129;
            button2.Text = "Ma'lumot";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.BackColor = Color.FromArgb(255, 255, 192);
            lbPrice.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lbPrice.Location = new Point(248, 351);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(97, 38);
            lbPrice.TabIndex = 131;
            lbPrice.Text = "          ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCyan;
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txId);
            panel2.Controls.Add(lbCount);
            panel2.Controls.Add(dTKun1);
            panel2.Controls.Add(dTKun2);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(lbPrice);
            panel2.Location = new Point(906, 254);
            panel2.Name = "panel2";
            panel2.Size = new Size(644, 502);
            panel2.TabIndex = 132;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(46, 412);
            label3.Name = "label3";
            label3.Size = new Size(288, 38);
            label3.TabIndex = 168;
            label3.Text = "Sotgan dorilari soni:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(46, 350);
            label4.Name = "label4";
            label4.Size = new Size(196, 38);
            label4.TabIndex = 169;
            label4.Text = "Ishlagan puli:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(46, 122);
            label8.Name = "label8";
            label8.Size = new Size(259, 38);
            label8.TabIndex = 171;
            label8.Text = "Boshlang'ich sana:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(46, 191);
            label1.Name = "label1";
            label1.Size = new Size(185, 38);
            label1.TabIndex = 170;
            label1.Text = "Tugash sana:";
            // 
            // txId
            // 
            txId.BackColor = Color.FromArgb(255, 255, 192);
            txId.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txId.Location = new Point(333, 46);
            txId.Name = "txId";
            txId.Size = new Size(250, 48);
            txId.TabIndex = 144;
            // 
            // lbCount
            // 
            lbCount.AutoSize = true;
            lbCount.BackColor = Color.FromArgb(255, 255, 192);
            lbCount.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lbCount.Location = new Point(340, 413);
            lbCount.Name = "lbCount";
            lbCount.Size = new Size(97, 38);
            lbCount.TabIndex = 143;
            lbCount.Text = "          ";
            // 
            // dTKun1
            // 
            dTKun1.Font = new Font("Segoe UI", 15F);
            dTKun1.Location = new Point(333, 119);
            dTKun1.Name = "dTKun1";
            dTKun1.Size = new Size(250, 41);
            dTKun1.TabIndex = 139;
            // 
            // dTKun2
            // 
            dTKun2.Font = new Font("Segoe UI", 15F);
            dTKun2.Location = new Point(333, 188);
            dTKun2.Name = "dTKun2";
            dTKun2.Size = new Size(250, 41);
            dTKun2.TabIndex = 137;
            // 
            // button9
            // 
            button9.BackColor = Color.LightSkyBlue;
            button9.Font = new Font("Microsoft Sans Serif", 13.8F);
            button9.Location = new Point(650, 304);
            button9.Name = "button9";
            button9.Size = new Size(139, 44);
            button9.TabIndex = 136;
            button9.Text = "Qaytarish";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.LightSkyBlue;
            button7.Font = new Font("Microsoft Sans Serif", 13.8F);
            button7.Location = new Point(502, 304);
            button7.Name = "button7";
            button7.Size = new Size(142, 44);
            button7.TabIndex = 135;
            button7.Text = "Kamayish";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSkyBlue;
            button3.Font = new Font("Microsoft Sans Serif", 13.8F);
            button3.Location = new Point(364, 304);
            button3.Name = "button3";
            button3.Size = new Size(132, 44);
            button3.TabIndex = 134;
            button3.Text = "O'sish";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // cbSort
            // 
            cbSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSort.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cbSort.FormattingEnabled = true;
            cbSort.Items.AddRange(new object[] { "Id", "Nomi", "Soni", "Sotilgan vaqti", "Narxi" });
            cbSort.Location = new Point(110, 299);
            cbSort.Name = "cbSort";
            cbSort.Size = new Size(248, 49);
            cbSort.TabIndex = 133;
            // 
            // dGWPills
            // 
            dGWPills.AutoGenerateColumns = false;
            dGWPills.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGWPills.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11 });
            dGWPills.DataSource = salesmanReportBindingSource6;
            dGWPills.Location = new Point(110, 354);
            dGWPills.Name = "dGWPills";
            dGWPills.RowHeadersWidth = 51;
            dGWPills.Size = new Size(679, 402);
            dGWPills.TabIndex = 137;
            dGWPills.CellContentClick += dataGridView1_CellContentClick;
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
            dataGridViewTextBoxColumn10.DataPropertyName = "SotilganVaqti";
            dataGridViewTextBoxColumn10.HeaderText = "SotilganVaqti";
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
            // salesmanReportBindingSource6
            // 
            salesmanReportBindingSource6.DataSource = typeof(Actions.SalesmanReport);
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label10.Location = new Point(46, 50);
            label10.Name = "label10";
            label10.Size = new Size(279, 38);
            label10.TabIndex = 166;
            label10.Text = "Dori id sini kiriting:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(292, 192);
            label2.Name = "label2";
            label2.Size = new Size(324, 38);
            label2.TabIndex = 138;
            label2.Text = "Sotgan dorilari ro'yxati";
            // 
            // SalesmanReportsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1666, 1033);
            Controls.Add(label2);
            Controls.Add(dGWPills);
            Controls.Add(button9);
            Controls.Add(button7);
            Controls.Add(button3);
            Controls.Add(cbSort);
            Controls.Add(panel2);
            Controls.Add(btBack);
            Controls.Add(cbSearch);
            Controls.Add(btSearch);
            Controls.Add(txPillInformation);
            Name = "SalesmanReportsForm";
            Text = "SalesmanReportsForm";
            FormClosed += SalesmanReportsForm_FormClosed;
            Load += SalesmanReportsForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dGWPills).EndInit();
            ((System.ComponentModel.ISupportInitialize)salesmanReportBindingSource6).EndInit();
            ((System.ComponentModel.ISupportInitialize)salesmanReportBindingSource5).EndInit();
            ((System.ComponentModel.ISupportInitialize)salesmanReportBindingSource4).EndInit();
            ((System.ComponentModel.ISupportInitialize)salesmanReportBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)salesmanReportBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)salesmanReportBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)salesmanReportBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbSearch;
        private Button btSearch;
        private TextBox txPillInformation;
        private Button btBack;
        private Button button2;
        private Label lbPrice;
        private Panel panel2;
        private Button button9;
        private Button button7;
        private Button button3;
        private ComboBox cbSort;
        private Label lbCount;
        private DateTimePicker dTKun1;
        private DateTimePicker dTKun2;
        private DataGridView dGWPills;
        private TextBox txId;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn processTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn informationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn processTimeDataGridViewTextBoxColumn;
        private BindingSource salesmanReportBindingSource;
        private BindingSource salesmanReportBindingSource1;
        private DataGridViewTextBoxColumn doriIdDataGridViewTextBoxColumn;
        private BindingSource salesmanReportBindingSource2;
        private BindingSource salesmanReportBindingSource3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nomiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sotilganVaqtiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn narxiDataGridViewTextBoxColumn;
        private BindingSource salesmanReportBindingSource4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private BindingSource salesmanReportBindingSource5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private BindingSource salesmanReportBindingSource6;
        private Label label10;
        private Label label3;
        private Label label4;
        private Label label8;
        private Label label1;
        private Label label2;
    }
}