namespace Кр_2варіант_
{
    partial class AddRouteForm
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
            this.txtRouteNumber = new System.Windows.Forms.TextBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.cmbStops = new System.Windows.Forms.ComboBox();
            this.dtpDepartureTime = new System.Windows.Forms.DateTimePicker();
            this.txtSeatsAvailable = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRouteNumber
            // 
            this.txtRouteNumber.Location = new System.Drawing.Point(193, 34);
            this.txtRouteNumber.Name = "txtRouteNumber";
            this.txtRouteNumber.Size = new System.Drawing.Size(100, 20);
            this.txtRouteNumber.TabIndex = 0;
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(193, 87);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(100, 20);
            this.txtDestination.TabIndex = 1;
            // 
            // cmbStops
            // 
            this.cmbStops.FormattingEnabled = true;
            this.cmbStops.Location = new System.Drawing.Point(193, 145);
            this.cmbStops.Name = "cmbStops";
            this.cmbStops.Size = new System.Drawing.Size(121, 21);
            this.cmbStops.TabIndex = 2;
            // 
            // dtpDepartureTime
            // 
            this.dtpDepartureTime.Location = new System.Drawing.Point(193, 197);
            this.dtpDepartureTime.Name = "dtpDepartureTime";
            this.dtpDepartureTime.Size = new System.Drawing.Size(200, 20);
            this.dtpDepartureTime.TabIndex = 3;
            this.dtpDepartureTime.ValueChanged += new System.EventHandler(this.dtpDepartureTime_ValueChanged);
            // 
            // txtSeatsAvailable
            // 
            this.txtSeatsAvailable.Location = new System.Drawing.Point(193, 247);
            this.txtSeatsAvailable.Name = "txtSeatsAvailable";
            this.txtSeatsAvailable.Size = new System.Drawing.Size(100, 20);
            this.txtSeatsAvailable.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(611, 367);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "Пітвердити";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(50, 367);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Вихід";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Номер рейсу";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Пункт призначення";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Зупинки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Час відправлення";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Вільні місця";
            // 
            // AddRouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtSeatsAvailable);
            this.Controls.Add(this.dtpDepartureTime);
            this.Controls.Add(this.cmbStops);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.txtRouteNumber);
            this.Name = "AddRouteForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRouteNumber;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.ComboBox cmbStops;
        private System.Windows.Forms.DateTimePicker dtpDepartureTime;
        private System.Windows.Forms.TextBox txtSeatsAvailable;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}