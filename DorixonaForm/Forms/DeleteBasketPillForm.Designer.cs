namespace DorixonaForm.Forms
{
    partial class DeleteBasketPillForm
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
            btBack = new Button();
            btExit = new Button();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            cbSearch = new ComboBox();
            btUpdatePill = new Button();
            txId = new TextBox();
            label2 = new Label();
            btSearch = new Button();
            txPillInformation = new TextBox();
            sellingPillBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soniDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            narxiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sellingPillBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btBack
            // 
            btBack.BackColor = Color.Silver;
            btBack.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btBack.Location = new Point(1619, 946);
            btBack.Name = "btBack";
            btBack.Size = new Size(249, 53);
            btBack.TabIndex = 117;
            btBack.Text = "Orqaga qaytish";
            btBack.UseVisualStyleBackColor = false;
            btBack.Click += btBack_Click;
            // 
            // btExit
            // 
            btExit.BackColor = Color.Silver;
            btExit.Font = new Font("Trebuchet MS", 14F);
            btExit.Location = new Point(1777, 112);
            btExit.Name = "btExit";
            btExit.Size = new Size(124, 44);
            btExit.TabIndex = 114;
            btExit.Text = "Chiqish";
            btExit.UseVisualStyleBackColor = false;
            btExit.Click += btExit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(506, 369);
            label4.Name = "label4";
            label4.Size = new Size(90, 38);
            label4.TabIndex = 121;
            label4.Text = "Savat";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomiDataGridViewTextBoxColumn, soniDataGridViewTextBoxColumn, narxiDataGridViewTextBoxColumn });
            dataGridView1.DataSource = sellingPillBindingSource;
            dataGridView1.Location = new Point(264, 419);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(555, 263);
            dataGridView1.TabIndex = 120;
            // 
            // cbSearch
            // 
            cbSearch.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cbSearch.FormattingEnabled = true;
            cbSearch.Items.AddRange(new object[] { "Nomi", "Id", "Soni", "Narxi" });
            cbSearch.Location = new Point(1050, 391);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(246, 49);
            cbSearch.TabIndex = 127;
            cbSearch.Text = "Nomi";
            // 
            // btUpdatePill
            // 
            btUpdatePill.BackColor = Color.FromArgb(255, 255, 128);
            btUpdatePill.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btUpdatePill.Location = new Point(1050, 573);
            btUpdatePill.Name = "btUpdatePill";
            btUpdatePill.Size = new Size(687, 60);
            btUpdatePill.TabIndex = 122;
            btUpdatePill.Text = "O'chirish";
            btUpdatePill.UseVisualStyleBackColor = false;
            btUpdatePill.Click += btUpdatePill_Click_1;
            // 
            // txId
            // 
            txId.BackColor = Color.FromArgb(255, 255, 192);
            txId.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txId.Location = new Point(1413, 477);
            txId.Name = "txId";
            txId.Size = new Size(243, 48);
            txId.TabIndex = 126;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 22.2F);
            label2.Location = new Point(1050, 479);
            label2.Name = "label2";
            label2.Size = new Size(343, 46);
            label2.TabIndex = 125;
            label2.Text = "Dori Id sini kiriting:";
            // 
            // btSearch
            // 
            btSearch.BackColor = Color.LightSkyBlue;
            btSearch.Font = new Font("Trebuchet MS", 18F);
            btSearch.Location = new Point(1595, 391);
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
            txPillInformation.Location = new Point(1325, 391);
            txPillInformation.Name = "txPillInformation";
            txPillInformation.Size = new Size(243, 48);
            txPillInformation.TabIndex = 124;
            // 
            // sellingPillBindingSource
            // 
            sellingPillBindingSource.DataSource = typeof(Actions.SellingPill);
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
            // DeleteBasketPillForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1917, 1033);
            Controls.Add(cbSearch);
            Controls.Add(btUpdatePill);
            Controls.Add(txId);
            Controls.Add(label2);
            Controls.Add(btSearch);
            Controls.Add(txPillInformation);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(btBack);
            Controls.Add(btExit);
            Name = "DeleteBasketPillForm";
            Text = "DeleteBasketPillForm";
            Load += DeleteBasketPillForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)sellingPillBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btBack;
        private Button btExit;
        private Label label4;
        private DataGridView dataGridView1;
        private ComboBox cbSearch;
        private Button btUpdatePill;
        private TextBox txId;
        private Label label2;
        private Button btSearch;
        private TextBox txPillInformation;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn narxiDataGridViewTextBoxColumn;
        private BindingSource sellingPillBindingSource;
    }
}