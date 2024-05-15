namespace DorixonaForm.Forms
{
    partial class UpdatePillForm
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
            label3 = new Label();
            panel2 = new Panel();
            txUpdatePillLifeTime = new TextBox();
            label1 = new Label();
            btUpdatePill = new Button();
            txUpdatePillPrice = new TextBox();
            lbUpdatePillPrice = new Label();
            txUpdatePillName = new TextBox();
            txUpdatePillCount = new TextBox();
            lbUpdatePillCount = new Label();
            lbUpdatePillName = new Label();
            btBack = new Button();
            lbFIO = new Label();
            dataGridView1 = new DataGridView();
            pillBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soniDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            muddatiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            narxiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            qoshilganSanaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 24F);
            label3.Location = new Point(303, 21);
            label3.Name = "label3";
            label3.Size = new Size(272, 49);
            label3.TabIndex = 60;
            label3.Text = "Dori yangilash";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCyan;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txUpdatePillLifeTime);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btUpdatePill);
            panel2.Controls.Add(txUpdatePillPrice);
            panel2.Controls.Add(lbUpdatePillPrice);
            panel2.Controls.Add(txUpdatePillName);
            panel2.Controls.Add(txUpdatePillCount);
            panel2.Controls.Add(lbUpdatePillCount);
            panel2.Controls.Add(lbUpdatePillName);
            panel2.Location = new Point(990, 147);
            panel2.Name = "panel2";
            panel2.Size = new Size(857, 743);
            panel2.TabIndex = 59;
            // 
            // txUpdatePillLifeTime
            // 
            txUpdatePillLifeTime.BackColor = Color.FromArgb(255, 255, 192);
            txUpdatePillLifeTime.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txUpdatePillLifeTime.Location = new Point(551, 356);
            txUpdatePillLifeTime.Name = "txUpdatePillLifeTime";
            txUpdatePillLifeTime.Size = new Size(258, 48);
            txUpdatePillLifeTime.TabIndex = 67;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 22.2F);
            label1.Location = new Point(34, 354);
            label1.Name = "label1";
            label1.Size = new Size(511, 46);
            label1.TabIndex = 66;
            label1.Text = "Dori yangi muddatini kiriting:";
            // 
            // btUpdatePill
            // 
            btUpdatePill.BackColor = Color.FromArgb(255, 255, 128);
            btUpdatePill.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btUpdatePill.Location = new Point(33, 621);
            btUpdatePill.Name = "btUpdatePill";
            btUpdatePill.Size = new Size(776, 60);
            btUpdatePill.TabIndex = 65;
            btUpdatePill.Text = "Yangilash";
            btUpdatePill.UseVisualStyleBackColor = false;
            btUpdatePill.Click += btUpdatePill_Click;
            // 
            // txUpdatePillPrice
            // 
            txUpdatePillPrice.BackColor = Color.FromArgb(255, 255, 192);
            txUpdatePillPrice.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txUpdatePillPrice.Location = new Point(551, 425);
            txUpdatePillPrice.Name = "txUpdatePillPrice";
            txUpdatePillPrice.Size = new Size(259, 48);
            txUpdatePillPrice.TabIndex = 64;
            // 
            // lbUpdatePillPrice
            // 
            lbUpdatePillPrice.AutoSize = true;
            lbUpdatePillPrice.Font = new Font("Trebuchet MS", 22.2F);
            lbUpdatePillPrice.Location = new Point(34, 423);
            lbUpdatePillPrice.Name = "lbUpdatePillPrice";
            lbUpdatePillPrice.Size = new Size(456, 46);
            lbUpdatePillPrice.TabIndex = 63;
            lbUpdatePillPrice.Text = "Dori yangi narxini kiriting:";
            // 
            // txUpdatePillName
            // 
            txUpdatePillName.BackColor = Color.FromArgb(255, 255, 192);
            txUpdatePillName.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txUpdatePillName.Location = new Point(551, 220);
            txUpdatePillName.Name = "txUpdatePillName";
            txUpdatePillName.Size = new Size(259, 48);
            txUpdatePillName.TabIndex = 62;
            // 
            // txUpdatePillCount
            // 
            txUpdatePillCount.BackColor = Color.FromArgb(255, 255, 192);
            txUpdatePillCount.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txUpdatePillCount.Location = new Point(551, 290);
            txUpdatePillCount.Name = "txUpdatePillCount";
            txUpdatePillCount.Size = new Size(259, 48);
            txUpdatePillCount.TabIndex = 61;
            // 
            // lbUpdatePillCount
            // 
            lbUpdatePillCount.AutoSize = true;
            lbUpdatePillCount.Font = new Font("Trebuchet MS", 22.2F);
            lbUpdatePillCount.Location = new Point(34, 288);
            lbUpdatePillCount.Name = "lbUpdatePillCount";
            lbUpdatePillCount.Size = new Size(439, 46);
            lbUpdatePillCount.TabIndex = 60;
            lbUpdatePillCount.Text = "Dori yangi sonini kiriting:";
            // 
            // lbUpdatePillName
            // 
            lbUpdatePillName.AutoSize = true;
            lbUpdatePillName.Font = new Font("Trebuchet MS", 22.2F);
            lbUpdatePillName.Location = new Point(34, 218);
            lbUpdatePillName.Name = "lbUpdatePillName";
            lbUpdatePillName.Size = new Size(357, 46);
            lbUpdatePillName.TabIndex = 59;
            lbUpdatePillName.Text = "Dori nomini kiriting:";
            // 
            // btBack
            // 
            btBack.BackColor = Color.Silver;
            btBack.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btBack.Location = new Point(1598, 925);
            btBack.Name = "btBack";
            btBack.Size = new Size(249, 53);
            btBack.TabIndex = 61;
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
            lbFIO.TabIndex = 62;
            lbFIO.Text = "FIO";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomiDataGridViewTextBoxColumn, soniDataGridViewTextBoxColumn, muddatiDataGridViewTextBoxColumn, narxiDataGridViewTextBoxColumn, qoshilganSanaDataGridViewTextBoxColumn });
            dataGridView1.DataSource = pillBindingSource;
            dataGridView1.Location = new Point(91, 147);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(803, 743);
            dataGridView1.TabIndex = 63;
            // 
            // pillBindingSource
            // 
            pillBindingSource.DataSource = typeof(Actions.Pill);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
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
            // muddatiDataGridViewTextBoxColumn
            // 
            muddatiDataGridViewTextBoxColumn.DataPropertyName = "Muddati";
            muddatiDataGridViewTextBoxColumn.HeaderText = "Muddati";
            muddatiDataGridViewTextBoxColumn.MinimumWidth = 6;
            muddatiDataGridViewTextBoxColumn.Name = "muddatiDataGridViewTextBoxColumn";
            muddatiDataGridViewTextBoxColumn.Width = 125;
            // 
            // narxiDataGridViewTextBoxColumn
            // 
            narxiDataGridViewTextBoxColumn.DataPropertyName = "Narxi";
            narxiDataGridViewTextBoxColumn.HeaderText = "Narxi";
            narxiDataGridViewTextBoxColumn.MinimumWidth = 6;
            narxiDataGridViewTextBoxColumn.Name = "narxiDataGridViewTextBoxColumn";
            narxiDataGridViewTextBoxColumn.Width = 125;
            // 
            // qoshilganSanaDataGridViewTextBoxColumn
            // 
            qoshilganSanaDataGridViewTextBoxColumn.DataPropertyName = "QoshilganSana";
            qoshilganSanaDataGridViewTextBoxColumn.HeaderText = "QoshilganSana";
            qoshilganSanaDataGridViewTextBoxColumn.MinimumWidth = 6;
            qoshilganSanaDataGridViewTextBoxColumn.Name = "qoshilganSanaDataGridViewTextBoxColumn";
            qoshilganSanaDataGridViewTextBoxColumn.Width = 125;
            // 
            // UpdatePillForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1917, 1033);
            Controls.Add(dataGridView1);
            Controls.Add(lbFIO);
            Controls.Add(btBack);
            Controls.Add(panel2);
            Name = "UpdatePillForm";
            Text = "UpdatePillForm";
            Load += UpdatePillForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Panel panel2;
        private TextBox txUpdatePillLifeTime;
        private Label label1;
        private Button btUpdatePill;
        private TextBox txUpdatePillPrice;
        private Label lbUpdatePillPrice;
        private TextBox txUpdatePillName;
        private TextBox txUpdatePillCount;
        private Label lbUpdatePillCount;
        private Label lbUpdatePillName;
        private Button btBack;
        private Label lbFIO;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn muddatiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn narxiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn qoshilganSanaDataGridViewTextBoxColumn;
        private BindingSource pillBindingSource;
    }
}