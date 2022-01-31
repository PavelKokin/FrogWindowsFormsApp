
namespace FrogWindowsFormsApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countStepLabel = new System.Windows.Forms.Label();
            this.rightPictureBox4 = new System.Windows.Forms.PictureBox();
            this.rightPictureBox3 = new System.Windows.Forms.PictureBox();
            this.rightPictureBox2 = new System.Windows.Forms.PictureBox();
            this.rightPictureBox1 = new System.Windows.Forms.PictureBox();
            this.emptyPictureBox = new System.Windows.Forms.PictureBox();
            this.leftPictureBox4 = new System.Windows.Forms.PictureBox();
            this.leftPictureBox3 = new System.Windows.Forms.PictureBox();
            this.leftPictureBox2 = new System.Windows.Forms.PictureBox();
            this.leftPictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(991, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.viewRulesToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restartToolStripMenuItem.Text = "Начать сначала";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // viewRulesToolStripMenuItem
            // 
            this.viewRulesToolStripMenuItem.Name = "viewRulesToolStripMenuItem";
            this.viewRulesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewRulesToolStripMenuItem.Text = "Показать правила";
            this.viewRulesToolStripMenuItem.Click += new System.EventHandler(this.viewRulesToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // countStepLabel
            // 
            this.countStepLabel.AutoSize = true;
            this.countStepLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countStepLabel.Location = new System.Drawing.Point(12, 200);
            this.countStepLabel.Name = "countStepLabel";
            this.countStepLabel.Size = new System.Drawing.Size(223, 24);
            this.countStepLabel.TabIndex = 10;
            this.countStepLabel.Text = "Количество ходов - 0";
            // 
            // rightPictureBox4
            // 
            this.rightPictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("rightPictureBox4.Image")));
            this.rightPictureBox4.Location = new System.Drawing.Point(880, 50);
            this.rightPictureBox4.Name = "rightPictureBox4";
            this.rightPictureBox4.Size = new System.Drawing.Size(110, 110);
            this.rightPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightPictureBox4.TabIndex = 8;
            this.rightPictureBox4.TabStop = false;
            this.rightPictureBox4.Click += new System.EventHandler(this.rightPictureBox1_Click);
            // 
            // rightPictureBox3
            // 
            this.rightPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("rightPictureBox3.Image")));
            this.rightPictureBox3.Location = new System.Drawing.Point(770, 50);
            this.rightPictureBox3.Name = "rightPictureBox3";
            this.rightPictureBox3.Size = new System.Drawing.Size(110, 110);
            this.rightPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightPictureBox3.TabIndex = 7;
            this.rightPictureBox3.TabStop = false;
            this.rightPictureBox3.Click += new System.EventHandler(this.rightPictureBox1_Click);
            // 
            // rightPictureBox2
            // 
            this.rightPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("rightPictureBox2.Image")));
            this.rightPictureBox2.Location = new System.Drawing.Point(660, 50);
            this.rightPictureBox2.Name = "rightPictureBox2";
            this.rightPictureBox2.Size = new System.Drawing.Size(110, 110);
            this.rightPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightPictureBox2.TabIndex = 6;
            this.rightPictureBox2.TabStop = false;
            this.rightPictureBox2.Click += new System.EventHandler(this.rightPictureBox1_Click);
            // 
            // rightPictureBox1
            // 
            this.rightPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("rightPictureBox1.Image")));
            this.rightPictureBox1.Location = new System.Drawing.Point(550, 50);
            this.rightPictureBox1.Name = "rightPictureBox1";
            this.rightPictureBox1.Size = new System.Drawing.Size(110, 110);
            this.rightPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightPictureBox1.TabIndex = 5;
            this.rightPictureBox1.TabStop = false;
            this.rightPictureBox1.Click += new System.EventHandler(this.rightPictureBox1_Click);
            // 
            // emptyPictureBox
            // 
            this.emptyPictureBox.Image = global::FrogWindowsFormsApp.Properties.Resources.empty;
            this.emptyPictureBox.Location = new System.Drawing.Point(440, 50);
            this.emptyPictureBox.Name = "emptyPictureBox";
            this.emptyPictureBox.Size = new System.Drawing.Size(110, 110);
            this.emptyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.emptyPictureBox.TabIndex = 4;
            this.emptyPictureBox.TabStop = false;
            // 
            // leftPictureBox4
            // 
            this.leftPictureBox4.Image = global::FrogWindowsFormsApp.Properties.Resources.fof1;
            this.leftPictureBox4.Location = new System.Drawing.Point(330, 50);
            this.leftPictureBox4.Name = "leftPictureBox4";
            this.leftPictureBox4.Size = new System.Drawing.Size(110, 110);
            this.leftPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftPictureBox4.TabIndex = 3;
            this.leftPictureBox4.TabStop = false;
            this.leftPictureBox4.Click += new System.EventHandler(this.rightPictureBox1_Click);
            // 
            // leftPictureBox3
            // 
            this.leftPictureBox3.Image = global::FrogWindowsFormsApp.Properties.Resources.fof1;
            this.leftPictureBox3.Location = new System.Drawing.Point(220, 50);
            this.leftPictureBox3.Name = "leftPictureBox3";
            this.leftPictureBox3.Size = new System.Drawing.Size(110, 110);
            this.leftPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftPictureBox3.TabIndex = 2;
            this.leftPictureBox3.TabStop = false;
            this.leftPictureBox3.Click += new System.EventHandler(this.rightPictureBox1_Click);
            // 
            // leftPictureBox2
            // 
            this.leftPictureBox2.Image = global::FrogWindowsFormsApp.Properties.Resources.fof1;
            this.leftPictureBox2.Location = new System.Drawing.Point(110, 50);
            this.leftPictureBox2.Name = "leftPictureBox2";
            this.leftPictureBox2.Size = new System.Drawing.Size(110, 110);
            this.leftPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftPictureBox2.TabIndex = 1;
            this.leftPictureBox2.TabStop = false;
            this.leftPictureBox2.Click += new System.EventHandler(this.rightPictureBox1_Click);
            // 
            // leftPictureBox1
            // 
            this.leftPictureBox1.Image = global::FrogWindowsFormsApp.Properties.Resources.fof1;
            this.leftPictureBox1.Location = new System.Drawing.Point(0, 50);
            this.leftPictureBox1.Name = "leftPictureBox1";
            this.leftPictureBox1.Size = new System.Drawing.Size(110, 110);
            this.leftPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftPictureBox1.TabIndex = 0;
            this.leftPictureBox1.TabStop = false;
            this.leftPictureBox1.Click += new System.EventHandler(this.rightPictureBox1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 261);
            this.Controls.Add(this.countStepLabel);
            this.Controls.Add(this.rightPictureBox4);
            this.Controls.Add(this.rightPictureBox3);
            this.Controls.Add(this.rightPictureBox2);
            this.Controls.Add(this.rightPictureBox1);
            this.Controls.Add(this.emptyPictureBox);
            this.Controls.Add(this.leftPictureBox4);
            this.Controls.Add(this.leftPictureBox3);
            this.Controls.Add(this.leftPictureBox2);
            this.Controls.Add(this.leftPictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Попрыгушки";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox leftPictureBox1;
        private System.Windows.Forms.PictureBox leftPictureBox2;
        private System.Windows.Forms.PictureBox leftPictureBox4;
        private System.Windows.Forms.PictureBox leftPictureBox3;
        private System.Windows.Forms.PictureBox rightPictureBox3;
        private System.Windows.Forms.PictureBox rightPictureBox2;
        private System.Windows.Forms.PictureBox rightPictureBox1;
        private System.Windows.Forms.PictureBox emptyPictureBox;
        private System.Windows.Forms.PictureBox rightPictureBox4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewRulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.Label countStepLabel;
    }
}

