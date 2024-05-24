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
            label4 = new Label();
            dataGridView1 = new DataGridView();
            sellingPillBindingSource = new BindingSource(components);
            cbSearch = new ComboBox();
            btUpdatePill = new Button();
            txId = new TextBox();
            label2 = new Label();
            btSearch = new Button();
            txPillInformation = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sellingPillBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btBack
            // 
            btBack.BackColor = Color.Silver;
            btBack.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btBack.Location = new Point(1821, 946);
            btBack.Name = "btBack";
            btBack.Size = new Size(280, 53);
            btBack.TabIndex = 117;
            btBack.Text = "Orqaga qaytish";
            btBack.UseVisualStyleBackColor = false;
            btBack.Click += btBack_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(569, 369);
            label4.Name = "label4";
            label4.Size = new Size(90, 38);
            label4.TabIndex = 121;
            label4.Text = "Savat";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.DataSource = sellingPillBindingSource;
            dataGridView1.Location = new Point(297, 419);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(624, 263);
            dataGridView1.TabIndex = 120;
            // 
            // cbSearch
            // 
            cbSearch.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cbSearch.FormattingEnabled = true;
            cbSearch.Items.AddRange(new object[] { "Nomi", "Id", "Soni", "Narxi" });
            cbSearch.Location = new Point(1181, 391);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(276, 49);
            cbSearch.TabIndex = 127;
            cbSearch.Text = "Nomi";
            // 
            // btUpdatePill
            // 
            btUpdatePill.BackColor = Color.FromArgb(255, 255, 128);
            btUpdatePill.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btUpdatePill.Location = new Point(1181, 573);
            btUpdatePill.Name = "btUpdatePill";
            btUpdatePill.Size = new Size(773, 60);
            btUpdatePill.TabIndex = 122;
            btUpdatePill.Text = "O'chirish";
            btUpdatePill.UseVisualStyleBackColor = false;
            btUpdatePill.Click += btUpdatePill_Click_1;
            // 
            // txId
            // 
            txId.BackColor = Color.FromArgb(255, 255, 192);
            txId.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txId.Location = new Point(1590, 477);
            txId.Name = "txId";
            txId.Size = new Size(273, 48);
            txId.TabIndex = 126;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 22.2F);
            label2.Location = new Point(1181, 479);
            label2.Name = "label2";
            label2.Size = new Size(343, 46);
            label2.TabIndex = 125;
            label2.Text = "Dori Id sini kiriting:";
            // 
            // btSearch
            // 
            btSearch.BackColor = Color.LightSkyBlue;
            btSearch.Font = new Font("Trebuchet MS", 18F);
            btSearch.Location = new Point(1770, 391);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(160, 47);
            btSearch.TabIndex = 123;
            btSearch.Text = "Qidirish";
            btSearch.UseVisualStyleBackColor = false;
            btSearch.Click += btSearch_Click;
            // 
            // txPillInformation
            // 
            txPillInformation.BackColor = Color.FromArgb(255, 255, 192);
            txPillInformation.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txPillInformation.Location = new Point(1491, 391);
            txPillInformation.Name = "txPillInformation";
            txPillInformation.Size = new Size(273, 48);
            txPillInformation.TabIndex = 124;
            // 
            // DeleteBasketPillForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1924, 1033);
            Controls.Add(cbSearch);
            Controls.Add(btUpdatePill);
            Controls.Add(txId);
            Controls.Add(label2);
            Controls.Add(btSearch);
            Controls.Add(txPillInformation);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(btBack);
            Name = "DeleteBasketPillForm";
            Text = "DeleteBasketPillForm";
            FormClosed += DeleteBasketPillForm_FormClosed;
            Load += DeleteBasketPillForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)sellingPillBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btBack;
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