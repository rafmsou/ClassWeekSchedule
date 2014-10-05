namespace WeekClassSchedule
{
    partial class FrmWeekClassSchedule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.lblLoadingSchedule = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSaveSchedule = new System.Windows.Forms.Button();
            this.loading = new System.Windows.Forms.PictureBox();
            this.lblScheduleSaved = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgClassSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProfessors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).BeginInit();
            this.SuspendLayout();
            // 
            // dgClassSchedule
            // 
            this.dgClassSchedule.AllowUserToAddRows = false;
            this.dgClassSchedule.AllowUserToDeleteRows = false;
            this.dgClassSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgClassSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgClassSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClassSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Aula,
            this.Segunda,
            this.Terça,
            this.Quarta,
            this.Quinta,
            this.Sexta});
            this.dgClassSchedule.Location = new System.Drawing.Point(26, 337);
            this.dgClassSchedule.MultiSelect = false;
            this.dgClassSchedule.Name = "dgClassSchedule";
            this.dgClassSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgClassSchedule.Size = new System.Drawing.Size(594, 286);
            this.dgClassSchedule.TabIndex = 0;
            this.dgClassSchedule.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgClassSchedule_CellBeginEdit);
            this.dgClassSchedule.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClassSchedule_CellEndEdit);
            this.dgClassSchedule.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgClassSchedule_DataBindingComplete);
            this.dgClassSchedule.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgSala1_DataError);
            this.dgClassSchedule.Click += new System.EventHandler(this.dgClassSchedule_Click);
            // 
            // Aula
            // 
            this.Aula.DataPropertyName = "Aula";
            this.Aula.Frozen = true;
            this.Aula.HeaderText = "Aula";
            this.Aula.Name = "Aula";
            this.Aula.ReadOnly = true;
            this.Aula.Width = 40;
            // 
            // Segunda
            // 
            this.Segunda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Segunda.DataPropertyName = "Segunda";
            this.Segunda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Segunda.Frozen = true;
            this.Segunda.HeaderText = "Segunda";
            this.Segunda.Name = "Segunda";
            this.Segunda.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Terça
            // 
            this.Terça.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Terça.DataPropertyName = "Terça";
            this.Terça.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Terça.HeaderText = "Terça";
            this.Terça.Name = "Terça";
            // 
            // Quarta
            // 
            this.Quarta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Quarta.DataPropertyName = "Quarta";
            this.Quarta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quarta.HeaderText = "Quarta";
            this.Quarta.Name = "Quarta";
            // 
            // Quinta
            // 
            this.Quinta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Quinta.DataPropertyName = "Quinta";
            this.Quinta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quinta.HeaderText = "Quinta";
            this.Quinta.Name = "Quinta";
            // 
            // Sexta
            // 
            this.Sexta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Sexta.DataPropertyName = "Sexta";
            this.Sexta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sexta.HeaderText = "Sexta";
            this.Sexta.Name = "Sexta";
            // 
            // dgProfessors
            // 
            this.dgProfessors.AllowUserToAddRows = false;
            this.dgProfessors.AllowUserToDeleteRows = false;
            this.dgProfessors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProfessors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgProfessors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProfessors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.Subject,
            this.NumberOfClassesWeek,
            this.NumberOfRemainingClasses});
            this.dgProfessors.Location = new System.Drawing.Point(26, 63);
            this.dgProfessors.Name = "dgProfessors";
            this.dgProfessors.ReadOnly = true;
            this.dgProfessors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProfessors.Size = new System.Drawing.Size(403, 228);
            this.dgProfessors.TabIndex = 2;
            this.dgProfessors.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProfessors_CellContentDoubleClick);
            this.dgProfessors.Click += new System.EventHandler(this.dgProfessors_Click);
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
            this.lstClassrooms.Location = new System.Drawing.Point(450, 63);
            this.lstClassrooms.Name = "lstClassrooms";
            this.lstClassrooms.Size = new System.Drawing.Size(162, 199);
            this.lstClassrooms.TabIndex = 4;
            this.lstClassrooms.ValueMember = "Id";
            this.lstClassrooms.Click += new System.EventHandler(this.lstClassrooms_Click);
            this.lstClassrooms.DoubleClick += new System.EventHandler(this.lstClassrooms_DoubleClick);
            // 
            // lblLoadingSchedule
            // 
            this.lblLoadingSchedule.AutoSize = true;
            this.lblLoadingSchedule.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadingSchedule.ForeColor = System.Drawing.Color.Red;
            this.lblLoadingSchedule.Location = new System.Drawing.Point(126, 316);
            this.lblLoadingSchedule.Name = "lblLoadingSchedule";
            this.lblLoadingSchedule.Size = new System.Drawing.Size(199, 13);
            this.lblLoadingSchedule.TabIndex = 5;
            this.lblLoadingSchedule.Text = "Carregando dados da programação...";
            this.lblLoadingSchedule.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Professores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(447, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Classes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Programação";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(450, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "(Duplo clique na sala para exibir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(450, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "a programação.)";
            // 
            // btnSaveSchedule
            // 
            this.btnSaveSchedule.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSaveSchedule.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSchedule.Location = new System.Drawing.Point(635, 337);
            this.btnSaveSchedule.Name = "btnSaveSchedule";
            this.btnSaveSchedule.Size = new System.Drawing.Size(159, 122);
            this.btnSaveSchedule.TabIndex = 11;
            this.btnSaveSchedule.Text = "Salvar Programação";
            this.btnSaveSchedule.UseVisualStyleBackColor = false;
            this.btnSaveSchedule.Click += new System.EventHandler(this.btnSaveSchedule_Click);
            // 
            // loading
            // 
            this.loading.BackColor = System.Drawing.Color.Transparent;
            this.loading.Image = global::WeekClassSchedule.Properties.Resources.ajax_loader;
            this.loading.Location = new System.Drawing.Point(285, 422);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(68, 70);
            this.loading.TabIndex = 12;
            this.loading.TabStop = false;
            this.loading.Visible = false;
            // 
            // lblScheduleSaved
            // 
            this.lblScheduleSaved.AutoSize = true;
            this.lblScheduleSaved.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScheduleSaved.Location = new System.Drawing.Point(638, 466);
            this.lblScheduleSaved.Name = "lblScheduleSaved";
            this.lblScheduleSaved.Size = new System.Drawing.Size(105, 13);
            this.lblScheduleSaved.TabIndex = 13;
            this.lblScheduleSaved.Text = "Programação salva.";
            this.lblScheduleSaved.Visible = false;
            // 
            // FrmWeekClassSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(819, 645);
            this.Controls.Add(this.lblScheduleSaved);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.btnSaveSchedule);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLoadingSchedule);
            this.Controls.Add(this.lstClassrooms);
            this.Controls.Add(this.dgClassSchedule);
            this.Controls.Add(this.dgProfessors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmWeekClassSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "WeekClassSchedule";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmWeekClassSchedule_Load);
            this.Click += new System.EventHandler(this.FrmWeekClassSchedule_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgClassSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProfessors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgClassSchedule;
        private System.Windows.Forms.DataGridView dgProfessors;
        private System.Windows.Forms.ListBox lstClassrooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfClassesWeek;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfRemainingClasses;
        private System.Windows.Forms.Label lblLoadingSchedule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSaveSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aula;
        private System.Windows.Forms.DataGridViewComboBoxColumn Segunda;
        private System.Windows.Forms.DataGridViewComboBoxColumn Terça;
        private System.Windows.Forms.DataGridViewComboBoxColumn Quarta;
        private System.Windows.Forms.DataGridViewComboBoxColumn Quinta;
        private System.Windows.Forms.DataGridViewComboBoxColumn Sexta;
        private System.Windows.Forms.PictureBox loading;
        private System.Windows.Forms.Label lblScheduleSaved;
    }
}

