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
            reportSelesPillBindingSource = new BindingSource(components);
            allInformationsBindingSource = new BindingSource(components);
            btBack = new Button();
            lbFIO = new Label();
            button2 = new Button();
            cbSearch = new ComboBox();
            btSearch = new Button();
            txPillName = new TextBox();
            comboBox1 = new ComboBox();
            panel2 = new Panel();
            label4 = new Label();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            button1 = new Button();
            label8 = new Label();
            label9 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dGVInformations).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reportSelesPillBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)allInformationsBindingSource).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dGVInformations
            // 
            dGVInformations.AutoGenerateColumns = false;
            dGVInformations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVInformations.DataSource = reportSelesPillBindingSource;
            dGVInformations.Location = new Point(104, 115);
            dGVInformations.Name = "dGVInformations";
            dGVInformations.RowHeadersWidth = 100;
            dGVInformations.Size = new Size(853, 628);
            dGVInformations.TabIndex = 0;
            dGVInformations.CellContentClick += dGVInformations_CellContentClick;
            // 
            // btBack
            // 
            btBack.BackColor = Color.Silver;
            btBack.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btBack.Location = new Point(1614, 900);
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
            lbFIO.Location = new Point(321, 58);
            lbFIO.Name = "lbFIO";
            lbFIO.Size = new Size(383, 38);
            lbFIO.TabIndex = 42;
            lbFIO.Text = "Umumiy jarayonlar ro'yxati";
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.Font = new Font("Trebuchet MS", 18F);
            button2.Location = new Point(1723, 12);
            button2.Name = "button2";
            button2.Size = new Size(164, 50);
            button2.TabIndex = 71;
            button2.Text = "Chiqish";
            button2.UseVisualStyleBackColor = false;
            // 
            // cbSearch
            // 
            cbSearch.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cbSearch.FormattingEnabled = true;
            cbSearch.Items.AddRange(new object[] { "Nomi", "Id", "Soni", "Muddati", "Narxi" });
            cbSearch.Location = new Point(1117, 133);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(174, 49);
            cbSearch.TabIndex = 80;
            cbSearch.Text = "Nomi";
            // 
            // btSearch
            // 
            btSearch.BackColor = Color.LightSkyBlue;
            btSearch.Font = new Font("Trebuchet MS", 18F);
            btSearch.Location = new Point(1585, 137);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(142, 47);
            btSearch.TabIndex = 78;
            btSearch.Text = "Qidirish";
            btSearch.UseVisualStyleBackColor = false;
            btSearch.Click += btSearch_Click;
            // 
            // txPillName
            // 
            txPillName.BackColor = Color.FromArgb(255, 255, 192);
            txPillName.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txPillName.Location = new Point(1311, 135);
            txPillName.Name = "txPillName";
            txPillName.Size = new Size(243, 48);
            txPillName.TabIndex = 79;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Sotuvchilar" });
            comboBox1.Location = new Point(1117, 204);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(192, 49);
            comboBox1.TabIndex = 81;
            comboBox1.Text = "Sotuvchilar";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCyan;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dateTimePicker2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(1117, 280);
            panel2.Name = "panel2";
            panel2.Size = new Size(706, 441);
            panel2.TabIndex = 133;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 255, 192);
            label4.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label4.Location = new Point(173, 350);
            label4.Name = "label4";
            label4.Size = new Size(97, 38);
            label4.TabIndex = 143;
            label4.Text = "          ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 22.2F);
            label5.Location = new Point(66, 342);
            label5.Name = "label5";
            label5.Size = new Size(103, 46);
            label5.TabIndex = 142;
            label5.Text = "Soni:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 255, 192);
            label2.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(474, 319);
            label2.Name = "label2";
            label2.Size = new Size(97, 38);
            label2.TabIndex = 141;
            label2.Text = "          ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 22.2F);
            label3.Location = new Point(360, 312);
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
            button1.Location = new Point(66, 236);
            button1.Name = "button1";
            button1.Size = new Size(626, 47);
            button1.TabIndex = 129;
            button1.Text = "Ma'lumot";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(255, 255, 192);
            label8.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label8.Location = new Point(228, 294);
            label8.Name = "label8";
            label8.Size = new Size(97, 38);
            label8.TabIndex = 131;
            label8.Text = "          ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Trebuchet MS", 22.2F);
            label9.Location = new Point(66, 286);
            label9.Name = "label9";
            label9.Size = new Size(156, 46);
            label9.TabIndex = 130;
            label9.Text = "Tushum:";
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
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1917, 1033);
            Controls.Add(panel2);
            Controls.Add(comboBox1);
            Controls.Add(cbSearch);
            Controls.Add(btSearch);
            Controls.Add(txPillName);
            Controls.Add(button2);
            Controls.Add(lbFIO);
            Controls.Add(btBack);
            Controls.Add(dGVInformations);
            Name = "ReportsForm";
            Text = "ReportsForm";
            Load += ReportsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dGVInformations).EndInit();
            ((System.ComponentModel.ISupportInitialize)reportSelesPillBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)allInformationsBindingSource).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dGVInformations;
        private BindingSource allInformationsBindingSource;
        private Button btBack;
        private Label lbFIO;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sotilganVaqtiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn narxiDataGridViewTextBoxColumn;
        private BindingSource reportSelesPillBindingSource;
        private Button button2;
        private ComboBox cbSearch;
        private Button btSearch;
        private TextBox txPillName;
        private ComboBox comboBox1;
        private Panel panel2;
        private Label label4;
        private Label label5;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private Button button1;
        private Label label8;
        private Label label9;
        private Label label6;
    }
}