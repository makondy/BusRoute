using System;

namespace Кр_2варіант_
{
    partial class TicketForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.cmbRoutes = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBenefit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ім\'я";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Прізвище";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Вибір рейсу";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(37, 259);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Відмінити";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(169, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(169, 71);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 7;
            // 
            // cmbRoutes
            // 
            this.cmbRoutes.FormattingEnabled = true;
            this.cmbRoutes.Location = new System.Drawing.Point(169, 127);
            this.cmbRoutes.Name = "cmbRoutes";
            this.cmbRoutes.Size = new System.Drawing.Size(121, 21);
            this.cmbRoutes.TabIndex = 8;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(189, 259);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(118, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Оформити квиток";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Location = new System.Drawing.Point(258, 186);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(32, 17);
            this.rbYes.TabIndex = 9;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "Є";
            this.rbYes.UseVisualStyleBackColor = true;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(169, 187);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(53, 17);
            this.rbNo.TabIndex = 10;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "Нема";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Пільги";
            // 
            // txtBenefit
            // 
            this.txtBenefit.Location = new System.Drawing.Point(296, 186);
            this.txtBenefit.Name = "txtBenefit";
            this.txtBenefit.Size = new System.Drawing.Size(100, 20);
            this.txtBenefit.TabIndex = 12;
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 358);
            this.Controls.Add(this.txtBenefit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbNo);
            this.Controls.Add(this.rbYes);
            this.Controls.Add(this.cmbRoutes);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TicketForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.TicketForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TicketForm_Load(object sender, EventArgs e)
        {
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.ComboBox cmbRoutes;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBenefit;
    }
}