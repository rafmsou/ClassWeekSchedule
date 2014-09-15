namespace WeekClassSchedule
{
    partial class FrmClassroom
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgClassrooms = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfClassesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClassNum = new System.Windows.Forms.TextBox();
            this.btnGenerateSchedule = new System.Windows.Forms.Button();
            this.lblGeneratingSchedule = new System.Windows.Forms.Label();
            this.lblDone = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClassrooms)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sala de Aula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(66, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(137, 18);
            this.txtName.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(78, 130);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 39);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Incluir";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.dgClassrooms);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtClassNum);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Location = new System.Drawing.Point(30, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 417);
            this.panel1.TabIndex = 4;
            // 
            // dgClassrooms
            // 
            this.dgClassrooms.AllowUserToAddRows = false;
            this.dgClassrooms.AllowUserToDeleteRows = false;
            this.dgClassrooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgClassrooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClassrooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.NumberOfClassesColumn});
            this.dgClassrooms.GridColor = System.Drawing.SystemColors.Control;
            this.dgClassrooms.Location = new System.Drawing.Point(6, 184);
            this.dgClassrooms.Margin = new System.Windows.Forms.Padding(0);
            this.dgClassrooms.Name = "dgClassrooms";
            this.dgClassrooms.ReadOnly = true;
            this.dgClassrooms.RowHeadersWidth = 25;
            this.dgClassrooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgClassrooms.Size = new System.Drawing.Size(266, 221);
            this.dgClassrooms.TabIndex = 6;
            // 
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "Name";
            this.NameColumn.HeaderText = "Nome";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 120;
            // 
            // NumberOfClassesColumn
            // 
            this.NumberOfClassesColumn.DataPropertyName = "NumberOfClasses";
            this.NumberOfClassesColumn.HeaderText = "Aulas";
            this.NumberOfClassesColumn.Name = "NumberOfClassesColumn";
            this.NumberOfClassesColumn.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Número de Aulas";
            // 
            // txtClassNum
            // 
            this.txtClassNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClassNum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassNum.Location = new System.Drawing.Point(66, 94);
            this.txtClassNum.Name = "txtClassNum";
            this.txtClassNum.Size = new System.Drawing.Size(137, 18);
            this.txtClassNum.TabIndex = 2;
            // 
            // btnGenerateSchedule
            // 
            this.btnGenerateSchedule.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGenerateSchedule.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateSchedule.Location = new System.Drawing.Point(52, 48);
            this.btnGenerateSchedule.Name = "btnGenerateSchedule";
            this.btnGenerateSchedule.Size = new System.Drawing.Size(138, 72);
            this.btnGenerateSchedule.TabIndex = 5;
            this.btnGenerateSchedule.Text = "Gerar Programação";
            this.btnGenerateSchedule.UseVisualStyleBackColor = false;
            this.btnGenerateSchedule.Click += new System.EventHandler(this.btnGenerateSchedule_Click);
            // 
            // lblGeneratingSchedule
            // 
            this.lblGeneratingSchedule.AutoSize = true;
            this.lblGeneratingSchedule.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneratingSchedule.ForeColor = System.Drawing.Color.Red;
            this.lblGeneratingSchedule.Location = new System.Drawing.Point(18, 125);
            this.lblGeneratingSchedule.Name = "lblGeneratingSchedule";
            this.lblGeneratingSchedule.Size = new System.Drawing.Size(225, 13);
            this.lblGeneratingSchedule.TabIndex = 6;
            this.lblGeneratingSchedule.Text = "Gerando Programação para a sala {class} ...";
            this.lblGeneratingSchedule.Visible = false;
            // 
            // lblDone
            // 
            this.lblDone.AutoSize = true;
            this.lblDone.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDone.Location = new System.Drawing.Point(18, 144);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(63, 13);
            this.lblDone.TabIndex = 7;
            this.lblDone.Text = "Finalizado.";
            this.lblDone.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblDone);
            this.panel2.Controls.Add(this.btnGenerateSchedule);
            this.panel2.Controls.Add(this.lblGeneratingSchedule);
            this.panel2.Location = new System.Drawing.Point(311, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 417);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Programação";
            // 
            // FrmClassroom
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(602, 540);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClassroom";
            this.Text = "Sala de Aula";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmClassroom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClassrooms)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGenerateSchedule;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClassNum;
        private System.Windows.Forms.Label lblGeneratingSchedule;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgClassrooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfClassesColumn;
    }
}