namespace DorixonaForm.Forms
{
    partial class UpdateBasketPillForm
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
            btBack = new Button();
            cbSearch = new ComboBox();
            txUpdatePillCount = new TextBox();
            lbUpdatePillCount = new Label();
            btUpdatePill = new Button();
            btPlacement = new Button();
            txId = new TextBox();
            label2 = new Label();
            btSearch = new Button();
            txPillInformation = new TextBox();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soniDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            narxiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sellingPillBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sellingPillBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btExit
            // 
            btExit.BackColor = Color.Silver;
            btExit.Font = new Font("Trebuchet MS", 14F);
            btExit.Location = new Point(1774, 88);
            btExit.Name = "btExit";
            btExit.Size = new Size(124, 44);
            btExit.TabIndex = 93;
            btExit.Text = "Chiqish";
            btExit.UseVisualStyleBackColor = false;
            btExit.Click += btExit_Click;
            // 
            // btBack
            // 
            btBack.BackColor = Color.Silver;
            btBack.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btBack.Location = new Point(1616, 922);
            btBack.Name = "btBack";
            btBack.Size = new Size(249, 53);
            btBack.TabIndex = 104;
            btBack.Text = "Orqaga qaytish";
            btBack.UseVisualStyleBackColor = false;
            // 
            // cbSearch
            // 
            cbSearch.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cbSearch.FormattingEnabled = true;
            cbSearch.Items.AddRange(new object[] { "Nomi", "Id", "Soni", "Narxi" });
            cbSearch.Location = new Point(1121, 340);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(246, 49);
            cbSearch.TabIndex = 130;
            cbSearch.Text = "Nomi";
            // 
            // txUpdatePillCount
            // 
            txUpdatePillCount.BackColor = Color.FromArgb(255, 255, 192);
            txUpdatePillCount.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txUpdatePillCount.Location = new Point(1397, 503);
            txUpdatePillCount.Name = "txUpdatePillCount";
            txUpdatePillCount.Size = new Size(259, 48);
            txUpdatePillCount.TabIndex = 129;
            // 
            // lbUpdatePillCount
            // 
            lbUpdatePillCount.AutoSize = true;
            lbUpdatePillCount.Font = new Font("Trebuchet MS", 22.2F);
            lbUpdatePillCount.Location = new Point(1102, 501);
            lbUpdatePillCount.Name = "lbUpdatePillCount";
            lbUpdatePillCount.Size = new Size(179, 46);
            lbUpdatePillCount.TabIndex = 128;
            lbUpdatePillCount.Text = "Dori soni:";
            // 
            // btUpdatePill
            // 
            btUpdatePill.BackColor = Color.FromArgb(255, 255, 128);
            btUpdatePill.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btUpdatePill.Location = new Point(1156, 667);
            btUpdatePill.Name = "btUpdatePill";
            btUpdatePill.Size = new Size(555, 60);
            btUpdatePill.TabIndex = 122;
            btUpdatePill.Text = "Yangilash";
            btUpdatePill.UseVisualStyleBackColor = false;
            btUpdatePill.Click += btUpdatePill_Click;
            // 
            // btPlacement
            // 
            btPlacement.BackColor = Color.LightSkyBlue;
            btPlacement.Font = new Font("Trebuchet MS", 18F);
            btPlacement.Location = new Point(1671, 422);
            btPlacement.Name = "btPlacement";
            btPlacement.Size = new Size(142, 47);
            btPlacement.TabIndex = 127;
            btPlacement.Text = "Joylash";
            btPlacement.UseVisualStyleBackColor = false;
            btPlacement.Click += btPlacement_Click;
            // 
            // txId
            // 
            txId.BackColor = Color.FromArgb(255, 255, 192);
            txId.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txId.Location = new Point(1397, 422);
            txId.Name = "txId";
            txId.Size = new Size(243, 48);
            txId.TabIndex = 126;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 22.2F);
            label2.Location = new Point(1034, 424);
            label2.Name = "label2";
            label2.Size = new Size(343, 46);
            label2.TabIndex = 125;
            label2.Text = "Dori Id sini kiriting:";
            // 
            // btSearch
            // 
            btSearch.BackColor = Color.LightSkyBlue;
            btSearch.Font = new Font("Trebuchet MS", 18F);
            btSearch.Location = new Point(1671, 340);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(142, 47);
            btSearch.TabIndex = 123;
            btSearch.Text = "Qidirish";
            btSearch.UseVisualStyleBackColor = false;
            btSearch.Click += btSearch_Click;
            // 
            // txPillInformation
            // 
            txPillInformation.BackColor = Color.FromArgb(255, 255, 192);
            txPillInformation.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txPillInformation.Location = new Point(1397, 338);
            txPillInformation.Name = "txPillInformation";
            txPillInformation.Size = new Size(243, 48);
            txPillInformation.TabIndex = 124;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomiDataGridViewTextBoxColumn, soniDataGridViewTextBoxColumn, narxiDataGridViewTextBoxColumn });
            dataGridView1.DataSource = sellingPillBindingSource;
            dataGridView1.Location = new Point(289, 319);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(555, 263);
            dataGridView1.TabIndex = 131;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomiDataGridViewTextBoxColumn
            // 
            nomiDataGridViewTextBoxColumn.DataPropertyName = "Nomi";
            nomiDataGridViewTextBoxColumn.HeaderText = "Nomi";
            nomiDataGridViewTextBoxColumn.MinimumWidth = 6;
            nomiDataGridViewTextBoxColumn.Name = "nomiDataGridViewTextBoxColumn";
            nomiDataGridViewTextBoxColumn.ReadOnly = true;
            nomiDataGridViewTextBoxColumn.Width = 125;
            // 
            // soniDataGridViewTextBoxColumn
            // 
            soniDataGridViewTextBoxColumn.DataPropertyName = "Soni";
            soniDataGridViewTextBoxColumn.HeaderText = "Soni";
            soniDataGridViewTextBoxColumn.MinimumWidth = 6;
            soniDataGridViewTextBoxColumn.Name = "soniDataGridViewTextBoxColumn";
            soniDataGridViewTextBoxColumn.ReadOnly = true;
            soniDataGridViewTextBoxColumn.Width = 125;
            // 
            // narxiDataGridViewTextBoxColumn
            // 
            narxiDataGridViewTextBoxColumn.DataPropertyName = "Narxi";
            narxiDataGridViewTextBoxColumn.HeaderText = "Narxi";
            narxiDataGridViewTextBoxColumn.MinimumWidth = 6;
            narxiDataGridViewTextBoxColumn.Name = "narxiDataGridViewTextBoxColumn";
            narxiDataGridViewTextBoxColumn.ReadOnly = true;
            narxiDataGridViewTextBoxColumn.Width = 125;
            // 
            // sellingPillBindingSource
            // 
            sellingPillBindingSource.DataSource = typeof(Actions.SellingPill);
            // 
            // UpdateBasketPillForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1917, 1033);
            Controls.Add(dataGridView1);
            Controls.Add(cbSearch);
            Controls.Add(txUpdatePillCount);
            Controls.Add(lbUpdatePillCount);
            Controls.Add(btUpdatePill);
            Controls.Add(btPlacement);
            Controls.Add(txId);
            Controls.Add(label2);
            Controls.Add(btSearch);
            Controls.Add(txPillInformation);
            Controls.Add(btBack);
            Controls.Add(btExit);
            Name = "UpdateBasketPillForm";
            Text = "UpdateBasketPillForm";
            Load += UpdateBasketPillForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)sellingPillBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btExit;
        private Button btBack;
        private ComboBox cbSearch;
        private TextBox txUpdatePillCount;
        private Label lbUpdatePillCount;
        private Button btUpdatePill;
        private Button btPlacement;
        private TextBox txId;
        private Label label2;
        private Button btSearch;
        private TextBox txPillInformation;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn narxiDataGridViewTextBoxColumn;
        private BindingSource sellingPillBindingSource;
    }
}