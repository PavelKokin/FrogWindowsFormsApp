
namespace FrogWindowsFormsApp
{
    partial class RulesForm
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
            this.firstRulesLabel = new System.Windows.Forms.Label();
            this.secondRulesLabel = new System.Windows.Forms.Label();
            this.thirdRulesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstRulesLabel
            // 
            this.firstRulesLabel.AutoSize = true;
            this.firstRulesLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstRulesLabel.Location = new System.Drawing.Point(13, 13);
            this.firstRulesLabel.Name = "firstRulesLabel";
            this.firstRulesLabel.Size = new System.Drawing.Size(20, 15);
            this.firstRulesLabel.TabIndex = 0;
            this.firstRulesLabel.Text = "1. ";
            // 
            // secondRulesLabel
            // 
            this.secondRulesLabel.AutoSize = true;
            this.secondRulesLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondRulesLabel.Location = new System.Drawing.Point(12, 28);
            this.secondRulesLabel.Name = "secondRulesLabel";
            this.secondRulesLabel.Size = new System.Drawing.Size(17, 15);
            this.secondRulesLabel.TabIndex = 1;
            this.secondRulesLabel.Text = "2.";
            // 
            // thirdRulesLabel
            // 
            this.thirdRulesLabel.AutoSize = true;
            this.thirdRulesLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thirdRulesLabel.Location = new System.Drawing.Point(12, 43);
            this.thirdRulesLabel.Name = "thirdRulesLabel";
            this.thirdRulesLabel.Size = new System.Drawing.Size(17, 15);
            this.thirdRulesLabel.TabIndex = 2;
            this.thirdRulesLabel.Text = "3.";
            // 
            // RulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 82);
            this.Controls.Add(this.thirdRulesLabel);
            this.Controls.Add(this.secondRulesLabel);
            this.Controls.Add(this.firstRulesLabel);
            this.Name = "RulesForm";
            this.Text = "RulesForm";
            this.Load += new System.EventHandler(this.RulesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstRulesLabel;
        private System.Windows.Forms.Label secondRulesLabel;
        private System.Windows.Forms.Label thirdRulesLabel;
    }
}