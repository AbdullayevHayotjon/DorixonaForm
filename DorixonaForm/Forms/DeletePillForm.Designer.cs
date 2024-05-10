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
            btDeletePill = new Button();
            txDeletePillName = new TextBox();
            lbDeletePillName = new Label();
            btBack = new Button();
            SuspendLayout();
            // 
            // btDeletePill
            // 
            btDeletePill.BackColor = Color.LightSkyBlue;
            btDeletePill.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btDeletePill.Location = new Point(402, 427);
            btDeletePill.Name = "btDeletePill";
            btDeletePill.Size = new Size(677, 60);
            btDeletePill.TabIndex = 55;
            btDeletePill.Text = "O'chirish";
            btDeletePill.UseVisualStyleBackColor = false;
            btDeletePill.Click += btDeletePill_Click;
            // 
            // txDeletePillName
            // 
            txDeletePillName.BackColor = Color.FromArgb(255, 255, 192);
            txDeletePillName.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txDeletePillName.Location = new Point(765, 351);
            txDeletePillName.Name = "txDeletePillName";
            txDeletePillName.Size = new Size(314, 48);
            txDeletePillName.TabIndex = 52;
            txDeletePillName.TextChanged += txDeletePillName_TextChanged;
            // 
            // lbDeletePillName
            // 
            lbDeletePillName.AutoSize = true;
            lbDeletePillName.Font = new Font("Trebuchet MS", 22.2F);
            lbDeletePillName.Location = new Point(402, 349);
            lbDeletePillName.Name = "lbDeletePillName";
            lbDeletePillName.Size = new Size(357, 46);
            lbDeletePillName.TabIndex = 49;
            lbDeletePillName.Text = "Dori nomini kiriting:";
            // 
            // btBack
            // 
            btBack.BackColor = Color.Silver;
            btBack.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btBack.Location = new Point(830, 514);
            btBack.Name = "btBack";
            btBack.Size = new Size(249, 53);
            btBack.TabIndex = 48;
            btBack.Text = "Orqaga qaytish";
            btBack.UseVisualStyleBackColor = false;
            btBack.Click += btBack_Click;
            // 
            // DeletePillForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1482, 903);
            Controls.Add(btDeletePill);
            Controls.Add(txDeletePillName);
            Controls.Add(lbDeletePillName);
            Controls.Add(btBack);
            Name = "DeletePillForm";
            Text = "DeletePillForm";
            Load += DeletePillForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btDeletePill;
        private TextBox txDeletePillName;
        private Label lbDeletePillName;
        private Button btBack;
    }
}