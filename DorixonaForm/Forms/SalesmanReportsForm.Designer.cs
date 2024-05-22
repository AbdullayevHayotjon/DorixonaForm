﻿namespace DorixonaForm.Forms
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
            btExit = new Button();
            btBack = new Button();
            label6 = new Label();
            button2 = new Button();
            lbPrice = new Label();
            label9 = new Label();
            panel2 = new Panel();
            label7 = new Label();
            txId = new TextBox();
            lbCount = new Label();
            label5 = new Label();
            dTKun1 = new DateTimePicker();
            label1 = new Label();
            dTKun2 = new DateTimePicker();
            button9 = new Button();
            button7 = new Button();
            button3 = new Button();
            cbSort = new ComboBox();
            dGWPills = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            salesmanReportBindingSource5 = new BindingSource(components);
            salesmanReportBindingSource4 = new BindingSource(components);
            salesmanReportBindingSource3 = new BindingSource(components);
            salesmanReportBindingSource2 = new BindingSource(components);
            salesmanReportBindingSource1 = new BindingSource(components);
            salesmanReportBindingSource = new BindingSource(components);
            btBack1 = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGWPills).BeginInit();
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
            cbSearch.Items.AddRange(new object[] { "Nomi", "Id", "Soni", "Sotilgan vaqti", "Narxi" });
            cbSearch.Location = new Point(858, 167);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(248, 49);
            cbSearch.TabIndex = 86;
            // 
            // btSearch
            // 
            btSearch.BackColor = Color.LightSkyBlue;
            btSearch.Font = new Font("Trebuchet MS", 18F);
            btSearch.Location = new Point(1431, 167);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(142, 49);
            btSearch.TabIndex = 84;
            btSearch.Text = "Qidirish";
            btSearch.UseVisualStyleBackColor = false;
            btSearch.Click += btSearch_Click;
            // 
            // txPillInformation
            // 
            txPillInformation.BackColor = Color.FromArgb(255, 255, 192);
            txPillInformation.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txPillInformation.Location = new Point(1118, 167);
            txPillInformation.Name = "txPillInformation";
            txPillInformation.Size = new Size(298, 48);
            txPillInformation.TabIndex = 85;
            // 
            // btExit
            // 
            btExit.BackColor = Color.Silver;
            btExit.Font = new Font("Trebuchet MS", 14F);
            btExit.Location = new Point(1523, 52);
            btExit.Name = "btExit";
            btExit.Size = new Size(124, 44);
            btExit.TabIndex = 88;
            btExit.Text = "Chiqish";
            btExit.UseVisualStyleBackColor = false;
            btExit.Click += btExit_Click;
            // 
            // btBack
            // 
            btBack.BackColor = Color.Silver;
            btBack.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btBack.Location = new Point(1358, 926);
            btBack.Name = "btBack";
            btBack.Size = new Size(249, 53);
            btBack.TabIndex = 118;
            btBack.Text = "Orqaga qaytish";
            btBack.UseVisualStyleBackColor = false;
            btBack.Click += btBack_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 22.2F);
            label6.Location = new Point(207, 163);
            label6.Name = "label6";
            label6.Size = new Size(113, 46);
            label6.TabIndex = 128;
            label6.Text = "Kun2:";
            // 
            // button2
            // 
            button2.BackColor = Color.LightSkyBlue;
            button2.Font = new Font("Trebuchet MS", 18F);
            button2.Location = new Point(207, 234);
            button2.Name = "button2";
            button2.Size = new Size(361, 47);
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
            lbPrice.Location = new Point(374, 314);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(97, 38);
            lbPrice.TabIndex = 131;
            lbPrice.Text = "          ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Trebuchet MS", 22.2F);
            label9.Location = new Point(207, 306);
            label9.Name = "label9";
            label9.Size = new Size(156, 46);
            label9.TabIndex = 130;
            label9.Text = "Tushum:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCyan;
            panel2.Controls.Add(btBack1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txId);
            panel2.Controls.Add(lbCount);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(dTKun1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dTKun2);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(lbPrice);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(81, 167);
            panel2.Name = "panel2";
            panel2.Size = new Size(729, 565);
            panel2.TabIndex = 132;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Trebuchet MS", 22.2F);
            label7.Location = new Point(259, 38);
            label7.Name = "label7";
            label7.Size = new Size(51, 46);
            label7.TabIndex = 145;
            label7.Text = "Id";
            // 
            // txId
            // 
            txId.BackColor = Color.FromArgb(255, 255, 192);
            txId.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txId.Location = new Point(316, 36);
            txId.Name = "txId";
            txId.Size = new Size(167, 48);
            txId.TabIndex = 144;
            // 
            // lbCount
            // 
            lbCount.AutoSize = true;
            lbCount.BackColor = Color.FromArgb(255, 255, 192);
            lbCount.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lbCount.Location = new Point(374, 370);
            lbCount.Name = "lbCount";
            lbCount.Size = new Size(97, 38);
            lbCount.TabIndex = 143;
            lbCount.Text = "          ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 22.2F);
            label5.Location = new Point(207, 370);
            label5.Name = "label5";
            label5.Size = new Size(103, 46);
            label5.TabIndex = 142;
            label5.Text = "Soni:";
            // 
            // dTKun1
            // 
            dTKun1.Location = new Point(318, 120);
            dTKun1.Name = "dTKun1";
            dTKun1.Size = new Size(250, 27);
            dTKun1.TabIndex = 139;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 22.2F);
            label1.Location = new Point(207, 105);
            label1.Name = "label1";
            label1.Size = new Size(113, 46);
            label1.TabIndex = 138;
            label1.Text = "Kun1:";
            // 
            // dTKun2
            // 
            dTKun2.Location = new Point(318, 178);
            dTKun2.Name = "dTKun2";
            dTKun2.Size = new Size(250, 27);
            dTKun2.TabIndex = 137;
            // 
            // button9
            // 
            button9.BackColor = Color.LightSkyBlue;
            button9.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button9.Location = new Point(1431, 222);
            button9.Name = "button9";
            button9.Size = new Size(142, 49);
            button9.TabIndex = 136;
            button9.Text = "Qaytarish";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.LightSkyBlue;
            button7.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button7.Location = new Point(1275, 222);
            button7.Name = "button7";
            button7.Size = new Size(142, 49);
            button7.TabIndex = 135;
            button7.Text = "Kamayish";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSkyBlue;
            button3.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.Location = new Point(1118, 222);
            button3.Name = "button3";
            button3.Size = new Size(142, 49);
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
            cbSort.Items.AddRange(new object[] { "O'sish", "Kamayish" });
            cbSort.Location = new Point(858, 222);
            cbSort.Name = "cbSort";
            cbSort.Size = new Size(248, 49);
            cbSort.TabIndex = 133;
            // 
            // dGWPills
            // 
            dGWPills.AutoGenerateColumns = false;
            dGWPills.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGWPills.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dGWPills.DataSource = salesmanReportBindingSource5;
            dGWPills.Location = new Point(858, 287);
            dGWPills.Name = "dGWPills";
            dGWPills.RowHeadersWidth = 51;
            dGWPills.Size = new Size(679, 402);
            dGWPills.TabIndex = 137;
            dGWPills.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Id";
            dataGridViewTextBoxColumn2.HeaderText = "Id";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Nomi";
            dataGridViewTextBoxColumn3.HeaderText = "Nomi";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Soni";
            dataGridViewTextBoxColumn4.HeaderText = "Soni";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "SotilganVaqti";
            dataGridViewTextBoxColumn5.HeaderText = "SotilganVaqti";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Narxi";
            dataGridViewTextBoxColumn6.HeaderText = "Narxi";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 125;
            // 
            // salesmanReportBindingSource5
            // 
            salesmanReportBindingSource5.DataSource = typeof(Actions.SalesmanReport);
            // 
            // btBack1
            // 
            btBack1.BackColor = Color.LightSkyBlue;
            btBack1.Font = new Font("Trebuchet MS", 18F);
            btBack1.Location = new Point(523, 475);
            btBack1.Name = "btBack1";
            btBack1.Size = new Size(175, 47);
            btBack1.TabIndex = 146;
            btBack1.Text = "Qaytarish";
            btBack1.UseVisualStyleBackColor = false;
            btBack1.Click += btBack1_Click;
            // 
            // SalesmanReportsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1666, 1033);
            Controls.Add(dGWPills);
            Controls.Add(button9);
            Controls.Add(button7);
            Controls.Add(button3);
            Controls.Add(cbSort);
            Controls.Add(panel2);
            Controls.Add(btBack);
            Controls.Add(btExit);
            Controls.Add(cbSearch);
            Controls.Add(btSearch);
            Controls.Add(txPillInformation);
            Name = "SalesmanReportsForm";
            Text = "SalesmanReportsForm";
            Load += SalesmanReportsForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dGWPills).EndInit();
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
        private Button btExit;
        private Button btBack;
        private Label label6;
        private Button button2;
        private Label lbPrice;
        private Label label9;
        private Panel panel2;
        private Button button9;
        private Button button7;
        private Button button3;
        private ComboBox cbSort;
        private Label lbCount;
        private Label label5;
        private DateTimePicker dTKun1;
        private Label label1;
        private DateTimePicker dTKun2;
        private DataGridView dGWPills;
        private Label label7;
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
        private Button btBack1;
    }
}