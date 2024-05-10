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
            dGVInformations = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fIODataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soniDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sotilganVaqtiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            narxiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            reportSelesPillBindingSource = new BindingSource(components);
            allInformationsBindingSource = new BindingSource(components);
            btBack = new Button();
            lbFIO = new Label();
            label1 = new Label();
            label2 = new Label();
            lbAllPillCount = new Label();
            lbAllPillPrice = new Label();
            lbLogin = new Label();
            txLogin = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btResult1 = new Button();
            lbStartDate = new Label();
            txStartDate = new TextBox();
            lbFinishDate = new Label();
            txFinishDate = new TextBox();
            btResult2 = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dGVInformations).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reportSelesPillBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)allInformationsBindingSource).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dGVInformations
            // 
            dGVInformations.AutoGenerateColumns = false;
            dGVInformations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVInformations.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, fIODataGridViewTextBoxColumn, nomiDataGridViewTextBoxColumn, soniDataGridViewTextBoxColumn, sotilganVaqtiDataGridViewTextBoxColumn, narxiDataGridViewTextBoxColumn });
            dGVInformations.DataSource = reportSelesPillBindingSource;
            dGVInformations.Location = new Point(104, 115);
            dGVInformations.Name = "dGVInformations";
            dGVInformations.RowHeadersWidth = 100;
            dGVInformations.Size = new Size(853, 733);
            dGVInformations.TabIndex = 0;
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
            // nomiDataGridViewTextBoxColumn
            // 
            nomiDataGridViewTextBoxColumn.DataPropertyName = "Nomi";
            nomiDataGridViewTextBoxColumn.HeaderText = "Nomi";
            nomiDataGridViewTextBoxColumn.MinimumWidth = 6;
            nomiDataGridViewTextBoxColumn.Name = "nomiDataGridViewTextBoxColumn";
            nomiDataGridViewTextBoxColumn.Width = 125;
            // 
            // soniDataGridViewTextBoxColumn
            // 
            soniDataGridViewTextBoxColumn.DataPropertyName = "Soni";
            soniDataGridViewTextBoxColumn.HeaderText = "Soni";
            soniDataGridViewTextBoxColumn.MinimumWidth = 6;
            soniDataGridViewTextBoxColumn.Name = "soniDataGridViewTextBoxColumn";
            soniDataGridViewTextBoxColumn.Width = 125;
            // 
            // sotilganVaqtiDataGridViewTextBoxColumn
            // 
            sotilganVaqtiDataGridViewTextBoxColumn.DataPropertyName = "SotilganVaqti";
            sotilganVaqtiDataGridViewTextBoxColumn.HeaderText = "SotilganVaqti";
            sotilganVaqtiDataGridViewTextBoxColumn.MinimumWidth = 6;
            sotilganVaqtiDataGridViewTextBoxColumn.Name = "sotilganVaqtiDataGridViewTextBoxColumn";
            sotilganVaqtiDataGridViewTextBoxColumn.Width = 125;
            // 
            // narxiDataGridViewTextBoxColumn
            // 
            narxiDataGridViewTextBoxColumn.DataPropertyName = "Narxi";
            narxiDataGridViewTextBoxColumn.HeaderText = "Narxi";
            narxiDataGridViewTextBoxColumn.MinimumWidth = 6;
            narxiDataGridViewTextBoxColumn.Name = "narxiDataGridViewTextBoxColumn";
            narxiDataGridViewTextBoxColumn.Width = 125;
            // 
            // reportSelesPillBindingSource
            // 
            reportSelesPillBindingSource.DataSource = typeof(Actions.ReportSelesPill);
            // 
            // allInformationsBindingSource
            // 
            allInformationsBindingSource.DataSource = typeof(Actions.AllInformations);
            // 
            // btBack
            // 
            btBack.BackColor = Color.Silver;
            btBack.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btBack.Location = new Point(1614, 1012);
            btBack.Name = "btBack";
            btBack.Size = new Size(249, 53);
            btBack.TabIndex = 41;
            btBack.Text = "Orqaga qaytish";
            btBack.UseVisualStyleBackColor = false;
            btBack.Click += btBack_Click;
            // 
            // lbFIO
            // 
            lbFIO.AutoSize = true;
            lbFIO.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbFIO.Location = new Point(12, 9);
            lbFIO.Name = "lbFIO";
            lbFIO.Size = new Size(61, 38);
            lbFIO.TabIndex = 42;
            lbFIO.Text = "FIO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(24, 78);
            label1.Name = "label1";
            label1.Size = new Size(243, 38);
            label1.TabIndex = 43;
            label1.Text = "Umumiy tushum:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(24, 25);
            label2.Name = "label2";
            label2.Size = new Size(413, 38);
            label2.TabIndex = 44;
            label2.Text = "Umumiy sotilgan dorilar soni:";
            // 
            // lbAllPillCount
            // 
            lbAllPillCount.AutoSize = true;
            lbAllPillCount.BackColor = Color.FromArgb(255, 255, 192);
            lbAllPillCount.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lbAllPillCount.Location = new Point(443, 26);
            lbAllPillCount.Name = "lbAllPillCount";
            lbAllPillCount.Size = new Size(73, 38);
            lbAllPillCount.TabIndex = 45;
            lbAllPillCount.Text = "Soni";
            // 
            // lbAllPillPrice
            // 
            lbAllPillPrice.AutoSize = true;
            lbAllPillPrice.BackColor = Color.FromArgb(255, 255, 192);
            lbAllPillPrice.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lbAllPillPrice.Location = new Point(273, 79);
            lbAllPillPrice.Name = "lbAllPillPrice";
            lbAllPillPrice.Size = new Size(83, 38);
            lbAllPillPrice.TabIndex = 46;
            lbAllPillPrice.Text = "Narxi";
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Trebuchet MS", 22.2F);
            lbLogin.Location = new Point(70, 63);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(254, 46);
            lbLogin.TabIndex = 52;
            lbLogin.Text = "Login kiriting:";
            // 
            // txLogin
            // 
            txLogin.BackColor = Color.FromArgb(255, 255, 192);
            txLogin.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txLogin.Location = new Point(365, 65);
            txLogin.Name = "txLogin";
            txLogin.Size = new Size(233, 48);
            txLogin.TabIndex = 53;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 255, 192);
            label3.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.Location = new Point(365, 207);
            label3.Name = "label3";
            label3.Size = new Size(97, 38);
            label3.TabIndex = 57;
            label3.Text = "          ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 255, 192);
            label4.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label4.Location = new Point(365, 143);
            label4.Name = "label4";
            label4.Size = new Size(57, 38);
            label4.TabIndex = 56;
            label4.Text = "     ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(70, 142);
            label5.Name = "label5";
            label5.Size = new Size(288, 38);
            label5.TabIndex = 55;
            label5.Text = "Sotgan dorilari soni:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(70, 206);
            label6.Name = "label6";
            label6.Size = new Size(289, 38);
            label6.TabIndex = 54;
            label6.Text = "Sotgandagi tushumi:";
            // 
            // btResult1
            // 
            btResult1.BackColor = Color.LightSkyBlue;
            btResult1.Font = new Font("Trebuchet MS", 18F);
            btResult1.Location = new Point(631, 65);
            btResult1.Name = "btResult1";
            btResult1.Size = new Size(142, 47);
            btResult1.TabIndex = 58;
            btResult1.Text = "Natija";
            btResult1.UseVisualStyleBackColor = false;
            btResult1.Click += btResult1_Click;
            // 
            // lbStartDate
            // 
            lbStartDate.AutoSize = true;
            lbStartDate.Font = new Font("Trebuchet MS", 22.2F);
            lbStartDate.Location = new Point(68, 49);
            lbStartDate.Name = "lbStartDate";
            lbStartDate.Size = new Size(316, 46);
            lbStartDate.TabIndex = 59;
            lbStartDate.Text = "Boshlanish sanasi:";
            // 
            // txStartDate
            // 
            txStartDate.BackColor = Color.FromArgb(255, 255, 192);
            txStartDate.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txStartDate.Location = new Point(390, 51);
            txStartDate.Name = "txStartDate";
            txStartDate.Size = new Size(233, 48);
            txStartDate.TabIndex = 60;
            txStartDate.TextChanged += txStartDate_TextChanged;
            // 
            // lbFinishDate
            // 
            lbFinishDate.AutoSize = true;
            lbFinishDate.Font = new Font("Trebuchet MS", 22.2F);
            lbFinishDate.Location = new Point(68, 128);
            lbFinishDate.Name = "lbFinishDate";
            lbFinishDate.Size = new Size(253, 46);
            lbFinishDate.TabIndex = 61;
            lbFinishDate.Text = "Tugash sanasi:";
            // 
            // txFinishDate
            // 
            txFinishDate.BackColor = Color.FromArgb(255, 255, 192);
            txFinishDate.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txFinishDate.Location = new Point(390, 130);
            txFinishDate.Name = "txFinishDate";
            txFinishDate.Size = new Size(233, 48);
            txFinishDate.TabIndex = 62;
            // 
            // btResult2
            // 
            btResult2.BackColor = Color.LightSkyBlue;
            btResult2.Font = new Font("Trebuchet MS", 18F);
            btResult2.Location = new Point(658, 130);
            btResult2.Name = "btResult2";
            btResult2.Size = new Size(142, 47);
            btResult2.TabIndex = 63;
            btResult2.Text = "Natija";
            btResult2.UseVisualStyleBackColor = false;
            btResult2.Click += btResult2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(255, 255, 192);
            label7.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label7.Location = new Point(390, 281);
            label7.Name = "label7";
            label7.Size = new Size(97, 38);
            label7.TabIndex = 67;
            label7.Text = "          ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(255, 255, 192);
            label8.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label8.Location = new Point(390, 211);
            label8.Name = "label8";
            label8.Size = new Size(57, 38);
            label8.TabIndex = 66;
            label8.Text = "     ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label9.Location = new Point(68, 211);
            label9.Name = "label9";
            label9.Size = new Size(297, 38);
            label9.TabIndex = 65;
            label9.Text = "Sotilgan dorilar soni:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label10.Location = new Point(68, 281);
            label10.Name = "label10";
            label10.Size = new Size(135, 38);
            label10.TabIndex = 64;
            label10.Text = "Tushumi:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbAllPillCount);
            panel1.Controls.Add(lbAllPillPrice);
            panel1.Location = new Point(104, 914);
            panel1.Name = "panel1";
            panel1.Size = new Size(853, 151);
            panel1.TabIndex = 68;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCyan;
            panel2.Controls.Add(txLogin);
            panel2.Controls.Add(lbLogin);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btResult1);
            panel2.Location = new Point(1022, 115);
            panel2.Name = "panel2";
            panel2.Size = new Size(841, 309);
            panel2.TabIndex = 69;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightCyan;
            panel3.Controls.Add(txFinishDate);
            panel3.Controls.Add(txStartDate);
            panel3.Controls.Add(lbStartDate);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(lbFinishDate);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(btResult2);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label10);
            panel3.Location = new Point(1022, 494);
            panel3.Name = "panel3";
            panel3.Size = new Size(841, 354);
            panel3.TabIndex = 70;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1917, 1158);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lbFIO);
            Controls.Add(btBack);
            Controls.Add(dGVInformations);
            Name = "ReportsForm";
            Text = "ReportsForm";
            Load += ReportsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dGVInformations).EndInit();
            ((System.ComponentModel.ISupportInitialize)reportSelesPillBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)allInformationsBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dGVInformations;
        private BindingSource allInformationsBindingSource;
        private Button btBack;
        private Label lbFIO;
        private Label label1;
        private Label label2;
        private Label lbAllPillCount;
        private Label lbAllPillPrice;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sotilganVaqtiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn narxiDataGridViewTextBoxColumn;
        private BindingSource reportSelesPillBindingSource;
        private Label lbLogin;
        private TextBox txLogin;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btResult1;
        private Label lbStartDate;
        private TextBox txStartDate;
        private Label lbFinishDate;
        private TextBox txFinishDate;
        private Button btResult2;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}