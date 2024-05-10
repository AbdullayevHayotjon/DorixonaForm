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
            components = new System.ComponentModel.Container();
            btReports = new Button();
            dGVEmploye = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fIODataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            loginDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employeBindingSource = new BindingSource(components);
            lbFIO = new Label();
            lnklSettings = new LinkLabel();
            lbPillsList = new Label();
            button1 = new Button();
            dGVInformations = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            fIODataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            processTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            informationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            processTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            allInformationsBindingSource = new BindingSource(components);
            button2 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dGVEmploye).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dGVInformations).BeginInit();
            ((System.ComponentModel.ISupportInitialize)allInformationsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btReports
            // 
            btReports.BackColor = Color.LightSkyBlue;
            btReports.Font = new Font("Trebuchet MS", 17F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btReports.Location = new Point(159, 977);
            btReports.Name = "btReports";
            btReports.Size = new Size(728, 54);
            btReports.TabIndex = 10;
            btReports.Text = "Hisobotlar";
            btReports.UseVisualStyleBackColor = false;
            btReports.Click += btReports_Click;
            // 
            // dGVEmploye
            // 
            dGVEmploye.AutoGenerateColumns = false;
            dGVEmploye.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVEmploye.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, fIODataGridViewTextBoxColumn, loginDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn });
            dGVEmploye.DataSource = employeBindingSource;
            dGVEmploye.Location = new Point(1068, 173);
            dGVEmploye.Name = "dGVEmploye";
            dGVEmploye.RowHeadersWidth = 51;
            dGVEmploye.Size = new Size(679, 783);
            dGVEmploye.TabIndex = 19;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            fIODataGridViewTextBoxColumn.HeaderText = "FIO";
            fIODataGridViewTextBoxColumn.MinimumWidth = 6;
            fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            fIODataGridViewTextBoxColumn.Width = 125;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            loginDataGridViewTextBoxColumn.HeaderText = "Login";
            loginDataGridViewTextBoxColumn.MinimumWidth = 6;
            loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            loginDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeBindingSource
            // 
            employeBindingSource.DataSource = typeof(Actions.Employe);
            // 
            // lbFIO
            // 
            lbFIO.AutoSize = true;
            lbFIO.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbFIO.Location = new Point(12, 9);
            lbFIO.Name = "lbFIO";
            lbFIO.Size = new Size(61, 38);
            lbFIO.TabIndex = 20;
            lbFIO.Text = "FIO";
            lbFIO.Click += lbFIO_Click;
            // 
            // lnklSettings
            // 
            lnklSettings.AutoSize = true;
            lnklSettings.Font = new Font("Segoe UI", 14F);
            lnklSettings.Location = new Point(12, 47);
            lnklSettings.Name = "lnklSettings";
            lnklSettings.Size = new Size(129, 32);
            lnklSettings.TabIndex = 30;
            lnklSettings.TabStop = true;
            lnklSettings.Text = "Sozlamalar";
            lnklSettings.LinkClicked += lnklSettings_LinkClicked;
            // 
            // lbPillsList
            // 
            lbPillsList.AutoSize = true;
            lbPillsList.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbPillsList.Location = new Point(1270, 123);
            lbPillsList.Name = "lbPillsList";
            lbPillsList.Size = new Size(276, 38);
            lbPillsList.TabIndex = 31;
            lbPillsList.Text = "Sotuvchilar ro'yxati";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.Font = new Font("Trebuchet MS", 17F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(1068, 977);
            button1.Name = "button1";
            button1.Size = new Size(679, 54);
            button1.TabIndex = 33;
            button1.Text = "Sotuvchilar ro'yxatiga o'zgartirish kiritish";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dGVInformations
            // 
            dGVInformations.AutoGenerateColumns = false;
            dGVInformations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVInformations.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, fIODataGridViewTextBoxColumn1, processTypeDataGridViewTextBoxColumn, informationDataGridViewTextBoxColumn, processTimeDataGridViewTextBoxColumn });
            dGVInformations.DataSource = allInformationsBindingSource;
            dGVInformations.Location = new Point(159, 173);
            dGVInformations.Name = "dGVInformations";
            dGVInformations.RowHeadersWidth = 100;
            dGVInformations.Size = new Size(728, 783);
            dGVInformations.TabIndex = 34;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // fIODataGridViewTextBoxColumn1
            // 
            fIODataGridViewTextBoxColumn1.DataPropertyName = "FIO";
            fIODataGridViewTextBoxColumn1.HeaderText = "FIO";
            fIODataGridViewTextBoxColumn1.MinimumWidth = 6;
            fIODataGridViewTextBoxColumn1.Name = "fIODataGridViewTextBoxColumn1";
            fIODataGridViewTextBoxColumn1.Width = 125;
            // 
            // processTypeDataGridViewTextBoxColumn
            // 
            processTypeDataGridViewTextBoxColumn.DataPropertyName = "ProcessType";
            processTypeDataGridViewTextBoxColumn.HeaderText = "ProcessType";
            processTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            processTypeDataGridViewTextBoxColumn.Name = "processTypeDataGridViewTextBoxColumn";
            processTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // informationDataGridViewTextBoxColumn
            // 
            informationDataGridViewTextBoxColumn.DataPropertyName = "Information";
            informationDataGridViewTextBoxColumn.HeaderText = "Information";
            informationDataGridViewTextBoxColumn.MinimumWidth = 6;
            informationDataGridViewTextBoxColumn.Name = "informationDataGridViewTextBoxColumn";
            informationDataGridViewTextBoxColumn.Width = 125;
            // 
            // processTimeDataGridViewTextBoxColumn
            // 
            processTimeDataGridViewTextBoxColumn.DataPropertyName = "ProcessTime";
            processTimeDataGridViewTextBoxColumn.HeaderText = "ProcessTime";
            processTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            processTimeDataGridViewTextBoxColumn.Name = "processTimeDataGridViewTextBoxColumn";
            processTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // allInformationsBindingSource
            // 
            allInformationsBindingSource.DataSource = typeof(Actions.AllInformations);
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.Font = new Font("Trebuchet MS", 18F);
            button2.Location = new Point(1583, 1051);
            button2.Name = "button2";
            button2.Size = new Size(164, 50);
            button2.TabIndex = 35;
            button2.Text = "Chiqish";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(332, 123);
            label1.Name = "label1";
            label1.Size = new Size(383, 38);
            label1.TabIndex = 36;
            label1.Text = "Umumiy jarayonlar ro'yxati";
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1917, 1158);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(dGVInformations);
            Controls.Add(button1);
            Controls.Add(lbPillsList);
            Controls.Add(lnklSettings);
            Controls.Add(lbFIO);
            Controls.Add(dGVEmploye);
            Controls.Add(btReports);
            Name = "ManagerForm";
            Text = "ManagerForm";
            Load += ManagerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dGVEmploye).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dGVInformations).EndInit();
            ((System.ComponentModel.ISupportInitialize)allInformationsBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btReports;
        private DataGridView dGVEmploye;
        private BindingSource employeBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private Label lbFIO;
        private LinkLabel lnklSettings;
        private Label lbPillsList;
        private Button button1;
        private DataGridView dGVInformations;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn processTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn informationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn processTimeDataGridViewTextBoxColumn;
        private BindingSource allInformationsBindingSource;
        private Button button2;
        private Label label1;
    }
}