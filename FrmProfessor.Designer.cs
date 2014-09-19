namespace WeekClassSchedule
{
    partial class FrmProfessor
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtWeekClassesQty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbAll = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sextaCheckList = new System.Windows.Forms.CheckedListBox();
            this.quintaCheckList = new System.Windows.Forms.CheckedListBox();
            this.quartaCheckList = new System.Windows.Forms.CheckedListBox();
            this.tercaCheckList = new System.Windows.Forms.CheckedListBox();
            this.segundaCheckList = new System.Windows.Forms.CheckedListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(231, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(138, 18);
            this.txtName.TabIndex = 0;
            // 
            // txtSubject
            // 
            this.txtSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubject.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.Location = new System.Drawing.Point(231, 59);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(138, 18);
            this.txtSubject.TabIndex = 1;
            // 
            // txtWeekClassesQty
            // 
            this.txtWeekClassesQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWeekClassesQty.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeekClassesQty.Location = new System.Drawing.Point(306, 217);
            this.txtWeekClassesQty.Name = "txtWeekClassesQty";
            this.txtWeekClassesQty.Size = new System.Drawing.Size(138, 18);
            this.txtWeekClassesQty.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Disciplina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantidade Aulas";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(538, 490);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(103, 39);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.cbAll);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtSubject);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.sextaCheckList);
            this.panel1.Controls.Add(this.quintaCheckList);
            this.panel1.Controls.Add(this.quartaCheckList);
            this.panel1.Controls.Add(this.tercaCheckList);
            this.panel1.Controls.Add(this.segundaCheckList);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(74, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 296);
            this.panel1.TabIndex = 10;
            // 
            // cbAll
            // 
            this.cbAll.AutoSize = true;
            this.cbAll.Location = new System.Drawing.Point(46, 131);
            this.cbAll.Name = "cbAll";
            this.cbAll.Size = new System.Drawing.Size(113, 17);
            this.cbAll.TabIndex = 12;
            this.cbAll.TabStop = false;
            this.cbAll.Text = "Selecionar Todos";
            this.cbAll.UseVisualStyleBackColor = true;
            this.cbAll.Click += new System.EventHandler(this.cbAll_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(223, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Dias que pode:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(428, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Sexta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(331, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Quinta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Quarta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Terça";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Segunda";
            // 
            // sextaCheckList
            // 
            this.sextaCheckList.CheckOnClick = true;
            this.sextaCheckList.FormattingEnabled = true;
            this.sextaCheckList.Items.AddRange(new object[] {
            "1ª Aula",
            "2ª Aula",
            "3ª Aula",
            "4ª Aula",
            "5ª Aula",
            "6ª Aula"});
            this.sextaCheckList.Location = new System.Drawing.Point(408, 174);
            this.sextaCheckList.Name = "sextaCheckList";
            this.sextaCheckList.Size = new System.Drawing.Size(85, 106);
            this.sextaCheckList.TabIndex = 16;
            this.sextaCheckList.TabStop = false;
            this.sextaCheckList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.sextaCheckList_ItemCheck);
            // 
            // quintaCheckList
            // 
            this.quintaCheckList.CheckOnClick = true;
            this.quintaCheckList.FormattingEnabled = true;
            this.quintaCheckList.Items.AddRange(new object[] {
            "1ª Aula",
            "2ª Aula",
            "3ª Aula",
            "4ª Aula",
            "5ª Aula",
            "6ª Aula"});
            this.quintaCheckList.Location = new System.Drawing.Point(317, 174);
            this.quintaCheckList.Name = "quintaCheckList";
            this.quintaCheckList.Size = new System.Drawing.Size(85, 106);
            this.quintaCheckList.TabIndex = 14;
            this.quintaCheckList.TabStop = false;
            this.quintaCheckList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.quintaCheckList_ItemCheck);
            // 
            // quartaCheckList
            // 
            this.quartaCheckList.CheckOnClick = true;
            this.quartaCheckList.FormattingEnabled = true;
            this.quartaCheckList.Items.AddRange(new object[] {
            "1ª Aula",
            "2ª Aula",
            "3ª Aula",
            "4ª Aula",
            "5ª Aula",
            "6ª Aula"});
            this.quartaCheckList.Location = new System.Drawing.Point(226, 174);
            this.quartaCheckList.Name = "quartaCheckList";
            this.quartaCheckList.Size = new System.Drawing.Size(85, 106);
            this.quartaCheckList.TabIndex = 15;
            this.quartaCheckList.TabStop = false;
            this.quartaCheckList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.quartaCheckList_ItemCheck);
            // 
            // tercaCheckList
            // 
            this.tercaCheckList.CheckOnClick = true;
            this.tercaCheckList.FormattingEnabled = true;
            this.tercaCheckList.Items.AddRange(new object[] {
            "1ª Aula",
            "2ª Aula",
            "3ª Aula",
            "4ª Aula",
            "5ª Aula",
            "6ª Aula"});
            this.tercaCheckList.Location = new System.Drawing.Point(137, 174);
            this.tercaCheckList.Name = "tercaCheckList";
            this.tercaCheckList.Size = new System.Drawing.Size(85, 106);
            this.tercaCheckList.TabIndex = 13;
            this.tercaCheckList.TabStop = false;
            this.tercaCheckList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.tercaCheckList_ItemCheck);
            // 
            // segundaCheckList
            // 
            this.segundaCheckList.CheckOnClick = true;
            this.segundaCheckList.FormattingEnabled = true;
            this.segundaCheckList.Items.AddRange(new object[] {
            "1ª Aula",
            "2ª Aula",
            "3ª Aula",
            "4ª Aula",
            "5ª Aula",
            "6ª Aula"});
            this.segundaCheckList.Location = new System.Drawing.Point(46, 174);
            this.segundaCheckList.Name = "segundaCheckList";
            this.segundaCheckList.Size = new System.Drawing.Size(85, 106);
            this.segundaCheckList.TabIndex = 12;
            this.segundaCheckList.TabStop = false;
            this.segundaCheckList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.segundaCheckList_ItemCheck);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(312, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 21);
            this.label10.TabIndex = 12;
            this.label10.Text = "Professor";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(232, 440);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(246, 13);
            this.lblMessage.TabIndex = 13;
            this.lblMessage.Text = "Professor cadastrado\\atualizado com sucesso.";
            this.lblMessage.Visible = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExcluir.Location = new System.Drawing.Point(429, 490);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(103, 39);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.TabStop = false;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(64, 490);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(103, 39);
            this.btnNew.TabIndex = 15;
            this.btnNew.Text = "Novo";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // FrmProfessor
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(714, 623);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtWeekClassesQty);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProfessor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FrmProfessor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmProfessor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtWeekClassesQty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox sextaCheckList;
        private System.Windows.Forms.CheckedListBox quintaCheckList;
        private System.Windows.Forms.CheckedListBox quartaCheckList;
        private System.Windows.Forms.CheckedListBox tercaCheckList;
        private System.Windows.Forms.CheckedListBox segundaCheckList;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cbAll;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNew;
    }
}