﻿namespace DorixonaForm.Forms
{
    partial class HelpReportsForm
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
            dGVEmploye = new DataGridView();
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            button1 = new Button();
            label6 = new Label();
            lbFIO = new Label();
            btOsish = new Button();
            btKamayish = new Button();
            btQaytarish = new Button();
            cbSort = new ComboBox();
            label10 = new Label();
            txSalesmanId = new TextBox();
            cbSearch = new ComboBox();
            btSearch = new Button();
            txPillInformation = new TextBox();
            button2 = new Button();
            btBack = new Button();
            allInformationsBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fIODataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            processTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            informationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            processTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dGVEmploye).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)allInformationsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dGVEmploye
            // 
            dGVEmploye.AutoGenerateColumns = false;
            dGVEmploye.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVEmploye.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, fIODataGridViewTextBoxColumn, processTypeDataGridViewTextBoxColumn, informationDataGridViewTextBoxColumn, processTimeDataGridViewTextBoxColumn });
            dGVEmploye.DataSource = allInformationsBindingSource;
            dGVEmploye.Location = new Point(127, 192);
            dGVEmploye.Name = "dGVEmploye";
            dGVEmploye.RowHeadersWidth = 51;
            dGVEmploye.Size = new Size(680, 532);
            dGVEmploye.TabIndex = 150;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCyan;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dateTimePicker2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(980, 252);
            panel2.Name = "panel2";
            panel2.Size = new Size(706, 571);
            panel2.TabIndex = 148;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 255, 192);
            label2.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(343, 312);
            label2.Name = "label2";
            label2.Size = new Size(97, 38);
            label2.TabIndex = 141;
            label2.Text = "          ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 22.2F);
            label3.Location = new Point(229, 305);
            label3.Name = "label3";
            label3.Size = new Size(108, 46);
            label3.TabIndex = 140;
            label3.Text = "Vaqt:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(268, 122);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 139;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 22.2F);
            label1.Location = new Point(157, 107);
            label1.Name = "label1";
            label1.Size = new Size(113, 46);
            label1.TabIndex = 138;
            label1.Text = "Kun1:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(268, 180);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 137;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Font = new Font("Trebuchet MS", 18F);
            button1.Location = new Point(157, 236);
            button1.Name = "button1";
            button1.Size = new Size(361, 47);
            button1.TabIndex = 129;
            button1.Text = "Ma'lumot";
            button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 22.2F);
            label6.Location = new Point(157, 165);
            label6.Name = "label6";
            label6.Size = new Size(113, 46);
            label6.TabIndex = 128;
            label6.Text = "Kun2:";
            // 
            // lbFIO
            // 
            lbFIO.AutoSize = true;
            lbFIO.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbFIO.Location = new Point(276, 48);
            lbFIO.Name = "lbFIO";
            lbFIO.Size = new Size(383, 38);
            lbFIO.TabIndex = 143;
            lbFIO.Text = "Umumiy jarayonlar ro'yxati";
            // 
            // btOsish
            // 
            btOsish.BackColor = Color.LightSkyBlue;
            btOsish.Font = new Font("Trebuchet MS", 18F);
            btOsish.Location = new Point(369, 107);
            btOsish.Name = "btOsish";
            btOsish.Size = new Size(142, 49);
            btOsish.TabIndex = 163;
            btOsish.Text = "O'sish";
            btOsish.UseVisualStyleBackColor = false;
            // 
            // btKamayish
            // 
            btKamayish.BackColor = Color.LightSkyBlue;
            btKamayish.Font = new Font("Trebuchet MS", 18F);
            btKamayish.Location = new Point(517, 107);
            btKamayish.Name = "btKamayish";
            btKamayish.Size = new Size(142, 49);
            btKamayish.TabIndex = 162;
            btKamayish.Text = "Kamayish";
            btKamayish.UseVisualStyleBackColor = false;
            // 
            // btQaytarish
            // 
            btQaytarish.BackColor = Color.LightSkyBlue;
            btQaytarish.Font = new Font("Trebuchet MS", 18F);
            btQaytarish.Location = new Point(664, 107);
            btQaytarish.Name = "btQaytarish";
            btQaytarish.Size = new Size(167, 49);
            btQaytarish.TabIndex = 161;
            btQaytarish.Text = "Qaytarish";
            btQaytarish.UseVisualStyleBackColor = false;
            // 
            // cbSort
            // 
            cbSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSort.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cbSort.FormattingEnabled = true;
            cbSort.Location = new Point(95, 106);
            cbSort.Name = "cbSort";
            cbSort.Size = new Size(269, 49);
            cbSort.TabIndex = 160;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label10.Location = new Point(1080, 192);
            label10.Name = "label10";
            label10.Size = new Size(165, 38);
            label10.TabIndex = 165;
            label10.Text = "Sotuvchi id";
            // 
            // txSalesmanId
            // 
            txSalesmanId.BackColor = Color.FromArgb(255, 255, 192);
            txSalesmanId.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txSalesmanId.Location = new Point(1291, 182);
            txSalesmanId.Name = "txSalesmanId";
            txSalesmanId.Size = new Size(243, 48);
            txSalesmanId.TabIndex = 164;
            // 
            // cbSearch
            // 
            cbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearch.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cbSearch.FormattingEnabled = true;
            cbSearch.Items.AddRange(new object[] { "SotuvchiId", "FIO", "DoriId", "Nomi", "Soni", "SotilganVaqti", "Narxi" });
            cbSearch.Location = new Point(976, 91);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(192, 49);
            cbSearch.TabIndex = 168;
            // 
            // btSearch
            // 
            btSearch.BackColor = Color.LightSkyBlue;
            btSearch.Font = new Font("Trebuchet MS", 18F);
            btSearch.Location = new Point(1443, 95);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(142, 47);
            btSearch.TabIndex = 166;
            btSearch.Text = "Qidirish";
            btSearch.UseVisualStyleBackColor = false;
            // 
            // txPillInformation
            // 
            txPillInformation.BackColor = Color.FromArgb(255, 255, 192);
            txPillInformation.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txPillInformation.Location = new Point(1187, 92);
            txPillInformation.Name = "txPillInformation";
            txPillInformation.Size = new Size(243, 48);
            txPillInformation.TabIndex = 167;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.Font = new Font("Trebuchet MS", 18F);
            button2.Location = new Point(1522, 36);
            button2.Name = "button2";
            button2.Size = new Size(164, 50);
            button2.TabIndex = 169;
            button2.Text = "Chiqish";
            button2.UseVisualStyleBackColor = false;
            // 
            // btBack
            // 
            btBack.BackColor = Color.Silver;
            btBack.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btBack.Location = new Point(1437, 840);
            btBack.Name = "btBack";
            btBack.Size = new Size(249, 53);
            btBack.TabIndex = 170;
            btBack.Text = "Orqaga qaytish";
            btBack.UseVisualStyleBackColor = false;
            // 
            // allInformationsBindingSource
            // 
            allInformationsBindingSource.DataSource = typeof(Actions.AllInformations);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            fIODataGridViewTextBoxColumn.HeaderText = "FIO";
            fIODataGridViewTextBoxColumn.MinimumWidth = 6;
            fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            fIODataGridViewTextBoxColumn.Width = 125;
            // 
            // processTypeDataGridViewTextBoxColumn
            // 
            processTypeDataGridViewTextBoxColumn.DataPropertyName = "ProcessType";
            processTypeDataGridViewTextBoxColumn.HeaderText = "ProcessType";
            processTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            processTypeDataGridViewTextBoxColumn.Name = "processTypeDataGridViewTextBoxColumn";
            processTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // informationDataGridViewTextBoxColumn
            // 
            informationDataGridViewTextBoxColumn.DataPropertyName = "Information";
            informationDataGridViewTextBoxColumn.HeaderText = "Information";
            informationDataGridViewTextBoxColumn.MinimumWidth = 6;
            informationDataGridViewTextBoxColumn.Name = "informationDataGridViewTextBoxColumn";
            informationDataGridViewTextBoxColumn.Width = 125;
            // 
            // processTimeDataGridViewTextBoxColumn
            // 
            processTimeDataGridViewTextBoxColumn.DataPropertyName = "ProcessTime";
            processTimeDataGridViewTextBoxColumn.HeaderText = "ProcessTime";
            processTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            processTimeDataGridViewTextBoxColumn.Name = "processTimeDataGridViewTextBoxColumn";
            processTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // HelpReportsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1747, 930);
            Controls.Add(btBack);
            Controls.Add(button2);
            Controls.Add(cbSearch);
            Controls.Add(btSearch);
            Controls.Add(txPillInformation);
            Controls.Add(label10);
            Controls.Add(txSalesmanId);
            Controls.Add(btOsish);
            Controls.Add(btKamayish);
            Controls.Add(btQaytarish);
            Controls.Add(cbSort);
            Controls.Add(dGVEmploye);
            Controls.Add(panel2);
            Controls.Add(lbFIO);
            Name = "HelpReportsForm";
            Text = "HelpReportsForm";
            Load += HelpReportsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dGVEmploye).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)allInformationsBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dGVEmploye;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private Button button1;
        private Label label6;
        private Label lbFIO;
        private Button btOsish;
        private Button btKamayish;
        private Button btQaytarish;
        private ComboBox cbSort;
        private Label label10;
        private TextBox txSalesmanId;
        private ComboBox cbSearch;
        private Button btSearch;
        private TextBox txPillInformation;
        private Button button2;
        private Button btBack;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn processTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn informationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn processTimeDataGridViewTextBoxColumn;
        private BindingSource allInformationsBindingSource;
    }
}