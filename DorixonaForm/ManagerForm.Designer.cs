namespace DorixonaForm.Forms
{
    partial class ManagerForm
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
            btReports = new Button();
            btDeleteSalesman = new Button();
            btSettings = new Button();
            btAddSalesman = new Button();
            btExit = new Button();
            SuspendLayout();
            // 
            // btReports
            // 
            btReports.BackColor = Color.LightSkyBlue;
            btReports.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btReports.Location = new Point(476, 421);
            btReports.Name = "btReports";
            btReports.Size = new Size(600, 60);
            btReports.TabIndex = 10;
            btReports.Text = "Hisobotlar";
            btReports.UseVisualStyleBackColor = false;
            // 
            // btDeleteSalesman
            // 
            btDeleteSalesman.BackColor = Color.LightSkyBlue;
            btDeleteSalesman.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btDeleteSalesman.Location = new Point(476, 342);
            btDeleteSalesman.Name = "btDeleteSalesman";
            btDeleteSalesman.Size = new Size(600, 60);
            btDeleteSalesman.TabIndex = 11;
            btDeleteSalesman.Text = "Sotuvchi o'chirish";
            btDeleteSalesman.UseVisualStyleBackColor = false;
            // 
            // btSettings
            // 
            btSettings.BackColor = Color.LightSkyBlue;
            btSettings.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btSettings.Location = new Point(476, 504);
            btSettings.Name = "btSettings";
            btSettings.Size = new Size(600, 60);
            btSettings.TabIndex = 13;
            btSettings.Text = "Sozlamalar";
            btSettings.UseVisualStyleBackColor = false;
            // 
            // btAddSalesman
            // 
            btAddSalesman.BackColor = Color.LightSkyBlue;
            btAddSalesman.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btAddSalesman.Location = new Point(476, 265);
            btAddSalesman.Name = "btAddSalesman";
            btAddSalesman.Size = new Size(600, 60);
            btAddSalesman.TabIndex = 14;
            btAddSalesman.Text = "Sotuvchi qo'shish";
            btAddSalesman.UseVisualStyleBackColor = false;
            // 
            // btExit
            // 
            btExit.BackColor = Color.LightSkyBlue;
            btExit.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btExit.Location = new Point(476, 587);
            btExit.Name = "btExit";
            btExit.Size = new Size(600, 60);
            btExit.TabIndex = 18;
            btExit.Text = "Chiqish";
            btExit.UseVisualStyleBackColor = false;
            btExit.Click += btExit_Click;
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1482, 903);
            Controls.Add(btExit);
            Controls.Add(btAddSalesman);
            Controls.Add(btSettings);
            Controls.Add(btDeleteSalesman);
            Controls.Add(btReports);
            Name = "ManagerForm";
            Text = "ManagerForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btReports;
        private Button btDeleteSalesman;
        private Button btSettings;
        private Button btAddSalesman;
        private Button btExit;
    }
}