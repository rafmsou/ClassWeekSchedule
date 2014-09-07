namespace WeekSchedule
{
    partial class FrmWeekSchedule
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
            this.components = new System.ComponentModel.Container();
            this.dgClassSchedule = new System.Windows.Forms.DataGridView();
            this.Aula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Segunda = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Terça = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Quarta = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Quinta = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Sexta = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgProfessors = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfClassesWeek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfRemainingClasses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstClassrooms = new System.Windows.Forms.ListBox();
            this.professorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblLoadingSchedule = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgClassSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProfessors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgClassSchedule
            // 
            this.dgClassSchedule.AllowUserToAddRows = false;
            this.dgClassSchedule.AllowUserToDeleteRows = false;
            this.dgClassSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClassSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Aula,
            this.Segunda,
            this.Terça,
            this.Quarta,
            this.Quinta,
            this.Sexta});
            this.dgClassSchedule.Location = new System.Drawing.Point(26, 259);
            this.dgClassSchedule.MultiSelect = false;
            this.dgClassSchedule.Name = "dgClassSchedule";
            this.dgClassSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgClassSchedule.Size = new System.Drawing.Size(445, 228);
            this.dgClassSchedule.TabIndex = 0;
            this.dgClassSchedule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClassSchedule_CellClick);
            this.dgClassSchedule.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClassSchedule_CellValueChanged);
            this.dgClassSchedule.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgClassSchedule_DataBindingComplete);
            this.dgClassSchedule.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgSala1_DataError);
            // 
            // Aula
            // 
            this.Aula.DataPropertyName = "Aula";
            this.Aula.Frozen = true;
            this.Aula.HeaderText = "Aula";
            this.Aula.Name = "Aula";
            this.Aula.ReadOnly = true;
            this.Aula.Width = 51;
            // 
            // Segunda
            // 
            this.Segunda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Segunda.DataPropertyName = "Segunda";
            this.Segunda.Frozen = true;
            this.Segunda.HeaderText = "Segunda";
            this.Segunda.Name = "Segunda";
            this.Segunda.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Segunda.Width = 70;
            // 
            // Terça
            // 
            this.Terça.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Terça.DataPropertyName = "Terça";
            this.Terça.HeaderText = "Terça";
            this.Terça.Name = "Terça";
            this.Terça.Width = 70;
            // 
            // Quarta
            // 
            this.Quarta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Quarta.DataPropertyName = "Quarta";
            this.Quarta.HeaderText = "Quarta";
            this.Quarta.Name = "Quarta";
            this.Quarta.Width = 70;
            // 
            // Quinta
            // 
            this.Quinta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Quinta.DataPropertyName = "Quinta";
            this.Quinta.HeaderText = "Quinta";
            this.Quinta.Name = "Quinta";
            this.Quinta.Width = 70;
            // 
            // Sexta
            // 
            this.Sexta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Sexta.DataPropertyName = "Sexta";
            this.Sexta.HeaderText = "Sexta";
            this.Sexta.Name = "Sexta";
            this.Sexta.Width = 70;
            // 
            // dgProfessors
            // 
            this.dgProfessors.AllowUserToAddRows = false;
            this.dgProfessors.AllowUserToDeleteRows = false;
            this.dgProfessors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProfessors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.Subject,
            this.NumberOfClassesWeek,
            this.NumberOfRemainingClasses});
            this.dgProfessors.Location = new System.Drawing.Point(26, 22);
            this.dgProfessors.Name = "dgProfessors";
            this.dgProfessors.ReadOnly = true;
            this.dgProfessors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProfessors.Size = new System.Drawing.Size(403, 199);
            this.dgProfessors.TabIndex = 2;
            this.dgProfessors.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProfessors_CellContentDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Name";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 58;
            // 
            // Subject
            // 
            this.Subject.DataPropertyName = "Subject";
            this.Subject.HeaderText = "Disciplina";
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            this.Subject.Width = 75;
            // 
            // NumberOfClassesWeek
            // 
            this.NumberOfClassesWeek.DataPropertyName = "NumberOfClassesWeek";
            this.NumberOfClassesWeek.HeaderText = "Aulas Por Semana";
            this.NumberOfClassesWeek.Name = "NumberOfClassesWeek";
            this.NumberOfClassesWeek.ReadOnly = true;
            this.NumberOfClassesWeek.Width = 125;
            // 
            // NumberOfRemainingClasses
            // 
            this.NumberOfRemainingClasses.DataPropertyName = "NumberOfRemainingClasses";
            this.NumberOfRemainingClasses.HeaderText = "Aulas Vagas";
            this.NumberOfRemainingClasses.Name = "NumberOfRemainingClasses";
            this.NumberOfRemainingClasses.ReadOnly = true;
            // 
            // lstClassrooms
            // 
            this.lstClassrooms.DisplayMember = "Name";
            this.lstClassrooms.FormattingEnabled = true;
            this.lstClassrooms.Location = new System.Drawing.Point(435, 22);
            this.lstClassrooms.Name = "lstClassrooms";
            this.lstClassrooms.Size = new System.Drawing.Size(162, 199);
            this.lstClassrooms.TabIndex = 4;
            this.lstClassrooms.ValueMember = "Id";
            this.lstClassrooms.DoubleClick += new System.EventHandler(this.lstClassrooms_DoubleClick);
            // 
            // professorBindingSource
            // 
            this.professorBindingSource.DataSource = typeof(WeekSchedule.AppData.Professor);
            // 
            // lblLoadingSchedule
            // 
            this.lblLoadingSchedule.AutoSize = true;
            this.lblLoadingSchedule.ForeColor = System.Drawing.Color.Red;
            this.lblLoadingSchedule.Location = new System.Drawing.Point(36, 243);
            this.lblLoadingSchedule.Name = "lblLoadingSchedule";
            this.lblLoadingSchedule.Size = new System.Drawing.Size(183, 13);
            this.lblLoadingSchedule.TabIndex = 5;
            this.lblLoadingSchedule.Text = "Carregando dados da programação...";
            this.lblLoadingSchedule.Visible = false;
            // 
            // FrmWeekSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(639, 533);
            this.Controls.Add(this.lblLoadingSchedule);
            this.Controls.Add(this.lstClassrooms);
            this.Controls.Add(this.dgClassSchedule);
            this.Controls.Add(this.dgProfessors);
            this.Name = "FrmWeekSchedule";
            this.Text = "WeekSchedule";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmWeekSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgClassSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProfessors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgClassSchedule;
        private System.Windows.Forms.DataGridView dgProfessors;
        private System.Windows.Forms.BindingSource professorBindingSource;
        private System.Windows.Forms.ListBox lstClassrooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aula;
        private System.Windows.Forms.DataGridViewComboBoxColumn Segunda;
        private System.Windows.Forms.DataGridViewComboBoxColumn Terça;
        private System.Windows.Forms.DataGridViewComboBoxColumn Quarta;
        private System.Windows.Forms.DataGridViewComboBoxColumn Quinta;
        private System.Windows.Forms.DataGridViewComboBoxColumn Sexta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfClassesWeek;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfRemainingClasses;
        private System.Windows.Forms.Label lblLoadingSchedule;
    }
}

