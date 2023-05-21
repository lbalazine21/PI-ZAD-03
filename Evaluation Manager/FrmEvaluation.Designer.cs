namespace Evaluation_Manager
{
    partial class FrmEvaluation
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
            this.lblActivities = new System.Windows.Forms.Label();
            this.lblMinForSignature = new System.Windows.Forms.Label();
            this.cboActivities = new System.Windows.Forms.ComboBox();
            this.txtMinForSignature = new System.Windows.Forms.TextBox();
            this.lblMinForGrade = new System.Windows.Forms.Label();
            this.txtMinForGrade = new System.Windows.Forms.TextBox();
            this.txtActivityDescription = new System.Windows.Forms.TextBox();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.txtEvaluationDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblActivities
            // 
            this.lblActivities.AutoSize = true;
            this.lblActivities.Location = new System.Drawing.Point(27, 21);
            this.lblActivities.Name = "lblActivities";
            this.lblActivities.Size = new System.Drawing.Size(64, 16);
            this.lblActivities.TabIndex = 0;
            this.lblActivities.Text = "Aktivnost:";
            this.lblActivities.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMinForSignature
            // 
            this.lblMinForSignature.AutoSize = true;
            this.lblMinForSignature.Location = new System.Drawing.Point(322, 21);
            this.lblMinForSignature.Name = "lblMinForSignature";
            this.lblMinForSignature.Size = new System.Drawing.Size(98, 16);
            this.lblMinForSignature.TabIndex = 1;
            this.lblMinForSignature.Text = "Uvjet za potpis:";
            this.lblMinForSignature.Click += new System.EventHandler(this.label2_Click);
            // 
            // cboActivities
            // 
            this.cboActivities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActivities.FormattingEnabled = true;
            this.cboActivities.Location = new System.Drawing.Point(30, 40);
            this.cboActivities.Name = "cboActivities";
            this.cboActivities.Size = new System.Drawing.Size(253, 24);
            this.cboActivities.TabIndex = 2;
            // 
            // txtMinForSignature
            // 
            this.txtMinForSignature.Location = new System.Drawing.Point(325, 42);
            this.txtMinForSignature.Name = "txtMinForSignature";
            this.txtMinForSignature.ReadOnly = true;
            this.txtMinForSignature.Size = new System.Drawing.Size(125, 22);
            this.txtMinForSignature.TabIndex = 3;
            // 
            // lblMinForGrade
            // 
            this.lblMinForGrade.AutoSize = true;
            this.lblMinForGrade.Location = new System.Drawing.Point(464, 21);
            this.lblMinForGrade.Name = "lblMinForGrade";
            this.lblMinForGrade.Size = new System.Drawing.Size(101, 16);
            this.lblMinForGrade.TabIndex = 4;
            this.lblMinForGrade.Text = "Uvjet za ocjenu:";
            // 
            // txtMinForGrade
            // 
            this.txtMinForGrade.Location = new System.Drawing.Point(467, 42);
            this.txtMinForGrade.Name = "txtMinForGrade";
            this.txtMinForGrade.ReadOnly = true;
            this.txtMinForGrade.Size = new System.Drawing.Size(125, 22);
            this.txtMinForGrade.TabIndex = 5;
            // 
            // txtActivityDescription
            // 
            this.txtActivityDescription.Location = new System.Drawing.Point(30, 83);
            this.txtActivityDescription.Multiline = true;
            this.txtActivityDescription.Name = "txtActivityDescription";
            this.txtActivityDescription.ReadOnly = true;
            this.txtActivityDescription.Size = new System.Drawing.Size(562, 179);
            this.txtActivityDescription.TabIndex = 6;
            // 
            // txtTeacher
            // 
            this.txtTeacher.Location = new System.Drawing.Point(213, 304);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.ReadOnly = true;
            this.txtTeacher.Size = new System.Drawing.Size(125, 22);
            this.txtTeacher.TabIndex = 7;
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Location = new System.Drawing.Point(210, 285);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(73, 16);
            this.lblTeacher.TabIndex = 8;
            this.lblTeacher.Text = "Ocjenjivač:";
            // 
            // txtEvaluationDate
            // 
            this.txtEvaluationDate.Location = new System.Drawing.Point(369, 332);
            this.txtEvaluationDate.Name = "txtEvaluationDate";
            this.txtEvaluationDate.ReadOnly = true;
            this.txtEvaluationDate.Size = new System.Drawing.Size(125, 22);
            this.txtEvaluationDate.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // FrmEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEvaluationDate);
            this.Controls.Add(this.lblTeacher);
            this.Controls.Add(this.txtTeacher);
            this.Controls.Add(this.txtActivityDescription);
            this.Controls.Add(this.txtMinForGrade);
            this.Controls.Add(this.lblMinForGrade);
            this.Controls.Add(this.txtMinForSignature);
            this.Controls.Add(this.cboActivities);
            this.Controls.Add(this.lblMinForSignature);
            this.Controls.Add(this.lblActivities);
            this.Name = "FrmEvaluation";
            this.Text = "FrmEvaluation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblActivities;
        private System.Windows.Forms.Label lblMinForSignature;
        private System.Windows.Forms.ComboBox cboActivities;
        private System.Windows.Forms.TextBox txtMinForSignature;
        private System.Windows.Forms.Label lblMinForGrade;
        private System.Windows.Forms.TextBox txtMinForGrade;
        private System.Windows.Forms.TextBox txtActivityDescription;
        private System.Windows.Forms.TextBox txtTeacher;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.TextBox txtEvaluationDate;
        private System.Windows.Forms.Label label1;
    }
}