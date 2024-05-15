namespace DorixonaForm.Forms
{
    partial class AddPillForm
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
            label2 = new Label();
            panel1 = new Panel();
            txLifeTime = new TextBox();
            lbAddPillName = new Label();
            lbLifeTime = new Label();
            lbAddPillCount = new Label();
            btAddPill = new Button();
            txAddPillCount = new TextBox();
            txAddPillPrice = new TextBox();
            txAddPillName = new TextBox();
            lbAddPillPrice = new Label();
            lbFIO = new Label();
            btBack = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 24F);
            label2.Location = new Point(261, 26);
            label2.Name = "label2";
            label2.Size = new Size(243, 49);
            label2.TabIndex = 59;
            label2.Text = "Dori qo'shish";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txLifeTime);
            panel1.Controls.Add(lbAddPillName);
            panel1.Controls.Add(lbLifeTime);
            panel1.Controls.Add(lbAddPillCount);
            panel1.Controls.Add(btAddPill);
            panel1.Controls.Add(txAddPillCount);
            panel1.Controls.Add(txAddPillPrice);
            panel1.Controls.Add(txAddPillName);
            panel1.Controls.Add(lbAddPillPrice);
            panel1.Location = new Point(580, 136);
            panel1.Name = "panel1";
            panel1.Size = new Size(757, 743);
            panel1.TabIndex = 58;
            // 
            // txLifeTime
            // 
            txLifeTime.BackColor = Color.FromArgb(255, 255, 192);
            txLifeTime.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txLifeTime.Location = new Point(457, 351);
            txLifeTime.Name = "txLifeTime";
            txLifeTime.Size = new Size(258, 48);
            txLifeTime.TabIndex = 49;
            // 
            // lbAddPillName
            // 
            lbAddPillName.AutoSize = true;
            lbAddPillName.Font = new Font("Trebuchet MS", 22.2F);
            lbAddPillName.Location = new Point(38, 213);
            lbAddPillName.Name = "lbAddPillName";
            lbAddPillName.Size = new Size(357, 46);
            lbAddPillName.TabIndex = 41;
            lbAddPillName.Text = "Dori nomini kiriting:";
            // 
            // lbLifeTime
            // 
            lbLifeTime.AutoSize = true;
            lbLifeTime.Font = new Font("Trebuchet MS", 22.2F);
            lbLifeTime.Location = new Point(38, 349);
            lbLifeTime.Name = "lbLifeTime";
            lbLifeTime.Size = new Size(413, 46);
            lbLifeTime.TabIndex = 48;
            lbLifeTime.Text = "Dori muddatini kiriting:";
            // 
            // lbAddPillCount
            // 
            lbAddPillCount.AutoSize = true;
            lbAddPillCount.Font = new Font("Trebuchet MS", 22.2F);
            lbAddPillCount.Location = new Point(38, 283);
            lbAddPillCount.Name = "lbAddPillCount";
            lbAddPillCount.Size = new Size(341, 46);
            lbAddPillCount.TabIndex = 42;
            lbAddPillCount.Text = "Dori sonini kiriting:";
            // 
            // btAddPill
            // 
            btAddPill.BackColor = Color.FromArgb(128, 255, 128);
            btAddPill.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btAddPill.Location = new Point(38, 602);
            btAddPill.Name = "btAddPill";
            btAddPill.Size = new Size(677, 60);
            btAddPill.TabIndex = 47;
            btAddPill.Text = "Qo'shish";
            btAddPill.UseVisualStyleBackColor = false;
            btAddPill.Click += btAddPill_Click;
            // 
            // txAddPillCount
            // 
            txAddPillCount.BackColor = Color.FromArgb(255, 255, 192);
            txAddPillCount.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txAddPillCount.Location = new Point(457, 285);
            txAddPillCount.Name = "txAddPillCount";
            txAddPillCount.Size = new Size(258, 48);
            txAddPillCount.TabIndex = 43;
            // 
            // txAddPillPrice
            // 
            txAddPillPrice.BackColor = Color.FromArgb(255, 255, 192);
            txAddPillPrice.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txAddPillPrice.Location = new Point(457, 420);
            txAddPillPrice.Name = "txAddPillPrice";
            txAddPillPrice.Size = new Size(258, 48);
            txAddPillPrice.TabIndex = 46;
            // 
            // txAddPillName
            // 
            txAddPillName.BackColor = Color.FromArgb(255, 255, 192);
            txAddPillName.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txAddPillName.Location = new Point(457, 215);
            txAddPillName.Name = "txAddPillName";
            txAddPillName.Size = new Size(258, 48);
            txAddPillName.TabIndex = 44;
            // 
            // lbAddPillPrice
            // 
            lbAddPillPrice.AutoSize = true;
            lbAddPillPrice.Font = new Font("Trebuchet MS", 22.2F);
            lbAddPillPrice.Location = new Point(38, 418);
            lbAddPillPrice.Name = "lbAddPillPrice";
            lbAddPillPrice.Size = new Size(358, 46);
            lbAddPillPrice.TabIndex = 45;
            lbAddPillPrice.Text = "Dori narxini kiriting:";
            // 
            // lbFIO
            // 
            lbFIO.AutoSize = true;
            lbFIO.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbFIO.Location = new Point(12, 9);
            lbFIO.Name = "lbFIO";
            lbFIO.Size = new Size(61, 38);
            lbFIO.TabIndex = 59;
            lbFIO.Text = "FIO";
            // 
            // btBack
            // 
            btBack.BackColor = Color.Silver;
            btBack.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btBack.Location = new Point(1584, 909);
            btBack.Name = "btBack";
            btBack.Size = new Size(249, 53);
            btBack.TabIndex = 60;
            btBack.Text = "Orqaga qaytish";
            btBack.UseVisualStyleBackColor = false;
            btBack.Click += btBack_Click;
            // 
            // AddPillForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1917, 1033);
            Controls.Add(btBack);
            Controls.Add(lbFIO);
            Controls.Add(panel1);
            Name = "AddPillForm";
            Text = "AddPillForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Panel panel1;
        private TextBox txLifeTime;
        private Label lbAddPillName;
        private Label lbLifeTime;
        private Label lbAddPillCount;
        private Button btAddPill;
        private TextBox txAddPillCount;
        private TextBox txAddPillPrice;
        private TextBox txAddPillName;
        private Label lbAddPillPrice;
        private Label lbFIO;
        private Button btBack;
    }
}