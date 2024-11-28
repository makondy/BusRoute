using System;

namespace Кр_2варіант_
{
    partial class TicketTableForm
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
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.lblRouteInfo = new System.Windows.Forms.Label();
            this.lstTickets = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.Location = new System.Drawing.Point(691, 365);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(85, 59);
            this.btnBackToMain.TabIndex = 0;
            this.btnBackToMain.Text = "Повернутися в головне меню";
            this.btnBackToMain.UseVisualStyleBackColor = true;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // lblRouteInfo
            // 
            this.lblRouteInfo.AutoSize = true;
            this.lblRouteInfo.Location = new System.Drawing.Point(23, 7);
            this.lblRouteInfo.Name = "lblRouteInfo";
            this.lblRouteInfo.Size = new System.Drawing.Size(35, 13);
            this.lblRouteInfo.TabIndex = 2;
            this.lblRouteInfo.Text = "label1";
            // 
            // lstTickets
            // 
            this.lstTickets.FormattingEnabled = true;
            this.lstTickets.Location = new System.Drawing.Point(26, 35);
            this.lstTickets.Name = "lstTickets";
            this.lstTickets.Size = new System.Drawing.Size(624, 381);
            this.lstTickets.TabIndex = 3;
            // 
            // TicketTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstTickets);
            this.Controls.Add(this.lblRouteInfo);
            this.Controls.Add(this.btnBackToMain);
            this.Name = "TicketTableForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.TicketTableForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TicketTableForm_Load(object sender, EventArgs e)
        {
        }


        #endregion

        private System.Windows.Forms.Button btnBackToMain;
        private System.Windows.Forms.Label lblRouteInfo;
        private System.Windows.Forms.ListBox lstTickets;
    }
}