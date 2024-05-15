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
            label4 = new Label();
            panel3 = new Panel();
            btDeletePill = new Button();
            txDeletePillName = new TextBox();
            lbDeletePillName = new Label();
            btBack = new Button();
            lbFIO = new Label();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 24F);
            label4.Location = new Point(260, 23);
            label4.Name = "label4";
            label4.Size = new Size(252, 49);
            label4.TabIndex = 61;
            label4.Text = "Dori o'chirish";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightCyan;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(btDeletePill);
            panel3.Controls.Add(txDeletePillName);
            panel3.Controls.Add(lbDeletePillName);
            panel3.Location = new Point(588, 195);
            panel3.Name = "panel3";
            panel3.Size = new Size(741, 685);
            panel3.TabIndex = 60;
            // 
            // btDeletePill
            // 
            btDeletePill.BackColor = Color.Tomato;
            btDeletePill.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btDeletePill.Location = new Point(57, 558);
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
            txDeletePillName.Location = new Point(420, 291);
            txDeletePillName.Name = "txDeletePillName";
            txDeletePillName.Size = new Size(258, 48);
            txDeletePillName.TabIndex = 58;
            // 
            // lbDeletePillName
            // 
            lbDeletePillName.AutoSize = true;
            lbDeletePillName.Font = new Font("Trebuchet MS", 22.2F);
            lbDeletePillName.Location = new Point(57, 289);
            lbDeletePillName.Name = "lbDeletePillName";
            lbDeletePillName.Size = new Size(357, 46);
            lbDeletePillName.TabIndex = 57;
            lbDeletePillName.Text = "Dori nomini kiriting:";
            // 
            // btBack
            // 
            btBack.BackColor = Color.Silver;
            btBack.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btBack.Location = new Point(1592, 926);
            btBack.Name = "btBack";
            btBack.Size = new Size(249, 53);
            btBack.TabIndex = 61;
            btBack.Text = "Orqaga qaytish";
            btBack.UseVisualStyleBackColor = false;
            btBack.Click += btBack_Click;
            // 
            // lbFIO
            // 
            lbFIO.AutoSize = true;
            lbFIO.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbFIO.Location = new Point(12, 9);
            lbFIO.Name = "lbFIO";
            lbFIO.Size = new Size(61, 38);
            lbFIO.TabIndex = 62;
            lbFIO.Text = "FIO";
            // 
            // DeletePillForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1917, 1033);
            Controls.Add(lbFIO);
            Controls.Add(btBack);
            Controls.Add(panel3);
            Name = "DeletePillForm";
            Text = "DeletePillForm";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Panel panel3;
        private Button btDeletePill;
        private TextBox txDeletePillName;
        private Label lbDeletePillName;
        private Button btBack;
        private Label lbFIO;
    }
}