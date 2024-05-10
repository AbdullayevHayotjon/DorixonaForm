namespace DorixonaForm.Forms
{
    partial class SellPillForm
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
            components = new System.ComponentModel.Container();
            dGWSellPill = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soniDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            narxiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pillBindingSource = new BindingSource(components);
            btConfirmation = new Button();
            btBack = new Button();
            panel1 = new Panel();
            lbFIO = new Label();
            ((System.ComponentModel.ISupportInitialize)dGWSellPill).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dGWSellPill
            // 
            dGWSellPill.AutoGenerateColumns = false;
            dGWSellPill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGWSellPill.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomiDataGridViewTextBoxColumn, soniDataGridViewTextBoxColumn, narxiDataGridViewTextBoxColumn });
            dGWSellPill.DataSource = pillBindingSource;
            dGWSellPill.Location = new Point(58, 56);
            dGWSellPill.Name = "dGWSellPill";
            dGWSellPill.ReadOnly = true;
            dGWSellPill.RowHeadersWidth = 100;
            dGWSellPill.Size = new Size(604, 547);
            dGWSellPill.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomiDataGridViewTextBoxColumn
            // 
            nomiDataGridViewTextBoxColumn.DataPropertyName = "Nomi";
            nomiDataGridViewTextBoxColumn.HeaderText = "Nomi";
            nomiDataGridViewTextBoxColumn.MinimumWidth = 6;
            nomiDataGridViewTextBoxColumn.Name = "nomiDataGridViewTextBoxColumn";
            nomiDataGridViewTextBoxColumn.ReadOnly = true;
            nomiDataGridViewTextBoxColumn.Width = 125;
            // 
            // soniDataGridViewTextBoxColumn
            // 
            soniDataGridViewTextBoxColumn.DataPropertyName = "Soni";
            soniDataGridViewTextBoxColumn.HeaderText = "Soni";
            soniDataGridViewTextBoxColumn.MinimumWidth = 6;
            soniDataGridViewTextBoxColumn.Name = "soniDataGridViewTextBoxColumn";
            soniDataGridViewTextBoxColumn.ReadOnly = true;
            soniDataGridViewTextBoxColumn.Width = 125;
            // 
            // narxiDataGridViewTextBoxColumn
            // 
            narxiDataGridViewTextBoxColumn.DataPropertyName = "Narxi";
            narxiDataGridViewTextBoxColumn.HeaderText = "Narxi";
            narxiDataGridViewTextBoxColumn.MinimumWidth = 6;
            narxiDataGridViewTextBoxColumn.Name = "narxiDataGridViewTextBoxColumn";
            narxiDataGridViewTextBoxColumn.ReadOnly = true;
            narxiDataGridViewTextBoxColumn.Width = 125;
            // 
            // pillBindingSource
            // 
            pillBindingSource.DataSource = typeof(Actions.Pill);
            // 
            // btConfirmation
            // 
            btConfirmation.BackColor = Color.LightSkyBlue;
            btConfirmation.Font = new Font("Trebuchet MS", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btConfirmation.Location = new Point(58, 638);
            btConfirmation.Name = "btConfirmation";
            btConfirmation.Size = new Size(604, 57);
            btConfirmation.TabIndex = 28;
            btConfirmation.Text = "Sotish";
            btConfirmation.UseVisualStyleBackColor = false;
            btConfirmation.Click += btConfirmation_Click;
            // 
            // btBack
            // 
            btBack.BackColor = Color.Silver;
            btBack.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btBack.Location = new Point(429, 721);
            btBack.Name = "btBack";
            btBack.Size = new Size(233, 53);
            btBack.TabIndex = 42;
            btBack.Text = "Orqaga qaytish";
            btBack.UseVisualStyleBackColor = false;
            btBack.Click += btBack_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(dGWSellPill);
            panel1.Controls.Add(btBack);
            panel1.Controls.Add(btConfirmation);
            panel1.Location = new Point(619, 144);
            panel1.Name = "panel1";
            panel1.Size = new Size(716, 832);
            panel1.TabIndex = 43;
            panel1.Paint += panel1_Paint;
            // 
            // lbFIO
            // 
            lbFIO.AutoSize = true;
            lbFIO.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbFIO.Location = new Point(12, 9);
            lbFIO.Name = "lbFIO";
            lbFIO.Size = new Size(61, 38);
            lbFIO.TabIndex = 44;
            lbFIO.Text = "FIO";
            lbFIO.Click += lbFIO_Click;
            // 
            // SellPillForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1917, 1158);
            Controls.Add(lbFIO);
            Controls.Add(panel1);
            Name = "SellPillForm";
            Text = "SellPillForm";
            Load += SellPillForm_Load;
            ((System.ComponentModel.ISupportInitialize)dGWSellPill).EndInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dGWSellPill;
        private BindingSource pillBindingSource;
        private Button btConfirmation;
        private Button btBack;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn narxiDataGridViewTextBoxColumn;
        private Panel panel1;
        private Label lbFIO;
    }
}