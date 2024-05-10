namespace DorixonaForm.Forms
{
    partial class ChangePillForm
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
            btAddPill = new Button();
            txAddPillPrice = new TextBox();
            lbAddPillPrice = new Label();
            txAddPillName = new TextBox();
            txAddPillCount = new TextBox();
            lbAddPillCount = new Label();
            lbAddPillName = new Label();
            btBack = new Button();
            txLifeTime = new TextBox();
            lbLifeTime = new Label();
            panel1 = new Panel();
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
            panel3 = new Panel();
            btDeletePill = new Button();
            txDeletePillName = new TextBox();
            lbDeletePillName = new Label();
            lbFIO = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btAddPill
            // 
            btAddPill.BackColor = Color.FromArgb(128, 255, 128);
            btAddPill.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btAddPill.Location = new Point(40, 327);
            btAddPill.Name = "btAddPill";
            btAddPill.Size = new Size(677, 60);
            btAddPill.TabIndex = 47;
            btAddPill.Text = "Qo'shish";
            btAddPill.UseVisualStyleBackColor = false;
            btAddPill.Click += btAddPill_Click;
            // 
            // txAddPillPrice
            // 
            txAddPillPrice.BackColor = Color.FromArgb(255, 255, 192);
            txAddPillPrice.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txAddPillPrice.Location = new Point(459, 255);
            txAddPillPrice.Name = "txAddPillPrice";
            txAddPillPrice.Size = new Size(258, 48);
            txAddPillPrice.TabIndex = 46;
            // 
            // lbAddPillPrice
            // 
            lbAddPillPrice.AutoSize = true;
            lbAddPillPrice.Font = new Font("Trebuchet MS", 22.2F);
            lbAddPillPrice.Location = new Point(40, 253);
            lbAddPillPrice.Name = "lbAddPillPrice";
            lbAddPillPrice.Size = new Size(358, 46);
            lbAddPillPrice.TabIndex = 45;
            lbAddPillPrice.Text = "Dori narxini kiriting:";
            // 
            // txAddPillName
            // 
            txAddPillName.BackColor = Color.FromArgb(255, 255, 192);
            txAddPillName.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txAddPillName.Location = new Point(459, 50);
            txAddPillName.Name = "txAddPillName";
            txAddPillName.Size = new Size(258, 48);
            txAddPillName.TabIndex = 44;
            // 
            // txAddPillCount
            // 
            txAddPillCount.BackColor = Color.FromArgb(255, 255, 192);
            txAddPillCount.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txAddPillCount.Location = new Point(459, 120);
            txAddPillCount.Name = "txAddPillCount";
            txAddPillCount.Size = new Size(258, 48);
            txAddPillCount.TabIndex = 43;
            // 
            // lbAddPillCount
            // 
            lbAddPillCount.AutoSize = true;
            lbAddPillCount.Font = new Font("Trebuchet MS", 22.2F);
            lbAddPillCount.Location = new Point(40, 118);
            lbAddPillCount.Name = "lbAddPillCount";
            lbAddPillCount.Size = new Size(341, 46);
            lbAddPillCount.TabIndex = 42;
            lbAddPillCount.Text = "Dori sonini kiriting:";
            // 
            // lbAddPillName
            // 
            lbAddPillName.AutoSize = true;
            lbAddPillName.Font = new Font("Trebuchet MS", 22.2F);
            lbAddPillName.Location = new Point(40, 48);
            lbAddPillName.Name = "lbAddPillName";
            lbAddPillName.Size = new Size(357, 46);
            lbAddPillName.TabIndex = 41;
            lbAddPillName.Text = "Dori nomini kiriting:";
            // 
            // btBack
            // 
            btBack.BackColor = Color.Silver;
            btBack.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btBack.Location = new Point(1566, 982);
            btBack.Name = "btBack";
            btBack.Size = new Size(249, 53);
            btBack.TabIndex = 40;
            btBack.Text = "Orqaga qaytish";
            btBack.UseVisualStyleBackColor = false;
            btBack.Click += btBack_Click;
            // 
            // txLifeTime
            // 
            txLifeTime.BackColor = Color.FromArgb(255, 255, 192);
            txLifeTime.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txLifeTime.Location = new Point(459, 186);
            txLifeTime.Name = "txLifeTime";
            txLifeTime.Size = new Size(258, 48);
            txLifeTime.TabIndex = 49;
            // 
            // lbLifeTime
            // 
            lbLifeTime.AutoSize = true;
            lbLifeTime.Font = new Font("Trebuchet MS", 22.2F);
            lbLifeTime.Location = new Point(40, 184);
            lbLifeTime.Name = "lbLifeTime";
            lbLifeTime.Size = new Size(413, 46);
            lbLifeTime.TabIndex = 48;
            lbLifeTime.Text = "Dori muddatini kiriting:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(txLifeTime);
            panel1.Controls.Add(lbAddPillName);
            panel1.Controls.Add(lbLifeTime);
            panel1.Controls.Add(lbAddPillCount);
            panel1.Controls.Add(btAddPill);
            panel1.Controls.Add(txAddPillCount);
            panel1.Controls.Add(txAddPillPrice);
            panel1.Controls.Add(txAddPillName);
            panel1.Controls.Add(lbAddPillPrice);
            panel1.Location = new Point(96, 170);
            panel1.Name = "panel1";
            panel1.Size = new Size(757, 436);
            panel1.TabIndex = 50;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCyan;
            panel2.Controls.Add(txUpdatePillLifeTime);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btUpdatePill);
            panel2.Controls.Add(txUpdatePillPrice);
            panel2.Controls.Add(lbUpdatePillPrice);
            panel2.Controls.Add(txUpdatePillName);
            panel2.Controls.Add(txUpdatePillCount);
            panel2.Controls.Add(lbUpdatePillCount);
            panel2.Controls.Add(lbUpdatePillName);
            panel2.Location = new Point(958, 170);
            panel2.Name = "panel2";
            panel2.Size = new Size(857, 436);
            panel2.TabIndex = 51;
            // 
            // txUpdatePillLifeTime
            // 
            txUpdatePillLifeTime.BackColor = Color.FromArgb(255, 255, 192);
            txUpdatePillLifeTime.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txUpdatePillLifeTime.Location = new Point(550, 186);
            txUpdatePillLifeTime.Name = "txUpdatePillLifeTime";
            txUpdatePillLifeTime.Size = new Size(258, 48);
            txUpdatePillLifeTime.TabIndex = 67;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 22.2F);
            label1.Location = new Point(33, 184);
            label1.Name = "label1";
            label1.Size = new Size(511, 46);
            label1.TabIndex = 66;
            label1.Text = "Dori yangi muddatini kiriting:";
            // 
            // btUpdatePill
            // 
            btUpdatePill.BackColor = Color.FromArgb(255, 192, 128);
            btUpdatePill.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btUpdatePill.Location = new Point(33, 327);
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
            txUpdatePillPrice.Location = new Point(550, 255);
            txUpdatePillPrice.Name = "txUpdatePillPrice";
            txUpdatePillPrice.Size = new Size(259, 48);
            txUpdatePillPrice.TabIndex = 64;
            // 
            // lbUpdatePillPrice
            // 
            lbUpdatePillPrice.AutoSize = true;
            lbUpdatePillPrice.Font = new Font("Trebuchet MS", 22.2F);
            lbUpdatePillPrice.Location = new Point(33, 253);
            lbUpdatePillPrice.Name = "lbUpdatePillPrice";
            lbUpdatePillPrice.Size = new Size(456, 46);
            lbUpdatePillPrice.TabIndex = 63;
            lbUpdatePillPrice.Text = "Dori yangi narxini kiriting:";
            // 
            // txUpdatePillName
            // 
            txUpdatePillName.BackColor = Color.FromArgb(255, 255, 192);
            txUpdatePillName.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txUpdatePillName.Location = new Point(550, 50);
            txUpdatePillName.Name = "txUpdatePillName";
            txUpdatePillName.Size = new Size(259, 48);
            txUpdatePillName.TabIndex = 62;
            // 
            // txUpdatePillCount
            // 
            txUpdatePillCount.BackColor = Color.FromArgb(255, 255, 192);
            txUpdatePillCount.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txUpdatePillCount.Location = new Point(550, 120);
            txUpdatePillCount.Name = "txUpdatePillCount";
            txUpdatePillCount.Size = new Size(259, 48);
            txUpdatePillCount.TabIndex = 61;
            // 
            // lbUpdatePillCount
            // 
            lbUpdatePillCount.AutoSize = true;
            lbUpdatePillCount.Font = new Font("Trebuchet MS", 22.2F);
            lbUpdatePillCount.Location = new Point(33, 118);
            lbUpdatePillCount.Name = "lbUpdatePillCount";
            lbUpdatePillCount.Size = new Size(439, 46);
            lbUpdatePillCount.TabIndex = 60;
            lbUpdatePillCount.Text = "Dori yangi sonini kiriting:";
            // 
            // lbUpdatePillName
            // 
            lbUpdatePillName.AutoSize = true;
            lbUpdatePillName.Font = new Font("Trebuchet MS", 22.2F);
            lbUpdatePillName.Location = new Point(33, 48);
            lbUpdatePillName.Name = "lbUpdatePillName";
            lbUpdatePillName.Size = new Size(357, 46);
            lbUpdatePillName.TabIndex = 59;
            lbUpdatePillName.Text = "Dori nomini kiriting:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightCyan;
            panel3.Controls.Add(btDeletePill);
            panel3.Controls.Add(txDeletePillName);
            panel3.Controls.Add(lbDeletePillName);
            panel3.Location = new Point(566, 759);
            panel3.Name = "panel3";
            panel3.Size = new Size(741, 276);
            panel3.TabIndex = 52;
            // 
            // btDeletePill
            // 
            btDeletePill.BackColor = Color.Tomato;
            btDeletePill.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btDeletePill.Location = new Point(57, 147);
            btDeletePill.Name = "btDeletePill";
            btDeletePill.Size = new Size(621, 60);
            btDeletePill.TabIndex = 59;
            btDeletePill.Text = "O'chirish";
            btDeletePill.UseVisualStyleBackColor = false;
            btDeletePill.Click += btDeletePill_Click;
            // 
            // txDeletePillName
            // 
            txDeletePillName.BackColor = Color.FromArgb(255, 255, 192);
            txDeletePillName.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txDeletePillName.Location = new Point(420, 71);
            txDeletePillName.Name = "txDeletePillName";
            txDeletePillName.Size = new Size(258, 48);
            txDeletePillName.TabIndex = 58;
            // 
            // lbDeletePillName
            // 
            lbDeletePillName.AutoSize = true;
            lbDeletePillName.Font = new Font("Trebuchet MS", 22.2F);
            lbDeletePillName.Location = new Point(57, 69);
            lbDeletePillName.Name = "lbDeletePillName";
            lbDeletePillName.Size = new Size(357, 46);
            lbDeletePillName.TabIndex = 57;
            lbDeletePillName.Text = "Dori nomini kiriting:";
            // 
            // lbFIO
            // 
            lbFIO.AutoSize = true;
            lbFIO.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbFIO.Location = new Point(12, 9);
            lbFIO.Name = "lbFIO";
            lbFIO.Size = new Size(61, 38);
            lbFIO.TabIndex = 53;
            lbFIO.Text = "FIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 24F);
            label2.Location = new Point(343, 108);
            label2.Name = "label2";
            label2.Size = new Size(243, 49);
            label2.TabIndex = 57;
            label2.Text = "Dori qo'shish";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 24F);
            label3.Location = new Point(1263, 108);
            label3.Name = "label3";
            label3.Size = new Size(272, 49);
            label3.TabIndex = 58;
            label3.Text = "Dori yangilash";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 24F);
            label4.Location = new Point(825, 693);
            label4.Name = "label4";
            label4.Size = new Size(252, 49);
            label4.TabIndex = 59;
            label4.Text = "Dori o'chirish";
            // 
            // ChangePillForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1917, 1158);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbFIO);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btBack);
            Name = "ChangePillForm";
            Text = "ChangePillForm";
            Load += AddPillForm_Load;
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

        private Button btAddPill;
        private TextBox txAddPillPrice;
        private Label lbAddPillPrice;
        private TextBox txAddPillName;
        private TextBox txAddPillCount;
        private Label lbAddPillCount;
        private Label lbAddPillName;
        private Button btBack;
        private TextBox txLifeTime;
        private Label lbLifeTime;
        private Panel panel1;
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
        private Panel panel3;
        private Button btDeletePill;
        private TextBox txDeletePillName;
        private Label lbDeletePillName;
        private Label lbFIO;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}