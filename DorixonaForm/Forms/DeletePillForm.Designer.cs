namespace DorixonaForm.Forms
{
    partial class DeletePillForm
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
            label4 = new Label();
            panel3 = new Panel();
            txDeletePillLifeTime = new TextBox();
            label1 = new Label();
            btDeletePill = new Button();
            lbUpdatePillCount = new Label();
            txDeletePillPrice = new TextBox();
            txDeletePillCount = new TextBox();
            lbUpdatePillName = new Label();
            lbUpdatePillPrice = new Label();
            txDeletePillName = new TextBox();
            btBack = new Button();
            btPlacement = new Button();
            txId = new TextBox();
            label2 = new Label();
            btSearch = new Button();
            txPillName = new TextBox();
            dataGridView1 = new DataGridView();
            pillBindingSource = new BindingSource(components);
            button9 = new Button();
            comboBox1 = new ComboBox();
            btExit = new Button();
            cbSearch = new ComboBox();
            button7 = new Button();
            button3 = new Button();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 24F);
            label4.Location = new Point(292, 23);
            label4.Name = "label4";
            label4.Size = new Size(252, 49);
            label4.TabIndex = 61;
            label4.Text = "Dori o'chirish";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightCyan;
            panel3.Controls.Add(txDeletePillLifeTime);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(btDeletePill);
            panel3.Controls.Add(lbUpdatePillCount);
            panel3.Controls.Add(txDeletePillPrice);
            panel3.Controls.Add(txDeletePillCount);
            panel3.Controls.Add(lbUpdatePillName);
            panel3.Controls.Add(lbUpdatePillPrice);
            panel3.Controls.Add(txDeletePillName);
            panel3.Location = new Point(1238, 329);
            panel3.Name = "panel3";
            panel3.Size = new Size(834, 577);
            panel3.TabIndex = 60;
            // 
            // txDeletePillLifeTime
            // 
            txDeletePillLifeTime.BackColor = Color.FromArgb(255, 255, 192);
            txDeletePillLifeTime.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txDeletePillLifeTime.Location = new Point(448, 302);
            txDeletePillLifeTime.Name = "txDeletePillLifeTime";
            txDeletePillLifeTime.Size = new Size(290, 48);
            txDeletePillLifeTime.TabIndex = 75;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 22.2F);
            label1.Location = new Point(116, 300);
            label1.Name = "label1";
            label1.Size = new Size(251, 46);
            label1.TabIndex = 74;
            label1.Text = "Dori muddati:";
            // 
            // btDeletePill
            // 
            btDeletePill.BackColor = Color.Tomato;
            btDeletePill.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btDeletePill.Location = new Point(70, 471);
            btDeletePill.Name = "btDeletePill";
            btDeletePill.Size = new Size(699, 60);
            btDeletePill.TabIndex = 59;
            btDeletePill.Text = "O'chirish";
            btDeletePill.UseVisualStyleBackColor = false;
            btDeletePill.Click += btDeletePill_Click;
            // 
            // lbUpdatePillCount
            // 
            lbUpdatePillCount.AutoSize = true;
            lbUpdatePillCount.Font = new Font("Trebuchet MS", 22.2F);
            lbUpdatePillCount.Location = new Point(116, 234);
            lbUpdatePillCount.Name = "lbUpdatePillCount";
            lbUpdatePillCount.Size = new Size(179, 46);
            lbUpdatePillCount.TabIndex = 69;
            lbUpdatePillCount.Text = "Dori soni:";
            // 
            // txDeletePillPrice
            // 
            txDeletePillPrice.BackColor = Color.FromArgb(255, 255, 192);
            txDeletePillPrice.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txDeletePillPrice.Location = new Point(447, 371);
            txDeletePillPrice.Name = "txDeletePillPrice";
            txDeletePillPrice.Size = new Size(291, 48);
            txDeletePillPrice.TabIndex = 73;
            // 
            // txDeletePillCount
            // 
            txDeletePillCount.BackColor = Color.FromArgb(255, 255, 192);
            txDeletePillCount.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txDeletePillCount.Location = new Point(448, 236);
            txDeletePillCount.Name = "txDeletePillCount";
            txDeletePillCount.Size = new Size(291, 48);
            txDeletePillCount.TabIndex = 70;
            // 
            // lbUpdatePillName
            // 
            lbUpdatePillName.AutoSize = true;
            lbUpdatePillName.Font = new Font("Trebuchet MS", 22.2F);
            lbUpdatePillName.Location = new Point(116, 164);
            lbUpdatePillName.Name = "lbUpdatePillName";
            lbUpdatePillName.Size = new Size(195, 46);
            lbUpdatePillName.TabIndex = 68;
            lbUpdatePillName.Text = "Dori nomi:";
            // 
            // lbUpdatePillPrice
            // 
            lbUpdatePillPrice.AutoSize = true;
            lbUpdatePillPrice.Font = new Font("Trebuchet MS", 22.2F);
            lbUpdatePillPrice.Location = new Point(116, 369);
            lbUpdatePillPrice.Name = "lbUpdatePillPrice";
            lbUpdatePillPrice.Size = new Size(196, 46);
            lbUpdatePillPrice.TabIndex = 72;
            lbUpdatePillPrice.Text = "Dori narxi:";
            // 
            // txDeletePillName
            // 
            txDeletePillName.BackColor = Color.FromArgb(255, 255, 192);
            txDeletePillName.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txDeletePillName.Location = new Point(447, 166);
            txDeletePillName.Name = "txDeletePillName";
            txDeletePillName.Size = new Size(291, 48);
            txDeletePillName.TabIndex = 71;
            // 
            // btBack
            // 
            btBack.BackColor = Color.Silver;
            btBack.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btBack.Location = new Point(1791, 926);
            btBack.Name = "btBack";
            btBack.Size = new Size(280, 53);
            btBack.TabIndex = 61;
            btBack.Text = "Orqaga qaytish";
            btBack.UseVisualStyleBackColor = false;
            btBack.Click += btBack_Click;
            // 
            // btPlacement
            // 
            btPlacement.BackColor = Color.LightSkyBlue;
            btPlacement.Font = new Font("Trebuchet MS", 18F);
            btPlacement.Location = new Point(1911, 259);
            btPlacement.Name = "btPlacement";
            btPlacement.Size = new Size(160, 47);
            btPlacement.TabIndex = 79;
            btPlacement.Text = "Joylash";
            btPlacement.UseVisualStyleBackColor = false;
            btPlacement.Click += btPlacement_Click;
            // 
            // txId
            // 
            txId.BackColor = Color.FromArgb(255, 255, 192);
            txId.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txId.Location = new Point(1603, 259);
            txId.Name = "txId";
            txId.Size = new Size(273, 48);
            txId.TabIndex = 78;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 22.2F);
            label2.Location = new Point(1195, 261);
            label2.Name = "label2";
            label2.Size = new Size(343, 46);
            label2.TabIndex = 77;
            label2.Text = "Dori Id sini kiriting:";
            // 
            // btSearch
            // 
            btSearch.BackColor = Color.LightSkyBlue;
            btSearch.Font = new Font("Trebuchet MS", 18F);
            btSearch.Location = new Point(1911, 177);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(160, 47);
            btSearch.TabIndex = 74;
            btSearch.Text = "Qidirish";
            btSearch.UseVisualStyleBackColor = false;
            btSearch.Click += btSearch_Click;
            // 
            // txPillName
            // 
            txPillName.BackColor = Color.FromArgb(255, 255, 192);
            txPillName.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txPillName.Location = new Point(1603, 175);
            txPillName.Name = "txPillName";
            txPillName.Size = new Size(273, 48);
            txPillName.TabIndex = 75;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.DataSource = pillBindingSource;
            dataGridView1.Location = new Point(188, 163);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(903, 743);
            dataGridView1.TabIndex = 80;
            // 
            // button9
            // 
            button9.BackColor = Color.LightSkyBlue;
            button9.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button9.Location = new Point(854, 72);
            button9.Name = "button9";
            button9.Size = new Size(155, 41);
            button9.TabIndex = 89;
            button9.Text = "Qaytarish";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "O'sish", "Kamayish" });
            comboBox1.Location = new Point(52, 108);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(195, 49);
            comboBox1.TabIndex = 82;
            // 
            // btExit
            // 
            btExit.BackColor = Color.Silver;
            btExit.Font = new Font("Trebuchet MS", 14F);
            btExit.Location = new Point(1987, 29);
            btExit.Name = "btExit";
            btExit.Size = new Size(140, 44);
            btExit.TabIndex = 81;
            btExit.Text = "Chiqish";
            btExit.UseVisualStyleBackColor = false;
            // 
            // cbSearch
            // 
            cbSearch.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cbSearch.FormattingEnabled = true;
            cbSearch.Items.AddRange(new object[] { "Nomi", "Id", "Soni", "Muddati", "Narxi" });
            cbSearch.Location = new Point(1401, 175);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(195, 49);
            cbSearch.TabIndex = 90;
            cbSearch.Text = "Nomi";
            // 
            // button7
            // 
            button7.BackColor = Color.LightSkyBlue;
            button7.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button7.Location = new Point(404, 116);
            button7.Name = "button7";
            button7.Size = new Size(145, 41);
            button7.TabIndex = 92;
            button7.Text = "Kamayish";
            button7.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSkyBlue;
            button3.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.Location = new Point(270, 116);
            button3.Name = "button3";
            button3.Size = new Size(127, 41);
            button3.TabIndex = 91;
            button3.Text = "O'sish";
            button3.UseVisualStyleBackColor = false;
            // 
            // DeletePillForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1924, 1033);
            Controls.Add(button7);
            Controls.Add(button3);
            Controls.Add(cbSearch);
            Controls.Add(button9);
            Controls.Add(comboBox1);
            Controls.Add(btExit);
            Controls.Add(dataGridView1);
            Controls.Add(btPlacement);
            Controls.Add(txId);
            Controls.Add(label2);
            Controls.Add(btSearch);
            Controls.Add(txPillName);
            Controls.Add(btBack);
            Controls.Add(panel3);
            Name = "DeletePillForm";
            Text = "DeletePillForm";
            Load += DeletePillForm_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Panel panel3;
        private Button btDeletePill;
        private Button btBack;
        private TextBox txDeletePillLifeTime;
        private Label label1;
        private Label lbUpdatePillCount;
        private TextBox txDeletePillPrice;
        private TextBox txDeletePillCount;
        private Label lbUpdatePillName;
        private Label lbUpdatePillPrice;
        private TextBox txDeletePillName;
        private Button btPlacement;
        private TextBox txId;
        private Label label2;
        private Button btSearch;
        private TextBox txPillName;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn muddatiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn narxiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn qoshilganSanaDataGridViewTextBoxColumn;
        private BindingSource pillBindingSource;
        private Button button9;
        private ComboBox comboBox1;
        private Button btExit;
        private ComboBox cbSearch;
        private Button button7;
        private Button button3;
    }
}