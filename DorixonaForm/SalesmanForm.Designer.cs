namespace DorixonaForm
{
    partial class SalesmanForm
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
            btSettings = new Button();
            btExit = new Button();
            btDeletePill = new Button();
            btSellPill = new Button();
            btUpdatePill = new Button();
            SuspendLayout();
            // 
            // btAddPill
            // 
            btAddPill.BackColor = Color.LightSkyBlue;
            btAddPill.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btAddPill.Location = new Point(441, 348);
            btAddPill.Name = "btAddPill";
            btAddPill.Size = new Size(600, 60);
            btAddPill.TabIndex = 19;
            btAddPill.Text = "Dori qo'shish";
            btAddPill.UseVisualStyleBackColor = false;
            btAddPill.Click += btAddPill_Click;
            // 
            // btSettings
            // 
            btSettings.BackColor = Color.LightSkyBlue;
            btSettings.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btSettings.Location = new Point(441, 584);
            btSettings.Name = "btSettings";
            btSettings.Size = new Size(600, 60);
            btSettings.TabIndex = 18;
            btSettings.Text = "Sozlamalar";
            btSettings.UseVisualStyleBackColor = false;
            // 
            // btExit
            // 
            btExit.BackColor = Color.LightSkyBlue;
            btExit.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btExit.Location = new Point(441, 664);
            btExit.Name = "btExit";
            btExit.Size = new Size(600, 60);
            btExit.TabIndex = 17;
            btExit.Text = "Chiqish";
            btExit.UseVisualStyleBackColor = false;
            btExit.Click += btExit_Click;
            // 
            // btDeletePill
            // 
            btDeletePill.BackColor = Color.LightSkyBlue;
            btDeletePill.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btDeletePill.Location = new Point(441, 424);
            btDeletePill.Name = "btDeletePill";
            btDeletePill.Size = new Size(600, 60);
            btDeletePill.TabIndex = 16;
            btDeletePill.Text = "Dori o'chirish";
            btDeletePill.UseVisualStyleBackColor = false;
            // 
            // btSellPill
            // 
            btSellPill.BackColor = Color.LightSkyBlue;
            btSellPill.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btSellPill.Location = new Point(441, 269);
            btSellPill.Name = "btSellPill";
            btSellPill.Size = new Size(600, 60);
            btSellPill.TabIndex = 15;
            btSellPill.Text = "Dori sotish";
            btSellPill.UseVisualStyleBackColor = false;
            // 
            // btUpdatePill
            // 
            btUpdatePill.BackColor = Color.LightSkyBlue;
            btUpdatePill.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btUpdatePill.Location = new Point(441, 507);
            btUpdatePill.Name = "btUpdatePill";
            btUpdatePill.Size = new Size(600, 60);
            btUpdatePill.TabIndex = 20;
            btUpdatePill.Text = "Dori yangilash";
            btUpdatePill.UseVisualStyleBackColor = false;
            // 
            // SalesmanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1482, 903);
            Controls.Add(btUpdatePill);
            Controls.Add(btAddPill);
            Controls.Add(btSettings);
            Controls.Add(btExit);
            Controls.Add(btDeletePill);
            Controls.Add(btSellPill);
            Name = "SalesmanForm";
            Text = "SalesmanForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btAddPill;
        private Button btSettings;
        private Button btExit;
        private Button btDeletePill;
        private Button btSellPill;
        private Button btUpdatePill;
    }
}