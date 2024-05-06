namespace DorixonaForm
{
    partial class PillListForm
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
            DtgPlist = new DataGridView();
            btOrqaga = new Button();
            ((System.ComponentModel.ISupportInitialize)DtgPlist).BeginInit();
            SuspendLayout();
            // 
            // DtgPlist
            // 
            DtgPlist.BackgroundColor = Color.LightCyan;
            DtgPlist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtgPlist.Location = new Point(0, 0);
            DtgPlist.Name = "DtgPlist";
            DtgPlist.RowHeadersWidth = 51;
            DtgPlist.Size = new Size(940, 366);
            DtgPlist.TabIndex = 0;
            DtgPlist.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btOrqaga
            // 
            btOrqaga.BackColor = Color.LightSkyBlue;
            btOrqaga.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btOrqaga.Location = new Point(327, 372);
            btOrqaga.Name = "btOrqaga";
            btOrqaga.Size = new Size(270, 60);
            btOrqaga.TabIndex = 21;
            btOrqaga.Text = "Back";
            btOrqaga.UseVisualStyleBackColor = false;
            btOrqaga.Click += btOrqaga_Click;
            // 
            // PillListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(939, 558);
            Controls.Add(btOrqaga);
            Controls.Add(DtgPlist);
            Name = "PillListForm";
            Text = "PillListForm";
            ((System.ComponentModel.ISupportInitialize)DtgPlist).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DtgPlist;
        private Button btOrqaga;
    }
}