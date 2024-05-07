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
            btUpdatePill = new Button();
            txUpdatePillPrice = new TextBox();
            lbUpdatePillPrice = new Label();
            txUpdatePillName = new TextBox();
            txUpdatePillCount = new TextBox();
            lbUpdatePillCount = new Label();
            lbUpdatePillName = new Label();
            btBack = new Button();
            SuspendLayout();
            // 
            // btUpdatePill
            // 
            btUpdatePill.BackColor = Color.LightSkyBlue;
            btUpdatePill.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btUpdatePill.Location = new Point(393, 483);
            btUpdatePill.Name = "btUpdatePill";
            btUpdatePill.Size = new Size(759, 60);
            btUpdatePill.TabIndex = 55;
            btUpdatePill.Text = "Yangilash";
            btUpdatePill.UseVisualStyleBackColor = false;
            btUpdatePill.Click += btUpdatePill_Click;
            // 
            // txUpdatePillPrice
            // 
            txUpdatePillPrice.BackColor = Color.FromArgb(255, 255, 192);
            txUpdatePillPrice.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txUpdatePillPrice.Location = new Point(838, 409);
            txUpdatePillPrice.Name = "txUpdatePillPrice";
            txUpdatePillPrice.Size = new Size(314, 48);
            txUpdatePillPrice.TabIndex = 54;
            // 
            // lbUpdatePillPrice
            // 
            lbUpdatePillPrice.AutoSize = true;
            lbUpdatePillPrice.Font = new Font("Trebuchet MS", 22.2F);
            lbUpdatePillPrice.Location = new Point(393, 407);
            lbUpdatePillPrice.Name = "lbUpdatePillPrice";
            lbUpdatePillPrice.Size = new Size(456, 46);
            lbUpdatePillPrice.TabIndex = 53;
            lbUpdatePillPrice.Text = "Dori yangi narxini kiriting:";
            // 
            // txUpdatePillName
            // 
            txUpdatePillName.BackColor = Color.FromArgb(255, 255, 192);
            txUpdatePillName.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txUpdatePillName.Location = new Point(838, 265);
            txUpdatePillName.Name = "txUpdatePillName";
            txUpdatePillName.Size = new Size(314, 48);
            txUpdatePillName.TabIndex = 52;
            // 
            // txUpdatePillCount
            // 
            txUpdatePillCount.BackColor = Color.FromArgb(255, 255, 192);
            txUpdatePillCount.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txUpdatePillCount.Location = new Point(838, 334);
            txUpdatePillCount.Name = "txUpdatePillCount";
            txUpdatePillCount.Size = new Size(314, 48);
            txUpdatePillCount.TabIndex = 51;
            // 
            // lbUpdatePillCount
            // 
            lbUpdatePillCount.AutoSize = true;
            lbUpdatePillCount.Font = new Font("Trebuchet MS", 22.2F);
            lbUpdatePillCount.Location = new Point(393, 332);
            lbUpdatePillCount.Name = "lbUpdatePillCount";
            lbUpdatePillCount.Size = new Size(439, 46);
            lbUpdatePillCount.TabIndex = 50;
            lbUpdatePillCount.Text = "Dori yangi sonini kiriting:";
            // 
            // lbUpdatePillName
            // 
            lbUpdatePillName.AutoSize = true;
            lbUpdatePillName.Font = new Font("Trebuchet MS", 22.2F);
            lbUpdatePillName.Location = new Point(393, 265);
            lbUpdatePillName.Name = "lbUpdatePillName";
            lbUpdatePillName.Size = new Size(357, 46);
            lbUpdatePillName.TabIndex = 49;
            lbUpdatePillName.Text = "Dori nomini kiriting:";
            // 
            // btBack
            // 
            btBack.BackColor = Color.Silver;
            btBack.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btBack.Location = new Point(903, 565);
            btBack.Name = "btBack";
            btBack.Size = new Size(249, 53);
            btBack.TabIndex = 48;
            btBack.Text = "Orqaga qaytish";
            btBack.UseVisualStyleBackColor = false;
            btBack.Click += btBack_Click;
            // 
            // UpdatePillForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1482, 903);
            Controls.Add(btUpdatePill);
            Controls.Add(txUpdatePillPrice);
            Controls.Add(lbUpdatePillPrice);
            Controls.Add(txUpdatePillName);
            Controls.Add(txUpdatePillCount);
            Controls.Add(lbUpdatePillCount);
            Controls.Add(lbUpdatePillName);
            Controls.Add(btBack);
            Name = "UpdatePillForm";
            Text = "UpdatePillForm";
            Load += UpdatePillForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btUpdatePill;
        private TextBox txUpdatePillPrice;
        private Label lbUpdatePillPrice;
        private TextBox txUpdatePillName;
        private TextBox txUpdatePillCount;
        private Label lbUpdatePillCount;
        private Label lbUpdatePillName;
        private Button btBack;
    }
}