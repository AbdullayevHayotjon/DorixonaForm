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
            btAddPill = new Button();
            txAddPillPrice = new TextBox();
            lbAddPillPrice = new Label();
            txAddPillName = new TextBox();
            txAddPillCount = new TextBox();
            lbAddPillCount = new Label();
            lbAddPillName = new Label();
            btBack = new Button();
            SuspendLayout();
            // 
            // btAddPill
            // 
            btAddPill.BackColor = Color.LightSkyBlue;
            btAddPill.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btAddPill.Location = new Point(390, 491);
            btAddPill.Name = "btAddPill";
            btAddPill.Size = new Size(677, 60);
            btAddPill.TabIndex = 47;
            btAddPill.Text = "Saqlash";
            btAddPill.UseVisualStyleBackColor = false;
            btAddPill.Click += btAddPill_Click;
            // 
            // txAddPillPrice
            // 
            txAddPillPrice.BackColor = Color.FromArgb(255, 255, 192);
            txAddPillPrice.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txAddPillPrice.Location = new Point(753, 416);
            txAddPillPrice.Name = "txAddPillPrice";
            txAddPillPrice.Size = new Size(314, 48);
            txAddPillPrice.TabIndex = 46;
            // 
            // lbAddPillPrice
            // 
            lbAddPillPrice.AutoSize = true;
            lbAddPillPrice.Font = new Font("Trebuchet MS", 22.2F);
            lbAddPillPrice.Location = new Point(390, 414);
            lbAddPillPrice.Name = "lbAddPillPrice";
            lbAddPillPrice.Size = new Size(358, 46);
            lbAddPillPrice.TabIndex = 45;
            lbAddPillPrice.Text = "Dori narxini kiriting:";
            // 
            // txAddPillName
            // 
            txAddPillName.BackColor = Color.FromArgb(255, 255, 192);
            txAddPillName.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txAddPillName.Location = new Point(753, 274);
            txAddPillName.Name = "txAddPillName";
            txAddPillName.Size = new Size(314, 48);
            txAddPillName.TabIndex = 44;
            // 
            // txAddPillCount
            // 
            txAddPillCount.BackColor = Color.FromArgb(255, 255, 192);
            txAddPillCount.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txAddPillCount.Location = new Point(753, 341);
            txAddPillCount.Name = "txAddPillCount";
            txAddPillCount.Size = new Size(314, 48);
            txAddPillCount.TabIndex = 43;
            // 
            // lbAddPillCount
            // 
            lbAddPillCount.AutoSize = true;
            lbAddPillCount.Font = new Font("Trebuchet MS", 22.2F);
            lbAddPillCount.Location = new Point(390, 339);
            lbAddPillCount.Name = "lbAddPillCount";
            lbAddPillCount.Size = new Size(341, 46);
            lbAddPillCount.TabIndex = 42;
            lbAddPillCount.Text = "Dori sonini kiriting:";
            // 
            // lbAddPillName
            // 
            lbAddPillName.AutoSize = true;
            lbAddPillName.Font = new Font("Trebuchet MS", 22.2F);
            lbAddPillName.Location = new Point(390, 272);
            lbAddPillName.Name = "lbAddPillName";
            lbAddPillName.Size = new Size(357, 46);
            lbAddPillName.TabIndex = 41;
            lbAddPillName.Text = "Dori nomini kiriting:";
            // 
            // btBack
            // 
            btBack.BackColor = Color.Silver;
            btBack.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btBack.Location = new Point(818, 571);
            btBack.Name = "btBack";
            btBack.Size = new Size(249, 53);
            btBack.TabIndex = 40;
            btBack.Text = "Orqaga qaytish";
            btBack.UseVisualStyleBackColor = false;
            btBack.Click += btBack_Click;
            // 
            // AddPillForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1482, 903);
            Controls.Add(btAddPill);
            Controls.Add(txAddPillPrice);
            Controls.Add(lbAddPillPrice);
            Controls.Add(txAddPillName);
            Controls.Add(txAddPillCount);
            Controls.Add(lbAddPillCount);
            Controls.Add(lbAddPillName);
            Controls.Add(btBack);
            Name = "AddPillForm";
            Text = "AddPillForm";
            Load += AddPillForm_Load;
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
    }
}