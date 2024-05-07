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
            ((System.ComponentModel.ISupportInitialize)dGWSellPill).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dGWSellPill
            // 
            dGWSellPill.AutoGenerateColumns = false;
            dGWSellPill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGWSellPill.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomiDataGridViewTextBoxColumn, soniDataGridViewTextBoxColumn, narxiDataGridViewTextBoxColumn });
            dGWSellPill.DataSource = pillBindingSource;
            dGWSellPill.Location = new Point(448, 143);
            dGWSellPill.Name = "dGWSellPill";
            dGWSellPill.RowHeadersWidth = 100;
            dGWSellPill.Size = new Size(604, 151);
            dGWSellPill.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomiDataGridViewTextBoxColumn
            // 
            nomiDataGridViewTextBoxColumn.DataPropertyName = "Nomi";
            nomiDataGridViewTextBoxColumn.HeaderText = "Nomi";
            nomiDataGridViewTextBoxColumn.MinimumWidth = 6;
            nomiDataGridViewTextBoxColumn.Name = "nomiDataGridViewTextBoxColumn";
            nomiDataGridViewTextBoxColumn.Width = 125;
            // 
            // soniDataGridViewTextBoxColumn
            // 
            soniDataGridViewTextBoxColumn.DataPropertyName = "Soni";
            soniDataGridViewTextBoxColumn.HeaderText = "Soni";
            soniDataGridViewTextBoxColumn.MinimumWidth = 6;
            soniDataGridViewTextBoxColumn.Name = "soniDataGridViewTextBoxColumn";
            soniDataGridViewTextBoxColumn.Width = 125;
            // 
            // narxiDataGridViewTextBoxColumn
            // 
            narxiDataGridViewTextBoxColumn.DataPropertyName = "Narxi";
            narxiDataGridViewTextBoxColumn.HeaderText = "Narxi";
            narxiDataGridViewTextBoxColumn.MinimumWidth = 6;
            narxiDataGridViewTextBoxColumn.Name = "narxiDataGridViewTextBoxColumn";
            narxiDataGridViewTextBoxColumn.Width = 125;
            // 
            // pillBindingSource
            // 
            pillBindingSource.DataSource = typeof(Actions.Pill);
            // 
            // btConfirmation
            // 
            btConfirmation.BackColor = Color.LightSkyBlue;
            btConfirmation.Font = new Font("Trebuchet MS", 18F);
            btConfirmation.Location = new Point(871, 334);
            btConfirmation.Name = "btConfirmation";
            btConfirmation.Size = new Size(181, 47);
            btConfirmation.TabIndex = 28;
            btConfirmation.Text = "Sotish";
            btConfirmation.UseVisualStyleBackColor = false;
            btConfirmation.Click += btConfirmation_Click;
            // 
            // btBack
            // 
            btBack.BackColor = Color.Silver;
            btBack.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btBack.Location = new Point(1151, 603);
            btBack.Name = "btBack";
            btBack.Size = new Size(233, 53);
            btBack.TabIndex = 42;
            btBack.Text = "Orqaga qaytish";
            btBack.UseVisualStyleBackColor = false;
            btBack.Click += btBack_Click;
            // 
            // SellPillForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1482, 903);
            Controls.Add(btBack);
            Controls.Add(btConfirmation);
            Controls.Add(dGWSellPill);
            Name = "SellPillForm";
            Text = "SellPillForm";
            Load += SellPillForm_Load;
            ((System.ComponentModel.ISupportInitialize)dGWSellPill).EndInit();
            ((System.ComponentModel.ISupportInitialize)pillBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dGWSellPill;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn narxiDataGridViewTextBoxColumn;
        private BindingSource pillBindingSource;
        private Button btConfirmation;
        private Button btBack;
    }
}