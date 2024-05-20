namespace DorixonaForm.Forms
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
            cbSearch = new ComboBox();
            btSearch = new Button();
            txPillName = new TextBox();
            btExit = new Button();
            btBack = new Button();
            label6 = new Label();
            button2 = new Button();
            label8 = new Label();
            label9 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            button9 = new Button();
            button7 = new Button();
            button3 = new Button();
            comboBox3 = new ComboBox();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // cbSearch
            // 
            cbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearch.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cbSearch.FormattingEnabled = true;
            cbSearch.Items.AddRange(new object[] { "Nomi", "Id", "Soni", "Muddati", "Narxi" });
            cbSearch.Location = new Point(1047, 167);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(279, 49);
            cbSearch.TabIndex = 86;
            // 
            // btSearch
            // 
            btSearch.BackColor = Color.LightSkyBlue;
            btSearch.Font = new Font("Trebuchet MS", 18F);
            btSearch.Location = new Point(1693, 167);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(160, 49);
            btSearch.TabIndex = 84;
            btSearch.Text = "Qidirish";
            btSearch.UseVisualStyleBackColor = false;
            // 
            // txPillName
            // 
            txPillName.BackColor = Color.FromArgb(255, 255, 192);
            txPillName.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txPillName.Location = new Point(1341, 167);
            txPillName.Name = "txPillName";
            txPillName.Size = new Size(335, 48);
            txPillName.TabIndex = 85;
            // 
            // btExit
            // 
            btExit.BackColor = Color.Silver;
            btExit.Font = new Font("Trebuchet MS", 14F);
            btExit.Location = new Point(2004, 12);
            btExit.Name = "btExit";
            btExit.Size = new Size(140, 44);
            btExit.TabIndex = 88;
            btExit.Text = "Chiqish";
            btExit.UseVisualStyleBackColor = false;
            // 
            // btBack
            // 
            btBack.BackColor = Color.Silver;
            btBack.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btBack.Location = new Point(1528, 926);
            btBack.Name = "btBack";
            btBack.Size = new Size(280, 53);
            btBack.TabIndex = 118;
            btBack.Text = "Orqaga qaytish";
            btBack.UseVisualStyleBackColor = false;
            btBack.Click += btBack_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 22.2F);
            label6.Location = new Point(233, 163);
            label6.Name = "label6";
            label6.Size = new Size(113, 46);
            label6.TabIndex = 128;
            label6.Text = "Kun2:";
            // 
            // button2
            // 
            button2.BackColor = Color.LightSkyBlue;
            button2.Font = new Font("Trebuchet MS", 18F);
            button2.Location = new Point(233, 234);
            button2.Name = "button2";
            button2.Size = new Size(406, 47);
            button2.TabIndex = 129;
            button2.Text = "Ma'lumot";
            button2.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(255, 255, 192);
            label8.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label8.Location = new Point(421, 314);
            label8.Name = "label8";
            label8.Size = new Size(97, 38);
            label8.TabIndex = 131;
            label8.Text = "          ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Trebuchet MS", 22.2F);
            label9.Location = new Point(233, 306);
            label9.Name = "label9";
            label9.Size = new Size(156, 46);
            label9.TabIndex = 130;
            label9.Text = "Tushum:";
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
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(91, 167);
            panel2.Name = "panel2";
            panel2.Size = new Size(917, 565);
            panel2.TabIndex = 132;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 255, 192);
            label4.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label4.Location = new Point(421, 370);
            label4.Name = "label4";
            label4.Size = new Size(97, 38);
            label4.TabIndex = 143;
            label4.Text = "          ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 22.2F);
            label5.Location = new Point(233, 370);
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
            label2.Location = new Point(421, 440);
            label2.Name = "label2";
            label2.Size = new Size(97, 38);
            label2.TabIndex = 141;
            label2.Text = "          ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 22.2F);
            label3.Location = new Point(233, 432);
            label3.Name = "label3";
            label3.Size = new Size(108, 46);
            label3.TabIndex = 140;
            label3.Text = "Vaqt:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(358, 120);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(281, 27);
            dateTimePicker1.TabIndex = 139;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 22.2F);
            label1.Location = new Point(233, 105);
            label1.Name = "label1";
            label1.Size = new Size(113, 46);
            label1.TabIndex = 138;
            label1.Text = "Kun1:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(358, 178);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(281, 27);
            dateTimePicker2.TabIndex = 137;
            // 
            // button9
            // 
            button9.BackColor = Color.LightSkyBlue;
            button9.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button9.Location = new Point(1693, 222);
            button9.Name = "button9";
            button9.Size = new Size(160, 49);
            button9.TabIndex = 136;
            button9.Text = "Qaytarish";
            button9.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.LightSkyBlue;
            button7.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button7.Location = new Point(1516, 222);
            button7.Name = "button7";
            button7.Size = new Size(160, 49);
            button7.TabIndex = 135;
            button7.Text = "Kamayish";
            button7.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSkyBlue;
            button3.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.Location = new Point(1341, 222);
            button3.Name = "button3";
            button3.Size = new Size(160, 49);
            button3.TabIndex = 134;
            button3.Text = "O'sish";
            button3.UseVisualStyleBackColor = false;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "O'sish", "Kamayish" });
            comboBox3.Location = new Point(1047, 222);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(279, 49);
            comboBox3.TabIndex = 133;
            // 
            // SalesmanReportsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1924, 1033);
            Controls.Add(button9);
            Controls.Add(button7);
            Controls.Add(button3);
            Controls.Add(comboBox3);
            Controls.Add(panel2);
            Controls.Add(btBack);
            Controls.Add(btExit);
            Controls.Add(cbSearch);
            Controls.Add(btSearch);
            Controls.Add(txPillName);
            Name = "SalesmanReportsForm";
            Text = "SalesmanReportsForm";
            Load += SalesmanReportsForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbSearch;
        private Button btSearch;
        private TextBox txPillName;
        private Button btExit;
        private Button btBack;
        private Label label6;
        private Button button2;
        private Label label8;
        private Label label9;
        private Panel panel2;
        private Button button9;
        private Button button7;
        private Button button3;
        private ComboBox comboBox3;
        private Label label4;
        private Label label5;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private DateTimePicker dateTimePicker2;
    }
}