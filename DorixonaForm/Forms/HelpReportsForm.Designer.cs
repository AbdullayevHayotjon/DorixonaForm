namespace DorixonaForm.Forms
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
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fIODataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            processTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            informationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            processTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            allInformationsBindingSource = new BindingSource(components);
            panel2 = new Panel();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label2 = new Label();
            lbMinut = new Label();
            txSalesmanId = new TextBox();
            label10 = new Label();
            lbHour = new Label();
            dtDay1 = new DateTimePicker();
            dtDay2 = new DateTimePicker();
            button1 = new Button();
            btOsish = new Button();
            btKamayish = new Button();
            btQaytarish = new Button();
            cbSort = new ComboBox();
            cbSearch = new ComboBox();
            btSearch = new Button();
            txPillInformation = new TextBox();
            btBack = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dGVEmploye).BeginInit();
            ((System.ComponentModel.ISupportInitialize)allInformationsBindingSource).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dGVEmploye
            // 
            dGVEmploye.AutoGenerateColumns = false;
            dGVEmploye.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVEmploye.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, fIODataGridViewTextBoxColumn, processTypeDataGridViewTextBoxColumn, informationDataGridViewTextBoxColumn, processTimeDataGridViewTextBoxColumn });
            dGVEmploye.DataSource = allInformationsBindingSource;
            dGVEmploye.Location = new Point(105, 273);
            dGVEmploye.Name = "dGVEmploye";
            dGVEmploye.RowHeadersWidth = 51;
            dGVEmploye.Size = new Size(697, 532);
            dGVEmploye.TabIndex = 150;
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
            // allInformationsBindingSource
            // 
            allInformationsBindingSource.DataSource = typeof(Actions.AllInformations);
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCyan;
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lbMinut);
            panel2.Controls.Add(txSalesmanId);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(lbHour);
            panel2.Controls.Add(dtDay1);
            panel2.Controls.Add(dtDay2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(917, 204);
            panel2.Name = "panel2";
            panel2.Size = new Size(706, 490);
            panel2.TabIndex = 148;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label9.Location = new Point(54, 392);
            label9.Name = "label9";
            label9.Size = new Size(232, 38);
            label9.TabIndex = 169;
            label9.Text = "Ishlagan minuti:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(54, 124);
            label8.Name = "label8";
            label8.Size = new Size(248, 38);
            label8.TabIndex = 168;
            label8.Text = "Boshlang'ich sana";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(54, 335);
            label7.Name = "label7";
            label7.Size = new Size(210, 38);
            label7.TabIndex = 167;
            label7.Text = "Ishlagan soati:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(54, 184);
            label2.Name = "label2";
            label2.Size = new Size(174, 38);
            label2.TabIndex = 166;
            label2.Text = "Tugash sana";
            // 
            // lbMinut
            // 
            lbMinut.AutoSize = true;
            lbMinut.BackColor = Color.FromArgb(255, 255, 192);
            lbMinut.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lbMinut.Location = new Point(292, 393);
            lbMinut.Name = "lbMinut";
            lbMinut.Size = new Size(97, 38);
            lbMinut.TabIndex = 143;
            lbMinut.Text = "          ";
            // 
            // txSalesmanId
            // 
            txSalesmanId.BackColor = Color.FromArgb(255, 255, 192);
            txSalesmanId.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txSalesmanId.Location = new Point(397, 53);
            txSalesmanId.Name = "txSalesmanId";
            txSalesmanId.Size = new Size(250, 48);
            txSalesmanId.TabIndex = 164;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label10.Location = new Point(54, 57);
            label10.Name = "label10";
            label10.Size = new Size(337, 38);
            label10.TabIndex = 165;
            label10.Text = "Sotuvchi id sini kiriting:";
            // 
            // lbHour
            // 
            lbHour.AutoSize = true;
            lbHour.BackColor = Color.FromArgb(255, 255, 192);
            lbHour.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lbHour.Location = new Point(270, 336);
            lbHour.Name = "lbHour";
            lbHour.Size = new Size(97, 38);
            lbHour.TabIndex = 141;
            lbHour.Text = "          ";
            // 
            // dtDay1
            // 
            dtDay1.Font = new Font("Segoe UI", 15F);
            dtDay1.Location = new Point(397, 121);
            dtDay1.Name = "dtDay1";
            dtDay1.Size = new Size(250, 41);
            dtDay1.TabIndex = 139;
            // 
            // dtDay2
            // 
            dtDay2.Font = new Font("Segoe UI", 15F);
            dtDay2.Location = new Point(397, 181);
            dtDay2.Name = "dtDay2";
            dtDay2.Size = new Size(250, 41);
            dtDay2.TabIndex = 137;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Font = new Font("Trebuchet MS", 20F);
            button1.Location = new Point(54, 250);
            button1.Name = "button1";
            button1.Size = new Size(593, 60);
            button1.TabIndex = 129;
            button1.Text = "Ma'lumot";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btOsish
            // 
            btOsish.BackColor = Color.LightSkyBlue;
            btOsish.Font = new Font("Trebuchet MS", 14F);
            btOsish.Location = new Point(398, 223);
            btOsish.Name = "btOsish";
            btOsish.Size = new Size(104, 44);
            btOsish.TabIndex = 163;
            btOsish.Text = "O'sish";
            btOsish.UseVisualStyleBackColor = false;
            btOsish.Click += btOsish_Click;
            // 
            // btKamayish
            // 
            btKamayish.BackColor = Color.LightSkyBlue;
            btKamayish.Font = new Font("Trebuchet MS", 14F);
            btKamayish.Location = new Point(508, 223);
            btKamayish.Name = "btKamayish";
            btKamayish.Size = new Size(142, 44);
            btKamayish.TabIndex = 162;
            btKamayish.Text = "Kamayish";
            btKamayish.UseVisualStyleBackColor = false;
            btKamayish.Click += btKamayish_Click;
            // 
            // btQaytarish
            // 
            btQaytarish.BackColor = Color.LightSkyBlue;
            btQaytarish.Font = new Font("Trebuchet MS", 14F);
            btQaytarish.Location = new Point(656, 223);
            btQaytarish.Name = "btQaytarish";
            btQaytarish.Size = new Size(146, 44);
            btQaytarish.TabIndex = 161;
            btQaytarish.Text = "Qaytarish";
            btQaytarish.UseVisualStyleBackColor = false;
            btQaytarish.Click += btQaytarish_Click;
            // 
            // cbSort
            // 
            cbSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSort.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cbSort.FormattingEnabled = true;
            cbSort.Items.AddRange(new object[] { "Id", "FIO", "Process type", "Information", "Process time" });
            cbSort.Location = new Point(105, 217);
            cbSort.Name = "cbSort";
            cbSort.Size = new Size(287, 49);
            cbSort.TabIndex = 160;
            // 
            // cbSearch
            // 
            cbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearch.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cbSearch.FormattingEnabled = true;
            cbSearch.Items.AddRange(new object[] { "Id", "FIO", "ProcessType", "Information", "ProcessTime" });
            cbSearch.Location = new Point(105, 162);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(287, 49);
            cbSearch.TabIndex = 168;
            // 
            // btSearch
            // 
            btSearch.BackColor = Color.LightSkyBlue;
            btSearch.Font = new Font("Trebuchet MS", 14F);
            btSearch.Location = new Point(656, 173);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(146, 44);
            btSearch.TabIndex = 166;
            btSearch.Text = "Qidirish";
            btSearch.UseVisualStyleBackColor = false;
            btSearch.Click += btSearch_Click;
            // 
            // txPillInformation
            // 
            txPillInformation.BackColor = Color.FromArgb(255, 255, 192);
            txPillInformation.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txPillInformation.Location = new Point(398, 169);
            txPillInformation.Name = "txPillInformation";
            txPillInformation.Size = new Size(252, 48);
            txPillInformation.TabIndex = 167;
            // 
            // btBack
            // 
            btBack.BackColor = Color.Silver;
            btBack.Font = new Font("Trebuchet MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btBack.Location = new Point(1419, 718);
            btBack.Name = "btBack";
            btBack.Size = new Size(204, 44);
            btBack.TabIndex = 170;
            btBack.Text = "Orqaga qaytish";
            btBack.UseVisualStyleBackColor = false;
            btBack.Click += btBack_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 24F);
            label5.Location = new Point(221, 101);
            label5.Name = "label5";
            label5.Size = new Size(507, 49);
            label5.TabIndex = 171;
            label5.Text = "Umumiy jarayonlar ro'yxati";
            // 
            // HelpReportsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1717, 943);
            Controls.Add(label5);
            Controls.Add(btBack);
            Controls.Add(cbSearch);
            Controls.Add(btSearch);
            Controls.Add(txPillInformation);
            Controls.Add(btOsish);
            Controls.Add(btKamayish);
            Controls.Add(btQaytarish);
            Controls.Add(cbSort);
            Controls.Add(dGVEmploye);
            Controls.Add(panel2);
            Name = "HelpReportsForm";
            Text = "HelpReportsForm";
            FormClosed += HelpReportsForm_FormClosed;
            Load += HelpReportsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dGVEmploye).EndInit();
            ((System.ComponentModel.ISupportInitialize)allInformationsBindingSource).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dGVEmploye;
        private Panel panel2;
        private Label lbHour;
        private DateTimePicker dtDay1;
        private DateTimePicker dtDay2;
        private Button button1;
        private Button btOsish;
        private Button btKamayish;
        private Button btQaytarish;
        private ComboBox cbSort;
        private Label label10;
        private TextBox txSalesmanId;
        private ComboBox cbSearch;
        private Button btSearch;
        private TextBox txPillInformation;
        private Button btBack;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn processTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn informationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn processTimeDataGridViewTextBoxColumn;
        private BindingSource allInformationsBindingSource;
        private Label lbMinut;
        private Label label5;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label2;
    }
}