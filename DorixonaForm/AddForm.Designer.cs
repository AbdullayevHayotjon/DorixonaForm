namespace DorixonaForm
{
    partial class AddForm
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
            lbName = new Label();
            lbPrice = new Label();
            lbQuantity = new Label();
            txName = new TextBox();
            txPrice = new TextBox();
            txQuantity = new TextBox();
            btAdd = new Button();
            SuspendLayout();
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbName.ForeColor = Color.Black;
            lbName.Location = new Point(98, 99);
            lbName.Name = "lbName";
            lbName.Size = new Size(347, 46);
            lbName.TabIndex = 7;
            lbName.Text = "Dori Nomini kiriting";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbPrice.ForeColor = Color.Black;
            lbPrice.Location = new Point(98, 208);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(270, 46);
            lbPrice.TabIndex = 14;
            lbPrice.Text = "Narxini Kiriting";
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbQuantity.ForeColor = Color.Black;
            lbQuantity.Location = new Point(98, 326);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(251, 46);
            lbQuantity.TabIndex = 15;
            lbQuantity.Text = "Sonini kiriting";
            // 
            // txName
            // 
            txName.BackColor = Color.FromArgb(255, 255, 192);
            txName.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txName.Location = new Point(491, 101);
            txName.Name = "txName";
            txName.Size = new Size(314, 48);
            txName.TabIndex = 17;
            // 
            // txPrice
            // 
            txPrice.BackColor = Color.FromArgb(255, 255, 192);
            txPrice.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txPrice.Location = new Point(491, 210);
            txPrice.Name = "txPrice";
            txPrice.Size = new Size(314, 48);
            txPrice.TabIndex = 16;
            // 
            // txQuantity
            // 
            txQuantity.BackColor = Color.FromArgb(255, 255, 192);
            txQuantity.Font = new Font("Calibri Light", 19.8000011F, FontStyle.Italic);
            txQuantity.Location = new Point(491, 324);
            txQuantity.Name = "txQuantity";
            txQuantity.Size = new Size(314, 48);
            txQuantity.TabIndex = 18;
            // 
            // btAdd
            // 
            btAdd.BackColor = Color.LightSkyBlue;
            btAdd.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btAdd.Location = new Point(279, 432);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(402, 60);
            btAdd.TabIndex = 19;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = false;
            btAdd.Click += btAdd_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(951, 573);
            Controls.Add(btAdd);
            Controls.Add(txQuantity);
            Controls.Add(txName);
            Controls.Add(txPrice);
            Controls.Add(lbQuantity);
            Controls.Add(lbPrice);
            Controls.Add(lbName);
            Name = "AddForm";
            Text = "AddForm";
            Load += AddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label lbName;
        private Label lbPrice;
        private Label lbQuantity;
        private TextBox txName;
        private TextBox txPrice;
        private TextBox txQuantity;
        private Button btAdd;
    }
}